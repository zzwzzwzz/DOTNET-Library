namespace Library
{
    partial class LibrarianDeleteBook
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
            button4 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(485, 403);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(169, 59);
            button3.TabIndex = 31;
            button3.Text = "Back";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(263, 403);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(169, 59);
            button4.TabIndex = 30;
            button4.Text = "Confirm";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 133);
            label3.Name = "label3";
            label3.Size = new Size(486, 54);
            label3.TabIndex = 29;
            label3.Text = "Librarian Delete Book by ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(416, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 32);
            textBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label4.Location = new Point(265, 275);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 27;
            label4.Text = "Book ID";
            // 
            // LibrarianDeleteBook
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Margin = new Padding(4);
            Name = "LibrarianDeleteBook";
            Text = "LibrarianDeleteBook";
            Load += LibrarianDeleteBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button4;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}