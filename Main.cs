using CS161_Practice4.ProgrammingProblems;
using CS161_Practice4.Tutorials;

namespace CS161_Practice4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void testScoreButton_Click(object sender, EventArgs e)
        {
            TestAverage form = new TestAverage();
            form.Show();
        }

        private void payrollOvertimeButton_Click(object sender, EventArgs e)
        {
            PayrollOvertime payrollOvertime = new PayrollOvertime();
            payrollOvertime.Show();
        }

        private void loanQualiferButton_Click(object sender, EventArgs e)
        {
            LoanQualifier form = new LoanQualifier();
            form.Show();
        }

        private void fuelEconomyButton_Click(object sender, EventArgs e)
        {
            FuelEcon form = new FuelEcon();
            form.Show();
        }

        private void colorThemeButton_Click(object sender, EventArgs e)
        {
            ColorTheme form = new ColorTheme();
            form.Show();
        }

        private void timeZoneButton_Click(object sender, EventArgs e)
        {
            Time_Zones form = new Time_Zones();
            form.Show();
        }

        private void romanNumeralButton_Click(object sender, EventArgs e)
        {
            Roman_Numeral form = new Roman_Numeral();
            form.Show();
        }

        private void massWeightButton_Click(object sender, EventArgs e)
        {
            Mass_and_Weight form = new Mass_and_Weight();
            form.Show();
        }

        private void magicDateButton_Click(object sender, EventArgs e)
        {
            Magic_Date form = new Magic_Date();
            form.Show();
        }

        private void colorMixerButton_Click(object sender, EventArgs e)
        {
            Color_Mixer form = new Color_Mixer();
            form.Show();
        }

        private void distanceConverterButton_Click(object sender, EventArgs e)
        {

        }

        private void bookClubButton_Click(object sender, EventArgs e)
        {

        }
    }
}
