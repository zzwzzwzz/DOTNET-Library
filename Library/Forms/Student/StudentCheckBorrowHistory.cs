﻿using Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class StudentCheckBorrowHistory : Form
    {
        private static string booksFilePath = "Data/books.json";
        private static string borrowHistoryFilePath = "Data/borrowHistory.json";
        public StudentCheckBorrowHistory()
        {
            InitializeComponent();

            // Add the Student Menu Bar to the form
            var menuStrip = StudentMenuBar.CreateMenu(this);
            this.MainMenuStrip = menuStrip; // Set the main menu for the form
            this.Controls.Add(menuStrip);   // Add it to the form controls
            menuStrip.Dock = DockStyle.Top; // Ensure the MenuStrip is docked at the top
        }

        private void StudentCheckBorrowHistory_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMM yyyy h:mm tt";
            dateTimePicker1.Value = DateTime.Now;

            // Initialize the DataGridView  and load borrow history data
            SetupDataGridView();
            LoadBorrowHistoryIntoDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();

            // Add columns for Book ID, Name, Author, Year, Date of Borrow, Date of Return
            dataGridView1.Columns.Add("BookID", "Book ID");
            dataGridView1.Columns.Add("BookName", "Book Name");
            dataGridView1.Columns.Add("Author", "Author");
            dataGridView1.Columns.Add("Year", "Year");
            dataGridView1.Columns.Add("DateOfBorrow", "Date of Borrow");
            dataGridView1.Columns.Add("DateOfReturn", "Date of Return");

           
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  //Set columns to auto-fit
                column.SortMode = DataGridViewColumnSortMode.NotSortable; //disable sort mode
            }

            // Hide the row headers make more space
            dataGridView1.RowHeadersVisible = false;
        }

        // Load and display user's borrow history
        private void LoadBorrowHistoryIntoDataGridView()
        {
            try
            {
                // Load books and borrow history from JSON files
                List<Book> books = LoadBooks();
                List<BorrowBook> history = LoadBorrowHistory();

                // Filter history for the current user
                var userHistory = history.Where(h => h.UserID == UserSession.CurrentUserID).ToList();

                // check each borrowing record for the user
                foreach (var entry in userHistory)
                {
                    var book = books.FirstOrDefault(b => b.BookID == entry.BookID);
                    if (book != null)
                    {
                        dataGridView1.Rows.Add(
                            book.BookID,
                            book.BookName,
                            book.Author,
                            book.Year,
                            entry.BorrowDate?.ToString("dd/MM/yyyy") ?? "N/A",
                            entry.ReturnDate?.ToString("dd/MM/yyy") ?? "Waiting"
                        );
                    }
                }
            }
            // if catch errors like file not found, Invalid JSON format and etc. show message below
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading borrow history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load the list of books from JSON
        private List<Book> LoadBooks()
        {
            if (File.Exists(booksFilePath))
            {
                string jsonData = File.ReadAllText(booksFilePath);
                return JsonConvert.DeserializeObject<List<Book>>(jsonData) ?? new List<Book>();
            }
            return new List<Book>();
        }

        // Method to load the list of borrowed book
        private List<BorrowBook> LoadBorrowHistory()
        {
            if (File.Exists(borrowHistoryFilePath))
            {
                string jsonData = File.ReadAllText(borrowHistoryFilePath);
                return JsonConvert.DeserializeObject<List<BorrowBook>>(jsonData) ?? new List<BorrowBook>();
            }
            return new List<BorrowBook>();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePicker1.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
