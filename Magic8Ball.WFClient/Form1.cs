﻿using Magic8Ball.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// This C# sample is used to test the Classic Magic 8 Ball class.
namespace Magic8Ball.WFClient
{
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
                var service = cboService.SelectedItem as Magic8BallServiceDefinition;
                var magic8BallService = Activator.CreateInstance(Type.GetType(service.TypeName)) as IMagic8BallService;
                // Ask the Magic 8 Ball service the user's question
                string question = txtQuestion.Text;
                Cursor = Cursors.WaitCursor;
                var magic8BallData = await magic8BallService.AskAsync(question);
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
            List<Magic8BallServiceDefinition> list = new();
            list.Add(new Magic8BallServiceDefinition("Classic 8 Ball Answers", 
                typeof(Classic.ClassicMagic8Ball).AssemblyQualifiedName));
            list.Add(new Magic8BallServiceDefinition("Azure Function 8 Ball REST Service",
                typeof(RESTClient.RESTClientMagic8Ball).AssemblyQualifiedName));
            list.Add(new Magic8BallServiceDefinition("Delegator 8 Ball REST Service", 
                typeof(Delegator.DelegatorMagic8Ball).AssemblyQualifiedName));
            cboService.DataSource = list;
            cboService.ValueMember = "TypeName";
            cboService.DisplayMember = "DisplayName";
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
}
