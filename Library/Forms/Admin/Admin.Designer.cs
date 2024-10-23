namespace Library
{
    partial class Admin
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Papyrus", 8.883117F);
            button1.Location = new Point(556, 180);
            button1.Name = "button1";
            button1.Size = new Size(284, 59);
            button1.TabIndex = 0;
            button1.Text = "Check All User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(537, 76);
            label1.Name = "label1";
            label1.Size = new Size(313, 54);
            label1.TabIndex = 1;
            label1.Text = "Admin Dashboard";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Papyrus", 8.883117F);
            button2.Location = new Point(556, 280);
            button2.Name = "button2";
            button2.Size = new Size(284, 59);
            button2.TabIndex = 2;
            button2.Text = "Add New User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Papyrus", 8.883117F);
            button3.Location = new Point(556, 380);
            button3.Name = "button3";
            button3.Size = new Size(284, 59);
            button3.TabIndex = 3;
            button3.Text = "Delete User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 591);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(636, 480);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(129, 54);
            button4.TabIndex = 7;
            button4.Text = "SIGN OUT";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Microsoft YaHei UI", 8.883117F);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
    }
}