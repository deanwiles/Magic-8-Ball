using Magic8Ball.Shared;

// This C# sample is used to test the Classic Magic 8 Ball class.
namespace Magic8Ball.WFClient;

public partial class Form1 : Form
{
    private readonly Color colorPositiveAnswer = Color.LightGreen;
    private readonly Color colorNeutralAnswer = Color.PaleGoldenrod;
    private readonly Color colorNegativeAnswer = Color.LightCoral;
    private readonly Color colorNoAnswer = SystemColors.Window;
    public Form1()
    {
        InitializeComponent();
    }

    // This Magic 8 Ball test demonstrates calling a Magic 8 Ball API.
    // After the user enters a question and clicks the Magic 8 Ball button
    // it instantiates a class derived from the common Magic8BallBase
    // and calls the Ask method with the specified question.
    // The answer response is displayed and the response background color set to green, yellow or red
    // based on the type of response (affirmative, neutral or contrary).
    // If any errors occur, they are displayed in a message box.
    // To force an error, leave the Question empty and click the Magic 8 Ball button.
    private async void BtnMagic8Ball_Click(object sender, EventArgs e)
    {
        try
        {
            // Reset response
            txtAnswer.Text = string.Empty;
            txtAnswer.BackColor = colorNoAnswer;
            // Instantiate selected Magic 8 Ball service type
            var service = cboService.SelectedItem as Magic8BallServiceDefinition
                ?? throw new Exception("No Magic 8 Ball Service selected");
            var magic8BallType = Type.GetType(service.TypeName)
                ?? throw new Exception($"Unrecognized Magic 8 Ball Service type '{service.TypeName}'");
            var magic8BallService = Activator.CreateInstance(magic8BallType) as IMagic8BallService
                ?? throw new Exception($"Could not create Magic 8 Ball Service type '{service.TypeName}'");
            // Ask the Magic 8 Ball service the user's question
            string question = txtQuestion.Text;
            Cursor = Cursors.WaitCursor;
            var magic8BallData = await magic8BallService.AskAsync(question)
                ?? throw new Exception("No Magic 8 Ball response received");
            // Display and color code the answer
            txtAnswer.Text = magic8BallData.Answer;
            var iType = magic8BallData.Type;
            txtAnswer.BackColor = iType switch
            {
                AnswerType.Positive => colorPositiveAnswer,
                AnswerType.Neutral => colorNeutralAnswer,
                AnswerType.Negative => colorNegativeAnswer,
                _ => colorNoAnswer,
            };
        }
        catch (Exception ex)
        {
            // Error occurred; display message box with error details
            string msg = ex.Message;
            if (null != ex.InnerException) msg += $"{Environment.NewLine}{ex.InnerException.Message}";
            MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // Reset any hourglass cursor
            this.Cursor = Cursors.Default;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Initial list of Magic 8 Ball Services
        List<Magic8BallServiceDefinition> list = new()
        {
            new Magic8BallServiceDefinition("Classic Magic 8 Ball Answers",
                GetAssemblyQualifiedName(typeof(Classic.ClassicMagic8Ball))),
            new Magic8BallServiceDefinition("Azure Function Magic 8 Ball REST Service",
                GetAssemblyQualifiedName(typeof(RESTClient.RESTClientMagic8Ball))),
            new Magic8BallServiceDefinition("Artificially Intelligent Magic 8 Ball Service",
                GetAssemblyQualifiedName(typeof(AI.AIMagic8Ball)))
        };
        cboService.DataSource = list;
        cboService.ValueMember = "TypeName";
        cboService.DisplayMember = "DisplayName";
    }

    private static string GetAssemblyQualifiedName(Type type)
    {
        return type.AssemblyQualifiedName
            ?? throw new Exception($"Unknown assembly qualified name for '{type.FullName}'");
    }
}

public class Magic8BallServiceDefinition
{
    public string DisplayName { get; set; }
    public string TypeName { get; set; }
    public Magic8BallServiceDefinition(string DisplayName, string TypeName)
    {
        this.DisplayName = DisplayName;
        this.TypeName = TypeName;
    }
}
