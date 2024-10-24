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
        private void Button2_Click(object sender, EventArgs e)
        {
            // Open the Check All Books form
            StudentCheckAllBooks checkAllBooksForm = new();
            checkAllBooksForm.ShowDialog();  // Show as a modal dialog
        }

        // Borrow Book button
        private void Button4_Click(object sender, EventArgs e)
        {
            // Open the Borrow Book form
            StudentBorrowBook borrowBookForm = new();
            borrowBookForm.ShowDialog();
        }

        // Return Book button
        private void Button1_Click(object sender, EventArgs e)
        {
            // Open the Return Book form
            StudentReturnBook returnBookForm = new();
            returnBookForm.ShowDialog();
        }

        // Check Borrow History button
        private void Button3_Click(object sender, EventArgs e)
        {
            // Open the Check Borrow History form
            StudentCheckBorrowHistory checkBorrowHistoryForm = new();
            checkBorrowHistoryForm.ShowDialog();
        }

        // Sign Out button
        private void Button5_Click(object sender, EventArgs e)
        {
            // Use the SignOutUser method, passing the current form (Student form)
            SignOut.SignOutUser(this);
        }
    }
}
