using Magic8Ball.Classic;
using Magic8Ball.Shared;
using System;
using System.Drawing;
using System.Windows.Forms;

// This C# sample is used to test the Classic Magic 8-Ball class.
namespace Magic8Ball.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This Magic 8-Ball test demonstrates calling a Magic 8-Ball API.
        // After the user enters a question and clicks the Magic 8-Ball button
        // it instantiates a class derived from the common Magic8BallBase
        // and calls the Ask method with the specified question.
        // The answer response is displayed and the response background color set to green, yellow or red
        // based on the type of response (affirmative, neutral or contrary).
        // If any errors occur, they are displayed in a message box.
        // To force an error, leave the Question empty and click the Magic 8-Ball button.
        private async void BtnMagic8Ball_Click(object sender, EventArgs e)
        {
            try
            {
                var oMagic8Ball = new ClassicMagic8Ball();
                string sQuestion = txtQuestion.Text;
                Cursor = Cursors.WaitCursor;
                string sAnswer = await oMagic8Ball.AskAsync(sQuestion);
                txtAnswer.Text = sAnswer;
                var iType = oMagic8Ball.Type;
                txtAnswer.BackColor = iType switch
                {
                    AnswerType.Positive => Color.LightGreen,
                    AnswerType.Neutral => Color.PaleGoldenrod,
                    AnswerType.Negative => Color.LightCoral,
                    _ => SystemColors.Window,
                };
            }
            catch (Exception eek)
            {
                string msg = eek.Message;
                if (null != eek.InnerException) msg += $"{Environment.NewLine}{eek.InnerException.Message}";
                MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
