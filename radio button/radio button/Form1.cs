using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radio_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)

        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring variables
            String Name, Gender;
            String Faculty = "";
            int Age, validation;

            //validation of data conversition using try parse
            if (int.TryParse(txtAge.Text, out validation))
            {
                //assigning variables to input user
                Name = txtName.Text;
                Age = int.Parse(txtAge.Text);

                //check validation age
                if (Age > 0)// true
                {
                    if (radioButtonMALE.Checked | radioButtonFEMALE.Checked)
                    {
                        Gender = "male\n";
                        listBox1.Items.Add(Gender);


                    }
                    else if (radioButtonFEMALE.Checked)
                    {
                        Gender = "Female\n";
                        listBox1.Items.Add(Gender);
                    }
                    else
                    {
                        MessageBox.Show("please select on gender");
                    }
                    if (checkBoxComputer.Checked & checkBoxIT.Checked & checkBoxBusiness.Checked)
                    {
                        Faculty += " computer\n" + "IT\n" + "Business";
                        listBox1.Items.Add(Faculty + "\n");
                    }
                    else if (checkBoxIT.Checked & checkBoxBusiness.Checked)
                    {
                        Faculty +=  "IT\n" + "Business";
                        listBox1.Items.Add(Faculty + "\n");
                    }
                    else if(checkBoxComputer.Checked & checkBoxIT.Checked)
                    {
                        Faculty += "computer\n" + "IT";
                        listBox1.Items.Add(Faculty + "\n");
                    }
                    else if (checkBoxBusiness.Checked & checkBoxComputer.Checked)
                    {
                        Faculty += "computer\n" + "Business";
                        listBox1.Items.Add(Faculty + "\n");
                    }
                    else
                    {
                        MessageBox.Show("please select one fculty");
                    }
                }
            }
            else
            {
                MessageBox.Show("Age only exept positive number");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
