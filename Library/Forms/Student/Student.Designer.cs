namespace Library
{
    partial class Student
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
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Student_Dashboard;
            pictureBox1.Location = new Point(50, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 415);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            button3.Location = new Point(566, 396);
            button3.Name = "button3";
            button3.Size = new Size(284, 59);
            button3.TabIndex = 8;
            button3.Text = "Check Borrow History";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            button2.Location = new Point(566, 144);
            button2.Name = "button2";
            button2.Size = new Size(284, 59);
            button2.TabIndex = 7;
            button2.Text = "Check All Books";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(537, 61);
            label1.Name = "label1";
            label1.Size = new Size(346, 54);
            label1.TabIndex = 6;
            label1.Text = "Student Dashboard";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            button1.Location = new Point(566, 312);
            button1.Name = "button1";
            button1.Size = new Size(284, 59);
            button1.TabIndex = 5;
            button1.Text = "Return Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            button4.Location = new Point(566, 228);
            button4.Name = "button4";
            button4.Size = new Size(284, 59);
            button4.TabIndex = 10;
            button4.Text = "Borrow Book";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(622, 480);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(169, 59);
            button5.TabIndex = 11;
            button5.Text = "SIGN OUT";
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = false;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}