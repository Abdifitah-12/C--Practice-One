using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //clear
            dayOfWeekTxtBox.Text = " ";
            monthTxtBox.Text = string.Empty;
            dayOfmonthTxtBox.Clear();
            yearTxtBox.Clear();
            dateOutputLabel.Text = string.Empty;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            //close the form using close function
            //this.close();
            this.Close();
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            //creating variable to 
            String DayOfWeek, Month, Day, year, fullDate;

            //Assign variable to user input
            DayOfWeek = dayOfWeekTxtBox.Text;
            Month = monthTxtBox.Text;
            Day = dayOfmonthTxtBox.Text;
            year = yearTxtBox.Text;

            //process - using 
            fullDate = DayOfWeek + " | " + Month + "  " + Day + " | " + year;

            //display the output
            dateOutputLabel.Text = fullDate;






        }

        private void dayOfWeekTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
