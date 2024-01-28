namespace CS161_Practice4.ProgrammingProblems
{
    partial class Roman_Numeral
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
            numberTextBox = new TextBox();
            convertButton = new Button();
            exitButton = new Button();
            displayLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(262, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Number To Convert To Roman Numeral:";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(283, 10);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(100, 23);
            numberTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(99, 96);
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
            exitButton.Location = new Point(201, 98);
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
            displayLabel.Location = new Point(99, 42);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(180, 36);
            displayLabel.TabIndex = 4;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Roman_Numeral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 138);
            Controls.Add(displayLabel);
            Controls.Add(exitButton);
            Controls.Add(convertButton);
            Controls.Add(numberTextBox);
            Controls.Add(label1);
            Name = "Roman_Numeral";
            Text = "Roman_Numeral";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numberTextBox;
        private Button convertButton;
        private Button exitButton;
        private Label displayLabel;
    }
}