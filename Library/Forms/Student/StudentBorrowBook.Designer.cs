namespace Library
{
    partial class StudentBorrowBook
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
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            allBooksToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(290, 384);
            button3.Name = "button3";
            button3.Size = new Size(389, 59);
            button3.TabIndex = 20;
            button3.Text = "Check All Books";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(301, 100);
            label1.Name = "label1";
            label1.Size = new Size(386, 45);
            label1.TabIndex = 19;
            label1.Text = "Student Borrow Book";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(441, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 32);
            textBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 232);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 17;
            label2.Text = "Book ID";
            // 
            // button2
            // 
            button2.Location = new Point(559, 306);
            button2.Name = "button2";
            button2.Size = new Size(120, 37);
            button2.TabIndex = 16;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(290, 306);
            button1.Name = "button1";
            button1.Size = new Size(120, 37);
            button1.TabIndex = 15;
            button1.Text = "Borrow";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(26, 26);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, allBooksToolStripMenuItem, historyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(969, 33);
            menuStrip1.TabIndex = 21;
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
            // StudentBorrowBook
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 580);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "StudentBorrowBook";
            Text = "StudentBorrowBook";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem allBooksToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
    }
}