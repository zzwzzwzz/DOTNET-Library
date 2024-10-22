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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(273, 127);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 36);
            label1.TabIndex = 18;
            label1.Text = "Librarian Delete Book";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(367, 228);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 230);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 16;
            label2.Text = "Book ID";
            // 
            // button2
            // 
            button2.Location = new Point(453, 293);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(87, 30);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(257, 293);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(87, 30);
            button1.TabIndex = 14;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // LibrarianDeleteBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LibrarianDeleteBook";
            Text = "LibrarianDeleteBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}