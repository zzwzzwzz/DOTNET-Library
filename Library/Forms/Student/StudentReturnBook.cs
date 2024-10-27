using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class StudentReturnBook : Form
    {
        private static string booksFilePath = "Data/books.json";
        private static string borrowHistoryFilePath = "Data/borrowHistory.json";
        public StudentReturnBook()
        {
            InitializeComponent();

            // Check if user is logged in user session
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

        private void StudentReturnBook_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMM yyyy h:mm tt";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // check if user input is integer
            if (!int.TryParse(textBox1.Text, out int bookID))
            {
                MessageBox.Show("Please enter a valid Book ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user has an unreturned of the book
            List<BorrowBook> history = LoadBorrowHistory();

            // search for book that current user does not return yet
            var borrowEntry = history.FirstOrDefault(h => h.BookID == bookID && h.UserID == UserSession.CurrentUserID && h.ReturnDate == null);

            if (borrowEntry == null)
            {
                MessageBox.Show("You did not borrow this book or it has already been returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the return date and save the updated history
            borrowEntry.ReturnDate = dateTimePicker1.Value;
            SaveBorrowHistory(history);

            // Update book availability
            List<Book> books = LoadBooks();
            var book = books.FirstOrDefault(b => b.BookID == bookID);
            if (book != null)
            {
                book.Availability = "yes";
                SaveBooks(books);
            }

            MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close(); 
        }

        // Method to load the list of books from JSON
        private List<Book> LoadBooks()
        {
            if (File.Exists(booksFilePath))
            {
                string jsonData = File.ReadAllText(booksFilePath);
                return JsonSerializer.Deserialize<List<Book>>(jsonData) ?? new List<Book>();
            }
            return new List<Book>();
        }

        // Save the updated to JSON file

        private void SaveBooks(List<Book> books)
        {
            string jsonData = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(booksFilePath, jsonData);
        }

        // Method to load the list of borrowed book
        private List<BorrowBook> LoadBorrowHistory()
        {
            if (File.Exists(borrowHistoryFilePath))
            {
                string jsonData = File.ReadAllText(borrowHistoryFilePath);
                return JsonSerializer.Deserialize<List<BorrowBook>>(jsonData) ?? new List<BorrowBook>();
            }
            return new List<BorrowBook>();
        }

        //Method to save the updated borrow history to JSON file
        private void SaveBorrowHistory(List<BorrowBook> history)
        {
            string jsonData = JsonSerializer.Serialize(history, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(borrowHistoryFilePath, jsonData);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
        }
    }
}
