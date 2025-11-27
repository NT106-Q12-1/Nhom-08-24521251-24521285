namespace BAI4
{
    partial class Main
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
            loaddata_btn = new Button();
            progressBar1 = new ProgressBar();
            describe_btn = new Button();
            name_txt = new TextBox();
            phone_txt = new TextBox();
            urlcinema_ccb = new ComboBox();
            film_cbb = new ComboBox();
            order_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // loaddata_btn
            // 
            loaddata_btn.Location = new Point(633, 39);
            loaddata_btn.Name = "loaddata_btn";
            loaddata_btn.Size = new Size(107, 29);
            loaddata_btn.TabIndex = 1;
            loaddata_btn.Text = "Load";
            loaddata_btn.UseVisualStyleBackColor = true;
            loaddata_btn.Click += loaddata_btn_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, -1);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 10);
            progressBar1.TabIndex = 2;
            // 
            // describe_btn
            // 
            describe_btn.Location = new Point(606, 301);
            describe_btn.Name = "describe_btn";
            describe_btn.Size = new Size(147, 43);
            describe_btn.TabIndex = 3;
            describe_btn.Text = "Mô tả";
            describe_btn.UseVisualStyleBackColor = true;
            describe_btn.Click += describe_btn_Click;
            // 
            // name_txt
            // 
            name_txt.Location = new Point(225, 114);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(368, 27);
            name_txt.TabIndex = 4;
            // 
            // phone_txt
            // 
            phone_txt.Location = new Point(225, 182);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(368, 27);
            phone_txt.TabIndex = 5;
            // 
            // urlcinema_ccb
            // 
            urlcinema_ccb.FormattingEnabled = true;
            urlcinema_ccb.Location = new Point(168, 40);
            urlcinema_ccb.Name = "urlcinema_ccb";
            urlcinema_ccb.Size = new Size(425, 28);
            urlcinema_ccb.TabIndex = 6;
            // 
            // film_cbb
            // 
            film_cbb.FormattingEnabled = true;
            film_cbb.Location = new Point(168, 309);
            film_cbb.Name = "film_cbb";
            film_cbb.Size = new Size(425, 28);
            film_cbb.TabIndex = 7;
            // 
            // order_btn
            // 
            order_btn.Location = new Point(306, 366);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(156, 47);
            order_btn.TabIndex = 8;
            order_btn.Text = "Đặt vé";
            order_btn.UseVisualStyleBackColor = true;
            order_btn.Click += order_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 121);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 9;
            label1.Text = "Họ tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 185);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 10;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 43);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 11;
            label3.Text = "Wed Cimena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 312);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 12;
            label4.Text = "Chọn Film";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(order_btn);
            Controls.Add(film_cbb);
            Controls.Add(urlcinema_ccb);
            Controls.Add(phone_txt);
            Controls.Add(name_txt);
            Controls.Add(describe_btn);
            Controls.Add(progressBar1);
            Controls.Add(loaddata_btn);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loaddata_btn;
        private ProgressBar progressBar1;
        private Button describe_btn;
        private TextBox name_txt;
        private TextBox phone_txt;
        private ComboBox urlcinema_ccb;
        private ComboBox film_cbb;
        private Button order_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
