namespace CS161_Practice4.Tutorials
{
    partial class FuelEcon
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
            label2 = new Label();
            label3 = new Label();
            btt_MPG = new Button();
            btt_Exit = new Button();
            txtb_Miles = new TextBox();
            txtb_Gas = new TextBox();
            lb_MPG = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(203, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of the miles driven:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 52);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter the gallons of gas used:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 88);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Your car's MPG:";
            // 
            // btt_MPG
            // 
            btt_MPG.Location = new Point(75, 147);
            btt_MPG.Name = "btt_MPG";
            btt_MPG.Size = new Size(75, 44);
            btt_MPG.TabIndex = 3;
            btt_MPG.Text = "Calculate MPG";
            btt_MPG.UseVisualStyleBackColor = true;
            btt_MPG.Click += btt_MPG_Click;
            // 
            // btt_Exit
            // 
            btt_Exit.BackColor = Color.RosyBrown;
            btt_Exit.Location = new Point(179, 147);
            btt_Exit.Name = "btt_Exit";
            btt_Exit.Size = new Size(75, 44);
            btt_Exit.TabIndex = 4;
            btt_Exit.Text = "Exit";
            btt_Exit.UseVisualStyleBackColor = false;
            btt_Exit.Click += btt_Exit_Click;
            // 
            // txtb_Miles
            // 
            txtb_Miles.Location = new Point(221, 10);
            txtb_Miles.Name = "txtb_Miles";
            txtb_Miles.Size = new Size(100, 23);
            txtb_Miles.TabIndex = 5;
            // 
            // txtb_Gas
            // 
            txtb_Gas.Location = new Point(221, 49);
            txtb_Gas.Name = "txtb_Gas";
            txtb_Gas.Size = new Size(100, 23);
            txtb_Gas.TabIndex = 6;
            // 
            // lb_MPG
            // 
            lb_MPG.BackColor = SystemColors.ControlLight;
            lb_MPG.BorderStyle = BorderStyle.FixedSingle;
            lb_MPG.Location = new Point(221, 87);
            lb_MPG.Name = "lb_MPG";
            lb_MPG.Size = new Size(100, 23);
            lb_MPG.TabIndex = 7;
            lb_MPG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FuelEcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 203);
            Controls.Add(lb_MPG);
            Controls.Add(txtb_Gas);
            Controls.Add(txtb_Miles);
            Controls.Add(btt_Exit);
            Controls.Add(btt_MPG);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FuelEcon";
            Text = "FuelEcon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btt_MPG;
        private Button btt_Exit;
        private TextBox txtb_Miles;
        private TextBox txtb_Gas;
        private Label lb_MPG;
    }
}