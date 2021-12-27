using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LMS lms = new LMS();
        

        int ShirtAmount = 0;
        int PantsAmount = 0;
        int SuitsAmount = 0;
        int BedSheetAmount = 0;
        


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTextBox.Text;
            int UserID = Convert.ToInt32(UserIDTextBox.Text);
            string UserAdress = UserAddressTextBox.Text;
            
            
            
                    User dummy = new User(UserID, UserName, UserAdress);
                    lms.Users.Add(dummy);
                    MessageBox.Show("User has been added!");
                  
               
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(UserIDTextBox2.Text);
            int ShirtsNum;
            string ShirtType;
            int PantsNum;
            string PantType;
            int SuitsNum;
            string SuitsType;
            int BedSheetsNum;
            string BedSheetType;
            int SpecificUserAmount = 0;
            bool found = false;
            
            
            if(ShirtTextBox.Text == "" && shirttype.Text == "")
            {
                ShirtAmount = 0;
                ShirtsNum = 0;
                ShirtType = "No Shirts";

            }
            else
            {
                if (shirttype.Text == "Both")
                {
                    ShirtsNum = Convert.ToInt32(ShirtTextBox.Text);
                    ShirtType = shirttype.Text;
                    ShirtAmount = 10;
                }
                else
                {
                    ShirtsNum = Convert.ToInt32(ShirtTextBox.Text);
                    ShirtType = shirttype.Text;
                    ShirtAmount = 5;
                }
            }

            if (PantsTextBox.Text == "" && comboBox3.Text == "")
            {

                PantsAmount = 0;
                PantsNum = 0;
                PantType = "No Pants";


            }
            else
            {
                if (comboBox3.Text == "Both")
                {
                    PantsNum = Convert.ToInt32(PantsTextBox.Text);
                    PantsAmount = 10;
                    PantType = comboBox3.Text;
                }
                else
                {
                    PantsNum = Convert.ToInt32(PantsTextBox.Text);
                    PantsAmount = 5;
                    PantType = comboBox3.Text;
                }
            }

            if (SuitsTextBox.Text == "" && comboBox4.Text == "")
            {
                SuitsAmount = 0;
                SuitsNum = 0;
                SuitsType = "No Suits";


            }
            else
            {
                if (comboBox4.Text == "Both")
                {
                    SuitsNum = Convert.ToInt32(SuitsTextBox.Text);
                    SuitsAmount = 10;
                    SuitsType = comboBox4.Text;
                }
                else
                {
                    SuitsNum = Convert.ToInt32(SuitsTextBox.Text);
                    SuitsAmount = 5;
                    SuitsType = comboBox4.Text;
                }
            }

            if (BedSheetTextBox.Text == "" && comboBox5.Text == "")
            {
                BedSheetAmount = 0;
                BedSheetsNum = 0;
                BedSheetType = "No Bedsheets";

            }
            else
            {
                if(comboBox5.Text == "Both")
                {
                    BedSheetsNum = Convert.ToInt32(BedSheetTextBox.Text);
                    BedSheetAmount = 20;
                    BedSheetType = comboBox5.Text;
                }
                else
                {
                    BedSheetsNum = Convert.ToInt32(BedSheetTextBox.Text);
                    BedSheetAmount = 10;
                    BedSheetType = comboBox5.Text;
                }
            }

            
            foreach (User user in lms.Users)
            {
                if (UserID == user.UserID)
                {
                    found = true;
                    SpecificUserAmount += (ShirtsNum * ShirtAmount) + (PantsNum * PantsAmount) + (SuitsNum * SuitsAmount) + (BedSheetsNum * BedSheetAmount);
                    Account.orderID++;
                    Order dummy = new Order(UserID, ShirtsNum, ShirtType, PantsNum, PantType, SuitsNum, SuitsType, BedSheetsNum, BedSheetType, SpecificUserAmount, Account.orderID);
                    lms.Orders.Add(dummy);
                    
                }
            }

            if (found == false)
            {
                MessageBox.Show("User not found");
            }
            else 
            { 
                MessageBox.Show("Order Placed! Your Order Id is: " + Convert.ToString(Account.orderID) + " and pay BDT " + Convert.ToString(SpecificUserAmount)); 
            }
            
        }
 
        
        private void button1_Click(object sender, EventArgs e)
        {

            int OrderID = Convert.ToInt32(textBox1.Text);
            bool flag = false;
            bool deliver = false;
            
            foreach (Order order in lms.Orders)
            {

                if (OrderID == order.OrderID)
                {
                    flag= true;
                    
                    
                    if(order.Status == "Delivered")
                    {
                        deliver = true;
                    }
                    else
                    {
                        order.Status = comboBox1.Text;
                        
                        if (comboBox1.Text == "Delivered")
                        {

                            Account.Amount += order.SpecificUserAmount;
                            label15.Text = "Current Amount: " + Convert.ToString(Account.Amount);
                            order.Date = DatePicker.Text;


                        }
                        else
                        {
                            label15.Text = "Current Amount: " + "0";
                        }

                        MessageBox.Show("Status Updated");
                    }
                    
                }

            }
            
            if(deliver == true)
            {
                MessageBox.Show("Already Delivered");
            }

            if (flag == false)
            {
                MessageBox.Show("Order ID could not be found");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(textBox10.Text);
            int TempID = 0;
            bool flag = false;

            foreach (Order order in lms.Orders)
            {
                if (OrderID == order.OrderID)
                {
                    flag = true;
                    
                    for (int i = 0; i < lms.Orders.Count; i++)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(lms.Orders[i].getOrderList());

                    }
                    
                    label12.Text = "Amount: " + order.SpecificUserAmount;
                    label11.Text = "Status: " + order.Status;
                    label17.Text = "Delivery Date: " + order.Date;
                    TempID = order.UserID;


                    foreach(User user in lms.Users)
                    {
                        if(TempID == user.UserID)
                        {
                            label14.Text = "Name: " + user.UserName;
                            label13.Text = "Address: " + user.UserAdress;
                            
                        }
                    }
                    
                }
                

            }

            if(flag == false)
            {
                MessageBox.Show("Order ID could not be found");
            }

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
