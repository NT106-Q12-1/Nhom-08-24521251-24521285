namespace BAI7
{
    partial class Bai7
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
            tabControl1 = new TabControl();
            All_tab = new TabPage();
            Mytab_tab = new TabPage();
            label1 = new Label();
            ramdom_btn = new Button();
            addfood_btn = new Button();
            status_txt = new TextBox();
            login_btn = new Button();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(All_tab);
            tabControl1.Controls.Add(Mytab_tab);
            tabControl1.Location = new Point(42, 54);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(538, 321);
            tabControl1.TabIndex = 0;
            // 
            // All_tab
            // 
            All_tab.Location = new Point(4, 29);
            All_tab.Name = "All_tab";
            All_tab.Padding = new Padding(3);
            All_tab.Size = new Size(530, 288);
            All_tab.TabIndex = 0;
            All_tab.Text = "All";
            All_tab.UseVisualStyleBackColor = true;
            // 
            // Mytab_tab
            // 
            Mytab_tab.Location = new Point(4, 29);
            Mytab_tab.Name = "Mytab_tab";
            Mytab_tab.Padding = new Padding(3);
            Mytab_tab.Size = new Size(530, 288);
            Mytab_tab.TabIndex = 1;
            Mytab_tab.Text = "Tôi đóng góp";
            Mytab_tab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(42, 5);
            label1.Name = "label1";
            label1.Size = new Size(252, 46);
            label1.TabIndex = 1;
            label1.Text = "Hôm nay ăn gì";
            // 
            // ramdom_btn
            // 
            ramdom_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ramdom_btn.Location = new Point(420, 12);
            ramdom_btn.Name = "ramdom_btn";
            ramdom_btn.Size = new Size(143, 48);
            ramdom_btn.TabIndex = 2;
            ramdom_btn.Text = "Ăn gì giờ ";
            ramdom_btn.UseVisualStyleBackColor = true;
            ramdom_btn.Click += ramdom_btn_Click;
            // 
            // addfood_btn
            // 
            addfood_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addfood_btn.Location = new Point(609, 12);
            addfood_btn.Name = "addfood_btn";
            addfood_btn.Size = new Size(158, 48);
            addfood_btn.TabIndex = 3;
            addfood_btn.Text = "Thêm món ăn";
            addfood_btn.UseVisualStyleBackColor = true;
            addfood_btn.Click += addfood_btn_Click;
            // 
            // status_txt
            // 
            status_txt.Location = new Point(46, 381);
            status_txt.Name = "status_txt";
            status_txt.Size = new Size(153, 27);
            status_txt.TabIndex = 4;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(238, 381);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 5;
            login_btn.Text = "Đăng Nhập";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login_btn);
            Controls.Add(status_txt);
            Controls.Add(addfood_btn);
            Controls.Add(ramdom_btn);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Bai7";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage All_tab;
        private TabPage Mytab_tab;
        private Label label1;
        private Button ramdom_btn;
        private Button addfood_btn;
        private TextBox status_txt;
        private Button login_btn;
    }
}
