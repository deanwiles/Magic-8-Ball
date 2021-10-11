namespace Magic8Ball.WFClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnMagic8Ball = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Location = new System.Drawing.Point(18, 98);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(468, 23);
            this.txtQuestion.TabIndex = 3;
            this.txtQuestion.Text = "Will I win the lottery?";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(14, 78);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(58, 15);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "&Question:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Location = new System.Drawing.Point(18, 157);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(468, 23);
            this.txtAnswer.TabIndex = 6;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(14, 137);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(49, 15);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "&Answer:";
            // 
            // btnMagic8Ball
            // 
            this.btnMagic8Ball.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMagic8Ball.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMagic8Ball.BackgroundImage = global::Magic8Ball.WFClient.Properties.Resources.Magic_8_Ball;
            this.btnMagic8Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMagic8Ball.Location = new System.Drawing.Point(511, 38);
            this.btnMagic8Ball.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMagic8Ball.Name = "btnMagic8Ball";
            this.btnMagic8Ball.Size = new System.Drawing.Size(142, 142);
            this.btnMagic8Ball.TabIndex = 4;
            this.btnMagic8Ball.UseVisualStyleBackColor = true;
            this.btnMagic8Ball.Click += new System.EventHandler(this.BtnMagic8Ball_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(14, 19);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(116, 15);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "&Magic 8-Ball Service:";
            // 
            // cboService
            // 
            this.cboService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(18, 38);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(468, 23);
            this.cboService.TabIndex = 1;
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInstructions.Location = new System.Drawing.Point(18, 221);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.ReadOnly = true;
            this.rtbInstructions.Size = new System.Drawing.Size(636, 84);
            this.rtbInstructions.TabIndex = 7;
            this.rtbInstructions.TabStop = false;
            this.rtbInstructions.Text = resources.GetString("rtbInstructions.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Instructions:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMagic8Ball;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnMagic8Ball);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Test Magic 8-Ball";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtQuestion;
        internal System.Windows.Forms.Label lblQuestion;
        internal System.Windows.Forms.TextBox txtAnswer;
        internal System.Windows.Forms.Label lblAnswer;
        internal System.Windows.Forms.Button btnMagic8Ball;
        internal System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        internal System.Windows.Forms.Label label1;
    }
}

