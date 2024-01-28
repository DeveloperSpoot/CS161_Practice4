namespace CS161_Practice4.ProgrammingProblems
{
    partial class Distance_Converter
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
            distanceNumeric = new NumericUpDown();
            groupBox1 = new GroupBox();
            fromListBox = new ListBox();
            to = new GroupBox();
            toListBox = new ListBox();
            displayLabel = new Label();
            convertButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)distanceNumeric).BeginInit();
            groupBox1.SuspendLayout();
            to.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 21);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a distance to convert:";
            // 
            // distanceNumeric
            // 
            distanceNumeric.Location = new Point(259, 17);
            distanceNumeric.Name = "distanceNumeric";
            distanceNumeric.Size = new Size(82, 23);
            distanceNumeric.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(fromListBox);
            groupBox1.Location = new Point(15, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // fromListBox
            // 
            fromListBox.FormattingEnabled = true;
            fromListBox.ItemHeight = 15;
            fromListBox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            fromListBox.Location = new Point(16, 22);
            fromListBox.Name = "fromListBox";
            fromListBox.Size = new Size(164, 64);
            fromListBox.TabIndex = 0;
            // 
            // to
            // 
            to.Controls.Add(toListBox);
            to.Location = new Point(233, 54);
            to.Name = "to";
            to.Size = new Size(200, 100);
            to.TabIndex = 3;
            to.TabStop = false;
            to.Text = "To";
            // 
            // toListBox
            // 
            toListBox.FormattingEnabled = true;
            toListBox.ItemHeight = 15;
            toListBox.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            toListBox.Location = new Point(16, 22);
            toListBox.Name = "toListBox";
            toListBox.Size = new Size(164, 64);
            toListBox.TabIndex = 0;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Location = new Point(19, 166);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(196, 28);
            displayLabel.TabIndex = 4;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(233, 169);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 5;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(358, 169);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Distance_Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 210);
            Controls.Add(exitButton);
            Controls.Add(convertButton);
            Controls.Add(displayLabel);
            Controls.Add(to);
            Controls.Add(groupBox1);
            Controls.Add(distanceNumeric);
            Controls.Add(label1);
            Name = "Distance_Converter";
            Text = "Distance_Converter";
            ((System.ComponentModel.ISupportInitialize)distanceNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            to.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown distanceNumeric;
        private GroupBox groupBox1;
        private ListBox fromListBox;
        private GroupBox to;
        private ListBox toListBox;
        private Label displayLabel;
        private Button convertButton;
        private Button exitButton;
    }
}