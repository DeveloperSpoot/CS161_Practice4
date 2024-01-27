namespace CS161_Practice4.Tutorials
{
    public partial class TestAverage : Form
    {
        public TestAverage()
        {
            InitializeComponent();
        }

        private void btt_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double testAverage = ((double.Parse(txtb_Test1.Text) + double.Parse(txtb_Test2.Text) + double.Parse(txtb_Test3.Text)) / 3.0);
                lb_Average.Text = testAverage.ToString("n1");

                if(testAverage > 95)
                {
                    MessageBox.Show("Congradulations on getting 95+!");
                }

            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btt_Clear_Click(object sender, EventArgs e)
        {
            txtb_Test1.Text = "";
            txtb_Test2.Text = "";
            txtb_Test3.Text = "";
            lb_Average.Text = "";
;        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
