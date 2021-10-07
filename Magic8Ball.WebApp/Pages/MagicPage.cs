using Magic8Ball.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Magic8Ball.WebApp.Pages
{
    public partial class MagicPage
    {
        [Parameter]
        public string Service { get; set; } = "";

        private Magic8BallData Magic8BallData { get; set; } = null;

        private ElementReference QuestionInput;

        private string AnswerStyle;

        protected override void OnInitialized()
        {
            Debug.WriteLine("Entering OnInitialized()...");
        }

        protected override void OnParametersSet()
        {
            Debug.WriteLine("Entering OnParametersSet()...");
            // Instantiate specified Magic 8-Ball service type (or default to Classic)
            Magic8BallData = Service.ToLower() switch
            {
                "delegator" => new Delegator.DelegatorMagic8Ball(),
                "classic" or "" => new Classic.ClassicMagic8Ball(),
                _ => throw new ArgumentException($"Unsupported Magic 8-Ball Service name '{Service}'", nameof(Service)),
            };
            // Set default question
            string question = "Will I win the lottery?";
            Magic8BallData.Question = question;
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            // Set focus on Question input textbox
            await QuestionInput.FocusAsync();
        }

        private async Task AskQuestion()
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
                _ => "",
            };
            // Refresh screen with Answer & Type
            StateHasChanged();
        }
    }
}
