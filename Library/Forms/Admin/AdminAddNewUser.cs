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
        private string jsonFilePath = "users.json";

        public AdminAddNewUser()
        {
            InitializeComponent();
        }

        private void AdminAddNewUser_Load(object sender, EventArgs e)
        {
            // Populate the role ComboBox with two options: Student and Librarian
            comboBox1.Items.Add("Librarian");
            comboBox1.Items.Add("Student");
        }

        // Confirm Button Click (buttonConfirm)
        private void button4_Click(object sender, EventArgs e)
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

            // Validate UserID (should be at least 4 digits)
            if (userId.Length < 4 || !int.TryParse(userId, out int parsedUserId))
            {
                MessageBox.Show("User ID must be at least 4 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate based on role
            if (role == "Librarian" && !userId.StartsWith("2001"))
            {
                MessageBox.Show("Librarian ID must start with 2001.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (role == "Student" && !userId.StartsWith("3001"))
            {
                MessageBox.Show("Student ID must start with 3001.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Save to JSON
            try
            {
                AddNewUserToJson(newUser);
                MessageBox.Show("New user added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, clear the input fields after successful addition
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

        // Method to add a new user to the users.json file
        private void AddNewUserToJson(dynamic newUser)
        {
            List<dynamic> usersList = new List<dynamic>();

            // Read the existing JSON data
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                usersList = JsonConvert.DeserializeObject<List<dynamic>>(json) ?? new List<dynamic>();
            }

            // Add the new user to the list
            usersList.Add(newUser);

            // Write the updated list back to the JSON file
            string updatedJson = JsonConvert.SerializeObject(usersList, Formatting.Indented);
            File.WriteAllText(jsonFilePath, updatedJson);
        }
    }
}






//using System;
//using System.Collections.Generic;
//using System.IO;
//using Newtonsoft.Json;
//using System.Windows.Forms;

//namespace Library
//{
//    public partial class AdminAddNewUser : Form
//    {
//        // Path to the users.json file
//        private string jsonFilePath = "users.json";

//        public AdminAddNewUser()
//        {
//            InitializeComponent();
//        }

//        private void AdminAddNewUser_Load(object sender, EventArgs e)
//        {
//            // Populate the role ComboBox with two options: Student and Librarian
//            comboBox1.Items.Add("Librarian");
//            comboBox1.Items.Add("Student");
//        }

//        // Confirm Button Click (buttonConfirm)
//        private void button1_Click(object sender, EventArgs e)
//        {
//            // Get inputs from text boxes
//            string userId = textBox1.Text.Trim();
//            string username = textBox2.Text.Trim();
//            string password = textBox3.Text.Trim();
//            string? role = comboBox1.SelectedItem?.ToString(); // Get the selected role

//            // Check if all input boxes are filled
//            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(username) ||
//                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
//            {
//                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            // Validate UserID (should be at least 4 digits)
//            if (userId.Length < 4 || !int.TryParse(userId, out int parsedUserId))
//            {
//                MessageBox.Show("User ID must be at least 4 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            // Validate based on role
//            if (role == "Librarian" && !userId.StartsWith("2001"))
//            {
//                MessageBox.Show("Librarian ID must start with 2001.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }
//            else if (role == "Student" && !userId.StartsWith("3001"))
//            {
//                MessageBox.Show("Student ID must start with 3001.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return;
//            }

//            // Create a new user object
//            var newUser = new
//            {
//                UserID = parsedUserId,
//                Username = username,
//                Password = password,
//                Role = role
//            };

//            // Save to JSON
//            try
//            {
//                AddNewUserToJson(newUser);
//                MessageBox.Show("New user added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                // Optionally, clear the input fields after successful addition
//                textBox1.Clear();
//                textBox2.Clear();
//                textBox3.Clear();
//                comboBox1.SelectedIndex = -1;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error saving the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // Back Button Click
//        private void button4_Click(object sender, EventArgs e)
//        {
//            // Close the current form and go back to the previous one
//            this.Close();
//        }

//        // Method to add a new user to the users.json file
//        private void AddNewUserToJson(dynamic newUser)
//        {
//            List<dynamic> usersList = new List<dynamic>();

//            // Read the existing JSON data
//            if (File.Exists(jsonFilePath))
//            {
//                string json = File.ReadAllText(jsonFilePath);
//                usersList = JsonConvert.DeserializeObject<List<dynamic>>(json) ?? new List<dynamic>();
//            }

//            // Add the new user to the list
//            usersList.Add(newUser);

//            // Write the updated list back to the JSON file
//            string updatedJson = JsonConvert.SerializeObject(usersList, Formatting.Indented);
//            File.WriteAllText(jsonFilePath, updatedJson);
//        }
//    }
//}


//namespace Library
//{
//    public partial class AdminAddNewUser : Form
//    {
//        public AdminAddNewUser()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//        private void button2_Click(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        // Dropdown bar
//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void AdminAddNewUser_Load(object sender, EventArgs e)
//        {

//        }

//        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }

//        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }

//        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }

//        // Comfirm button
//        private void button4_Click(object sender, EventArgs e)
//        {

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox3_TextChanged(object sender, EventArgs e)
//        {

//        }

//        // Back button
//        private void button1_Click_1(object sender, EventArgs e)
//        {

//        }
//    }
//}
