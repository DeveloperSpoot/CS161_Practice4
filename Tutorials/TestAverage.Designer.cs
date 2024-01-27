namespace CS161_Practice4.Tutorials
{
    partial class TestAverage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_Test1 = new System.Windows.Forms.TextBox();
            this.txtb_Test2 = new System.Windows.Forms.TextBox();
            this.txtb_Test3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Average = new System.Windows.Forms.Label();
            this.btt_Calculate = new System.Windows.Forms.Button();
            this.btt_Clear = new System.Windows.Forms.Button();
            this.btt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test 3:";
            // 
            // txtb_Test1
            // 
            this.txtb_Test1.Location = new System.Drawing.Point(144, 15);
            this.txtb_Test1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_Test1.Name = "txtb_Test1";
            this.txtb_Test1.Size = new System.Drawing.Size(114, 26);
            this.txtb_Test1.TabIndex = 3;
            // 
            // txtb_Test2
            // 
            this.txtb_Test2.Location = new System.Drawing.Point(144, 60);
            this.txtb_Test2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_Test2.Name = "txtb_Test2";
            this.txtb_Test2.Size = new System.Drawing.Size(114, 26);
            this.txtb_Test2.TabIndex = 4;
            // 
            // txtb_Test3
            // 
            this.txtb_Test3.Location = new System.Drawing.Point(144, 104);
            this.txtb_Test3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtb_Test3.Name = "txtb_Test3";
            this.txtb_Test3.Size = new System.Drawing.Size(114, 26);
            this.txtb_Test3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average Test Score:";
            // 
            // lb_Average
            // 
            this.lb_Average.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Average.Location = new System.Drawing.Point(202, 157);
            this.lb_Average.Name = "lb_Average";
            this.lb_Average.Size = new System.Drawing.Size(141, 30);
            this.lb_Average.TabIndex = 7;
            this.lb_Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btt_Calculate
            // 
            this.btt_Calculate.Location = new System.Drawing.Point(26, 218);
            this.btt_Calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_Calculate.Name = "btt_Calculate";
            this.btt_Calculate.Size = new System.Drawing.Size(86, 29);
            this.btt_Calculate.TabIndex = 8;
            this.btt_Calculate.Text = "Calculate";
            this.btt_Calculate.UseVisualStyleBackColor = true;
            this.btt_Calculate.Click += new System.EventHandler(this.btt_Calculate_Click);
            // 
            // btt_Clear
            // 
            this.btt_Clear.Location = new System.Drawing.Point(144, 218);
            this.btt_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_Clear.Name = "btt_Clear";
            this.btt_Clear.Size = new System.Drawing.Size(86, 29);
            this.btt_Clear.TabIndex = 9;
            this.btt_Clear.Text = "Clear";
            this.btt_Clear.UseVisualStyleBackColor = true;
            this.btt_Clear.Click += new System.EventHandler(this.btt_Clear_Click);
            // 
            // btt_Exit
            // 
            this.btt_Exit.BackColor = System.Drawing.Color.RosyBrown;
            this.btt_Exit.Location = new System.Drawing.Point(261, 218);
            this.btt_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btt_Exit.Name = "btt_Exit";
            this.btt_Exit.Size = new System.Drawing.Size(86, 29);
            this.btt_Exit.TabIndex = 10;
            this.btt_Exit.Text = "Exit";
            this.btt_Exit.UseVisualStyleBackColor = false;
            this.btt_Exit.Click += new System.EventHandler(this.btt_Exit_Click);
            // 
            // TestAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 274);
            this.Controls.Add(this.btt_Exit);
            this.Controls.Add(this.btt_Clear);
            this.Controls.Add(this.btt_Calculate);
            this.Controls.Add(this.lb_Average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_Test3);
            this.Controls.Add(this.txtb_Test2);
            this.Controls.Add(this.txtb_Test1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestAverage";
            this.Text = "TestAverage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtb_Test1;
        private TextBox txtb_Test2;
        private TextBox txtb_Test3;
        private Label label4;
        private Label lb_Average;
        private Button btt_Calculate;
        private Button btt_Clear;
        private Button btt_Exit;
    }
}