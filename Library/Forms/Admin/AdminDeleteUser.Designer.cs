﻿namespace Library
{
    partial class AdminDeleteUser
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
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 32);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold);
            label2.Location = new Point(256, 256);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 11;
            label2.Text = "User ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 112);
            label1.Name = "label1";
            label1.Size = new Size(436, 54);
            label1.TabIndex = 13;
            label1.Text = "Admin Delete User by ID";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(476, 384);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(169, 59);
            button1.TabIndex = 26;
            button1.Text = "Back";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PapayaWhip;
            button4.Font = new Font("Papyrus", 8.883117F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(254, 384);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(169, 59);
            button4.TabIndex = 25;
            button4.Text = "Confirm";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button4_Click;
            // 
            // AdminDeleteUser
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "AdminDeleteUser";
            Text = "AdminDeleteUser";
            Load += AdminDeleteUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button4;
    }
}