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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var users = LoadUsersFromFile();

                // Debug: Check if users were loaded
                if (users.Count == 0)
                {
                    MessageBox.Show("No users found in the database.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = users.Find(u =>
                    string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(u.Password, password, StringComparison.Ordinal));

                if (user != null)
                {
                    Form? dashboard = null;
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

                    if (dashboard != null)
                    {
                        dashboard.FormClosed += (s, args) => this.Close();
                        dashboard.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<User> LoadUsersFromFile()
        {
            try
            {
                // Get the application's base directory
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Construct the full path to users.json
                string filePath = Path.Combine(baseDirectory, "Data", "users.json");

                // Debug: Check if file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"Users file not found at: {filePath}", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<User>();
                }

                string jsonData = File.ReadAllText(filePath);

                // Debug: Check if JSON data is empty
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
    }

    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}