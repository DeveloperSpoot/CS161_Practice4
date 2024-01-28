namespace CS161_Practice4.ProgrammingProblems
{
    partial class Mass_and_Weight
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
            label1 = new Label();
            massTextBox = new TextBox();
            convertButton = new Button();
            exitButton = new Button();
            displayLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter object's mass:";
            // 
            // massTextBox
            // 
            massTextBox.Location = new Point(172, 20);
            massTextBox.Name = "massTextBox";
            massTextBox.Size = new Size(100, 23);
            massTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(16, 99);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 2;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(197, 99);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.Location = new Point(16, 53);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(256, 30);
            displayLabel.TabIndex = 4;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Mass_and_Weight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 135);
            Controls.Add(displayLabel);
            Controls.Add(exitButton);
            Controls.Add(convertButton);
            Controls.Add(massTextBox);
            Controls.Add(label1);
            Name = "Mass_and_Weight";
            Text = "Mass_and_Weight";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox massTextBox;
        private Button convertButton;
        private Button exitButton;
        private Label displayLabel;
    }
}