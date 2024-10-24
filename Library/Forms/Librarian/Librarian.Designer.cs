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
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            button4.Location = new Point(567, 171);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(285, 59);
            button4.TabIndex = 14;
            button4.Text = "Check All Book";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PapayaWhip;
            button2.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            button2.Location = new Point(567, 269);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(285, 59);
            button2.TabIndex = 13;
            button2.Text = "Add Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(539, 79);
            label1.Name = "label1";
            label1.Size = new Size(354, 54);
            label1.TabIndex = 12;
            label1.Text = "Librarian Dashboard";
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            button1.Location = new Point(567, 367);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(285, 59);
            button1.TabIndex = 11;
            button1.Text = "Delete Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Librarian_Dashboard;
            pictureBox1.ImageLocation = "C:\\Users\\Prakai\\Desktop\\Library\\Library\\Images\\Logo.png";
            pictureBox1.Location = new Point(43, 68);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(623, 465);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(169, 59);
            button3.TabIndex = 16;
            button3.Text = "SIGN OUT";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Librarian";
            Text = "Librarian";
            Load += Librarian_Load;
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
        private Button button3;
    }
}