using Magic8Ball.RESTClient;
using Magic8Ball.Shared;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace Magic8Ball.WebApp.Pages;

public partial class Index
{
    [Parameter]
    public string Service { get; set; } = string.Empty;

    private Magic8BallData? Magic8BallData { get; set; } = null;
    private string Question { get; set; } = string.Empty;
    private string Answer { get; set; } = string.Empty;

    private ElementReference QuestionInput;
    private ElementReference SubmitButton;

    private string AnswerStyle = string.Empty;

    //used to store state of screen
    protected bool ShowMessage;
    protected MarkupString Message = new();
    protected string StatusClass = string.Empty;

    protected bool InstructionsCollapsed { get; set; } = true; // hide by default
    protected bool IsBusy { get; set; } = false; // true when waiting for Magic 8 Ball to answer

    protected override void OnInitialized()
    {
        Console.WriteLine("Entering OnInitialized()...");
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine($"Entering OnParametersSet(Service='{Service}')...");
        // Default to classic if Service not specified
        if (string.IsNullOrWhiteSpace(Service)) Service = "Classic";
        // Instantiate specified Magic 8 Ball service type
        Magic8BallData = Service.ToLower() switch
        {
            "classic" => new Magic8Ball.Classic.ClassicMagic8Ball(),
            // For Azure/AI api client, check for local config override (e.g. during Development), else assume static web app's api route
            "azure" => new RESTClientMagic8Ball(Configuration?["RESTClientMagic8Ball:BaseAddress"] ?? $"{HostEnvironment.BaseAddress}api", ServiceType.Classic),
            // Running AI locally doesn't currently work due to issues with Grpc.Core and the PaLM client, so just replace Azure option with AI call via Azure
            // "ai" => new AI.AIMagic8Ball(),
            "ai" => new RESTClientMagic8Ball(Configuration?["RESTClientMagic8Ball:BaseAddress"] ?? $"{HostEnvironment.BaseAddress}api", ServiceType.AI),
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
            // Yes, set default question
            Question = "Will I win the lottery?";
            // Clear Answer and Message area
            ClearAnswer();
            ClearMessage();
        }
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        // Set focus on Question input textbox (if present)
        if (!ShowMessage && QuestionInput.Context != null)
            //    await QuestionInput.FocusAsync();
            await SubmitButton.FocusAsync();
    }

    private async Task AskQuestion()
    {
        try
        {
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
            await service.AskAsync(Question);
            // Check if Magic 8 Ball answered too fast; we should wait at least the minimum time to enhance the magic effect
            stopWatch.Stop();
            double magicDelay = 500 - stopWatch.Elapsed.TotalMilliseconds;  // 1/2 second
            if (magicDelay > 0)
                await Task.Delay(Convert.ToInt32(magicDelay));
            // Save Answer and set Answer Style
            Answer = Magic8BallData.Answer;
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
        }
        catch (Exception ex)
        {
            // Display error message
            string msg = ex.Message;
            if (null != ex.InnerException) msg += $"<br>{ex.InnerException.Message}";
            SetErrorMessage(msg);
        }
    }

    private void ClearAnswer()
    {
        // Clear Answer text and style
        Answer = string.Empty;
        AnswerStyle = string.Empty;
        StateHasChanged();
    }

    private void ClearMessage()
    {
        // Clear Message area
        ShowMessage = false;
        Message = new();
        StatusClass = string.Empty;
        StateHasChanged();
    }

#if (false) // Not yet needed
    private void SetInfoMessage(string InfoMessage)
    {
        // Clear Message area
        ShowMessage = true;
        Message = InfoMessage;
        StatusClass = "alert-success";
        StateHasChanged();
    }
#endif

    private void SetErrorMessage(string ErrorMessage)
    {
        // Clear Message area
        ShowMessage = true;
        Message = new(ErrorMessage);
        StatusClass = "alert-danger";
        IsBusy = false;
        StateHasChanged();
    }

    private void ToggleInstructions()
    {
        InstructionsCollapsed = !InstructionsCollapsed;
        StateHasChanged();
    }

    private void ShowBusy(bool IsBusy)
    {
        this.IsBusy = IsBusy;
        StateHasChanged();
    }
}
