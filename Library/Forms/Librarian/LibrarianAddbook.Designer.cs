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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(357, 242);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(174, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(357, 194);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(357, 146);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 292);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 18;
            label5.Text = "Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 244);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 17;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 196);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 16;
            label3.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 148);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 15;
            label2.Text = "Book ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(246, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 36);
            label1.TabIndex = 14;
            label1.Text = "Librarian Add New Book";
            // 
            // button2
            // 
            button2.Location = new Point(443, 350);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(87, 30);
            button2.TabIndex = 13;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(246, 350);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(87, 30);
            button1.TabIndex = 12;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(357, 289);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 27);
            textBox4.TabIndex = 22;
            // 
            // LibrarianAddbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LibrarianAddbook";
            Text = "Librarian Add New Book";
            Load += LibrarianAddbook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
    }
}