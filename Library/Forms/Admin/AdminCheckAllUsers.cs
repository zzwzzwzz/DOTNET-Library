using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class AdminCheckAllUsers : Form
    {
        private readonly string jsonFilePath;

        public AdminCheckAllUsers()
        {
            InitializeComponent();

            // Set the path to the users.json file (in the Data folder)
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            jsonFilePath = Path.Combine(baseDirectory, "Data", "users.json");

            // Add the Admin Menu Bar to the form
            var menuStrip = AdminMenuBar.CreateMenu(this);
            this.MainMenuStrip = menuStrip; // Set the main menu for the form
            this.Controls.Add(menuStrip); // Add it to the form controls
            menuStrip.Dock = DockStyle.Top; // Ensure the MenuStrip is docked at the top
        }

        // This method loads when the form opens
        private void AdminCheckAllUsers_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns
            SetupDataGridView();
            // Load users into the DataGridView
            LoadUsersIntoDataGridView();
            // Ensure there are at least 12 rows
            EnsureMinimumRows(12);
        }

        // Set up the DataGridView columns
        private void SetupDataGridView()
        {
            // Clear existing columns just in case
            dataGridView1.Columns.Clear();

            // Add columns: UserID, Username, Role
            dataGridView1.Columns.Add("UserID", "User ID");
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("Role", "Role");

            // Set the width for all columns to auto-fill the grid
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Optional: Disable sorting on columns if not needed
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        // Load users from the JSON file and display them in the DataGridView
        private void LoadUsersIntoDataGridView()
        {
            try
            {
                // Read the users from the JSON file
                if (File.Exists(jsonFilePath))
                {
                    string jsonData = File.ReadAllText(jsonFilePath);
                    var users = JsonConvert.DeserializeObject<List<User>>(jsonData);

                    // Check if any users are loaded
                    if (users != null && users.Count > 0)
                    {
                        // Clear any existing rows
                        dataGridView1.Rows.Clear();

                        // Display each user's info in the DataGridView
                        foreach (var user in users)
                        {
                            // Add user info to the DataGridView
                            dataGridView1.Rows.Add(user.UserID, user.Username, user.Role);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No users found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Users file not found!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ensure there are at least 12 rows in the DataGridView
        private void EnsureMinimumRows(int minRows)
        {
            // Calculate how many empty rows need to be added
            int rowsToAdd = minRows - dataGridView1.Rows.Count;

            // Add empty rows if needed
            for (int i = 0; i < rowsToAdd; i++)
            {
                dataGridView1.Rows.Add("", "", "");
            }

            // Set the width for all columns to auto-fill the grid
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}