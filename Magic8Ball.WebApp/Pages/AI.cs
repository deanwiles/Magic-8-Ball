﻿using Magic8Ball.RESTClient;
using Magic8Ball.Shared;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace Magic8Ball.WebApp.Pages;

public partial class AI
{
    [Parameter]
    public string Service { get; set; } = string.Empty;

    protected Magic8BallData? Magic8BallData { get; set; } = null;

    protected ElementReference SubmitButton;

    protected string AnswerStyle = string.Empty;

    // used to store state of screen
    protected bool ShowMessage;
    protected MarkupString Message = new();
    protected string StatusClass = string.Empty;

    protected bool ShowInstructions { get; set; } = false; // hide by default
    protected bool IsBusy { get; set; } = false; // true when waiting for Magic 8 Ball to answer
    protected bool ShowPleaseWait { get; set; } = false; // hide by default
    protected static bool requestPending = false; // api request sent and awaiting response

    protected string GetApiBaseAddress() => Configuration?["RESTClientMagic8Ball:BaseAddress"] ?? $"{HostEnvironment.BaseAddress}api";

    protected override void OnInitialized()
    {
        Logger.LogInformation("Entering OnInitialized()...");
    }

    protected override void OnParametersSet()
    {
        Logger.LogInformation("Entering OnParametersSet(Service='{Service}')...", Service);
        // Default to AI if Service not specified
        if (string.IsNullOrWhiteSpace(Service)) Service = "AI";
        // Instantiate specified Magic 8 Ball service type
        Magic8BallData = Service.ToLower() switch
        {
            "classic" => new Magic8Ball.Classic.ClassicMagic8Ball(),
            // For Azure/AI api client, check for local config override (e.g. during Development), else assume static web app's api route
            "azure" => new RESTClientMagic8Ball(GetApiBaseAddress(), ServiceType.Classic),
            // Running AI locally doesn't currently work due to issues with Grpc.Core and the PaLM client, so just replace Azure option with AI call via Azure
            // "ai" => new AI.AIMagic8Ball(),
            "ai" => new RESTClientMagic8Ball(GetApiBaseAddress(), ServiceType.AI),
            _ => null,
        };
        // Check if service created
        if (Magic8BallData == null)
        {
            // No, show error message
            SetErrorMessage($"Unsupported Magic 8 Ball Service name '{Service}'");
        }
        else
        {
            // Yes, set default question (if configured)
            Magic8BallData.Question = Configuration?[$"{Service}:Question"] ?? string.Empty;
            // Clear Answer and Message area
            ClearAnswer();
            ClearMessage();
        }
        Logger.LogInformation("Exiting OnParametersSet");
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        Logger.LogInformation("Entering OnAfterRenderAsync(firstRender={firstRender})...", firstRender);
        // Set focus on Submit button (if present)
        if (!ShowMessage && SubmitButton.Context != null)
            await SubmitButton.FocusAsync();
        // Check if we have done an api request yet
        if (firstRender)
        {
            // No, ask a Classic Azure Magic 8 Ball question to fire up the Azure Function now in case it had shutdown
            // This will save a little response time once the user submits a question
            var azure = new RESTClientMagic8Ball(GetApiBaseAddress(), ServiceType.Classic);
            try 
            {
                Logger.LogInformation("Sending Wake Up call to Magic 8 Ball service");
                requestPending = true;
                await azure.AskAsync("Are you awake?");
                requestPending = false;
            }
            catch 
            {
                // Ignore any error for now
            }
        }
        Logger.LogInformation("Exiting OnAfterRenderAsync");
    }

    protected async Task AskQuestion()
    {
        try
        {
            Logger.LogInformation("Entering AskQuestion(), Question='{Question}'...", Magic8BallData?.Question);
            // Indicate that we're waiting for the Magic 8 Ball to answer
            ShowBusy(true);
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            // Clear any previous answer
            ClearAnswer();
            // Verify we have a valid Magic 8 Ball service
            if (Magic8BallData == null || Magic8BallData is not IMagic8BallService service)
                throw new Exception("Magic 8 Ball Service not initialized");
            // Ask the Magic 8 Ball service the user's question
            // Note that for the AI service, we'll call it indirectly via the Azure function
            requestPending = true;
            await service.AskAsync(Magic8BallData.Question);
            requestPending = false;
            // Check if Magic 8 Ball answered too fast; we should wait at least the minimum time to enhance the magic effect
            stopWatch.Stop();
            double magicDelay = 500 - stopWatch.Elapsed.TotalMilliseconds;  // 1/2 second
            if (magicDelay > 0)
                await Task.Delay(Convert.ToInt32(magicDelay));
            // Save Answer and set Answer Style
            var iType = Magic8BallData.Type;
            AnswerStyle = iType switch
            {
                AnswerType.Positive => "alert-success",
                AnswerType.Neutral => "alert-warning",
                AnswerType.Negative => "alert-danger",
                _ => "alert",
            };
            // Refresh screen with Answer & Type
            ClearMessage();
            ShowBusy(false);
            Logger.LogInformation("Exiting AskQuestion, Type='{Type}', Answer='{Answer}'", Magic8BallData?.Type, Magic8BallData?.Answer);
        }
        catch (Exception ex)
        {
            // Display error message
            string msg = ex.Message;
            if (null != ex.InnerException) msg += $"<br>&nbsp;{ex.InnerException.Message}";
            msg += "<br>Sometimes the AI Engine needs to think twice. Please click &lt;Reset&gt; and try again.";
            Logger.LogInformation(ex, "Error occurred in AskQuestion, Message='{Message}'", msg);
            SetErrorMessage(msg);
        }
    }

    protected void ClearAnswer()
    {
        // Clear Answer text and style
        if (Magic8BallData != null) Magic8BallData.Answer = string.Empty;
        AnswerStyle = string.Empty;
        StateHasChanged();
    }

    protected void ClearMessage()
    {
        // Clear Message area
        ShowMessage = false;
        Message = new();
        StatusClass = string.Empty;
        StateHasChanged();
    }

#if (false) // Not yet needed
    protected void SetInfoMessage(string InfoMessage)
    {
        // Clear Message area
        ShowMessage = true;
        Message = InfoMessage;
        StatusClass = "alert-success";
        StateHasChanged();
    }
#endif

    protected void SetErrorMessage(string ErrorMessage)
    {
        // Clear Message area
        ShowMessage = true;
        Message = new(ErrorMessage);
        StatusClass = "alert-danger";
        IsBusy = false;
        ShowPleaseWait = false;
        StateHasChanged();
    }

    protected void ToggleInstructions()
    {
        ShowInstructions = !ShowInstructions;
        StateHasChanged();
    }

    protected void ShowBusy(bool IsBusy)
    {
        this.IsBusy = IsBusy;
        ShowPleaseWait = IsBusy && requestPending;
        StateHasChanged();
    }
}
