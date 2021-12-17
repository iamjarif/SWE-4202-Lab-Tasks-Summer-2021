namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentSemesterTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentDepartTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentInfoClearButton = new System.Windows.Forms.Button();
            this.StudentInfoSaveButton = new System.Windows.Forms.Button();
            this.StudentInfoListBox = new System.Windows.Forms.ListBox();
            this.StudentInfoShowButton = new System.Windows.Forms.Button();
            this.TeachersInfoShowButton = new System.Windows.Forms.Button();
            this.TeachersInfoListBox = new System.Windows.Forms.ListBox();
            this.TeachersInfoSaveButton = new System.Windows.Forms.Button();
            this.TeachersInfoClearButton = new System.Windows.Forms.Button();
            this.TeachersDesignationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TeachersDepartTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TeachersNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TeachersIDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TeachersSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AdminSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AdminInfoShowButton = new System.Windows.Forms.Button();
            this.AdminInfoListBox = new System.Windows.Forms.ListBox();
            this.AdminInfoSaveButton = new System.Windows.Forms.Button();
            this.AdminInfoClearButton = new System.Windows.Forms.Button();
            this.AdminDesignationTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AdminNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AdminIDTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Location = new System.Drawing.Point(118, 85);
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(132, 20);
            this.StudentIDTextBox.TabIndex = 2;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Location = new System.Drawing.Point(118, 111);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(132, 20);
            this.StudentNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StudentSemesterTextBox
            // 
            this.StudentSemesterTextBox.Location = new System.Drawing.Point(118, 137);
            this.StudentSemesterTextBox.Name = "StudentSemesterTextBox";
            this.StudentSemesterTextBox.Size = new System.Drawing.Size(132, 20);
            this.StudentSemesterTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Semester:";
            // 
            // StudentDepartTextBox
            // 
            this.StudentDepartTextBox.Location = new System.Drawing.Point(118, 163);
            this.StudentDepartTextBox.Name = "StudentDepartTextBox";
            this.StudentDepartTextBox.Size = new System.Drawing.Size(132, 20);
            this.StudentDepartTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Department:";
            // 
            // StudentInfoClearButton
            // 
            this.StudentInfoClearButton.Location = new System.Drawing.Point(50, 212);
            this.StudentInfoClearButton.Name = "StudentInfoClearButton";
            this.StudentInfoClearButton.Size = new System.Drawing.Size(75, 23);
            this.StudentInfoClearButton.TabIndex = 9;
            this.StudentInfoClearButton.Text = "Clear";
            this.StudentInfoClearButton.UseVisualStyleBackColor = true;
            this.StudentInfoClearButton.Click += new System.EventHandler(this.StudentInfoClearButton_Click);
            // 
            // StudentInfoSaveButton
            // 
            this.StudentInfoSaveButton.Location = new System.Drawing.Point(175, 212);
            this.StudentInfoSaveButton.Name = "StudentInfoSaveButton";
            this.StudentInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.StudentInfoSaveButton.TabIndex = 10;
            this.StudentInfoSaveButton.Text = "Save";
            this.StudentInfoSaveButton.UseVisualStyleBackColor = true;
            this.StudentInfoSaveButton.Click += new System.EventHandler(this.StudentInfoSaveButton_Click);
            // 
            // StudentInfoListBox
            // 
            this.StudentInfoListBox.FormattingEnabled = true;
            this.StudentInfoListBox.Location = new System.Drawing.Point(350, 85);
            this.StudentInfoListBox.Name = "StudentInfoListBox";
            this.StudentInfoListBox.Size = new System.Drawing.Size(191, 95);
            this.StudentInfoListBox.TabIndex = 11;
            // 
            // StudentInfoShowButton
            // 
            this.StudentInfoShowButton.Location = new System.Drawing.Point(409, 212);
            this.StudentInfoShowButton.Name = "StudentInfoShowButton";
            this.StudentInfoShowButton.Size = new System.Drawing.Size(75, 23);
            this.StudentInfoShowButton.TabIndex = 12;
            this.StudentInfoShowButton.Text = "Show Info";
            this.StudentInfoShowButton.UseVisualStyleBackColor = true;
            this.StudentInfoShowButton.Click += new System.EventHandler(this.StudentInfoShowButton_Click);
            // 
            // TeachersInfoShowButton
            // 
            this.TeachersInfoShowButton.Location = new System.Drawing.Point(409, 462);
            this.TeachersInfoShowButton.Name = "TeachersInfoShowButton";
            this.TeachersInfoShowButton.Size = new System.Drawing.Size(75, 23);
            this.TeachersInfoShowButton.TabIndex = 25;
            this.TeachersInfoShowButton.Text = "Show Info";
            this.TeachersInfoShowButton.UseVisualStyleBackColor = true;
            this.TeachersInfoShowButton.Click += new System.EventHandler(this.TeachersInfoShowButton_Click);
            // 
            // TeachersInfoListBox
            // 
            this.TeachersInfoListBox.FormattingEnabled = true;
            this.TeachersInfoListBox.Location = new System.Drawing.Point(350, 314);
            this.TeachersInfoListBox.Name = "TeachersInfoListBox";
            this.TeachersInfoListBox.Size = new System.Drawing.Size(191, 95);
            this.TeachersInfoListBox.TabIndex = 24;
            // 
            // TeachersInfoSaveButton
            // 
            this.TeachersInfoSaveButton.Location = new System.Drawing.Point(175, 462);
            this.TeachersInfoSaveButton.Name = "TeachersInfoSaveButton";
            this.TeachersInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.TeachersInfoSaveButton.TabIndex = 23;
            this.TeachersInfoSaveButton.Text = "Save";
            this.TeachersInfoSaveButton.UseVisualStyleBackColor = true;
            this.TeachersInfoSaveButton.Click += new System.EventHandler(this.TeachersInfoSaveButton_Click);
            // 
            // TeachersInfoClearButton
            // 
            this.TeachersInfoClearButton.Location = new System.Drawing.Point(50, 462);
            this.TeachersInfoClearButton.Name = "TeachersInfoClearButton";
            this.TeachersInfoClearButton.Size = new System.Drawing.Size(75, 23);
            this.TeachersInfoClearButton.TabIndex = 22;
            this.TeachersInfoClearButton.Text = "Clear";
            this.TeachersInfoClearButton.UseVisualStyleBackColor = true;
            this.TeachersInfoClearButton.Click += new System.EventHandler(this.TeachersInfoClearButton_Click);
            // 
            // TeachersDesignationTextBox
            // 
            this.TeachersDesignationTextBox.Location = new System.Drawing.Point(118, 392);
            this.TeachersDesignationTextBox.Name = "TeachersDesignationTextBox";
            this.TeachersDesignationTextBox.Size = new System.Drawing.Size(132, 20);
            this.TeachersDesignationTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Department:";
            // 
            // TeachersDepartTextBox
            // 
            this.TeachersDepartTextBox.Location = new System.Drawing.Point(118, 366);
            this.TeachersDepartTextBox.Name = "TeachersDepartTextBox";
            this.TeachersDepartTextBox.Size = new System.Drawing.Size(132, 20);
            this.TeachersDepartTextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Designation:";
            // 
            // TeachersNameTextBox
            // 
            this.TeachersNameTextBox.Location = new System.Drawing.Point(118, 340);
            this.TeachersNameTextBox.Name = "TeachersNameTextBox";
            this.TeachersNameTextBox.Size = new System.Drawing.Size(132, 20);
            this.TeachersNameTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name:";
            // 
            // TeachersIDTextBox
            // 
            this.TeachersIDTextBox.Location = new System.Drawing.Point(118, 314);
            this.TeachersIDTextBox.Name = "TeachersIDTextBox";
            this.TeachersIDTextBox.Size = new System.Drawing.Size(132, 20);
            this.TeachersIDTextBox.TabIndex = 15;
            this.TeachersIDTextBox.TextChanged += new System.EventHandler(this.TeachersIDTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(41, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Teachers";
            // 
            // TeachersSalaryTextBox
            // 
            this.TeachersSalaryTextBox.Location = new System.Drawing.Point(118, 418);
            this.TeachersSalaryTextBox.Name = "TeachersSalaryTextBox";
            this.TeachersSalaryTextBox.Size = new System.Drawing.Size(132, 20);
            this.TeachersSalaryTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Salary:";
            // 
            // AdminSalaryTextBox
            // 
            this.AdminSalaryTextBox.Location = new System.Drawing.Point(118, 640);
            this.AdminSalaryTextBox.Name = "AdminSalaryTextBox";
            this.AdminSalaryTextBox.Size = new System.Drawing.Size(132, 20);
            this.AdminSalaryTextBox.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 644);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Salary:";
            // 
            // AdminInfoShowButton
            // 
            this.AdminInfoShowButton.Location = new System.Drawing.Point(409, 687);
            this.AdminInfoShowButton.Name = "AdminInfoShowButton";
            this.AdminInfoShowButton.Size = new System.Drawing.Size(75, 23);
            this.AdminInfoShowButton.TabIndex = 40;
            this.AdminInfoShowButton.Text = "Show Info";
            this.AdminInfoShowButton.UseVisualStyleBackColor = true;
            this.AdminInfoShowButton.Click += new System.EventHandler(this.AdminInfoShowButton_Click);
            // 
            // AdminInfoListBox
            // 
            this.AdminInfoListBox.FormattingEnabled = true;
            this.AdminInfoListBox.Location = new System.Drawing.Point(350, 562);
            this.AdminInfoListBox.Name = "AdminInfoListBox";
            this.AdminInfoListBox.Size = new System.Drawing.Size(191, 95);
            this.AdminInfoListBox.TabIndex = 39;
            // 
            // AdminInfoSaveButton
            // 
            this.AdminInfoSaveButton.Location = new System.Drawing.Point(175, 687);
            this.AdminInfoSaveButton.Name = "AdminInfoSaveButton";
            this.AdminInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AdminInfoSaveButton.TabIndex = 38;
            this.AdminInfoSaveButton.Text = "Save";
            this.AdminInfoSaveButton.UseVisualStyleBackColor = true;
            this.AdminInfoSaveButton.Click += new System.EventHandler(this.AdminInfoSaveButton_Click);
            // 
            // AdminInfoClearButton
            // 
            this.AdminInfoClearButton.Location = new System.Drawing.Point(50, 687);
            this.AdminInfoClearButton.Name = "AdminInfoClearButton";
            this.AdminInfoClearButton.Size = new System.Drawing.Size(75, 23);
            this.AdminInfoClearButton.TabIndex = 37;
            this.AdminInfoClearButton.Text = "Clear";
            this.AdminInfoClearButton.UseVisualStyleBackColor = true;
            this.AdminInfoClearButton.Click += new System.EventHandler(this.AdminInfoClearButton_Click);
            // 
            // AdminDesignationTextBox
            // 
            this.AdminDesignationTextBox.Location = new System.Drawing.Point(118, 614);
            this.AdminDesignationTextBox.Name = "AdminDesignationTextBox";
            this.AdminDesignationTextBox.Size = new System.Drawing.Size(132, 20);
            this.AdminDesignationTextBox.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 618);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Designation:";
            // 
            // AdminNameTextBox
            // 
            this.AdminNameTextBox.Location = new System.Drawing.Point(118, 588);
            this.AdminNameTextBox.Name = "AdminNameTextBox";
            this.AdminNameTextBox.Size = new System.Drawing.Size(132, 20);
            this.AdminNameTextBox.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 591);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Name:";
            // 
            // AdminIDTextBox
            // 
            this.AdminIDTextBox.Location = new System.Drawing.Point(118, 562);
            this.AdminIDTextBox.Name = "AdminIDTextBox";
            this.AdminIDTextBox.Size = new System.Drawing.Size(132, 20);
            this.AdminIDTextBox.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 565);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(41, 524);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Administration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 724);
            this.Controls.Add(this.AdminSalaryTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AdminInfoShowButton);
            this.Controls.Add(this.AdminInfoListBox);
            this.Controls.Add(this.AdminInfoSaveButton);
            this.Controls.Add(this.AdminInfoClearButton);
            this.Controls.Add(this.AdminDesignationTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AdminNameTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.AdminIDTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TeachersSalaryTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TeachersInfoShowButton);
            this.Controls.Add(this.TeachersInfoListBox);
            this.Controls.Add(this.TeachersInfoSaveButton);
            this.Controls.Add(this.TeachersInfoClearButton);
            this.Controls.Add(this.TeachersDesignationTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TeachersDepartTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TeachersNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TeachersIDTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StudentInfoShowButton);
            this.Controls.Add(this.StudentInfoListBox);
            this.Controls.Add(this.StudentInfoSaveButton);
            this.Controls.Add(this.StudentInfoClearButton);
            this.Controls.Add(this.StudentDepartTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentSemesterTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentSemesterTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentDepartTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StudentInfoClearButton;
        private System.Windows.Forms.Button StudentInfoSaveButton;
        private System.Windows.Forms.ListBox StudentInfoListBox;
        private System.Windows.Forms.Button StudentInfoShowButton;
        private System.Windows.Forms.Button TeachersInfoShowButton;
        private System.Windows.Forms.ListBox TeachersInfoListBox;
        private System.Windows.Forms.Button TeachersInfoSaveButton;
        private System.Windows.Forms.Button TeachersInfoClearButton;
        private System.Windows.Forms.TextBox TeachersDesignationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TeachersDepartTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TeachersNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TeachersIDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TeachersSalaryTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AdminSalaryTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AdminInfoShowButton;
        private System.Windows.Forms.ListBox AdminInfoListBox;
        private System.Windows.Forms.Button AdminInfoSaveButton;
        private System.Windows.Forms.Button AdminInfoClearButton;
        private System.Windows.Forms.TextBox AdminDesignationTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AdminNameTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox AdminIDTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

