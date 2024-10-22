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
            dateTimePicker1 = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            allBooksToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(272, 70);
            label1.Name = "label1";
            label1.Size = new Size(438, 45);
            label1.TabIndex = 3;
            label1.Text = "Student Check All Books";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(118, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(727, 329);
            listBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(605, 503);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 32);
            dateTimePicker1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(26, 26);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, allBooksToolStripMenuItem, historyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 33);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(82, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(93, 29);
            borrowToolStripMenuItem.Text = "Borrow";
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(89, 29);
            returnToolStripMenuItem.Text = "Return";
            // 
            // allBooksToolStripMenuItem
            // 
            allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            allBooksToolStripMenuItem.Size = new Size(112, 29);
            allBooksToolStripMenuItem.Text = "All Books";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(93, 29);
            historyToolStripMenuItem.Text = "History";
            // 
            // StudentCheckAllBooks
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 573);
            Controls.Add(menuStrip1);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem allBooksToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
    }
}