using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Set password char to hide password
            textBox2.PasswordChar = '•';
        }

        // This will be triggered when the "Sign In" button is clicked
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the text entered by the user in the username and password fields
                string username = textBox1.Text.Trim(); // Trim() removes extra spaces
                string password = textBox2.Text.Trim();

                // Check if the username or password fields are empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var users = LoadUsersFromFile();

                // Check if any users were loaded from the file
                if (users.Count == 0)
                {
                    // Show an error message if no users were found in the file
                    MessageBox.Show("No users found in the database.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Find a matching user based on the entered username and password
                var user = users.Find(u =>
                    string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(u.Password, password, StringComparison.Ordinal));

                // If a user is found, open the appropriate dashboard based on their role
                if (user != null)
                {
                    Form? dashboard = null; // This will hold the form to be opened based on the role

                    // Switch based on the user's role to decide which dashboard to open
                    switch (user.Role.ToLower())
                    {
                        case "admin":
                            dashboard = new Admin();
                            break;
                        case "librarian":
                            dashboard = new Librarian();
                            break;
                        case "student":
                            dashboard = new Student();
                            break;
                    }

                    // If a matching dashboard form was created, open it and close the login form
                    if (dashboard != null)
                    {
                        dashboard.FormClosed += (s, args) => this.Close(); // Close login form when the dashboard is closed
                        dashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // If no matching user is found, show an error message
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // If an error occurs during login (e.g., file issues), show a generic error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load users from a JSON file
        private List<User> LoadUsersFromFile()
        {
            try
            {
                // Get the application's base directory
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Create the full path to the users.json file in the "Data" folder
                string filePath = Path.Combine(baseDirectory, "Data", "users.json");

                // Check if file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Users file not found at: {filePath}", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<User>();
                }

                string jsonData = File.ReadAllText(filePath);

                // Check if JSON data is empty
                if (string.IsNullOrWhiteSpace(jsonData))
                {
                    MessageBox.Show("Users file is empty!", "Data Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<User>();
                }

                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                return users ?? new List<User>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<User>();
            }
        }

        // This method can handle any initialization when the form loads
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

    // Class to represent a user object, matching the JSON structure
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}