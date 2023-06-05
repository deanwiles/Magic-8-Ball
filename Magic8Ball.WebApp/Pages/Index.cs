﻿using Magic8Ball.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Magic8Ball.WebApp.Pages
{
    public partial class Index
    {
        [Parameter]
        public string Service { get; set; } = string.Empty;

        private Magic8BallData Magic8BallData { get; set; } = null;
        private string Question { get; set; }
        private string Answer { get; set; }

        private ElementReference QuestionInput;
        private ElementReference SubmitButton;

        private string AnswerStyle;

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
            if (string.IsNullOrWhiteSpace(Service)) Service = "classic";
            // Instantiate specified Magic 8 Ball service type
            Magic8BallData = Service.ToLower() switch
            {
                "classic" => new Classic.ClassicMagic8Ball(),
                "azure" => new RESTClient.RESTClientMagic8Ball(),
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
                // Ask the Magic 8 Ball service the user's question
                await (Magic8BallData as IMagic8BallService).AskAsync(Question);
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
}
