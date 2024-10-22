namespace Library
{
    partial class AdminCheckAllUsers
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
            listBox1 = new ListBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            allBooksToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(92, 168);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(727, 329);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(254, 80);
            label1.Name = "label1";
            label1.Size = new Size(407, 45);
            label1.TabIndex = 1;
            label1.Text = "Admin Check All Users";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(26, 26);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, allBooksToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(910, 33);
            menuStrip1.TabIndex = 23;
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
            borrowToolStripMenuItem.Size = new Size(112, 29);
            borrowToolStripMenuItem.Text = "Add User";
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(134, 29);
            returnToolStripMenuItem.Text = "Delete User";
            // 
            // allBooksToolStripMenuItem
            // 
            allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            allBooksToolStripMenuItem.Size = new Size(107, 29);
            allBooksToolStripMenuItem.Text = "All Users";
            // 
            // AdminCheckAllUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 556);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminCheckAllUsers";
            Text = "AdminCheckAllUsers";
            Load += AdminCheckAllUsers_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem allBooksToolStripMenuItem;
    }
}