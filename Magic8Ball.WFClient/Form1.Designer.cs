namespace Magic8Ball.WFClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtQuestion = new TextBox();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            lblAnswer = new Label();
            btnMagic8Ball = new Button();
            lblService = new Label();
            cboService = new ComboBox();
            rtbInstructions = new RichTextBox();
            lblInstructions = new Label();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuestion.Location = new Point(18, 98);
            txtQuestion.Margin = new Padding(4, 3, 4, 3);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(468, 23);
            txtQuestion.TabIndex = 3;
            txtQuestion.Text = "Will I win the lottery?";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(14, 78);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(58, 15);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "&Question:";
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.Location = new Point(18, 157);
            txtAnswer.Margin = new Padding(4, 3, 4, 3);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(468, 23);
            txtAnswer.TabIndex = 6;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(14, 137);
            lblAnswer.Margin = new Padding(4, 0, 4, 0);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(49, 15);
            lblAnswer.TabIndex = 5;
            lblAnswer.Text = "&Answer:";
            // 
            // btnMagic8Ball
            // 
            btnMagic8Ball.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMagic8Ball.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMagic8Ball.BackgroundImage = Properties.Resources.Magic_8_Ball;
            btnMagic8Ball.BackgroundImageLayout = ImageLayout.Stretch;
            btnMagic8Ball.Location = new Point(511, 38);
            btnMagic8Ball.Margin = new Padding(4, 3, 4, 3);
            btnMagic8Ball.Name = "btnMagic8Ball";
            btnMagic8Ball.Size = new Size(142, 142);
            btnMagic8Ball.TabIndex = 4;
            btnMagic8Ball.UseVisualStyleBackColor = true;
            btnMagic8Ball.Click += BtnMagic8Ball_Click;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(14, 19);
            lblService.Margin = new Padding(4, 0, 4, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(114, 15);
            lblService.TabIndex = 0;
            lblService.Text = "&Magic 8 Ball Service:";
            // 
            // cboService
            // 
            cboService.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboService.DropDownStyle = ComboBoxStyle.DropDownList;
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(18, 38);
            cboService.Name = "cboService";
            cboService.Size = new Size(468, 23);
            cboService.TabIndex = 1;
            // 
            // rtbInstructions
            // 
            rtbInstructions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbInstructions.Location = new Point(18, 221);
            rtbInstructions.Name = "rtbInstructions";
            rtbInstructions.ReadOnly = true;
            rtbInstructions.Size = new Size(636, 84);
            rtbInstructions.TabIndex = 8;
            rtbInstructions.TabStop = false;
            rtbInstructions.Text = resources.GetString("rtbInstructions.Text");
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(18, 203);
            lblInstructions.Margin = new Padding(4, 0, 4, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(72, 15);
            lblInstructions.TabIndex = 7;
            lblInstructions.Text = "Instructions:";
            // 
            // Form1
            // 
            AcceptButton = btnMagic8Ball;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 320);
            Controls.Add(lblInstructions);
            Controls.Add(rtbInstructions);
            Controls.Add(cboService);
            Controls.Add(lblService);
            Controls.Add(btnMagic8Ball);
            Controls.Add(txtAnswer);
            Controls.Add(lblAnswer);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Test Magic 8 Ball";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal TextBox txtQuestion;
        internal Label lblQuestion;
        internal TextBox txtAnswer;
        internal Label lblAnswer;
        internal Button btnMagic8Ball;
        internal Label lblService;
        private ComboBox cboService;
        private RichTextBox rtbInstructions;
        internal Label lblInstructions;
    }
}