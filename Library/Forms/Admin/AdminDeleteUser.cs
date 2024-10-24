using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;  // Use LINQ methods like FirstOrDefault and Any
using System.Windows.Forms;
using Library.Models;  // Import the User class from Models namespace

namespace Library
{
    public partial class AdminDeleteUser : Form
    {
        private string jsonFilePath;

        public string JsonFilePath { get => jsonFilePath; set => jsonFilePath = value; }

        public AdminDeleteUser()
        {
            InitializeComponent();

            // Set the path to the users.json file
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            jsonFilePath = Path.Combine(baseDirectory, "Data", "users.json");

            // Add the Admin Menu Bar to the form
            var menuStrip = AdminMenuBar.CreateMenu(this);
            this.MainMenuStrip = menuStrip; // Set the main menu for the form
            this.Controls.Add(menuStrip); // Add it to the form controls
            menuStrip.Dock = DockStyle.Top; // Ensure the MenuStrip is docked at the top
        }

        // This method is triggered when the form loads
        private void AdminDeleteUser_Load(object sender, EventArgs e)
        {

        }

        // Confirm Button Click, deletes user by ID
        private void Button4_Click(object sender, EventArgs e)
        {
            // Get the user ID entered by the admin
            string userId = textBox1.Text.Trim();

            // Check if user ID is entered
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter a User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to delete the user by the entered ID
            try
            {
                bool isDeleted = DeleteUserById(userId);

                if (isDeleted)
                {
                    MessageBox.Show($"User with ID {userId} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear(); // Clear the input after success
                }
                else
                {
                    MessageBox.Show($"No user found with ID {userId}.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back Button Click and return to the previous form
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        // Method to delete a user by ID from the JSON file
        private bool DeleteUserById(string userId)
        {
            // Read the existing JSON data
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                var usersList = JsonConvert.DeserializeObject<List<User>>(json) ?? [];

                // Check if the user exists in the list
                var userToDelete = usersList.FirstOrDefault(u => u.UserID.ToString() == userId);
                if (userToDelete != null)
                {
                    // Remove the user from the list
                    usersList.Remove(userToDelete);

                    // Write the updated list back to the JSON file
                    string updatedJson = JsonConvert.SerializeObject(usersList, Formatting.Indented);
                    File.WriteAllText(jsonFilePath, updatedJson);

                    return true; // User was successfully deleted
                }
            }
            return false; // No user found with the given ID
        }
    }
}
