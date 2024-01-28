namespace CS161_Practice4.Tutorials
{
    partial class PayrollOvertime
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
            this.hoursWorkedPromptLabel = new System.Windows.Forms.Label();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedPromptLabel
            // 
            this.hoursWorkedPromptLabel.AutoSize = true;
            this.hoursWorkedPromptLabel.Location = new System.Drawing.Point(41, 18);
            this.hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            this.hoursWorkedPromptLabel.Size = new System.Drawing.Size(98, 19);
            this.hoursWorkedPromptLabel.TabIndex = 0;
            this.hoursWorkedPromptLabel.Text = "Hours worked:";
            // 
            // hourlyPayRatePromptLabel
            // 
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(33, 53);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(107, 19);
            this.hourlyPayRatePromptLabel.TabIndex = 1;
            this.hourlyPayRatePromptLabel.Text = "Hourly pay rate:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(67, 86);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(73, 19);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Gross pay:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Location = new System.Drawing.Point(144, 81);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(114, 29);
            this.grossPayLabel.TabIndex = 3;
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(144, 13);
            this.hoursWorkedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(114, 26);
            this.hoursWorkedTextBox.TabIndex = 4;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(144, 47);
            this.hourlyPayRateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(114, 26);
            this.hourlyPayRateTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(7, 132);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 56);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Gross Pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(99, 132);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 56);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(192, 132);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 56);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PayrollOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 203);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.hoursWorkedPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PayrollOvertime";
            this.Text = "Payroll With Overtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hoursWorkedPromptLabel;
        private Label hourlyPayRatePromptLabel;
        private Label outputDescriptionLabel;
        private Label grossPayLabel;
        private TextBox hoursWorkedTextBox;
        private TextBox hourlyPayRateTextBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}