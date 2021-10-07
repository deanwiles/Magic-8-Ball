using Magic8Ball.Classic;
using Magic8Ball.Shared;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Magic8Ball.WebApp.Pages
{
    public partial class MagicPage
    {
        public Magic8BallData Magic8BallData { get; set; } = null;

        private ElementReference QuestionInput;

        protected override void OnInitialized()
        {
            // Set default question
            string question = "Will I win the lottery?";
            // Reset response
            Magic8BallData = null;
            // Instantiate selected Magic 8-Ball service type
            //var service = cboService.SelectedItem as Magic8BallService;
            //var oMagic8Ball = Activator.CreateInstance(Type.GetType(service.TypeName)) as Magic8BallBase;
            Magic8BallData = new ClassicMagic8Ball() { Question = question };
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await QuestionInput.FocusAsync();

        }

        private async Task AskQuestion()
        {
            // Ask the Magic 8-Ball service the user's question
            await (Magic8BallData as IMagic8BallService).AskAsync(Magic8BallData.Question);
            // Refresh screen with Answer & Type
            StateHasChanged();
        }
    }
}
