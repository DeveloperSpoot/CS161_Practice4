namespace CS161_Practice4.Tutorials
{
    public partial class FuelEcon : Form
    {
        public FuelEcon()
        {
            InitializeComponent();
        }

        private void btt_MPG_Click(object sender, EventArgs e)
        {
            double miles, gallons, mpg;

            if(!double.TryParse(txtb_Miles.Text, out miles)) {MessageBox.Show("Invalid input for miles.");  return; }
            if (!double.TryParse(txtb_Gas.Text, out gallons)) { MessageBox.Show("Invalid input for gas."); return; }

           mpg = miles / gallons;
            
            lb_MPG.Text = mpg.ToString("n1");
        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
