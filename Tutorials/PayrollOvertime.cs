namespace CS161_Practice4.Tutorials
{
    public partial class PayrollOvertime : Form
    {
        public PayrollOvertime()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal hoursWorked, hourlyPayRate, basePay, overtimeHours, overtimePay, grossPay;
            const decimal BASE_HOURS = 40m;
            const decimal OT_MULTIPLIER = 1.5m;

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursWorked > BASE_HOURS)
                {
                    basePay = hourlyPayRate * BASE_HOURS;
                    overtimeHours = hoursWorked - BASE_HOURS;
                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;
                    grossPay = basePay + overtimePay;
                } else
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }

                grossPayLabel.Text = grossPay.ToString("c");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";
            hoursWorkedTextBox.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}