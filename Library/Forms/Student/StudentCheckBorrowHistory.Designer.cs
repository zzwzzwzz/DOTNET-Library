namespace Library
{
    partial class StudentCheckBorrowHistory
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
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 15.8961039F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 67);
            label1.Name = "label1";
            label1.Size = new Size(538, 54);
            label1.TabIndex = 3;
            label1.Text = "Student Check Borrow History";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(72, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(793, 354);
            listBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(544, 530);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 32);
            dateTimePicker1.TabIndex = 23;
            // 
            // StudentCheckBorrowHistory
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 592);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "StudentCheckBorrowHistory";
            Text = "StudentCheckBorrowHistory";
            Load += StudentCheckBorrowHistory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
    }
}