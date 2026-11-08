namespace Assignment_3Stu_INFO
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.StudentType = new System.Windows.Forms.GroupBox();
            this.radioUndergraduate = new System.Windows.Forms.RadioButton();
            this.radioPostgraduate = new System.Windows.Forms.RadioButton();
            this.Saved_Student_Info = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.StudentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentType);
            this.groupBox1.Controls.Add(this.txtMark);
            this.groupBox1.Controls.Add(this.txtDep);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentInfo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mark :";
            // 
            // txtSID
            // 
            this.txtSID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSID.Location = new System.Drawing.Point(208, 23);
            this.txtSID.Multiline = true;
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(161, 43);
            this.txtSID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(207, 74);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 52);
            this.txtName.TabIndex = 5;
            // 
            // txtDep
            // 
            this.txtDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDep.Location = new System.Drawing.Point(207, 134);
            this.txtDep.Multiline = true;
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(161, 52);
            this.txtDep.TabIndex = 6;
            this.txtDep.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMark
            // 
            this.txtMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMark.Location = new System.Drawing.Point(207, 194);
            this.txtMark.Multiline = true;
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(161, 52);
            this.txtMark.TabIndex = 7;
            // 
            // StudentType
            // 
            this.StudentType.Controls.Add(this.radioPostgraduate);
            this.StudentType.Controls.Add(this.radioUndergraduate);
            this.StudentType.Location = new System.Drawing.Point(6, 253);
            this.StudentType.Name = "StudentType";
            this.StudentType.Size = new System.Drawing.Size(369, 132);
            this.StudentType.TabIndex = 8;
            this.StudentType.TabStop = false;
            this.StudentType.Text = "StudentType";
            // 
            // radioUndergraduate
            // 
            this.radioUndergraduate.AutoSize = true;
            this.radioUndergraduate.Location = new System.Drawing.Point(38, 46);
            this.radioUndergraduate.Name = "radioUndergraduate";
            this.radioUndergraduate.Size = new System.Drawing.Size(212, 33);
            this.radioUndergraduate.TabIndex = 0;
            this.radioUndergraduate.TabStop = true;
            this.radioUndergraduate.Text = "Undergraduate";
            this.radioUndergraduate.UseVisualStyleBackColor = true;
            // 
            // radioPostgraduate
            // 
            this.radioPostgraduate.AutoSize = true;
            this.radioPostgraduate.Location = new System.Drawing.Point(38, 85);
            this.radioPostgraduate.Name = "radioPostgraduate";
            this.radioPostgraduate.Size = new System.Drawing.Size(193, 33);
            this.radioPostgraduate.TabIndex = 1;
            this.radioPostgraduate.TabStop = true;
            this.radioPostgraduate.Text = "Postgraduate";
            this.radioPostgraduate.UseVisualStyleBackColor = true;
            // 
            // Saved_Student_Info
            // 
            this.Saved_Student_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saved_Student_Info.FormattingEnabled = true;
            this.Saved_Student_Info.ItemHeight = 32;
            this.Saved_Student_Info.Location = new System.Drawing.Point(453, 46);
            this.Saved_Student_Info.Name = "Saved_Student_Info";
            this.Saved_Student_Info.Size = new System.Drawing.Size(335, 356);
            this.Saved_Student_Info.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(56, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 52);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.AutoSize = true;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(256, 430);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(232, 52);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read From File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(494, 430);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 52);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(237, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(232, 52);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Saved_Student_Info);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StudentType.ResumeLayout(false);
            this.StudentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox StudentType;
        private System.Windows.Forms.RadioButton radioPostgraduate;
        private System.Windows.Forms.RadioButton radioUndergraduate;
        private System.Windows.Forms.ListBox Saved_Student_Info;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

