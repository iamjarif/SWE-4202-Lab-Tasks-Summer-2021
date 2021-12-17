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
            this.MedNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MedQuantityTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MedPriceTD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MedIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchMedID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SellMedIDTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SellMedQuantityTB = new System.Windows.Forms.TextBox();
            this.SellMedButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TotalBalanceText = new System.Windows.Forms.Label();
            this.medidtext = new System.Windows.Forms.Label();
            this.mednametext = new System.Windows.Forms.Label();
            this.medstocktext = new System.Windows.Forms.Label();
            this.medpricetext = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SellMedPriceTB = new System.Windows.Forms.TextBox();
            this.AddBalanceButton = new System.Windows.Forms.Button();
            this.AddBalanceTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MedNameTB
            // 
            this.MedNameTB.Location = new System.Drawing.Point(159, 69);
            this.MedNameTB.Name = "MedNameTB";
            this.MedNameTB.Size = new System.Drawing.Size(100, 20);
            this.MedNameTB.TabIndex = 0;
            this.MedNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medicine Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicine Quantity";
            // 
            // MedQuantityTB
            // 
            this.MedQuantityTB.Location = new System.Drawing.Point(159, 95);
            this.MedQuantityTB.Name = "MedQuantityTB";
            this.MedQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.MedQuantityTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Medicine Price Per/Pc";
            // 
            // MedPriceTD
            // 
            this.MedPriceTD.Location = new System.Drawing.Point(159, 121);
            this.MedPriceTD.Name = "MedPriceTD";
            this.MedPriceTD.Size = new System.Drawing.Size(100, 20);
            this.MedPriceTD.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MedIDTB
            // 
            this.MedIDTB.Location = new System.Drawing.Point(159, 43);
            this.MedIDTB.Name = "MedIDTB";
            this.MedIDTB.Size = new System.Drawing.Size(100, 20);
            this.MedIDTB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Medicine ID";
            // 
            // SearchMedID
            // 
            this.SearchMedID.Location = new System.Drawing.Point(338, 43);
            this.SearchMedID.Name = "SearchMedID";
            this.SearchMedID.Size = new System.Drawing.Size(100, 20);
            this.SearchMedID.TabIndex = 13;
            this.SearchMedID.Text = "Medicine ID";
            this.SearchMedID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Search Medicine";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Medicine ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Medicine Price Per/Pc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Medicine Stock (PC)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Medicine Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Medicine ID";
            // 
            // SellMedIDTB
            // 
            this.SellMedIDTB.Location = new System.Drawing.Point(159, 264);
            this.SellMedIDTB.Name = "SellMedIDTB";
            this.SellMedIDTB.Size = new System.Drawing.Size(100, 20);
            this.SellMedIDTB.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Medicine Quantity";
            // 
            // SellMedQuantityTB
            // 
            this.SellMedQuantityTB.Location = new System.Drawing.Point(159, 290);
            this.SellMedQuantityTB.Name = "SellMedQuantityTB";
            this.SellMedQuantityTB.Size = new System.Drawing.Size(100, 20);
            this.SellMedQuantityTB.TabIndex = 19;
            // 
            // SellMedButton
            // 
            this.SellMedButton.Location = new System.Drawing.Point(93, 355);
            this.SellMedButton.Name = "SellMedButton";
            this.SellMedButton.Size = new System.Drawing.Size(127, 23);
            this.SellMedButton.TabIndex = 23;
            this.SellMedButton.Text = "Sell Medicine";
            this.SellMedButton.UseVisualStyleBackColor = true;
            this.SellMedButton.Click += new System.EventHandler(this.SellMedButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(400, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Show Balance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Account Balance :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "$";
            // 
            // TotalBalanceText
            // 
            this.TotalBalanceText.AutoSize = true;
            this.TotalBalanceText.Location = new System.Drawing.Point(471, 300);
            this.TotalBalanceText.Name = "TotalBalanceText";
            this.TotalBalanceText.Size = new System.Drawing.Size(0, 13);
            this.TotalBalanceText.TabIndex = 27;
            // 
            // medidtext
            // 
            this.medidtext.AutoSize = true;
            this.medidtext.Location = new System.Drawing.Point(452, 85);
            this.medidtext.Name = "medidtext";
            this.medidtext.Size = new System.Drawing.Size(0, 13);
            this.medidtext.TabIndex = 28;
            // 
            // mednametext
            // 
            this.mednametext.AutoSize = true;
            this.mednametext.Location = new System.Drawing.Point(452, 111);
            this.mednametext.Name = "mednametext";
            this.mednametext.Size = new System.Drawing.Size(0, 13);
            this.mednametext.TabIndex = 29;
            // 
            // medstocktext
            // 
            this.medstocktext.AutoSize = true;
            this.medstocktext.Location = new System.Drawing.Point(452, 137);
            this.medstocktext.Name = "medstocktext";
            this.medstocktext.Size = new System.Drawing.Size(0, 13);
            this.medstocktext.TabIndex = 30;
            // 
            // medpricetext
            // 
            this.medpricetext.AutoSize = true;
            this.medpricetext.Location = new System.Drawing.Point(452, 163);
            this.medpricetext.Name = "medpricetext";
            this.medpricetext.Size = new System.Drawing.Size(0, 13);
            this.medpricetext.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Medicine Price Per/Pc";
            // 
            // SellMedPriceTB
            // 
            this.SellMedPriceTB.Location = new System.Drawing.Point(159, 316);
            this.SellMedPriceTB.Name = "SellMedPriceTB";
            this.SellMedPriceTB.Size = new System.Drawing.Size(100, 20);
            this.SellMedPriceTB.TabIndex = 32;
            // 
            // AddBalanceButton
            // 
            this.AddBalanceButton.Location = new System.Drawing.Point(455, 261);
            this.AddBalanceButton.Name = "AddBalanceButton";
            this.AddBalanceButton.Size = new System.Drawing.Size(112, 23);
            this.AddBalanceButton.TabIndex = 35;
            this.AddBalanceButton.Text = "Add Balance";
            this.AddBalanceButton.UseVisualStyleBackColor = true;
            this.AddBalanceButton.Click += new System.EventHandler(this.AddBalanceButton_Click);
            // 
            // AddBalanceTextbox
            // 
            this.AddBalanceTextbox.Location = new System.Drawing.Point(338, 263);
            this.AddBalanceTextbox.Name = "AddBalanceTextbox";
            this.AddBalanceTextbox.Size = new System.Drawing.Size(100, 20);
            this.AddBalanceTextbox.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBalanceButton);
            this.Controls.Add(this.AddBalanceTextbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.SellMedPriceTB);
            this.Controls.Add(this.medpricetext);
            this.Controls.Add(this.medstocktext);
            this.Controls.Add(this.mednametext);
            this.Controls.Add(this.medidtext);
            this.Controls.Add(this.TotalBalanceText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SellMedButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SellMedIDTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SellMedQuantityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchMedID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedIDTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MedPriceTD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MedQuantityTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedNameTB);
            this.Name = "Form1";
            this.Text = "Pharmacy Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MedNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MedQuantityTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MedPriceTD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MedIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchMedID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SellMedIDTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SellMedQuantityTB;
        private System.Windows.Forms.Button SellMedButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label TotalBalanceText;
        private System.Windows.Forms.Label medidtext;
        private System.Windows.Forms.Label mednametext;
        private System.Windows.Forms.Label medstocktext;
        private System.Windows.Forms.Label medpricetext;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox SellMedPriceTB;
        private System.Windows.Forms.Button AddBalanceButton;
        private System.Windows.Forms.TextBox AddBalanceTextbox;
    }
}

