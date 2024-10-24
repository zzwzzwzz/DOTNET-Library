using System;
using System.Drawing; // For color and font
using System.Windows.Forms;

namespace Library
{
    public class LibrarianMenuBar
    {
        public static MenuStrip CreateMenu(Form parentForm)
        {
            // Create a new MenuStrip
            MenuStrip menuStrip = new();

            // Create the menu items
            ToolStripMenuItem dashboardMenuItem = new("Dashboard");
            ToolStripMenuItem allBooksMenuItem = new("All Books");
            ToolStripMenuItem addBookMenuItem = new("Add Book");
            ToolStripMenuItem deleteBookMenuItem = new("Delete Book");
            ToolStripMenuItem signOutMenuItem = new("Sign Out");

            // Add menu items to the MenuStrip
            menuStrip.Items.AddRange(new ToolStripItem[]
            {
                dashboardMenuItem, allBooksMenuItem, addBookMenuItem, deleteBookMenuItem, signOutMenuItem
            });

            // Set styles for the MenuStrip
            menuStrip.Font = new Font("Papyrus", 9, FontStyle.Bold);  // Change the font to Papyrus
            menuStrip.BackColor = SystemColors.Control;                      // Set background color
            menuStrip.ForeColor = SystemColors.ControlText;               // Default system text color

            // Set hover effect using a custom renderer for the hover color
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomMenuRenderer());

            // Set event handlers for menu items
            dashboardMenuItem.Click += (sender, e) => OpenDashboard(parentForm);
            allBooksMenuItem.Click += (sender, e) => OpenAllBooks(parentForm);
            addBookMenuItem.Click += (sender, e) => OpenAddBook(parentForm);
            deleteBookMenuItem.Click += (sender, e) => OpenDeleteBook(parentForm);
            signOutMenuItem.Click += (sender, e) => SignOut(parentForm);

            return menuStrip;
        }

        // Event Handlers for menu item clicks
        private static void OpenDashboard(Form parentForm)
        {
            Librarian librarianDashboard = new();
            parentForm.Hide();
            librarianDashboard.FormClosed += (s, args) => parentForm.Show();
            librarianDashboard.Show();
        }

        private static void OpenAllBooks(Form parentForm)
        {
            LibrarianCheckBook checkBooksForm = new();
            parentForm.Hide();
            checkBooksForm.FormClosed += (s, args) => parentForm.Show();
            checkBooksForm.Show();
        }

        private static void OpenAddBook(Form parentForm)
        {
            LibrarianAddbook addBookForm = new();  // If it's lowercase 'b'
            parentForm.Hide();
            addBookForm.FormClosed += (s, args) => parentForm.Show();
            addBookForm.Show();
        }

        private static void OpenDeleteBook(Form parentForm)
        {
            LibrarianDeleteBook deleteBookForm = new();
            parentForm.Hide();
            deleteBookForm.FormClosed += (s, args) => parentForm.Show();
            deleteBookForm.Show();
        }

        private static void SignOut(Form parentForm)
        {
            Login loginForm = new();
            parentForm.Hide();
            loginForm.FormClosed += (s, args) => parentForm.Close();
            loginForm.Show();
        }

        // Change hover behavior
        private class CustomMenuRenderer : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.PapayaWhip; }  // Hover color:
            }

            public override Color MenuItemBorder
            {
                get { return Color.PapayaWhip; }  // Border color when hovered
            }
        }
    }
}
