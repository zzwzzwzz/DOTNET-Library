﻿namespace Library
{
    partial class Login
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(546, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome to DOTNET Library";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 10.2857141F, FontStyle.Bold);
            label3.Location = new Point(492, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 34);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Papyrus", 10.2857141F, FontStyle.Bold);
            label4.Location = new Point(492, 312);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 34);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(650, 233);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 32);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(650, 312);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 32);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.NavajoWhite;
            button1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(590, 418);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(176, 62);
            button1.TabIndex = 6;
            button1.Text = "SIGN IN";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(37, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}