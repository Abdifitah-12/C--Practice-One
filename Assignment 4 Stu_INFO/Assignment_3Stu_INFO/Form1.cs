using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3Stu_INFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtSID.Text);
                double mark = double.Parse(txtMark.Text);

                if (studentID < 0 || mark < 0)
                {
                    MessageBox.Show("ID and Mark must not be negative.");
                }
                else if (txtName.Text == "" || txtDep.Text == "")
                {
                    MessageBox.Show("Please enter Name and Department.");
                }
                else if (radioUndergraduate.Checked == false &&
                         radioPostgraduate.Checked == false)
                {
                    MessageBox.Show("Please choose one Student Type.");
                }
                else
                {
                    string studentType = "";

                    if (radioUndergraduate.Checked == true)
                    {
                        studentType = "Undergraduate";
                    }
                    else
                    {
                        studentType = "Postgraduate";
                    }
                    //saved dialog
                    DialogResult result = saveFileDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        StreamWriter write;

                        write = File.CreateText(saveFileDialog1.FileName);

                        write.WriteLine("Student ID: " + studentID);
                        write.WriteLine("Student Name: " + txtName.Text);
                        write.WriteLine("Department: " + txtDep.Text);
                        write.WriteLine("Mark: " + mark);
                        write.WriteLine("Student Type: " + studentType);

                        write.Close();


                        MessageBox.Show("File Saved Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Save Cancelled.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid information.");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
        
            try
            {
                // Open the file dialog
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Create StreamReader
                    StreamReader read;

                    read = File.OpenText(openFileDialog1.FileName);

                    

                    // Read the file line by line
                    string line;

                    line = read.ReadLine();

                    while (read.EndOfStream)
                    {
                        Saved_Student_Info.Items.Add(line);

                        line = read.ReadLine();
                    }

                    

                    MessageBox.Show("File Read Successfully.");
                }
                else
                {
                    MessageBox.Show("Reading Cancelled.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to read the file.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSID.Clear();
            txtName.Clear();
            txtDep.Clear();
            txtMark.Clear();

            radioUndergraduate.Checked = false;
            radioPostgraduate.Checked = false;

            Saved_Student_Info.Items.Clear();

        }
    }
    }
   
    