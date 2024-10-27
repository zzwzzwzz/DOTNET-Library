# DOTNET Library


# Introduction

The DOTNET Library is a library management system built using .NET Windows Forms, aimed at managing books, users, and library activities. The purpose of this project is to simulate a simple, user-friendly digital library system that could replace traditional paper-based ones, aiming to save time and reduce errors for admins, librarians, and students. The primary goal of the system is to simplify book and user management in a library setting, creating a positive user experience across three different roles: Admins, Students, and Librarians.

### Admins
Admins can manage all users in the system. They can add new users by role (Librarian and Student), delete users, and view a list of all users, allowing easy control over system access.

### Librarians
Librarians manage books in the library. They can add new books to the library's collection, delete books that are no longer needed, and view all books and their availability.

### Students
Students can use the system to borrow and return books. They can view available books, borrow and return them, and check their borrowing history to keep track of previously borrowed books.

---

# Usage Instructions

Our library management system is designed to be straightforward and user-friendly. Below is a step-by-step guide on navigating the system and performing basic functions.

### 1. Login
To start, log in to the system with a specific role. Here are the test credentials. After entering the username and password, users are directed to the main dashboard for their role, each with unique features and permissions:

- **Admin Login**: Username: `admin`, Password: `admin`
- **Librarian Login**: Username: `librarian`, Password: `librarian`
- **Student Login**: Username: `student`, Password: `student`

### 2. Admin Functions
Admins can manage users in the system, including adding and deleting users.

- **Add User**: Enter the User ID, Username, Password, and Role (either "Librarian" or "Student").
  - **User ID Requirements**:
    - Librarians' User IDs must start with "2" and have at least 4 digits (e.g., `2001`).
    - Students' User IDs must start with "3" and have at least 4 digits (e.g., `3001`).
- **Delete User**: Enter the User ID of the user that needs to be removed and confirm the action.
- **View All Users**: Click the "View All Users" button to see a list of all users.

### 3. Librarian Functions
Librarians manage the library's book collection.

- **Add New Book**: Enter details for the new book, including Book ID, Book Name, Author, and Year.
- **Delete Book**: Enter the Book ID of the book that needs to be removed and confirm.
- **View All Books**: Click the "View All Books" section to see the entire library collection.

### 4. Student Functions
Students can browse, borrow, and return books in the library.

- **View All Books**: Go to the "View All Books" section to see what’s available in the library.
- **Borrow Book**: Enter the Book ID of the book to borrow. The system will confirm if the book is available for borrowing.
- **Return Book**: Enter the Book ID of the book to return. The system will update the book's availability status.
- **Check Borrowing History**: Go to the "Borrowing History" section to view a list of books that have been borrowed.

---

# Development Approach

### Methodology
The development of the .NET Library Management System followed an agile development approach. This methodology allowed us to break down the project requirements into smaller components, which were implemented and tested incrementally, allowing for continuous improvement and early feedback.

- Focused on building the core login system and database setup using Entity Framework.
- Added book management features for librarians using LINQ.
- Developed the borrowing and returning module for students, integrated with the user interface.
- Focused on generating reports, handling error messages, and validating user input.

### Technology Stack and Frameworks

- **.NET Framework**: The application was built using .NET Windows Forms, which provides a user-friendly desktop application experience and extensive support for data manipulation.
- **Newtonsoft.Json**: This library was used for JSON serialization and deserialization, enabling easy reading and writing of data to JSON files. This was essential for handling user and book data, which is stored in JSON format instead of a database.
- **Interfaces and Polymorphism**: Using interfaces allows for flexibility and low coupling between components. The system also demonstrates polymorphism through method overloading, supporting book borrowing with varying parameters.
- **Generics and Collections**: Generic collections like `List<Book>` and `Dictionary<User, List<BorrowedBooks>>` were used to efficiently manage data such as book inventory and user borrowings.

