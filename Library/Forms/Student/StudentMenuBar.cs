using System;
using System.Drawing; // For color and font
using System.Windows.Forms;

namespace Library
{
    public class StudentMenuBar
    {
        public static MenuStrip CreateMenu(Form parentForm)
        {
            // Create a new MenuStrip
            MenuStrip menuStrip = new();

            // Create the menu items
            ToolStripMenuItem dashboardMenuItem = new("Dashboard");
            ToolStripMenuItem allBooksMenuItem = new("AllBooks");
            ToolStripMenuItem borrowBookMenuItem = new("Borrow Book");
            ToolStripMenuItem returnBookMenuItem = new("Return Book");
            ToolStripMenuItem historyMenuItem = new("History");
            ToolStripMenuItem signOutMenuItem = new("Sign Out");

            // Add menu items to the MenuStrip
            menuStrip.Items.AddRange(new ToolStripItem[]
            {
                dashboardMenuItem, allBooksMenuItem, borrowBookMenuItem, returnBookMenuItem, historyMenuItem, signOutMenuItem
            });

            // Set styles for the MenuStrip
            menuStrip.Font = new Font("Papyrus", 9, FontStyle.Bold);  // Change the font to Papyrus
            menuStrip.BackColor = SystemColors.Control;               // Set background color
            menuStrip.ForeColor = SystemColors.ControlText;           // Default system text color

            // Set hover effect using a custom renderer for the hover color
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomMenuRenderer());

            // Set event handlers for menu items
            dashboardMenuItem.Click += (sender, e) => OpenDashboard(parentForm);
            allBooksMenuItem.Click += (sender, e) => OpenAllBooks(parentForm);
            borrowBookMenuItem.Click += (sender, e) => OpenBorrowBook(parentForm);
            returnBookMenuItem.Click += (sender, e) => OpenReturnBook(parentForm);
            historyMenuItem.Click += (sender, e) => OpenHistory(parentForm);
            signOutMenuItem.Click += (sender, e) => SignOut(parentForm);

            return menuStrip;
        }

        // Event Handlers for menu item clicks
        private static void OpenDashboard(Form parentForm)
        {
            Student studentDashboard = new();
            parentForm.Hide();
            studentDashboard.FormClosed += (s, args) => parentForm.Show();
            studentDashboard.Show();
        }

        private static void OpenAllBooks(Form parentForm)
        {
            StudentCheckAllBooks allBooksForm = new();
            parentForm.Hide();
            allBooksForm.FormClosed += (s, args) => parentForm.Show();
            allBooksForm.Show();
        }

        private static void OpenBorrowBook(Form parentForm)
        {
            StudentBorrowBook borrowBookForm = new();
            parentForm.Hide();
            borrowBookForm.FormClosed += (s, args) => parentForm.Show();
            borrowBookForm.Show();
        }

        private static void OpenReturnBook(Form parentForm)
        {
            StudentReturnBook returnBookForm = new();
            parentForm.Hide();
            returnBookForm.FormClosed += (s, args) => parentForm.Show();
            returnBookForm.Show();
        }

        private static void OpenHistory(Form parentForm)
        {
            StudentCheckBorrowHistory historyForm = new();
            parentForm.Hide();
            historyForm.FormClosed += (s, args) => parentForm.Show();
            historyForm.Show();
        }

        private static void SignOut(Form parentForm)
        {
            Login loginForm = new();
            parentForm.Hide();
            loginForm.FormClosed += (s, args) => parentForm.Close();
            loginForm.Show();
        }

        // Custom renderer class to change hover behavior
        private class CustomMenuRenderer : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.PapayaWhip; }  // Hover color
            }

            public override Color MenuItemBorder
            {
                get { return Color.PapayaWhip; }  // Border color when hovered
            }
        }
    }
}
