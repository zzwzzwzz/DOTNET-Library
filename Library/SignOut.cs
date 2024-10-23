using System;
using System.Windows.Forms;

namespace Library
{
    public class SignOut
    {
        // Method to clear login details
        public void ClearLoginDetails()
        {
            // TODO clear any login/session details if necessary.

            MessageBox.Show("Login details have been cleared.", "Signed Out");
        }

        // Method to redirect to the login form
        public void RedirectToLoginForm(Form currentForm)
        {
            // Hide the current form (Admin/Student/Librarian)
            currentForm.Hide();

            // Open the login form
            Login loginForm = new Login();

            // Show the login form
            loginForm.Show();

            // Handle form closing event for the login form
            loginForm.FormClosed += (s, args) => currentForm.Close();  // Close the hidden form after login form is closed
        }

        // Combined method for sign out
        public void SignOutUser(Form currentForm)
        {
            ClearLoginDetails();    // Clear login details
            RedirectToLoginForm(currentForm); // Redirect to login
        }
    }
}
