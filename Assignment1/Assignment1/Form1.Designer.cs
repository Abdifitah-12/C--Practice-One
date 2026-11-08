namespace Assignment1
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
            this.dayOfWeekTxtBox = new System.Windows.Forms.TextBox();
            this.monthTxtBox = new System.Windows.Forms.TextBox();
            this.dayOfmonthTxtBox = new System.Windows.Forms.TextBox();
            this.yearTxtBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDataButton = new System.Windows.Forms.Label();
            this.ExitButtton = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayOfWeekTxtBox
            // 
            this.dayOfWeekTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayOfWeekTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekTxtBox.Location = new System.Drawing.Point(442, 18);
            this.dayOfWeekTxtBox.Multiline = true;
            this.dayOfWeekTxtBox.Name = "dayOfWeekTxtBox";
            this.dayOfWeekTxtBox.Size = new System.Drawing.Size(235, 53);
            this.dayOfWeekTxtBox.TabIndex = 0;
            this.dayOfWeekTxtBox.TextChanged += new System.EventHandler(this.dayOfWeekTxtBox_TextChanged);
            // 
            // monthTxtBox
            // 
            this.monthTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTxtBox.Location = new System.Drawing.Point(442, 86);
            this.monthTxtBox.Multiline = true;
            this.monthTxtBox.Name = "monthTxtBox";
            this.monthTxtBox.Size = new System.Drawing.Size(235, 53);
            this.monthTxtBox.TabIndex = 1;
            this.monthTxtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dayOfmonthTxtBox
            // 
            this.dayOfmonthTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayOfmonthTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfmonthTxtBox.Location = new System.Drawing.Point(442, 152);
            this.dayOfmonthTxtBox.Multiline = true;
            this.dayOfmonthTxtBox.Name = "dayOfmonthTxtBox";
            this.dayOfmonthTxtBox.Size = new System.Drawing.Size(235, 53);
            this.dayOfmonthTxtBox.TabIndex = 2;
            this.dayOfmonthTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // yearTxtBox
            // 
            this.yearTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTxtBox.Location = new System.Drawing.Point(442, 223);
            this.yearTxtBox.Multiline = true;
            this.yearTxtBox.Name = "yearTxtBox";
            this.yearTxtBox.Size = new System.Drawing.Size(235, 53);
            this.yearTxtBox.TabIndex = 3;
            // 
            // dayOfWeekPromptLabel
            // 
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(181, 36);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(215, 20);
            this.dayOfWeekPromptLabel.TabIndex = 4;
            this.dayOfWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthPromptLabel.Location = new System.Drawing.Point(156, 98);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(240, 20);
            this.monthPromptLabel.TabIndex = 5;
            this.monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayOfMonthPromptLabel
            // 
            this.dayOfMonthPromptLabel.AutoSize = true;
            this.dayOfMonthPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfMonthPromptLabel.Location = new System.Drawing.Point(104, 162);
            this.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            this.dayOfMonthPromptLabel.Size = new System.Drawing.Size(292, 20);
            this.dayOfMonthPromptLabel.TabIndex = 6;
            this.dayOfMonthPromptLabel.Text = "Enter the numeric day of the month";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearPromptLabel.Location = new System.Drawing.Point(273, 231);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(123, 20);
            this.yearPromptLabel.TabIndex = 7;
            this.yearPromptLabel.Text = "Enter the year";
            this.yearPromptLabel.Click += new System.EventHandler(this.yearPromptLabel_Click);
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutputLabel.Location = new System.Drawing.Point(25, 305);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(652, 55);
            this.dateOutputLabel.TabIndex = 8;
            // 
            // showDataButton
            // 
            this.showDataButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.showDataButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDataButton.Location = new System.Drawing.Point(37, 373);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(164, 37);
            this.showDataButton.TabIndex = 9;
            this.showDataButton.Text = "Show Date";
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // ExitButtton
            // 
            this.ExitButtton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitButtton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtton.Location = new System.Drawing.Point(512, 373);
            this.ExitButtton.Name = "ExitButtton";
            this.ExitButtton.Size = new System.Drawing.Size(165, 37);
            this.ExitButtton.TabIndex = 10;
            this.ExitButtton.Text = "Exit Button";
            this.ExitButtton.Click += new System.EventHandler(this.label1_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(273, 373);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(188, 37);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear Botton";
            this.clearButton.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 423);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ExitButtton);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Controls.Add(this.yearTxtBox);
            this.Controls.Add(this.dayOfmonthTxtBox);
            this.Controls.Add(this.monthTxtBox);
            this.Controls.Add(this.dayOfWeekTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayOfWeekTxtBox;
        private System.Windows.Forms.TextBox monthTxtBox;
        private System.Windows.Forms.TextBox dayOfmonthTxtBox;
        private System.Windows.Forms.TextBox yearTxtBox;
        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Label showDataButton;
        private System.Windows.Forms.Label ExitButtton;
        private System.Windows.Forms.Label clearButton;
    }
}

