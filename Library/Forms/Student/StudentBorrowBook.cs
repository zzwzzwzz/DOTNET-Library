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
    public partial class StudentBorrowBook : Form
    {
        public StudentBorrowBook()
        {
            InitializeComponent();

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

        }
    }
}
