using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();
        List<Book> books = new List<Book>();

        private void AddUserButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDTextBox1.Text);
            string name = NameTextBox1.Text;
            string address = AddressTextBox1.Text;

            User dummy = new User(id, name, address);

            users.Add(dummy);

            MessageBox.Show("User has been added successfully!");

        }

        private void AddBookButton1_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDTextBox1.Text);
            string title = BookNameTextBox1.Text;
            string author = AuthorTextBox1.Text;
            string publisher = PublisherTextBox1.Text;
            int quantity = Convert.ToInt32(QuantityTextBox1.Text);

            if (quantity < 0)
            {
                MessageBox.Show("Quantity can not be less than zero");
                return;
            }

            Book dummy = new Book(id, title, author, publisher, quantity);

            books.Add(dummy);

            MessageBox.Show("Book has been added successfully!");

        }

        private void ShowHistoryButton1_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDTextBox3.Text);
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)
            {
                if (user.id == userID)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("User not found!");
            }
            BooksListBox.Items.Clear();
            for (int i = 0; i < dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[j].id == id_book)
                    {
                        BooksListBox.Items.Add(books[j].history());
                    }
                }
            }
        }

        private void ShowHistoryButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDTextBox2.Text);
            bool flag = false;

            foreach (Book book in books)
            {
                if (book.id == id)
                {
                    flag = true;
                    IDLabel.Text = book.id.ToString();
                    NameLabel.Text = book.title;
                    AuthorLabel.Text = book.author;
                    PublisherLabel.Text = book.publisher;
                    QuantityLabel.Text = book.quantity.ToString();

                }
            }

            if (flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }
        }

        private void ShowButton1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool userExists(int id)
        {
            foreach (User user in users)
            {
                if (user.id == id)
                {
                    return true;
                }
                
            }
            return false;
        }

        private bool bookExists(int id)
        {
            foreach (Book book in books)
            {
                if(book.id == id)
                {
                    return true;
                }
            }
            return false;
        }   

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDTextBox3.Text);
            int bookID = Convert.ToInt32(BookIDTextBox3.Text);

            if (userExists(userID) && bookExists(bookID))
            {
                foreach (Book book in books)
                {
                    if (book.id == bookID)
                    {
                        if (book.quantity < 1)
                        {
                            MessageBox.Show("No stock");
                        }
                        book.quantity -= 1;

                        foreach (User user in users)
                        {
                            if (user.id == userID)
                            {
                                user.books.Add(bookID);
                                MessageBox.Show("Book has been added.");

                            }
                        }
                        break;
                    }
                }
            }
            else
                MessageBox.Show("ID Invalid");
        }

        private void BookIDTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
