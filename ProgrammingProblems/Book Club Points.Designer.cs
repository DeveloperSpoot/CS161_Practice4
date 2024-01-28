namespace CS161_Practice4.ProgrammingProblems
{
    partial class Book_Club_Points
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
            booksNumeric = new NumericUpDown();
            displayLabel = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)booksNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Number of Books Purchased:";
            // 
            // booksNumeric
            // 
            booksNumeric.Location = new Point(210, 5);
            booksNumeric.Name = "booksNumeric";
            booksNumeric.Size = new Size(61, 23);
            booksNumeric.TabIndex = 1;
            booksNumeric.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Location = new Point(171, 38);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(100, 23);
            displayLabel.TabIndex = 2;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 42);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 3;
            label3.Text = "Points Earned:";
            // 
            // Book_Club_Points
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 72);
            Controls.Add(label3);
            Controls.Add(displayLabel);
            Controls.Add(booksNumeric);
            Controls.Add(label1);
            Name = "Book_Club_Points";
            Text = "Book_Club_Points";
            ((System.ComponentModel.ISupportInitialize)booksNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown booksNumeric;
        private Label displayLabel;
        private Label label3;
    }
}