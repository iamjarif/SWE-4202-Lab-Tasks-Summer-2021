using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IUT_Result_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\User\Downloads\Final_Marksheet.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Student dummy_student = new Student(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
                    Student.studentList.Add(dummy_student);
                }
            }
            InitializeListBoxValues();
        }

        private void InitializeListBoxValues()
        {
            StudentListBox.Items.Clear();
            foreach (Student temp in Student.studentList)
            {
                StudentListBox.Items.Add(temp.getInfo());
            }
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

            foreach (Student temp in Student.studentList)
            {
                if (temp.getID() == idsearchbox.Text)
                {
                    attendancelabel.Text = "Attendance: " + temp.getAttendance();
                    quiz1label.Text = "Quiz1: " + temp.getQuiz1();
                    quiz2label.Text = "Quiz2: " + temp.getQuiz2();
                    quiz3label.Text = "Quiz3: " + temp.getQuiz3();
                    quiz4label.Text = "Quiz4: " + temp.getQuiz4();
                    midlabel.Text = "Mid: " + temp.getMid();
                    finallabel.Text = "Final: " + temp.getFinal();
                    Vivalabel.Text = "Viva: " + temp.getViva();
                    totallabel.Text = "Total(Out of 300): " + temp.getTotal();
                    percentagelabel.Text = "Percentage: " + temp.getPercentage();
                    gradelabel.Text = "Grade: " + temp.getGrades();
                }
            }
        }
    }
}
