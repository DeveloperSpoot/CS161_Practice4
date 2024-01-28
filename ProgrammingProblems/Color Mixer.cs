namespace CS161_Practice4.ProgrammingProblems
{
    public partial class Color_Mixer : Form
    {
        public Color_Mixer()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            bool red1 = red1RadioBtt.Checked;
            bool red2 = red2RadioBtt.Checked;
            bool blue1 = blue1RadioBtt.Checked;
            bool blue2 = blue2RadioBtt.Checked;
            bool yellow1 = yellow1RadioBtt.Checked;
            bool yellow2 = yellow2RadioBtt.Checked;

            if(red1 && red2) { this.BackColor = Color.Red; }
            if(blue1 && blue2) { this.BackColor = Color.Blue; }
            if(yellow1 && yellow2) { this.BackColor = Color.Yellow; }

            if((red1 || red2) && (blue1 || blue2))
            {
                this.BackColor = Color.Purple;
            }

            if((red1 || red2) && (yellow1 || yellow2))
            {
                this.BackColor = Color.Orange;
            }

            if((blue1 || blue2) && (yellow1 || yellow2))
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
