namespace Magic8Ball.Client
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
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(18, 30);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(373, 23);
            this.txtQuestion.TabIndex = 1;
            this.txtQuestion.Text = "Will I win the lottery?";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(14, 10);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(58, 15);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "&Question:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(18, 89);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(373, 23);
            this.txtAnswer.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(14, 69);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(49, 15);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "&Answer:";
            // 
            // btnMagic8Ball
            // 
            this.btnMagic8Ball.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMagic8Ball.BackgroundImage = global::Magic8Ball.Client.Properties.Resources.Magic_8_Ball;
            this.btnMagic8Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMagic8Ball.Location = new System.Drawing.Point(414, 30);
            this.btnMagic8Ball.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMagic8Ball.Name = "btnMagic8Ball";
            this.btnMagic8Ball.Size = new System.Drawing.Size(83, 82);
            this.btnMagic8Ball.TabIndex = 4;
            this.btnMagic8Ball.UseVisualStyleBackColor = true;
            this.btnMagic8Ball.Click += new System.EventHandler(this.BtnMagic8Ball_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMagic8Ball;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 133);
            this.Controls.Add(this.btnMagic8Ball);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Test Magic 8-Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtQuestion;
        internal System.Windows.Forms.Label lblQuestion;
        internal System.Windows.Forms.TextBox txtAnswer;
        internal System.Windows.Forms.Label lblAnswer;
        internal System.Windows.Forms.Button btnMagic8Ball;
    }
}

