namespace BAI5
{
    partial class Bai5
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
            lblURL = new Label();
            lbtUsername = new Label();
            lblPassword = new Label();
            tbURL = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            rtbResult = new RichTextBox();
            SuspendLayout();
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblURL.Location = new Point(12, 9);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(59, 32);
            lblURL.TabIndex = 0;
            lblURL.Text = "URL";
            // 
            // lbtUsername
            // 
            lbtUsername.AutoSize = true;
            lbtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbtUsername.Location = new Point(12, 56);
            lbtUsername.Name = "lbtUsername";
            lbtUsername.Size = new Size(128, 32);
            lbtUsername.TabIndex = 1;
            lbtUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPassword.Location = new Point(12, 98);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(122, 32);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // tbURL
            // 
            tbURL.Font = new Font("Segoe UI", 12F);
            tbURL.Location = new Point(148, 8);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(615, 34);
            tbURL.TabIndex = 3;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F);
            tbUsername.Location = new Point(148, 55);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(466, 34);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(148, 97);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(466, 34);
            tbPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.Location = new Point(641, 56);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 74);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(15, 147);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(748, 291);
            rtbResult.TabIndex = 7;
            rtbResult.Text = "";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 450);
            Controls.Add(rtbResult);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbURL);
            Controls.Add(lblPassword);
            Controls.Add(lbtUsername);
            Controls.Add(lblURL);
            Name = "Bai5";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblURL;
        private Label lbtUsername;
        private Label lblPassword;
        private TextBox tbURL;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private RichTextBox rtbResult;
    }
}
