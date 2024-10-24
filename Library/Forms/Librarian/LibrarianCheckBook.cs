using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    public partial class LibrarianCheckBook : Form
    {
        private readonly string jsonFilePath;

        public LibrarianCheckBook()
        {
            InitializeComponent();

            // Set the path to the books.json file in the Data folder
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory ?? string.Empty;
            jsonFilePath = Path.Combine(baseDirectory, "Data", "books.json");
        }

        // This method loads when the form opens
        private void LibrarianCheckBook_Load(object sender, EventArgs e)
        {
            // Set up the DataGridView columns
            SetupDataGridView();
            // Load books into the DataGridView
            LoadBooksIntoDataGridView();
            // Ensure there are at least 12 rows
            EnsureMinimumRows(12);
        }

        // Set up the DataGridView columns
        private void SetupDataGridView()
        {
            // Clear existing columns just in case
            dataGridView1.Columns.Clear();

            // Add columns: BookID, BookName, Author, Year, Availability
            dataGridView1.Columns.Add("BookID", "Book ID");
            dataGridView1.Columns.Add("BookName", "Book Name");
            dataGridView1.Columns.Add("Author", "Author");
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("Availability", "Availability");

            // Set the width for all columns to auto-fill the grid
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Disable sorting on columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Set specific column widths 
            dataGridView1.Columns["BookID"].Width = 80;
            dataGridView1.Columns["Year"].Width = 80;
            dataGridView1.Columns["Availability"].Width = 100;
        }

        // Load books from the JSON file and display them in the DataGridView
        private void LoadBooksIntoDataGridView()
        {
            try
            {
                // Read the books from the JSON file
                if (File.Exists(jsonFilePath))
                {
                    string jsonData = File.ReadAllText(jsonFilePath);
                    var books = JsonConvert.DeserializeObject<List<Book>>(jsonData);

                    // Check if any books are loaded
                    if (books != null && books.Count > 0)
                    {
                        // Clear any existing rows
                        dataGridView1.Rows.Clear();

                        // Display each book's info in the DataGridView
                        foreach (var book in books)
                        {
                            // Add book info to the DataGridView
                            dataGridView1.Rows.Add(
                                book.BookID,
                                book.BookName,
                                book.Author,
                                book.Year,
                                book.Availability
                            );
                        }

                        // Color coding for availability
                        ColorCodeAvailability();
                    }
                    else
                    {
                        MessageBox.Show("No books found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Books file not found!", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGridView1.Rows.Add("", "", "", "", "");
            }
        }

        // Color code the availability column
        private void ColorCodeAvailability()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Availability"].Value != null)
                {
                    string? availability = row.Cells["Availability"].Value.ToString();

                    // Check if availability is not null before calling Equals
                    if (availability != null)
                    {
                        if (availability.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                        {
                            row.Cells["Availability"].Style.BackColor = Color.YellowGreen;
                        }
                    }
                }
            }
        }
    }
}