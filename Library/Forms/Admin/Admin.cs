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
        private void Button1_Click(object sender, EventArgs e)
        {
            // Open the form for checking all users
            AdminCheckAllUsers checkAllUsersForm = new();
            checkAllUsersForm.ShowDialog();
        }

        // Admin Add New User button click event handler
        private void Button2_Click(object sender, EventArgs e)
        {
            // open the form to add a new user
            AdminAddNewUser addNewUserForm = new();
            addNewUserForm.ShowDialog();
        }

        // Admin Delete User button click event handler
        private void Button3_Click(object sender, EventArgs e)
        {
            // Open the form to delete a user
            AdminDeleteUser deleteUserForm = new();
            deleteUserForm.ShowDialog();
        }

        // Sign out button click event handler
        private void Button4_Click(object sender, EventArgs e)
        {
            SignOut signOut = new();

            // Use the SignOutUser method, passing the current Admin form
            signOut.SignOutUser(this);
        }

        //// TODO Method to clear login details

        //// Method to redirect to login form
        //private void RedirectToLoginForm()
        //{
        //    MessageBox.Show("Login details have been cleared.", "Signed Out");
        //    // Hide the current Admin/Student/Librarian form
        //    this.Hide();

        //    // Open the login form
        //    Login loginForm = new();

        //    // Show the login form
        //    loginForm.Show();

        //    // Handle form closing event for the login form
        //    loginForm.FormClosed += (s, args) => this.Close();  // Close the hidden form after login form is closed
        //}
    }
}