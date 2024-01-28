namespace CS161_Practice4.Tutorials
{
    partial class LoanQualifier
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
            this.salaryPromptLabel = new System.Windows.Forms.Label();
            this.yearsPromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryPromptLabel
            // 
            this.salaryPromptLabel.AutoSize = true;
            this.salaryPromptLabel.Location = new System.Drawing.Point(83, 18);
            this.salaryPromptLabel.Name = "salaryPromptLabel";
            this.salaryPromptLabel.Size = new System.Drawing.Size(94, 19);
            this.salaryPromptLabel.TabIndex = 0;
            this.salaryPromptLabel.Text = "Annual salary:";
            // 
            // yearsPromptLabel
            // 
            this.yearsPromptLabel.AutoSize = true;
            this.yearsPromptLabel.Location = new System.Drawing.Point(49, 54);
            this.yearsPromptLabel.Name = "yearsPromptLabel";
            this.yearsPromptLabel.Size = new System.Drawing.Size(131, 19);
            this.yearsPromptLabel.TabIndex = 1;
            this.yearsPromptLabel.Text = "Years at current job:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(14, 90);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(95, 19);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Loan decision:";
            // 
            // decisionLabel
            // 
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLabel.Location = new System.Drawing.Point(14, 117);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(319, 29);
            this.decisionLabel.TabIndex = 3;
            this.decisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(183, 14);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(114, 26);
            this.salaryTextBox.TabIndex = 4;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(183, 51);
            this.yearsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(114, 26);
            this.yearsTextBox.TabIndex = 5;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(14, 166);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(102, 51);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check Qualifications";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(122, 166);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 51);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(231, 166);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 51);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LoanQualifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 232);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.yearsPromptLabel);
            this.Controls.Add(this.salaryPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoanQualifier";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label salaryPromptLabel;
        private Label yearsPromptLabel;
        private Label outputDescriptionLabel;
        private Label decisionLabel;
        private TextBox salaryTextBox;
        private TextBox yearsTextBox;
        private Button checkButton;
        private Button clearButton;
        private Button exitButton;
    }
}