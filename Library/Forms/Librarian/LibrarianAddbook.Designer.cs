namespace Library
{
    partial class LibrarianAddbook
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            allBooksToolStripMenuItem = new ToolStripMenuItem();
            sIGNOUTToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(26, 26);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, allBooksToolStripMenuItem, sIGNOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(928, 38);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(131, 34);
            menuToolStripMenuItem.Text = "Dashboard";
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(124, 34);
            borrowToolStripMenuItem.Text = "All Books";
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(131, 34);
            returnToolStripMenuItem.Text = "Add Book";
            // 
            // allBooksToolStripMenuItem
            // 
            allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            allBooksToolStripMenuItem.Size = new Size(151, 34);
            allBooksToolStripMenuItem.Text = "Delete Book";
            // 
            // sIGNOUTToolStripMenuItem
            // 
            sIGNOUTToolStripMenuItem.Name = "sIGNOUTToolStripMenuItem";
            sIGNOUTToolStripMenuItem.Size = new Size(120, 34);
            sIGNOUTToolStripMenuItem.Text = "Sign Out";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(491, 450);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(169, 59);
            button2.TabIndex = 44;
            button2.Text = "Back";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(269, 450);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(169, 59);
            button4.TabIndex = 43;
            button4.Text = "Confirm";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(422, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 32);
            textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 32);
            textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(422, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 32);
            textBox1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label1.Location = new Point(269, 379);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 38;
            label1.Text = "Detail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label6.Location = new Point(269, 319);
            label6.Name = "label6";
            label6.Size = new Size(80, 30);
            label6.TabIndex = 37;
            label6.Text = "Author";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label7.Location = new Point(269, 259);
            label7.Name = "label7";
            label7.Size = new Size(125, 30);
            label7.TabIndex = 36;
            label7.Text = "Book Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label8.Location = new Point(269, 199);
            label8.Name = "label8";
            label8.Size = new Size(97, 30);
            label8.TabIndex = 35;
            label8.Text = "Book ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(252, 92);
            label9.Name = "label9";
            label9.Size = new Size(432, 54);
            label9.TabIndex = 34;
            label9.Text = "Librarian Add New Book";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(422, 379);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 32);
            textBox4.TabIndex = 45;
            // 
            // LibrarianAddbook
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(menuStrip1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LibrarianAddbook";
            Text = "Librarian Add New Book";
            Load += LibrarianAddbook_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem allBooksToolStripMenuItem;
        private ToolStripMenuItem sIGNOUTToolStripMenuItem;
        private Button button2;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
    }
}