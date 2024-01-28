namespace CS161_Practice4.ProgrammingProblems
{
    public partial class Magic_Date : Form
    {
        public Magic_Date()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int month = (int)monthNumeric.Value;
            int day = (int)dayNumeric.Value;
            int year = (int)yearNumeric.Value;

            if(month <= 0 || day <= 0 || year <= 0) { MessageBox.Show("Values enter cannot be a negative number."); return; }
            if(month > 12) { MessageBox.Show("Please enter a valid month. (Between 1 and 12)"); return; }
            if(day > 31) { MessageBox.Show("Please enter a valid day, cannot be above day 31."); return; }
            
            if(day*month == year) { MessageBox.Show("This date is magical!"); return; } else
            {
                MessageBox.Show("This date is NOT magical.");
                return;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
