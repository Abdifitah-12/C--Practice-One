namespace Assignment3
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
            this.txtboxColor = new System.Windows.Forms.TextBox();
            this.txtboxfat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkLowfat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxColor
            // 
            this.txtboxColor.Location = new System.Drawing.Point(293, 61);
            this.txtboxColor.Multiline = true;
            this.txtboxColor.Name = "txtboxColor";
            this.txtboxColor.Size = new System.Drawing.Size(310, 40);
            this.txtboxColor.TabIndex = 0;
            // 
            // txtboxfat
            // 
            this.txtboxfat.Location = new System.Drawing.Point(293, 106);
            this.txtboxfat.Multiline = true;
            this.txtboxfat.Name = "txtboxfat";
            this.txtboxfat.Size = new System.Drawing.Size(310, 40);
            this.txtboxfat.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPercentage);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkLowfat);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtboxColor);
            this.groupBox1.Controls.Add(this.txtboxfat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 485);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fat percentage Calculator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkLowfat
            // 
            this.checkLowfat.AutoSize = true;
            this.checkLowfat.Location = new System.Drawing.Point(346, 167);
            this.checkLowfat.Name = "checkLowfat";
            this.checkLowfat.Size = new System.Drawing.Size(165, 41);
            this.checkLowfat.TabIndex = 3;
            this.checkLowfat.Text = "Low Fat";
            this.checkLowfat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter num of colories";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter num of fat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Num of color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-10, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Percentage of fat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(280, 273);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(506, 63);
            this.lblNumber.TabIndex = 8;
            // 
            // lblPercentage
            // 
            this.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(280, 365);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(506, 67);
            this.lblPercentage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 565);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxColor;
        private System.Windows.Forms.TextBox txtboxfat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkLowfat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPercentage;
    }
}

