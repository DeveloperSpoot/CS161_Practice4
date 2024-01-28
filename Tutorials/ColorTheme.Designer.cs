namespace CS161_Practice4.Tutorials
{
    partial class ColorTheme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.normalRadioBtt = new System.Windows.Forms.RadioButton();
            this.whiteRadioBtt = new System.Windows.Forms.RadioButton();
            this.redRadioBtt = new System.Windows.Forms.RadioButton();
            this.yellowRadioBtt = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.normalRadioBtt);
            this.groupBox1.Controls.Add(this.whiteRadioBtt);
            this.groupBox1.Controls.Add(this.redRadioBtt);
            this.groupBox1.Controls.Add(this.yellowRadioBtt);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Background Color";
            // 
            // normalRadioBtt
            // 
            this.normalRadioBtt.AutoSize = true;
            this.normalRadioBtt.Checked = true;
            this.normalRadioBtt.Location = new System.Drawing.Point(39, 173);
            this.normalRadioBtt.Name = "normalRadioBtt";
            this.normalRadioBtt.Size = new System.Drawing.Size(121, 23);
            this.normalRadioBtt.TabIndex = 3;
            this.normalRadioBtt.TabStop = true;
            this.normalRadioBtt.Text = "Back to Normal";
            this.normalRadioBtt.UseVisualStyleBackColor = true;
            this.normalRadioBtt.CheckedChanged += new System.EventHandler(this.normalRadioBtt_CheckedChanged);
            // 
            // whiteRadioBtt
            // 
            this.whiteRadioBtt.AutoSize = true;
            this.whiteRadioBtt.Location = new System.Drawing.Point(39, 126);
            this.whiteRadioBtt.Name = "whiteRadioBtt";
            this.whiteRadioBtt.Size = new System.Drawing.Size(63, 23);
            this.whiteRadioBtt.TabIndex = 2;
            this.whiteRadioBtt.Text = "White";
            this.whiteRadioBtt.UseVisualStyleBackColor = true;
            this.whiteRadioBtt.CheckedChanged += new System.EventHandler(this.whiteRadioBtt_CheckedChanged);
            // 
            // redRadioBtt
            // 
            this.redRadioBtt.AutoSize = true;
            this.redRadioBtt.Location = new System.Drawing.Point(39, 79);
            this.redRadioBtt.Name = "redRadioBtt";
            this.redRadioBtt.Size = new System.Drawing.Size(50, 23);
            this.redRadioBtt.TabIndex = 1;
            this.redRadioBtt.Text = "Red";
            this.redRadioBtt.UseVisualStyleBackColor = true;
            this.redRadioBtt.CheckedChanged += new System.EventHandler(this.redRadioBtt_CheckedChanged);
            // 
            // yellowRadioBtt
            // 
            this.yellowRadioBtt.AutoSize = true;
            this.yellowRadioBtt.Location = new System.Drawing.Point(39, 32);
            this.yellowRadioBtt.Name = "yellowRadioBtt";
            this.yellowRadioBtt.Size = new System.Drawing.Size(65, 23);
            this.yellowRadioBtt.TabIndex = 0;
            this.yellowRadioBtt.Text = "Yellow";
            this.yellowRadioBtt.UseVisualStyleBackColor = true;
            this.yellowRadioBtt.CheckedChanged += new System.EventHandler(this.yellowRadioBtt_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(95, 236);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ColorTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 265);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorTheme";
            this.Text = "ColorTheme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button exit;
        private Button exitButton;
        private RadioButton normalRadioBtt;
        private RadioButton whiteRadioBtt;
        private RadioButton redRadioBtt;
        private RadioButton yellowRadioBtt;
    }
}