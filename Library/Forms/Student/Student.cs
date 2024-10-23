using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
        }

        // Check All Books button
        private void button2_Click(object sender, EventArgs e)
        {
            // Open the Check All Books form
            StudentCheckAllBooks checkAllBooksForm = new StudentCheckAllBooks();
            checkAllBooksForm.ShowDialog();  // Show as a modal dialog
        }

        // Borrow Book button
        private void button4_Click(object sender, EventArgs e)
        {
            // Open the Borrow Book form
            StudentBorrowBook borrowBookForm = new StudentBorrowBook();
            borrowBookForm.ShowDialog();
        }

        // Return Book button
        private void button1_Click(object sender, EventArgs e)
        {
            // Open the Return Book form
            StudentReturnBook returnBookForm = new StudentReturnBook();
            returnBookForm.ShowDialog();
        }

        // Check Borrow History button
        private void button3_Click(object sender, EventArgs e)
        {
            // Open the Check Borrow History form
            StudentCheckBorrowHistory checkBorrowHistoryForm = new StudentCheckBorrowHistory();
            checkBorrowHistoryForm.ShowDialog();
        }

        // Sign Out button
        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of the SignOut class
            SignOut signOut = new SignOut();

            // Use the SignOutUser method, passing the current form (Student form)
            signOut.SignOutUser(this);
        }
    }
}
