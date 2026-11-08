namespace radio_button
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.radioButtonMALE = new System.Windows.Forms.RadioButton();
            this.radioButtonFEMALE = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxComputer = new System.Windows.Forms.CheckBox();
            this.checkBoxIT = new System.Windows.Forms.CheckBox();
            this.checkBoxBusiness = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButtonFEMALE);
            this.groupBox1.Controls.Add(this.radioButtonMALE);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONAL INFO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter NAme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Age :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 44);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 39);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(174, 82);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(141, 39);
            this.txtAge.TabIndex = 4;
            // 
            // radioButtonMALE
            // 
            this.radioButtonMALE.AutoSize = true;
            this.radioButtonMALE.Location = new System.Drawing.Point(98, 151);
            this.radioButtonMALE.Name = "radioButtonMALE";
            this.radioButtonMALE.Size = new System.Drawing.Size(78, 24);
            this.radioButtonMALE.TabIndex = 5;
            this.radioButtonMALE.TabStop = true;
            this.radioButtonMALE.Text = "MALE";
            this.radioButtonMALE.UseVisualStyleBackColor = true;
            this.radioButtonMALE.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonFEMALE
            // 
            this.radioButtonFEMALE.AutoSize = true;
            this.radioButtonFEMALE.Location = new System.Drawing.Point(200, 151);
            this.radioButtonFEMALE.Name = "radioButtonFEMALE";
            this.radioButtonFEMALE.Size = new System.Drawing.Size(99, 24);
            this.radioButtonFEMALE.TabIndex = 6;
            this.radioButtonFEMALE.TabStop = true;
            this.radioButtonFEMALE.Text = "FEMALE";
            this.radioButtonFEMALE.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(130, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxBusiness);
            this.groupBox3.Controls.Add(this.checkBoxIT);
            this.groupBox3.Controls.Add(this.checkBoxComputer);
            this.groupBox3.Location = new System.Drawing.Point(37, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose faculty";
            // 
            // checkBoxComputer
            // 
            this.checkBoxComputer.AutoSize = true;
            this.checkBoxComputer.Location = new System.Drawing.Point(11, 48);
            this.checkBoxComputer.Name = "checkBoxComputer";
            this.checkBoxComputer.Size = new System.Drawing.Size(105, 24);
            this.checkBoxComputer.TabIndex = 2;
            this.checkBoxComputer.Text = "Computer";
            this.checkBoxComputer.UseVisualStyleBackColor = true;
            // 
            // checkBoxIT
            // 
            this.checkBoxIT.AutoSize = true;
            this.checkBoxIT.Location = new System.Drawing.Point(160, 48);
            this.checkBoxIT.Name = "checkBoxIT";
            this.checkBoxIT.Size = new System.Drawing.Size(49, 24);
            this.checkBoxIT.TabIndex = 3;
            this.checkBoxIT.Text = "IT";
            this.checkBoxIT.UseVisualStyleBackColor = true;
            this.checkBoxIT.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxBusiness
            // 
            this.checkBoxBusiness.AutoSize = true;
            this.checkBoxBusiness.Location = new System.Drawing.Point(312, 48);
            this.checkBoxBusiness.Name = "checkBoxBusiness";
            this.checkBoxBusiness.Size = new System.Drawing.Size(103, 24);
            this.checkBoxBusiness.TabIndex = 4;
            this.checkBoxBusiness.Text = "BUsiness";
            this.checkBoxBusiness.UseVisualStyleBackColor = true;
            this.checkBoxBusiness.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(48, 419);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 174);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save US";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(631, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 424);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFEMALE;
        private System.Windows.Forms.RadioButton radioButtonMALE;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxBusiness;
        private System.Windows.Forms.CheckBox checkBoxIT;
        private System.Windows.Forms.CheckBox checkBoxComputer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

