namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_clear = new Button();
            textBox_conclusion = new TextBox();
            btn_delete = new Button();
            btn_percent = new Button();
            btn_division = new Button();
            btn_multiplication = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_subtraction = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_addition = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_equality = new Button();
            btn_dot = new Button();
            btn_0 = new Button();
            btn_00 = new Button();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(255, 128, 0);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(12, 125);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(57, 52);
            btn_clear.TabIndex = 1;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // textBox_conclusion
            // 
            textBox_conclusion.BackColor = Color.Black;
            textBox_conclusion.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_conclusion.ForeColor = Color.White;
            textBox_conclusion.Location = new Point(13, 44);
            textBox_conclusion.Name = "textBox_conclusion";
            textBox_conclusion.PlaceholderText = "0";
            textBox_conclusion.Size = new Size(263, 57);
            textBox_conclusion.TabIndex = 2;
            textBox_conclusion.TextAlign = HorizontalAlignment.Right;
            textBox_conclusion.TextChanged += textBox1_TextChanged;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 128, 0);
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(81, 125);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(57, 52);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "<";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_percent
            // 
            btn_percent.BackColor = Color.FromArgb(255, 128, 0);
            btn_percent.Cursor = Cursors.Hand;
            btn_percent.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_percent.ForeColor = Color.White;
            btn_percent.Location = new Point(150, 125);
            btn_percent.Name = "btn_percent";
            btn_percent.Size = new Size(57, 52);
            btn_percent.TabIndex = 4;
            btn_percent.Text = "%";
            btn_percent.UseVisualStyleBackColor = false;
            btn_percent.Click += btn_percent_Click;
            // 
            // btn_division
            // 
            btn_division.BackColor = Color.FromArgb(255, 128, 0);
            btn_division.Cursor = Cursors.Hand;
            btn_division.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_division.ForeColor = Color.White;
            btn_division.Location = new Point(219, 125);
            btn_division.Name = "btn_division";
            btn_division.Size = new Size(57, 52);
            btn_division.TabIndex = 5;
            btn_division.Text = "÷";
            btn_division.UseVisualStyleBackColor = false;
            btn_division.Click += btn_division_Click;
            // 
            // btn_multiplication
            // 
            btn_multiplication.BackColor = Color.FromArgb(255, 128, 0);
            btn_multiplication.Cursor = Cursors.Hand;
            btn_multiplication.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_multiplication.ForeColor = Color.White;
            btn_multiplication.Location = new Point(219, 189);
            btn_multiplication.Name = "btn_multiplication";
            btn_multiplication.Size = new Size(57, 52);
            btn_multiplication.TabIndex = 9;
            btn_multiplication.Text = "×";
            btn_multiplication.UseVisualStyleBackColor = false;
            btn_multiplication.Click += btn_multiplication_Click;
            // 
            // btn_9
            // 
            btn_9.BackColor = Color.FromArgb(64, 64, 64);
            btn_9.Cursor = Cursors.Hand;
            btn_9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_9.ForeColor = Color.White;
            btn_9.Location = new Point(150, 189);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(57, 52);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = false;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.BackColor = Color.FromArgb(64, 64, 64);
            btn_8.Cursor = Cursors.Hand;
            btn_8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_8.ForeColor = Color.White;
            btn_8.Location = new Point(81, 189);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(57, 52);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = false;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.FromArgb(64, 64, 64);
            btn_7.Cursor = Cursors.Hand;
            btn_7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_7.ForeColor = Color.White;
            btn_7.Location = new Point(12, 189);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(57, 52);
            btn_7.TabIndex = 6;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_7_Click;
            // 
            // btn_subtraction
            // 
            btn_subtraction.BackColor = Color.FromArgb(255, 128, 0);
            btn_subtraction.Cursor = Cursors.Hand;
            btn_subtraction.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_subtraction.ForeColor = Color.White;
            btn_subtraction.Location = new Point(219, 251);
            btn_subtraction.Name = "btn_subtraction";
            btn_subtraction.Size = new Size(57, 52);
            btn_subtraction.TabIndex = 13;
            btn_subtraction.Text = "-";
            btn_subtraction.UseVisualStyleBackColor = false;
            btn_subtraction.Click += btn_subtraction_Click;
            // 
            // btn_6
            // 
            btn_6.BackColor = Color.FromArgb(64, 64, 64);
            btn_6.Cursor = Cursors.Hand;
            btn_6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_6.ForeColor = Color.White;
            btn_6.Location = new Point(150, 251);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(57, 52);
            btn_6.TabIndex = 12;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = false;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.BackColor = Color.FromArgb(64, 64, 64);
            btn_5.Cursor = Cursors.Hand;
            btn_5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_5.ForeColor = Color.White;
            btn_5.Location = new Point(81, 251);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(57, 52);
            btn_5.TabIndex = 11;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = false;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.FromArgb(64, 64, 64);
            btn_4.Cursor = Cursors.Hand;
            btn_4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_4.ForeColor = Color.White;
            btn_4.Location = new Point(12, 251);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(57, 52);
            btn_4.TabIndex = 10;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_4_Click;
            // 
            // btn_addition
            // 
            btn_addition.BackColor = Color.FromArgb(255, 128, 0);
            btn_addition.Cursor = Cursors.Hand;
            btn_addition.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_addition.ForeColor = Color.White;
            btn_addition.Location = new Point(219, 312);
            btn_addition.Name = "btn_addition";
            btn_addition.Size = new Size(57, 52);
            btn_addition.TabIndex = 17;
            btn_addition.Text = "+";
            btn_addition.UseVisualStyleBackColor = false;
            btn_addition.Click += btn_addition_Click;
            // 
            // btn_3
            // 
            btn_3.BackColor = Color.FromArgb(64, 64, 64);
            btn_3.Cursor = Cursors.Hand;
            btn_3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_3.ForeColor = Color.White;
            btn_3.Location = new Point(150, 312);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(57, 52);
            btn_3.TabIndex = 16;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = false;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.BackColor = Color.FromArgb(64, 64, 64);
            btn_2.Cursor = Cursors.Hand;
            btn_2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_2.ForeColor = Color.White;
            btn_2.Location = new Point(81, 312);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(57, 52);
            btn_2.TabIndex = 15;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = false;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.FromArgb(64, 64, 64);
            btn_1.Cursor = Cursors.Hand;
            btn_1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_1.ForeColor = Color.White;
            btn_1.Location = new Point(12, 312);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(57, 52);
            btn_1.TabIndex = 14;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_1_Click;
            // 
            // btn_equality
            // 
            btn_equality.BackColor = Color.FromArgb(255, 128, 0);
            btn_equality.Cursor = Cursors.Hand;
            btn_equality.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_equality.ForeColor = Color.White;
            btn_equality.Location = new Point(219, 373);
            btn_equality.Name = "btn_equality";
            btn_equality.Size = new Size(57, 52);
            btn_equality.TabIndex = 21;
            btn_equality.Text = "=";
            btn_equality.UseVisualStyleBackColor = false;
            btn_equality.Click += btn_equality_Click;
            // 
            // btn_dot
            // 
            btn_dot.BackColor = Color.FromArgb(64, 64, 64);
            btn_dot.Cursor = Cursors.Hand;
            btn_dot.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_dot.ForeColor = Color.White;
            btn_dot.Location = new Point(150, 373);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(57, 52);
            btn_dot.TabIndex = 20;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = false;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.FromArgb(64, 64, 64);
            btn_0.Cursor = Cursors.Hand;
            btn_0.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_0.ForeColor = Color.White;
            btn_0.Location = new Point(81, 373);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(57, 52);
            btn_0.TabIndex = 19;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btn_0_Click;
            // 
            // btn_00
            // 
            btn_00.BackColor = Color.FromArgb(64, 64, 64);
            btn_00.Cursor = Cursors.Hand;
            btn_00.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_00.ForeColor = Color.White;
            btn_00.Location = new Point(12, 373);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(57, 52);
            btn_00.TabIndex = 18;
            btn_00.Text = "00";
            btn_00.UseVisualStyleBackColor = false;
            btn_00.Click += btn_00_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(288, 452);
            Controls.Add(btn_equality);
            Controls.Add(btn_dot);
            Controls.Add(btn_0);
            Controls.Add(btn_00);
            Controls.Add(btn_addition);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(btn_subtraction);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_multiplication);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_division);
            Controls.Add(btn_percent);
            Controls.Add(btn_delete);
            Controls.Add(textBox_conclusion);
            Controls.Add(btn_clear);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_clear;
        private TextBox textBox_conclusion;
        private Button btn_delete;
        private Button btn_percent;
        private Button btn_division;
        private Button btn_multiplication;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_subtraction;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_addition;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_equality;
        private Button btn_dot;
        private Button btn_0;
        private Button btn_00;
    }
}
