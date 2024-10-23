namespace Library
{
    partial class StudentCheckAllBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            allBooksToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 74);
            label1.Name = "label1";
            label1.Size = new Size(447, 54);
            label1.TabIndex = 3;
            label1.Text = "Student Check All Books";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(65, 158);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(808, 379);
            listBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(26, 26);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, allBooksToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, historyToolStripMenuItem, signOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(928, 38);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(131, 34);
            menuToolStripMenuItem.Text = "Dashboard";
            // menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // allBooksToolStripMenuItem
            // 
            allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            allBooksToolStripMenuItem.Size = new Size(124, 34);
            allBooksToolStripMenuItem.Text = "All Books";
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(158, 34);
            borrowToolStripMenuItem.Text = "Borrow Book";
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(151, 34);
            returnToolStripMenuItem.Text = "Return Book";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(99, 34);
            historyToolStripMenuItem.Text = "History";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(120, 34);
            signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // StudentCheckAllBooks
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "StudentCheckAllBooks";
            Text = "StudentCheckAllBooks";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem allBooksToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
    }
}