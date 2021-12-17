using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Medicine> Medicines = new List<Medicine>();
        int Balance = 0;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int MedicineID = Convert.ToInt32(MedIDTB.Text);
            string MedicineName = MedNameTB.Text;
            int MedicineQuantity = Convert.ToInt32(MedQuantityTB.Text);
            int MedicinePrice = Convert.ToInt32(MedPriceTD.Text);
            Medicine dummy = new Medicine(MedicineID, MedicineName, MedicineQuantity, MedicinePrice);
            bool flag = false;
            
            foreach(Medicine Medicine in Medicines)
            {
                if(Medicine.MedicineID == MedicineID)
                {
                    flag = true;
                    Medicine.MedicineQuantity = Medicine.MedicineQuantity + MedicineQuantity;
                }
            }
            
            if(flag == false)
            {
                Medicines.Add(dummy);
            }
            
            MessageBox.Show("Medicine Added Successfully!");

        }

        private void SellMedButton_Click(object sender, EventArgs e)
        {
            int MedicineID = Convert.ToInt32(SellMedIDTB.Text);
            int MedicineQuantity = Convert.ToInt32(SellMedQuantityTB.Text);
            int MedicinePrice = Convert.ToInt32(SellMedPriceTB.Text);
            bool flag = false;
            


            foreach (Medicine Medicine in Medicines)
            {
                if (Medicine.MedicineID == MedicineID)
                {
                    flag = true;
                    
                    if (Medicine.MedicineQuantity >= MedicineQuantity)
                    {
                        Medicine.MedicineQuantity -= MedicineQuantity;
                        Balance += (MedicineQuantity * MedicinePrice);
                        MessageBox.Show("Medicine Sold!");
                    }
                    else
                    {
                        MessageBox.Show("Stock Out!");
                    }
                     
                }
                if (flag == false)
                {
                    MessageBox.Show("Medicine could not be found!");
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(SearchMedID.Text);
            bool flag = false;
            
            foreach(Medicine Medicine in Medicines)
            {
                if(Medicine.MedicineID == id)
                {
                    flag = true;

                    medidtext.Text = Medicine.MedicineID.ToString();
                    mednametext.Text = Medicine.MedicineName;
                    medstocktext.Text = Medicine.MedicineQuantity.ToString();
                    medpricetext.Text = Medicine.MedicinePrice.ToString();

                }
            }

            if(flag == false)
            {
                MessageBox.Show("Medicine could not be found!");
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TotalBalanceText.Text = Convert.ToString(Balance);
           
            
        }

        private void AddBalanceButton_Click(object sender, EventArgs e)
        {
            Balance += Convert.ToInt32(AddBalanceTextbox.Text);
            MessageBox.Show("Successfully Added!");
        }
    }
}
