using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        // Admin Check All Users button click event handler
        private void button1_Click(object sender, EventArgs e)
        {
            // Open the form for checking all users
            AdminCheckAllUsers checkAllUsersForm = new AdminCheckAllUsers();
            checkAllUsersForm.ShowDialog();
        }

        // Admin Add New User button click event handler
        private void button2_Click(object sender, EventArgs e)
        {
            // open the form to add a new user
            AdminAddNewUser addNewUserForm = new AdminAddNewUser();
            addNewUserForm.ShowDialog();
        }


        // Admin Delete User button click event handler
        private void button3_Click(object sender, EventArgs e)
        {
            // Open the form to delete a user
            AdminDeleteUser deleteUserForm = new AdminDeleteUser();
            deleteUserForm.ShowDialog();
        }

        // Sign out button click event handler
        private void button4_Click(object sender, EventArgs e)
        {
            SignOut signOut = new SignOut();

            // Use the SignOutUser method, passing the current Admin form
            signOut.SignOutUser(this);
        }

        // Method to clear login details
        private void ClearLoginDetails()
        {
            // Need more detail

            MessageBox.Show("Login details have been cleared.", "Signed Out");
        }

        // Method to redirect to login form
        private void RedirectToLoginForm()
        {
            // Hide the current Admin/Student/Librarian form
            this.Hide();

            // Open the login form
            Login loginForm = new Login();

            // Show the login form
            loginForm.Show();

            // Handle form closing event for the login form
            loginForm.FormClosed += (s, args) => this.Close();  // Close the hidden form after login form is closed
        }


        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        //private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        //{

        //}

        //private void checkAllUserToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

    }
}