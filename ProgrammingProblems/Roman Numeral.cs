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
    public partial class Roman_Numeral : Form
    {
        public Roman_Numeral()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int inputNumber;
            if (int.TryParse(numberTextBox.Text, out inputNumber))
            {

                if(inputNumber >= 1 && inputNumber <= 10)
                {
                    switch(inputNumber)
                    {
                        case 1:
                            displayLabel.Text = "I";
                            break;

                        case 2:
                            displayLabel.Text = "II";
                            break;
                        case 3:
                            displayLabel.Text = "III";
                            break;
                        case 4:
                            displayLabel.Text = "IV";
                            break;
                        case 5:
                            displayLabel.Text = "V";
                            break;
                        case 6:
                            displayLabel.Text = "VI";
                            break;
                        case 7:
                            displayLabel.Text = "VII";
                            break;
                        case 8:
                            displayLabel.Text = "VIII";
                            break;
                        case 9:
                            displayLabel.Text = "IX";
                            break;
                        case 10:
                            displayLabel.Text = "X";
                            break;
                    }
                }else
                {
                    MessageBox.Show("Please input a valid number from 1 to 10.");

                }

            }
            else
            {
                MessageBox.Show("Please input a valid number from 1 to 10.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
