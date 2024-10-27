using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Library.Models;
using Library.Interfaces;

namespace Library.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        private string testBooksFilePath = "Data/test_books.json";
        private string testBorrowHistoryFilePath = "Data/test_borrowHistory.json";
        private List<Book> testBooks;
        private List<BorrowBook> testBorrowHistory;
        private TestBookRepository bookRepository;
        private TestBorrowHistoryRepository borrowHistoryRepository;

        // Test repository implementations for isolated testing
        private class TestBookRepository : IBookRepository
        {
            private List<Book> books;
            public TestBookRepository(List<Book> initialBooks) { books = initialBooks; }
            public List<Book> LoadBooks() => books;
            public void SaveBooks(List<Book> books) { this.books = books; }
        }

        private class TestBorrowHistoryRepository : IBorrowHistoryRepository
        {
            private List<BorrowBook> borrowHistory;
            public TestBorrowHistoryRepository(List<BorrowBook> initialHistory) { borrowHistory = initialHistory; }
            public List<BorrowBook> LoadBorrowHistory() => borrowHistory;
            public void SaveBorrowHistory(List<BorrowBook> history) { borrowHistory = history; }
        }

        [SetUp]
        public void Setup()
        {
            // Initialize test data
            testBooks = new List<Book>
            {
                new Book { BookID = 1, BookName = "Test Book 1", Author = "Author 1", Year = "2020", Availability = "yes" },
                new Book { BookID = 2, BookName = "Test Book 2", Author = "Author 2", Year = "2021", Availability = "no" }
            };

            testBorrowHistory = new List<BorrowBook>
            {
                new BorrowBook
                {
                    UserID = 1,
                    BookID = 2,
                    BorrowDate = DateTime.Now.AddDays(-7),
                    ReturnDate = null
                }
            };

            // Initialize repositories with test data
            bookRepository = new TestBookRepository(testBooks);
            borrowHistoryRepository = new TestBorrowHistoryRepository(testBorrowHistory);

            // Set up UserSession for testing
            UserSession.CurrentUserID = 1;

            // Ensure test directory exists
            Directory.CreateDirectory("Data");
        }

        [TearDown]
        public void Cleanup()
        {
            // Reset UserSession
            UserSession.CurrentUserID = null;
        }

        [Test]
        public void CheckBorrowHistory_ShouldReturnCorrectHistory()
        {
            // Act
            var history = borrowHistoryRepository.LoadBorrowHistory();
            var userHistory = history.Where(h => h.UserID == UserSession.CurrentUserID).ToList();

            // Assert
            Assert.That(userHistory, Has.Count.EqualTo(1));
            Assert.That(userHistory[0].BookID, Is.EqualTo(2));
            Assert.That(userHistory[0].ReturnDate, Is.Null);
        }
    }
}