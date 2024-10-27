using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Text.Json;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library
{
    public partial class StudentBorrowBook : Form, IBookRepository, IBorrowHistoryRepository
    {
        private static string booksFilePath = "Data/books.json";
        private static string borrowHistoryFilePath = "Data/borrowHistory.json";
        public StudentBorrowBook()
        {
            InitializeComponent();

            // Check if user is logged in using user session
            if (UserSession.CurrentUserID == null)
            {
                MessageBox.Show("User not logged in. Please login first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Add the Student Menu Bar to the form
            var menuStrip = StudentMenuBar.CreateMenu(this);
            this.MainMenuStrip = menuStrip; // Set the main menu for the form
            this.Controls.Add(menuStrip);   // Add it to the form controls
            menuStrip.Dock = DockStyle.Top; // Ensure the MenuStrip is docked at the top
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StudentBorrowBook_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMM yyyy h:mm tt";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // after confirm button is clicked, it will borrow a book by using BookID
            BorrowBook(int.Parse(textBox1.Text));
        }

        // Overloaded BorrowBook to handle borrowing a book by BookID
        private void BorrowBook(int bookID)
        {

            if (bookID <= 0)
            {
                MessageBox.Show("Please enter a valid Book ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Book> books = LoadBooks();

            var book = books.FirstOrDefault(b => b.BookID == bookID);

            if (book == null)
            {
                MessageBox.Show("Book ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the book availability
            if (book.Availability.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("The book is currently not available.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Check if the user has already borrowed this book and do not returning it
            List<BorrowBook> history = LoadBorrowHistory();

            // using Linq and Lamda search book that alreay borrowed 
            var existingBorrow = history.FirstOrDefault(b => b.BookID == bookID && b.UserID == UserSession.CurrentUserID && b.ReturnDate == null);

            if (existingBorrow != null)
            {
                MessageBox.Show("You have already borrowed this book.", "Duplicate Borrow", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Update book availability and save
            book.Availability = "no";
            SaveBooks(books); 

            // Add a new borrow data
            history.Add(new BorrowBook
            {
                UserID = UserSession.CurrentUserID.Value,
                BookID = bookID,
                BorrowDate = DateTime.Now,
                ReturnDate = null
            });
            SaveBorrowHistory(history);

            MessageBox.Show($"Successfully borrowed '{book.BookName}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Polymorphism using method overloading
        private void BorrowBook(int bookID, DateTime borrowDate)
        {

        }

        // Method to load the list of books from JSON
        public List<Book> LoadBooks()
        {
            if (File.Exists(booksFilePath))
            {
                string jsonData = File.ReadAllText(booksFilePath);
                return JsonSerializer.Deserialize<List<Book>>(jsonData) ?? new List<Book>();
            }
            return new List<Book>();
        }

        // Save the updated to JSON file
        public void SaveBooks(List<Book> books)
        {
            string jsonData = JsonSerializer.Serialize(books);
            File.WriteAllText(booksFilePath, jsonData);
        }

        // Method to load the list of borrowed book
        public List<BorrowBook> LoadBorrowHistory()
        {
            if (File.Exists(borrowHistoryFilePath))
            {
                string jsonData = File.ReadAllText(borrowHistoryFilePath);
                return JsonSerializer.Deserialize<List<BorrowBook>>(jsonData) ?? new List<BorrowBook>();
            }
            return new List<BorrowBook>();
        }

        //Method to save the updated borrow history to JSON file
        public void SaveBorrowHistory(List<BorrowBook> history)
        {
            string jsonData = JsonSerializer.Serialize(history, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(borrowHistoryFilePath, jsonData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
