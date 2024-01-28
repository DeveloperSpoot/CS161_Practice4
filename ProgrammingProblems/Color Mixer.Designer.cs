namespace CS161_Practice4.ProgrammingProblems
{
    partial class Color_Mixer
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
            yellow1RadioBtt = new RadioButton();
            blue1RadioBtt = new RadioButton();
            red1RadioBtt = new RadioButton();
            groupBox2 = new GroupBox();
            yellow2RadioBtt = new RadioButton();
            blue2RadioBtt = new RadioButton();
            red2RadioBtt = new RadioButton();
            mixButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(yellow1RadioBtt);
            groupBox1.Controls.Add(blue1RadioBtt);
            groupBox1.Controls.Add(red1RadioBtt);
            groupBox1.Location = new Point(13, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(124, 123);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select 1st Mixer";
            // 
            // yellow1RadioBtt
            // 
            yellow1RadioBtt.AutoSize = true;
            yellow1RadioBtt.Location = new Point(15, 90);
            yellow1RadioBtt.Name = "yellow1RadioBtt";
            yellow1RadioBtt.Size = new Size(59, 19);
            yellow1RadioBtt.TabIndex = 2;
            yellow1RadioBtt.TabStop = true;
            yellow1RadioBtt.Text = "Yellow";
            yellow1RadioBtt.UseVisualStyleBackColor = true;
            // 
            // blue1RadioBtt
            // 
            blue1RadioBtt.AutoSize = true;
            blue1RadioBtt.Location = new Point(15, 57);
            blue1RadioBtt.Name = "blue1RadioBtt";
            blue1RadioBtt.Size = new Size(48, 19);
            blue1RadioBtt.TabIndex = 1;
            blue1RadioBtt.TabStop = true;
            blue1RadioBtt.Text = "Blue";
            blue1RadioBtt.UseVisualStyleBackColor = true;
            // 
            // red1RadioBtt
            // 
            red1RadioBtt.AutoSize = true;
            red1RadioBtt.Location = new Point(15, 24);
            red1RadioBtt.Name = "red1RadioBtt";
            red1RadioBtt.Size = new Size(45, 19);
            red1RadioBtt.TabIndex = 0;
            red1RadioBtt.TabStop = true;
            red1RadioBtt.Text = "Red";
            red1RadioBtt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(yellow2RadioBtt);
            groupBox2.Controls.Add(blue2RadioBtt);
            groupBox2.Controls.Add(red2RadioBtt);
            groupBox2.Location = new Point(154, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(124, 123);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select 2nd Mixer";
            // 
            // yellow2RadioBtt
            // 
            yellow2RadioBtt.AutoSize = true;
            yellow2RadioBtt.Location = new Point(15, 90);
            yellow2RadioBtt.Name = "yellow2RadioBtt";
            yellow2RadioBtt.Size = new Size(59, 19);
            yellow2RadioBtt.TabIndex = 2;
            yellow2RadioBtt.TabStop = true;
            yellow2RadioBtt.Text = "Yellow";
            yellow2RadioBtt.UseVisualStyleBackColor = true;
            // 
            // blue2RadioBtt
            // 
            blue2RadioBtt.AutoSize = true;
            blue2RadioBtt.Location = new Point(15, 57);
            blue2RadioBtt.Name = "blue2RadioBtt";
            blue2RadioBtt.Size = new Size(48, 19);
            blue2RadioBtt.TabIndex = 1;
            blue2RadioBtt.TabStop = true;
            blue2RadioBtt.Text = "Blue";
            blue2RadioBtt.UseVisualStyleBackColor = true;
            // 
            // red2RadioBtt
            // 
            red2RadioBtt.AutoSize = true;
            red2RadioBtt.Location = new Point(15, 24);
            red2RadioBtt.Name = "red2RadioBtt";
            red2RadioBtt.Size = new Size(45, 19);
            red2RadioBtt.TabIndex = 0;
            red2RadioBtt.TabStop = true;
            red2RadioBtt.Text = "Red";
            red2RadioBtt.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            mixButton.Location = new Point(14, 146);
            mixButton.Name = "mixButton";
            mixButton.Size = new Size(123, 23);
            mixButton.TabIndex = 4;
            mixButton.Text = "Mix";
            mixButton.UseVisualStyleBackColor = true;
            mixButton.Click += mixButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(154, 146);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(123, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Color_Mixer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 180);
            Controls.Add(exitButton);
            Controls.Add(mixButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Color_Mixer";
            Text = "Color_Mixer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton yellow1RadioBtt;
        private RadioButton blue1RadioBtt;
        private RadioButton red1RadioBtt;
        private GroupBox groupBox2;
        private RadioButton yellow2RadioBtt;
        private RadioButton blue2RadioBtt;
        private RadioButton red2RadioBtt;
        private Button mixButton;
        private Button exitButton;
    }
}