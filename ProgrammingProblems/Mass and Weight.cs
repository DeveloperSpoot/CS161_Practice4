using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_Practice4.ProgrammingProblems
{
    public partial class Mass_and_Weight : Form
    {
        public Mass_and_Weight()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = double.Parse(massTextBox.Text);
                double weight = mass * 9.8;

                if(weight > 1000.00 )
                {
                    MessageBox.Show("This object is too heavy!");
                } else if (weight < 10)
                {
                    MessageBox.Show("This object is too light!");
                }

                displayLabel.Text = $"{weight.ToString("n1")} Newtons";
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
