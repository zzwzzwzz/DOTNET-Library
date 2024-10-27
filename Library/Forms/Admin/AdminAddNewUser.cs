using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminAddNewUser : Form
    {
        // Path to the users.json file
        private string jsonFilePath;

        public string JsonFilePath { get => jsonFilePath; set => jsonFilePath = value; }

        public AdminAddNewUser()
        {
            InitializeComponent();

            // Set the correct path for users.json file
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; // Get the base directory
            jsonFilePath = Path.Combine(baseDirectory, "Data", "users.json"); // Combine with "Data" folder and file name

            // Add the Admin Menu Bar to the form
            var menuStrip = AdminMenuBar.CreateMenu(this);
            this.MainMenuStrip = menuStrip; // Set the main menu for the form
            this.Controls.Add(menuStrip); // Add it to the form controls
            menuStrip.Dock = DockStyle.Top; // Ensure the MenuStrip is docked at the top
        }

        private void AdminAddNewUser_Load(object sender, EventArgs e)
        {
            // Populate the role ComboBox with two options: Student and Librarian
            comboBox1.Items.Add("Librarian");
            comboBox1.Items.Add("Student");
        }

        // Confirm Button Click
        private void Button4_Click(object sender, EventArgs e)
        {
            // Get inputs from text boxes
            string userId = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();
            string? role = comboBox1.SelectedItem?.ToString(); // Get the selected role

            // Check if all input boxes are filled
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate UserID which should be at least 4 digits
            if (userId.Length < 4 || !int.TryParse(userId, out int parsedUserId))
            {
                MessageBox.Show("User ID must be at least 4 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate based on role
            if (role == "Librarian" && !userId.StartsWith('2'))
            {
                MessageBox.Show("Librarian ID must start with 2***.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (role == "Student" && !userId.StartsWith('3'))
            {
                MessageBox.Show("Student ID must start with 3***.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load the existing users from the JSON file
            List<dynamic> usersList = LoadUsersFromFile();

            // Check if the user ID already exists in the list
            bool userIdExists = usersList.Any(u => u.UserID == parsedUserId);

            if (userIdExists)
            {
                // Show an error message if the UserID is already taken
                MessageBox.Show("A user with this ID already exists. Please use a unique UserID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new user object
            var newUser = new
            {
                UserID = parsedUserId,
                Username = username,
                Password = password,
                Role = role
            };

            // Save the new user to JSON
            try
            {
                AddNewUserToJson(newUser);
                MessageBox.Show("New user added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields after successful addition
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current form and go back to the previous one
            this.Close();
        }

        // Method to load a new user to the users.json file
        private List<dynamic> LoadUsersFromFile()
        {
            List<dynamic> usersList = [];

            // Check if file exists
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                usersList = JsonConvert.DeserializeObject<List<dynamic>>(json) ?? [];
            }

            return usersList;
        }


        // Method to add a new user to the users.json file
        private void AddNewUserToJson(dynamic newUser)
        {
            List<dynamic> usersList = [];

            // Read the existing JSON data
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                usersList = JsonConvert.DeserializeObject<List<dynamic>>(json) ?? [];
            }

            // Add the new user to the list
            usersList.Add(newUser);

            // Write the updated list back to the JSON file
            string updatedJson = JsonConvert.SerializeObject(usersList, Formatting.Indented);
            File.WriteAllText(jsonFilePath, updatedJson);
        }
    }
}
