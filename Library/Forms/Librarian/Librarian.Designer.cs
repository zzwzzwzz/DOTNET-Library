namespace Library
{
    partial class Librarian
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
            button4 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(488, 140);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(207, 47);
            button4.TabIndex = 14;
            button4.Text = "Check All Book";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(488, 268);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(207, 47);
            button2.TabIndex = 13;
            button2.Text = "Add Book";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(443, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 36);
            label1.TabIndex = 12;
            label1.Text = "Librarian Dashboard";
            // 
            // button1
            // 
            button1.Location = new Point(488, 204);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(207, 47);
            button1.TabIndex = 11;
            button1.Text = "Delete Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\Prakai\\Desktop\\Library\\Library\\Images\\Logo.png";
            pictureBox1.Location = new Point(-12, -15);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 478);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 459);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Librarian";
            Text = "Librarian";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}