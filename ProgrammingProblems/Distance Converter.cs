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
    public partial class Distance_Converter : Form
    {
        public Distance_Converter()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double distance = (double)distanceNumeric.Value;
                string fromSelected = (string)fromListBox.SelectedItem;
                string toSelected = (string)toListBox.SelectedItem;

                switch (fromSelected)
                {
                    case "Inches":

                        switch(toSelected)
                        {
                            case "Inches":
                                displayLabel.Text = distance.ToString("f");
                                break;

                            case "Feet":
                                displayLabel.Text = (distance / 12).ToString("f");
                                break;

                            case "Yards":
                                displayLabel.Text = (distance/36).ToString("f");
                                break;
                        }
                        break;

                    case "Feet":
                        switch (toSelected)
                        {
                            case "Inches":
                                displayLabel.Text = (distance*12).ToString("f");
                                break;

                            case "Feet":
                                displayLabel.Text = (distance).ToString("f");
                                break;

                            case "Yards":
                                displayLabel.Text = (distance/3).ToString("f");
                                break;
                        }
                        break;

                    case "Yards":
                        switch (toSelected)
                        {
                            case "Inches":
                                displayLabel.Text = (distance*36).ToString("f");
                                break;

                            case "Feet":
                                displayLabel.Text = (distance / 3).ToString("f");
                                break;

                            case "Yards":
                                displayLabel.Text = (distance * 36).ToString("f");
                                break;
                        }
                        break;
                }

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
