namespace BAI7
{
    partial class FormSignUp
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
            user_txt = new TextBox();
            password_txt = new TextBox();
            lastname_txt = new TextBox();
            firstname_txt = new TextBox();
            phone_txt = new TextBox();
            email_txt = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            language_cbb = new ComboBox();
            male_rbtn = new RadioButton();
            female_rbtn = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            clear_btn = new Button();
            submit_btn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // user_txt
            // 
            user_txt.Location = new Point(205, 26);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(257, 27);
            user_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(205, 78);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(257, 27);
            password_txt.TabIndex = 1;
            // 
            // lastname_txt
            // 
            lastname_txt.Location = new Point(205, 92);
            lastname_txt.Name = "lastname_txt";
            lastname_txt.Size = new Size(257, 27);
            lastname_txt.TabIndex = 2;
            // 
            // firstname_txt
            // 
            firstname_txt.Location = new Point(205, 59);
            firstname_txt.Name = "firstname_txt";
            firstname_txt.Size = new Size(257, 27);
            firstname_txt.TabIndex = 3;
            // 
            // phone_txt
            // 
            phone_txt.Location = new Point(205, 125);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(257, 27);
            phone_txt.TabIndex = 4;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(205, 26);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(257, 27);
            email_txt.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(205, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // language_cbb
            // 
            language_cbb.FormattingEnabled = true;
            language_cbb.Items.AddRange(new object[] { "EN", "VI" });
            language_cbb.Location = new Point(205, 191);
            language_cbb.Name = "language_cbb";
            language_cbb.Size = new Size(151, 28);
            language_cbb.TabIndex = 7;
            // 
            // male_rbtn
            // 
            male_rbtn.AutoSize = true;
            male_rbtn.Location = new Point(205, 240);
            male_rbtn.Name = "male_rbtn";
            male_rbtn.Size = new Size(63, 24);
            male_rbtn.TabIndex = 8;
            male_rbtn.TabStop = true;
            male_rbtn.Text = "Male";
            male_rbtn.UseVisualStyleBackColor = true;
            // 
            // female_rbtn
            // 
            female_rbtn.AutoSize = true;
            female_rbtn.Location = new Point(384, 240);
            female_rbtn.Name = "female_rbtn";
            female_rbtn.Size = new Size(78, 24);
            female_rbtn.TabIndex = 9;
            female_rbtn.TabStop = true;
            female_rbtn.Text = "Female";
            female_rbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 46);
            label1.TabIndex = 10;
            label1.Text = "Hôm nay ăn gì";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(53, 26);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(53, 77);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(user_txt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(password_txt);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(71, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 125);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "SignUp";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(email_txt);
            groupBox2.Controls.Add(firstname_txt);
            groupBox2.Controls.Add(lastname_txt);
            groupBox2.Controls.Add(female_rbtn);
            groupBox2.Controls.Add(phone_txt);
            groupBox2.Controls.Add(male_rbtn);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(language_cbb);
            groupBox2.Location = new Point(71, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 306);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Information";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(55, 235);
            label10.Name = "label10";
            label10.Size = new Size(42, 28);
            label10.TabIndex = 16;
            label10.Text = "Sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(55, 191);
            label9.Name = "label9";
            label9.Size = new Size(97, 28);
            label9.TabIndex = 15;
            label9.Text = "Language";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(53, 158);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 14;
            label8.Text = "Birthday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(53, 125);
            label7.Name = "label7";
            label7.Size = new Size(67, 28);
            label7.TabIndex = 13;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(53, 91);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 12;
            label6.Text = "Lastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(53, 58);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 11;
            label5.Text = "Firstname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(53, 26);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(306, 545);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(138, 55);
            clear_btn.TabIndex = 15;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // submit_btn
            // 
            submit_btn.Location = new Point(571, 545);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(123, 55);
            submit_btn.TabIndex = 16;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 643);
            Controls.Add(submit_btn);
            Controls.Add(clear_btn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormSignUp";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox user_txt;
        private TextBox password_txt;
        private TextBox lastname_txt;
        private TextBox firstname_txt;
        private TextBox phone_txt;
        private TextBox email_txt;
        private DateTimePicker dateTimePicker1;
        private ComboBox language_cbb;
        private RadioButton male_rbtn;
        private RadioButton female_rbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button clear_btn;
        private Button submit_btn;
    }
}