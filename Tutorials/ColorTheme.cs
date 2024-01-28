namespace CS161_Practice4.Tutorials
{
    public partial class ColorTheme : Form
    {
        public ColorTheme()
        {
            InitializeComponent();
        }

        private void yellowRadioBtt_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioBtt.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void redRadioBtt_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioBtt.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void whiteRadioBtt_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteRadioBtt.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void normalRadioBtt_CheckedChanged(object sender, EventArgs e)
        {
            if (normalRadioBtt.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
