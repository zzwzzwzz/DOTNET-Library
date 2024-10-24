using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class LibrarianAddbook : Form
    {
        private string jsonFilePath;
        public string JsonFilePath { get => jsonFilePath; set => jsonFilePath = value; }

        public LibrarianAddbook()
        {
            InitializeComponent();
            // Set the correct path for books.json file
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            jsonFilePath = Path.Combine(baseDirectory ?? string.Empty, "Data", "books.json");
        }

        private void LibrarianAddbook_Load(object sender, EventArgs e)
        {
            
        }

        // Confirm Button Click
        private void button4_Click_1(object sender, EventArgs e)
        {
            // Get inputs from text boxes
            string bookId = textBox1.Text.Trim();
            string bookName = textBox2.Text.Trim();
            string author = textBox3.Text.Trim();
            string year = textBox4.Text.Trim();

            // Check if all input boxes are filled
            if (string.IsNullOrEmpty(bookId) || string.IsNullOrEmpty(bookName) ||
                string.IsNullOrEmpty(author) || string.IsNullOrEmpty(year))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate BookID
            if (!int.TryParse(bookId, out int parsedBookId))
            {
                MessageBox.Show("Book ID must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Year
            if (!int.TryParse(year, out _) || year.Length != 4)
            {
                MessageBox.Show("Year must be a valid 4-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load existing books from the JSON file
            List<Book> booksList = LoadBooksFromFile();

            // Check if the book ID already exists
            bool bookIdExists = booksList.Any(b => b.BookID == parsedBookId);
            if (bookIdExists)
            {
                MessageBox.Show("A book with this ID already exists. Please use a unique Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new book object
            var newBook = new Book
            {
                BookID = parsedBookId,
                BookName = bookName,
                Author = author,
                Year = year,
                Availability = "Yes" // Default to available
            };

            // Save the new book to JSON
            try
            {
                AddNewBookToJson(newBook);
                MessageBox.Show("New book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields after successful addition
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back Button Click
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to load books from the books.json file
        private List<Book> LoadBooksFromFile()
        {
            List<Book> booksList = new List<Book>();

            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);

                    // If the file is empty, return an empty list
                    if (string.IsNullOrWhiteSpace(json))
                    {
                        return booksList;
                    }

                    // Error handling
                    try
                    {
                        booksList = JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
                    }
                    catch (JsonReaderException ex)
                    {
                        MessageBox.Show($"Error reading books.json: {ex.Message}\nPlease check the JSON file format.",
                            "JSON Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return new List<Book>();
                    }
                }
                else
                {
                    // If file doesn't exist, create it with an empty array
                    File.WriteAllText(jsonFilePath, "[]");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing books.json: {ex.Message}",
                    "File Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return booksList;
        }

        // Method to add a new book to the books.json file
        private void AddNewBookToJson(Book newBook)
        {
            try
            {
                List<Book> booksList = LoadBooksFromFile();

                // Add the new book to the list
                booksList.Add(newBook);

                // Create directory if it doesn't exist
                string? directoryPath = Path.GetDirectoryName(jsonFilePath);
                if (directoryPath != null && !Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Write the updated list back to the JSON file
                string updatedJson = JsonConvert.SerializeObject(booksList, Formatting.Indented);
                File.WriteAllText(jsonFilePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to books.json: {ex.Message}",
                    "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Rethrow to be caught by the calling method
            }
        }
    }
}