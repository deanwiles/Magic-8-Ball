using Magic8Ball.Classic;
using Magic8Ball.Shared;
using System.Threading.Tasks;

namespace Magic8Ball.WebApp.Pages
{
    public partial class AskMagic8Ball
    {
        private Magic8BallBase MyMagic8Ball;

        protected async override Task OnInitializedAsync()
        {
            // Set default question
            string question = "Will I win the lottery?";
            // Reset response
            MyMagic8Ball = null;
            // Instantiate selected Magic 8-Ball service type
            //var service = cboService.SelectedItem as Magic8BallService;
            //var oMagic8Ball = Activator.CreateInstance(Type.GetType(service.TypeName)) as Magic8BallBase;
            MyMagic8Ball = new ClassicMagic8Ball();
            // Ask the Magic 8-Ball service the user's question
            await MyMagic8Ball.AskAsync(question);
        }
    }
}
