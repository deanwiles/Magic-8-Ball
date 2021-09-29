using System;
using System.Drawing;
using System.Windows.Forms;

// This C# sample is used to test the C# Magic 8-Ball WinForm REST Example (Magic8BallREST.DLL).
//   Magic8BallREST.Magic8Ball - provides access to Magic 8 Ball RESTful service

namespace Magic8BallREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This Magic 8 Ball test demonstrates calling a RESTful API.
        // After the user enters a question and clicks the Magic 8 Ball button
        // it instantiates the .NET COM class and calls the Ask method with the specified question.
        // The question is sent as an HTTP GET request and the response is received as a JSON message.
        // The answer response is displayed and the response background color set to green, yellow or red
        // based on the type of response (affirmative, neutral or contrary).
        // If any errors occur, they are displayed in a C# message box.
        // To force an error, leave the Question empty and click the Magic 8 Ball button.
        private void BtnMagic8Ball_Click(object sender, EventArgs e)
        {
            try
            {
                var oMagic8Ball = new Magic8BallREST.Magic8Ball();
                string sQuestion = txtQuestion.Text;
                if (string.IsNullOrWhiteSpace(sQuestion)) sQuestion = @"..\..\";    // if no question, force an error to demonstrate inner exception handling
                this.Cursor = Cursors.WaitCursor;
                string sAnswer = oMagic8Ball.Ask(sQuestion);
                txtAnswer.Text = sAnswer;
                var iType = oMagic8Ball.Type;
                txtAnswer.BackColor = iType switch
                {
                    Magic8BallREST.AnswerType.Affirmative => Color.LightGreen,
                    Magic8BallREST.AnswerType.Neutral => Color.PaleGoldenrod,
                    Magic8BallREST.AnswerType.Contrary => Color.LightCoral,
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
