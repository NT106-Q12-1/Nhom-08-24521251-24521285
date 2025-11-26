namespace BAI6
{
    partial class Bai6
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
            lbURL = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            tbURL = new TextBox();
            tbUsername = new TextBox();
            tbTextbox = new TextBox();
            btnLogin = new Button();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbURL.Location = new Point(12, 9);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(59, 32);
            lbURL.TabIndex = 0;
            lbURL.Text = "URL";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbUsername.Location = new Point(12, 60);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(128, 32);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbPassword.Location = new Point(12, 110);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(122, 32);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // tbURL
            // 
            tbURL.Font = new Font("Segoe UI", 12F);
            tbURL.Location = new Point(173, 8);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(615, 34);
            tbURL.TabIndex = 3;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(173, 59);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(472, 34);
            tbUsername.TabIndex = 4;
            // 
            // tbTextbox
            // 
            tbTextbox.Font = new Font("Segoe UI", 12F);
            tbTextbox.Location = new Point(173, 109);
            tbTextbox.Name = "tbTextbox";
            tbTextbox.Size = new Size(472, 34);
            tbTextbox.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.Location = new Point(651, 60);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 83);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(12, 157);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(776, 281);
            rtbResult.TabIndex = 7;
            rtbResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbResult);
            Controls.Add(btnLogin);
            Controls.Add(tbTextbox);
            Controls.Add(tbUsername);
            Controls.Add(tbURL);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbURL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbURL;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox tbURL;
        private TextBox tbUsername;
        private TextBox tbTextbox;
        private Button btnLogin;
        private RichTextBox rtbResult;
    }
}
