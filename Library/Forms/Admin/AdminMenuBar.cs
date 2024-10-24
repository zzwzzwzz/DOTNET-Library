using System;
using System.Drawing; // For color and font
using System.Windows.Forms;

namespace Library
{
    public class AdminMenuBar
    {
        public static MenuStrip CreateMenu(Form parentForm)
        {
            // Create a new MenuStrip
            MenuStrip menuStrip = new();

            // Create the menu items
            ToolStripMenuItem dashboardMenuItem = new("Dashboard");
            ToolStripMenuItem allUsersMenuItem = new("All Users");
            ToolStripMenuItem addUserMenuItem = new("Add User");
            ToolStripMenuItem deleteUserMenuItem = new("Delete User");
            ToolStripMenuItem signOutMenuItem = new("Sign Out");

            // Add menu items to the MenuStrip
            menuStrip.Items.AddRange(
            [
                dashboardMenuItem, allUsersMenuItem, addUserMenuItem, deleteUserMenuItem, signOutMenuItem
            ]);

            // Set styles for the MenuStrip
            menuStrip.Font = new Font("Papyrus", 9, FontStyle.Bold);  // Change the font to Papyrus
            menuStrip.BackColor = SystemColors.Control;                      // Set background color
            menuStrip.ForeColor = SystemColors.ControlText;               // Default system text color

            // Set hover effect using a custom renderer for the hover color
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomMenuRenderer());

            // Set event handlers for menu items
            dashboardMenuItem.Click += (sender, e) => OpenDashboard(parentForm);
            allUsersMenuItem.Click += (sender, e) => OpenAllUsers(parentForm);
            addUserMenuItem.Click += (sender, e) => OpenAddUser(parentForm);
            deleteUserMenuItem.Click += (sender, e) => OpenDeleteUser(parentForm);
            signOutMenuItem.Click += (sender, e) => SignOut(parentForm);

            return menuStrip;
        }

        // Event Handlers for menu item clicks
        private static void OpenDashboard(Form parentForm)
        {
            Admin adminDashboard = new();
            parentForm.Hide();
            adminDashboard.FormClosed += (s, args) => parentForm.Show();
            adminDashboard.Show();
        }

        private static void OpenAllUsers(Form parentForm)
        {
            AdminCheckAllUsers checkAllUsersForm = new();
            parentForm.Hide();
            checkAllUsersForm.FormClosed += (s, args) => parentForm.Show();
            checkAllUsersForm.Show();
        }

        private static void OpenAddUser(Form parentForm)
        {
            AdminAddNewUser addUserForm = new();
            parentForm.Hide();
            addUserForm.FormClosed += (s, args) => parentForm.Show();
            addUserForm.Show();
        }

        private static void OpenDeleteUser(Form parentForm)
        {
            AdminDeleteUser deleteUserForm = new();
            parentForm.Hide();
            deleteUserForm.FormClosed += (s, args) => parentForm.Show();
            deleteUserForm.Show();
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