namespace Students_Grades
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
            this.Namebox = new System.Windows.Forms.Label();
            this.IDbox = new System.Windows.Forms.Label();
            this.Presentbox = new System.Windows.Forms.Label();
            this.Midbox = new System.Windows.Forms.Label();
            this.Finalbox = new System.Windows.Forms.Label();
            this.Quiz1box = new System.Windows.Forms.Label();
            this.Quiz2box = new System.Windows.Forms.Label();
            this.Quiz3box = new System.Windows.Forms.Label();
            this.Quiz4box = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.textpresent = new System.Windows.Forms.TextBox();
            this.textmid = new System.Windows.Forms.TextBox();
            this.textfinal = new System.Windows.Forms.TextBox();
            this.textquiz1 = new System.Windows.Forms.TextBox();
            this.textquiz2 = new System.Windows.Forms.TextBox();
            this.textquiz3 = new System.Windows.Forms.TextBox();
            this.textquiz4 = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Obtainedmarks = new System.Windows.Forms.Label();
            this.Attendancefinal = new System.Windows.Forms.Label();
            this.Midfinal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quizfinal = new System.Windows.Forms.Label();
            this.Finalfinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Totalfinal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Gradetotal = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Namebox
            // 
            this.Namebox.AutoSize = true;
            this.Namebox.Location = new System.Drawing.Point(135, 226);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(35, 13);
            this.Namebox.TabIndex = 0;
            this.Namebox.Text = "Name";
            this.Namebox.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDbox
            // 
            this.IDbox.AutoSize = true;
            this.IDbox.Location = new System.Drawing.Point(134, 251);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(58, 13);
            this.IDbox.TabIndex = 1;
            this.IDbox.Text = "Student ID";
            // 
            // Presentbox
            // 
            this.Presentbox.AutoSize = true;
            this.Presentbox.Location = new System.Drawing.Point(133, 384);
            this.Presentbox.Name = "Presentbox";
            this.Presentbox.Size = new System.Drawing.Size(192, 13);
            this.Presentbox.TabIndex = 2;
            this.Presentbox.Text = "Number of attended classes (Out of 28)";
            // 
            // Midbox
            // 
            this.Midbox.AutoSize = true;
            this.Midbox.Location = new System.Drawing.Point(133, 411);
            this.Midbox.Name = "Midbox";
            this.Midbox.Size = new System.Drawing.Size(109, 13);
            this.Midbox.TabIndex = 3;
            this.Midbox.Text = "Mid Marks (Out of 75)";
            // 
            // Finalbox
            // 
            this.Finalbox.AutoSize = true;
            this.Finalbox.Location = new System.Drawing.Point(133, 436);
            this.Finalbox.Name = "Finalbox";
            this.Finalbox.Size = new System.Drawing.Size(120, 13);
            this.Finalbox.TabIndex = 4;
            this.Finalbox.Text = "Final Marks (Out of 150)";
            // 
            // Quiz1box
            // 
            this.Quiz1box.AutoSize = true;
            this.Quiz1box.Location = new System.Drawing.Point(475, 381);
            this.Quiz1box.Name = "Quiz1box";
            this.Quiz1box.Size = new System.Drawing.Size(125, 13);
            this.Quiz1box.TabIndex = 5;
            this.Quiz1box.Text = "Quiz 1 Marks  (Out of 15)";
            this.Quiz1box.Click += new System.EventHandler(this.label6_Click);
            // 
            // Quiz2box
            // 
            this.Quiz2box.AutoSize = true;
            this.Quiz2box.Location = new System.Drawing.Point(475, 406);
            this.Quiz2box.Name = "Quiz2box";
            this.Quiz2box.Size = new System.Drawing.Size(125, 13);
            this.Quiz2box.TabIndex = 6;
            this.Quiz2box.Text = "Quiz 2 Marks  (Out of 15)";
            // 
            // Quiz3box
            // 
            this.Quiz3box.AutoSize = true;
            this.Quiz3box.Location = new System.Drawing.Point(475, 431);
            this.Quiz3box.Name = "Quiz3box";
            this.Quiz3box.Size = new System.Drawing.Size(125, 13);
            this.Quiz3box.TabIndex = 7;
            this.Quiz3box.Text = "Quiz 3 Marks  (Out of 15)";
            // 
            // Quiz4box
            // 
            this.Quiz4box.AutoSize = true;
            this.Quiz4box.Location = new System.Drawing.Point(475, 455);
            this.Quiz4box.Name = "Quiz4box";
            this.Quiz4box.Size = new System.Drawing.Size(125, 13);
            this.Quiz4box.TabIndex = 8;
            this.Quiz4box.Text = "Quiz 4 Marks  (Out of 15)";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(390, 222);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 9;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(390, 247);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 10;
            // 
            // textpresent
            // 
            this.textpresent.Location = new System.Drawing.Point(342, 381);
            this.textpresent.Name = "textpresent";
            this.textpresent.Size = new System.Drawing.Size(100, 20);
            this.textpresent.TabIndex = 11;
            // 
            // textmid
            // 
            this.textmid.Location = new System.Drawing.Point(342, 407);
            this.textmid.Name = "textmid";
            this.textmid.Size = new System.Drawing.Size(100, 20);
            this.textmid.TabIndex = 12;
            // 
            // textfinal
            // 
            this.textfinal.Location = new System.Drawing.Point(342, 433);
            this.textfinal.Name = "textfinal";
            this.textfinal.Size = new System.Drawing.Size(100, 20);
            this.textfinal.TabIndex = 13;
            // 
            // textquiz1
            // 
            this.textquiz1.Location = new System.Drawing.Point(625, 377);
            this.textquiz1.Name = "textquiz1";
            this.textquiz1.Size = new System.Drawing.Size(100, 20);
            this.textquiz1.TabIndex = 14;
            // 
            // textquiz2
            // 
            this.textquiz2.Location = new System.Drawing.Point(625, 403);
            this.textquiz2.Name = "textquiz2";
            this.textquiz2.Size = new System.Drawing.Size(100, 20);
            this.textquiz2.TabIndex = 15;
            // 
            // textquiz3
            // 
            this.textquiz3.Location = new System.Drawing.Point(625, 429);
            this.textquiz3.Name = "textquiz3";
            this.textquiz3.Size = new System.Drawing.Size(100, 20);
            this.textquiz3.TabIndex = 16;
            // 
            // textquiz4
            // 
            this.textquiz4.Location = new System.Drawing.Point(625, 456);
            this.textquiz4.Name = "textquiz4";
            this.textquiz4.Size = new System.Drawing.Size(100, 20);
            this.textquiz4.TabIndex = 17;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Calculatebutton.Font = new System.Drawing.Font("Gotham Black", 16F);
            this.Calculatebutton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Calculatebutton.Location = new System.Drawing.Point(602, 206);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(123, 94);
            this.Calculatebutton.TabIndex = 18;
            this.Calculatebutton.Text = "Calculate Grade";
            this.Calculatebutton.UseVisualStyleBackColor = false;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Gotham Black", 16F);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(134, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Grade Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Semester No.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Gotham Black", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(133, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Marks";
            // 
            // Obtainedmarks
            // 
            this.Obtainedmarks.AutoSize = true;
            this.Obtainedmarks.Font = new System.Drawing.Font("Gotham Black", 16F);
            this.Obtainedmarks.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Obtainedmarks.Location = new System.Drawing.Point(899, 196);
            this.Obtainedmarks.Name = "Obtainedmarks";
            this.Obtainedmarks.Size = new System.Drawing.Size(185, 24);
            this.Obtainedmarks.TabIndex = 23;
            this.Obtainedmarks.Text = "Obtained Marks";
            // 
            // Attendancefinal
            // 
            this.Attendancefinal.AutoSize = true;
            this.Attendancefinal.Location = new System.Drawing.Point(1002, 246);
            this.Attendancefinal.Name = "Attendancefinal";
            this.Attendancefinal.Size = new System.Drawing.Size(0, 13);
            this.Attendancefinal.TabIndex = 24;
            // 
            // Midfinal
            // 
            this.Midfinal.AutoSize = true;
            this.Midfinal.Location = new System.Drawing.Point(1002, 274);
            this.Midfinal.Name = "Midfinal";
            this.Midfinal.Size = new System.Drawing.Size(0, 13);
            this.Midfinal.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(903, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Attendance:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mid:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(937, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quiz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(936, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Final:";
            // 
            // Quizfinal
            // 
            this.Quizfinal.AutoSize = true;
            this.Quizfinal.Location = new System.Drawing.Point(1002, 297);
            this.Quizfinal.Name = "Quizfinal";
            this.Quizfinal.Size = new System.Drawing.Size(0, 13);
            this.Quizfinal.TabIndex = 30;
            // 
            // Finalfinal
            // 
            this.Finalfinal.AutoSize = true;
            this.Finalfinal.Location = new System.Drawing.Point(1002, 324);
            this.Finalfinal.Name = "Finalfinal";
            this.Finalfinal.Size = new System.Drawing.Size(0, 13);
            this.Finalfinal.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gotham Black", 8.25F);
            this.label7.Location = new System.Drawing.Point(931, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "Total:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Totalfinal
            // 
            this.Totalfinal.AutoSize = true;
            this.Totalfinal.Location = new System.Drawing.Point(1002, 363);
            this.Totalfinal.Name = "Totalfinal";
            this.Totalfinal.Size = new System.Drawing.Size(0, 13);
            this.Totalfinal.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gotham Black", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(909, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Grade:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Gradetotal
            // 
            this.Gradetotal.AutoSize = true;
            this.Gradetotal.Font = new System.Drawing.Font("Gotham Black", 12F);
            this.Gradetotal.ForeColor = System.Drawing.Color.Red;
            this.Gradetotal.Location = new System.Drawing.Point(1002, 411);
            this.Gradetotal.Name = "Gradetotal";
            this.Gradetotal.Size = new System.Drawing.Size(0, 18);
            this.Gradetotal.TabIndex = 35;
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("Gotham", 9F);
            this.Comment.Location = new System.Drawing.Point(909, 463);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(0, 13);
            this.Comment.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(900, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "---------------------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 815);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Gradetotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Totalfinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Finalfinal);
            this.Controls.Add(this.Quizfinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Midfinal);
            this.Controls.Add(this.Attendancefinal);
            this.Controls.Add(this.Obtainedmarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.textquiz4);
            this.Controls.Add(this.textquiz3);
            this.Controls.Add(this.textquiz2);
            this.Controls.Add(this.textquiz1);
            this.Controls.Add(this.textfinal);
            this.Controls.Add(this.textmid);
            this.Controls.Add(this.textpresent);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.Quiz4box);
            this.Controls.Add(this.Quiz3box);
            this.Controls.Add(this.Quiz2box);
            this.Controls.Add(this.Quiz1box);
            this.Controls.Add(this.Finalbox);
            this.Controls.Add(this.Midbox);
            this.Controls.Add(this.Presentbox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.Namebox);
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namebox;
        private System.Windows.Forms.Label IDbox;
        private System.Windows.Forms.Label Presentbox;
        private System.Windows.Forms.Label Midbox;
        private System.Windows.Forms.Label Finalbox;
        private System.Windows.Forms.Label Quiz1box;
        private System.Windows.Forms.Label Quiz2box;
        private System.Windows.Forms.Label Quiz3box;
        private System.Windows.Forms.Label Quiz4box;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textpresent;
        private System.Windows.Forms.TextBox textmid;
        private System.Windows.Forms.TextBox textfinal;
        private System.Windows.Forms.TextBox textquiz1;
        private System.Windows.Forms.TextBox textquiz2;
        private System.Windows.Forms.TextBox textquiz3;
        private System.Windows.Forms.TextBox textquiz4;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Obtainedmarks;
        private System.Windows.Forms.Label Attendancefinal;
        private System.Windows.Forms.Label Midfinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Quizfinal;
        private System.Windows.Forms.Label Finalfinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Totalfinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Gradetotal;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Label label8;
    }
}

