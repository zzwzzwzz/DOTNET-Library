using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class LibrarianDeleteBook : Form
    {
        private string jsonFilePath;

        public string JsonFilePath { get => jsonFilePath; set => jsonFilePath = value; }

        public LibrarianDeleteBook()
        {
            InitializeComponent();

            // Set the path to the books.json file
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory ?? string.Empty;
            jsonFilePath = Path.Combine(baseDirectory, "Data", "books.json");
        }

        // This method is triggered when the form loads
        private void LibrarianDeleteBook_Load(object sender, EventArgs e)
        {
            // Optionally, you can add any initialization logic here
        }

        // TextBox change event (if needed)
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Add any text change validation if needed
        }

        // Confirm Button Click - Deletes book by ID
        private void Button4_Click(object sender, EventArgs e)
        {
            // Get the book ID entered by the librarian
            string bookId = textBox2.Text.Trim();

            // Check if book ID is entered
            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter a Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that the ID is a number
            if (!int.TryParse(bookId, out _))
            {
                MessageBox.Show("Please enter a valid numeric Book ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to delete the book by the entered ID
            try
            {
                bool isDeleted = DeleteBookById(bookId);

                if (isDeleted)
                {
                    MessageBox.Show($"Book with ID {bookId} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Clear(); // Clear the input after success
                }
                else
                {
                    MessageBox.Show($"No book found with ID {bookId}.", "Book Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back Button Click - Return to the previous form
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        // Method to delete a book by ID from the JSON file
        private bool DeleteBookById(string bookId)
        {
            try
            {
                // Read the existing JSON data
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    var booksList = JsonConvert.DeserializeObject<List<Book>>(json) ?? [];

                    // Check if the book exists in the list
                    var bookToDelete = booksList.FirstOrDefault(b => b.BookID.ToString() == bookId);
                    if (bookToDelete != null)
                    {
                        // Check if the book is currently borrowed
                        if (bookToDelete.Availability?.Equals("No", StringComparison.OrdinalIgnoreCase) == true)
                        {
                            MessageBox.Show("Cannot delete this book as it is currently borrowed.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        // Remove the book from the list
                        booksList.Remove(bookToDelete);

                        // Create directory if it doesn't exist
                        string? directoryPath = Path.GetDirectoryName(jsonFilePath);
                        if (directoryPath != null && !Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        // Write the updated list back to the JSON file
                        string updatedJson = JsonConvert.SerializeObject(booksList, Formatting.Indented);
                        File.WriteAllText(jsonFilePath, updatedJson);

                        return true; // Book was successfully deleted
                    }
                }
                return false; // No book found with the given ID
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing the books file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}