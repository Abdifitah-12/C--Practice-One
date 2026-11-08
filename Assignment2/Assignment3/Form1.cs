using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring variable

            double calories, fatGrams;

            if (double.TryParse(txtboxColor.Text, out calories) &&
                double.TryParse(txtboxfat.Text, out fatGrams) &&
                calories > 0 && fatGrams >= 0)
            {
                double caloriesFromFat = fatGrams * 9;
                if (caloriesFromFat > calories)
                {
                    MessageBox.Show("Fat calories cannot be greater than total calories.");
                    checkLowfat.Checked = false;
                    return;
                }
                double percentage = (caloriesFromFat / calories) * 100;

                lblNumber.Text = "Calories from Fat: " + caloriesFromFat;
                lblPercentage.Text = "Percentage of Fat: " + percentage.ToString("F2") + "%";


                if (percentage < 30)
                {
                    lblNumber.Text += "\nThis food is low in fat.";
                    checkLowfat.Checked = true;
                }
                else
                {
                    lblNumber.Text += "\nThis food is not low in fat.";
                    checkLowfat.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.");
            }



        }
    }
}
