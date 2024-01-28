namespace CS161_Practice4.ProgrammingProblems
{
    partial class Magic_Date
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            yearNumeric = new NumericUpDown();
            dayNumeric = new NumericUpDown();
            monthNumeric = new NumericUpDown();
            checkButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthNumeric).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(yearNumeric);
            groupBox1.Controls.Add(dayNumeric);
            groupBox1.Controls.Add(monthNumeric);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter a Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 32);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 4;
            label2.Text = "/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 32);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 3;
            label1.Text = "/";
            // 
            // yearNumeric
            // 
            yearNumeric.Location = new Point(152, 29);
            yearNumeric.Name = "yearNumeric";
            yearNumeric.Size = new Size(41, 27);
            yearNumeric.TabIndex = 2;
            // 
            // dayNumeric
            // 
            dayNumeric.Location = new Point(79, 29);
            dayNumeric.Name = "dayNumeric";
            dayNumeric.Size = new Size(41, 27);
            dayNumeric.TabIndex = 1;
            // 
            // monthNumeric
            // 
            monthNumeric.Location = new Point(6, 29);
            monthNumeric.Name = "monthNumeric";
            monthNumeric.Size = new Size(41, 27);
            monthNumeric.TabIndex = 0;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(235, 42);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(75, 23);
            checkButton.TabIndex = 1;
            checkButton.Text = "Check Magic";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(323, 42);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Magic_Date
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 89);
            Controls.Add(exitButton);
            Controls.Add(checkButton);
            Controls.Add(groupBox1);
            Name = "Magic_Date";
            Text = "Magic_Date";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private NumericUpDown yearNumeric;
        private NumericUpDown dayNumeric;
        private NumericUpDown monthNumeric;
        private Button checkButton;
        private Button exitButton;
    }
}