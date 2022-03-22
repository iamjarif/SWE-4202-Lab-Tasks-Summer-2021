namespace IUT_Result_System
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idsearchbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.attendancelabel = new System.Windows.Forms.Label();
            this.quiz1label = new System.Windows.Forms.Label();
            this.quiz2label = new System.Windows.Forms.Label();
            this.quiz3label = new System.Windows.Forms.Label();
            this.quiz4label = new System.Windows.Forms.Label();
            this.midlabel = new System.Windows.Forms.Label();
            this.finallabel = new System.Windows.Forms.Label();
            this.Vivalabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.percentagelabel = new System.Windows.Forms.Label();
            this.gradelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(285, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(551, 42);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "IUT Result Processing System";
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.ItemHeight = 16;
            this.StudentListBox.Location = new System.Drawing.Point(60, 178);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(435, 388);
            this.StudentListBox.TabIndex = 1;
            this.StudentListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Name: Object Oriented Concept 1";
            // 
            // idsearchbox
            // 
            this.idsearchbox.Location = new System.Drawing.Point(584, 178);
            this.idsearchbox.Name = "idsearchbox";
            this.idsearchbox.Size = new System.Drawing.Size(261, 22);
            this.idsearchbox.TabIndex = 3;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(873, 174);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(166, 31);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.Text = "Search by ID";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // attendancelabel
            // 
            this.attendancelabel.AutoSize = true;
            this.attendancelabel.Location = new System.Drawing.Point(581, 226);
            this.attendancelabel.Name = "attendancelabel";
            this.attendancelabel.Size = new System.Drawing.Size(78, 16);
            this.attendancelabel.TabIndex = 5;
            this.attendancelabel.Text = "Attendance:";
            // 
            // quiz1label
            // 
            this.quiz1label.AutoSize = true;
            this.quiz1label.Location = new System.Drawing.Point(581, 258);
            this.quiz1label.Name = "quiz1label";
            this.quiz1label.Size = new System.Drawing.Size(43, 16);
            this.quiz1label.TabIndex = 6;
            this.quiz1label.Text = "Quiz1:";
            // 
            // quiz2label
            // 
            this.quiz2label.AutoSize = true;
            this.quiz2label.Location = new System.Drawing.Point(581, 286);
            this.quiz2label.Name = "quiz2label";
            this.quiz2label.Size = new System.Drawing.Size(43, 16);
            this.quiz2label.TabIndex = 7;
            this.quiz2label.Text = "Quiz2:";
            // 
            // quiz3label
            // 
            this.quiz3label.AutoSize = true;
            this.quiz3label.Location = new System.Drawing.Point(581, 315);
            this.quiz3label.Name = "quiz3label";
            this.quiz3label.Size = new System.Drawing.Size(43, 16);
            this.quiz3label.TabIndex = 9;
            this.quiz3label.Text = "Quiz3:";
            // 
            // quiz4label
            // 
            this.quiz4label.AutoSize = true;
            this.quiz4label.Location = new System.Drawing.Point(581, 342);
            this.quiz4label.Name = "quiz4label";
            this.quiz4label.Size = new System.Drawing.Size(43, 16);
            this.quiz4label.TabIndex = 10;
            this.quiz4label.Text = "Quiz4:";
            // 
            // midlabel
            // 
            this.midlabel.AutoSize = true;
            this.midlabel.Location = new System.Drawing.Point(581, 371);
            this.midlabel.Name = "midlabel";
            this.midlabel.Size = new System.Drawing.Size(32, 16);
            this.midlabel.TabIndex = 11;
            this.midlabel.Text = "Mid:";
            // 
            // finallabel
            // 
            this.finallabel.AutoSize = true;
            this.finallabel.Location = new System.Drawing.Point(581, 398);
            this.finallabel.Name = "finallabel";
            this.finallabel.Size = new System.Drawing.Size(39, 16);
            this.finallabel.TabIndex = 12;
            this.finallabel.Text = "Final:";
            // 
            // Vivalabel
            // 
            this.Vivalabel.AutoSize = true;
            this.Vivalabel.Location = new System.Drawing.Point(581, 425);
            this.Vivalabel.Name = "Vivalabel";
            this.Vivalabel.Size = new System.Drawing.Size(37, 16);
            this.Vivalabel.TabIndex = 13;
            this.Vivalabel.Text = "Viva:";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Location = new System.Drawing.Point(581, 452);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(110, 16);
            this.totallabel.TabIndex = 14;
            this.totallabel.Text = "Total (Out of 300):";
            // 
            // percentagelabel
            // 
            this.percentagelabel.AutoSize = true;
            this.percentagelabel.Location = new System.Drawing.Point(581, 481);
            this.percentagelabel.Name = "percentagelabel";
            this.percentagelabel.Size = new System.Drawing.Size(80, 16);
            this.percentagelabel.TabIndex = 15;
            this.percentagelabel.Text = "Percentage:";
            // 
            // gradelabel
            // 
            this.gradelabel.AutoSize = true;
            this.gradelabel.Location = new System.Drawing.Point(581, 508);
            this.gradelabel.Name = "gradelabel";
            this.gradelabel.Size = new System.Drawing.Size(48, 16);
            this.gradelabel.TabIndex = 16;
            this.gradelabel.Text = "Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(870, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Developed by: 200042171";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradelabel);
            this.Controls.Add(this.percentagelabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.Vivalabel);
            this.Controls.Add(this.finallabel);
            this.Controls.Add(this.midlabel);
            this.Controls.Add(this.quiz4label);
            this.Controls.Add(this.quiz3label);
            this.Controls.Add(this.quiz2label);
            this.Controls.Add(this.quiz1label);
            this.Controls.Add(this.attendancelabel);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.idsearchbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "IUT Result Processing System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idsearchbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label attendancelabel;
        private System.Windows.Forms.Label quiz1label;
        private System.Windows.Forms.Label quiz2label;
        private System.Windows.Forms.Label quiz3label;
        private System.Windows.Forms.Label quiz4label;
        private System.Windows.Forms.Label midlabel;
        private System.Windows.Forms.Label finallabel;
        private System.Windows.Forms.Label Vivalabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label percentagelabel;
        private System.Windows.Forms.Label gradelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

