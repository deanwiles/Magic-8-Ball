﻿using Magic8Ball.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace Magic8Ball.WebApp.Pages
{
    public partial class Index
    {
        [Parameter]
        public string Service { get; set; } = string.Empty;

        private Magic8BallData Magic8BallData { get; set; } = null;

        private ElementReference QuestionInput;

        private string AnswerStyle;

        //used to store state of screen
        protected bool ShowMessage;
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected override void OnInitialized()
        {
            Console.WriteLine("Entering OnInitialized()...");
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine($"Entering OnParametersSet(Service='{Service}')...");
            // Default to classic if Service not specified
            if (string.IsNullOrWhiteSpace(Service)) Service = "classic";
            // Instantiate specified Magic 8-Ball service type
            Magic8BallData = Service.ToLower() switch
            {
                "delegator" => new Delegator.DelegatorMagic8Ball(),
                "classic" => new Classic.ClassicMagic8Ball(),
                _ => null,
            };
            // Check if service created
            if (Magic8BallData == null)
            {
                // No, show error message
                SetErrorMessage($"Unsupported Magic 8-Ball Service name '{Service}'");
            }
            else
            {
                // Yes, set default question
                string question = "Will I win the lottery?";
                Magic8BallData.Question = question;
                // Clear Message area
                ClearMessage();
            }
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            // Set focus on Question input textbox (if present)
            if (!ShowMessage && QuestionInput.Context != null)
                await QuestionInput.FocusAsync();
        }

        private async Task AskQuestion()
        {
            try
            {
                // Ask the Magic 8-Ball service the user's question
                await (Magic8BallData as IMagic8BallService).AskAsync(Magic8BallData.Question);
                // Set Answer Style
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
                StateHasChanged();
            }
            catch (Exception ex)
            {
                // Display error message
                SetErrorMessage(ex.Message);
            }
        }

        private void ClearMessage()
        {
            // Clear Message area
            ShowMessage = false;
            Message = string.Empty;
            StatusClass = string.Empty;
        }

        private void SetInfoMessage(string InfoMessage)
        {
            // Clear Message area
            ShowMessage = true;
            Message = InfoMessage;
            StatusClass = "alert-success";
        }

        private void SetErrorMessage(string ErrorMessage)
        {
            // Clear Message area
            ShowMessage = true;
            Message = ErrorMessage;
            StatusClass = "alert-danger";
        }
    }
}