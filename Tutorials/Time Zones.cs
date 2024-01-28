using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_Practice4.Tutorials
{
    public partial class Time_Zones : Form
    {
        public Time_Zones()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if(cityListbox.SelectedIndex != -1)
            {
                string city = cityListbox.SelectedItem.ToString();

                switch (city)
                {
                    case "Honolulu":
                        displayLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        displayLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        displayLabel.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        displayLabel.Text = "Central";
                        break;
                    case "New York":
                        displayLabel.Text = "Eastern";
                        break;
                }

            }else
            {
                MessageBox.Show("Select a city.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
