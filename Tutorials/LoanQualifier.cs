namespace CS161_Practice4.Tutorials
{
    public partial class LoanQualifier : Form
    {
        public LoanQualifier()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MINIMUM_SALARY = 40000m;
            const decimal MINIMUM_YEARS_ON_JOB = 2m;

            try
            {

                decimal salary = decimal.Parse(salaryTextBox.Text);
                int yearsOnJob = int.Parse(yearsTextBox.Text);

                if (salary >= MINIMUM_SALARY)
                {

                    if(yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        decisionLabel.Text = "You qualify for the loan.";
                    }else
                    {
                        decisionLabel.Text = "Minimum years at current job not met.";
                    }

                }else
                {
                    decisionLabel.Text = "Minimum salary requirement not met.";
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}