using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Grades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {

            var name = Convert.ToString(textname.Text);
            double present = Convert.ToDouble(textpresent.Text);
            double mid = Convert.ToDouble(textmid.Text);
            double final = Convert.ToDouble(textfinal.Text);

            double[] quiz = new double[4];
            quiz[0] = Convert.ToDouble(textquiz1.Text);
            quiz[1] = Convert.ToDouble(textquiz2.Text);
            quiz[2] = Convert.ToDouble(textquiz3.Text);
            quiz[3] = Convert.ToDouble(textquiz4.Text);

            double presentperc;
            double presentmarks;
            double total;
            double result; 

            presentperc = (present * 100) / 28;
            presentmarks = (30 * presentperc) / 100;

            Array.Sort(quiz);
            double quizmarks = quiz[1] + quiz[2] + quiz[3];


            total = final + mid + presentmarks + quizmarks;

            result = (total * 100) / 300;

            Attendancefinal.Text = presentmarks.ToString("#") + "/30";
            Midfinal.Text = mid.ToString() + "/75";
            Quizfinal.Text = quizmarks.ToString() + "/45";
            Finalfinal.Text = final.ToString() + "/150";
            Totalfinal.Text = total.ToString("#") + "/300";




            if (result >= 80 && result <= 100 )
            {
                Gradetotal.Text = "A+";
                
            }

            else if (result <= 79 && result >= 75)
            {
                Gradetotal.Text = "A";
            }

            else if (result <= 74 && result >= 70)
            {
                Gradetotal.Text = "A-";
            }

            else if (result <= 69 && result >= 65)
            {
                Gradetotal.Text = "B+";
            }

            else if (result <= 64 && result >= 60)
            {
                Gradetotal.Text = "B";
            }

            else if (result <= 59 && result >= 55)
            {
                Gradetotal.Text = "B-";
            }

            else if (result <= 54 && result >= 50)
            {
                Gradetotal.Text = "C+";
            }

            else if (result <= 49 && result >= 45)
            {
                Gradetotal.Text = "C";
            }

            else if (result <= 44 && result >= 40)
            {
                Gradetotal.Text = "D";
            }

            else 
            {
                Gradetotal.Text = "F";
            }


            Comment.Text = name + " obtained " + result.ToString("#") + "% marks.";


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
