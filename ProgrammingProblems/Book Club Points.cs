namespace CS161_Practice4.ProgrammingProblems
{
    public partial class Book_Club_Points : Form
    {
        public Book_Club_Points()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numberOfBooks = (int)booksNumeric.Value;

            if(numberOfBooks == 0) { displayLabel.Text = "0"; return; }
            if(numberOfBooks == 1) { displayLabel.Text = "5"; return; }
            if(numberOfBooks == 2) { displayLabel.Text = "15"; return; }
            if(numberOfBooks == 3) { displayLabel.Text = "30"; return; }
            if(numberOfBooks >= 4) { displayLabel.Text = "60"; return; }

        }
    }
}
