﻿namespace Library
{
    partial class AdminAddNewUser
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            allBooksToolStripMenuItem = new ToolStripMenuItem();
            sIGNOUTToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 93);
            label1.Name = "label1";
            label1.Size = new Size(382, 54);
            label1.TabIndex = 2;
            label1.Text = "Admin Add New User";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label2.Location = new Point(254, 208);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 3;
            label2.Text = "User ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label3.Location = new Point(254, 268);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label4.Location = new Point(254, 328);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 5;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label5.Location = new Point(254, 388);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 6;
            label5.Text = "Role";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 32);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(407, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 32);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(407, 325);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 32);
            textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(406, 385);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 33);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(26, 26);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, allBooksToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, sIGNOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(928, 38);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(123, 25);
            menuToolStripMenuItem.Text = "Dashboard";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(109, 25);
            borrowToolStripMenuItem.Text = "Add User";
            borrowToolStripMenuItem.Click += borrowToolStripMenuItem_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(131, 25);
            returnToolStripMenuItem.Text = "Delete User";
            // 
            // allBooksToolStripMenuItem
            // 
            allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            allBooksToolStripMenuItem.Size = new Size(106, 25);
            allBooksToolStripMenuItem.Text = "All Users";
            // 
            // sIGNOUTToolStripMenuItem
            // 
            sIGNOUTToolStripMenuItem.Name = "sIGNOUTToolStripMenuItem";
            sIGNOUTToolStripMenuItem.Size = new Size(120, 34);
            sIGNOUTToolStripMenuItem.Text = "Sign Out";
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(254, 459);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(169, 59);
            button4.TabIndex = 23;
            button4.Text = "Confirm";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(476, 459);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(169, 59);
            button1.TabIndex = 24;
            button1.Text = "Back";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // AdminAddNewUser
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(menuStrip1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminAddNewUser";
            Text = "AdminAddNewUser";
            Load += AdminAddNewUser_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem allBooksToolStripMenuItem;
        private ToolStripMenuItem sIGNOUTToolStripMenuItem;
        private Button button4;
        private Button button1;
    }
}