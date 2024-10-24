using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            //// Add the Librarian Menu Bar to the form
            //var menuStrip = LibrarianMenuBar.CreateMenu(this);
            //this.MainMenuStrip = menuStrip; // Set the main menu for the form
            //this.Controls.Add(menuStrip);   // Add it to the form controls
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Open the Check All Books form
            LibrarianCheckBook checkBooksForm = new();
            checkBooksForm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Open the Add New Book form
            LibrarianAddbook addBookForm = new();
            addBookForm.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Open the Delete Book form
            LibrarianDeleteBook deleteBookForm = new();
            deleteBookForm.ShowDialog();
        }

        // Sign out button click event handler
        private void Button3_Click(object sender, EventArgs e)
        {
            SignOut signOut = new();

            // Use the SignOutUser method, passing the current Admin form
            signOut.SignOutUser(this);
        }
    }
}
