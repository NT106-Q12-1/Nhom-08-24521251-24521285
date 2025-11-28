namespace BAI7
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            signup_link = new LinkLabel();
            label4 = new Label();
            login_btn = new Button();
            SuspendLayout();
            // 
            // user_txt
            // 
            user_txt.Location = new Point(179, 88);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(276, 27);
            user_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(179, 154);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(276, 27);
            password_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 2;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(52, 88);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 3;
            label2.Text = "Usernname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(52, 153);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // signup_link
            // 
            signup_link.AutoSize = true;
            signup_link.Location = new Point(324, 249);
            signup_link.Name = "signup_link";
            signup_link.Size = new Size(57, 20);
            signup_link.TabIndex = 5;
            signup_link.TabStop = true;
            signup_link.Text = "SignUp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 249);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account yet?";
            // 
            // login_btn
            // 
            login_btn.Location = new Point(238, 200);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(143, 46);
            login_btn.TabIndex = 7;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 320);
            Controls.Add(login_btn);
            Controls.Add(label4);
            Controls.Add(signup_link);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_txt);
            Controls.Add(user_txt);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox user_txt;
        private TextBox password_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel signup_link;
        private Label label4;
        private Button login_btn;
    }
}