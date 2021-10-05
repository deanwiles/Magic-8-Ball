using Magic8Ball.Classic;
using Magic8Ball.Shared;
using System.Threading.Tasks;

namespace Magic8Ball.WebApp.Pages
{
    public partial class MagicPage
    {
        public Magic8BallBase MyMagic8Ball { get; set; } = null;

        protected override void OnInitialized()
        {
            // Set default question
            string question = "Will I win the lottery?";
            // Reset response
            MyMagic8Ball = null;
            // Instantiate selected Magic 8-Ball service type
            //var service = cboService.SelectedItem as Magic8BallService;
            //var oMagic8Ball = Activator.CreateInstance(Type.GetType(service.TypeName)) as Magic8BallBase;
            MyMagic8Ball = new ClassicMagic8Ball() { Question = question };
        }

        private async Task AskQuestion()
        { 
            // Ask the Magic 8-Ball service the user's question
            await MyMagic8Ball.AskAsync(MyMagic8Ball.Question);
            // Refresh screen with Answer & Type
            StateHasChanged();
        }
    }
}
