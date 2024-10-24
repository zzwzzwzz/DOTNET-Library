namespace Library
{
    public partial class StudentCheckAllBooks : Form
    {
        public StudentCheckAllBooks()
        {
            InitializeComponent();
        }

        // Dashboard menu item
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Student Dashboard
            Student studentForm = new Student();
            studentForm.Show();
            this.Close(); // Optionally close the current form
        }

        // All Books menu item
        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open StudentCheckAllBooks form
            StudentCheckAllBooks checkAllBooksForm = new StudentCheckAllBooks();
            checkAllBooksForm.Show();
            this.Close(); // Close current form if needed
        }

        // Borrow Book menu item
        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Borrow Book form
            StudentBorrowBook borrowBookForm = new StudentBorrowBook();
            borrowBookForm.Show();
            this.Close(); // Optionally close the current form
        }

        // Return Book menu item
        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Return Book form
            StudentReturnBook returnBookForm = new StudentReturnBook();
            returnBookForm.Show();
            this.Close(); // Close the current form
        }

        // History menu item
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Borrow History form
            StudentCheckBorrowHistory checkBorrowHistoryForm = new StudentCheckBorrowHistory();
            checkBorrowHistoryForm.Show();
            this.Close(); 
        }

        // Sign Out menu item
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sign out and return to Login form
            SignOut signOut = new SignOut();
            SignOut.SignOutUser(this);
        }

        private void StudentCheckAllBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
