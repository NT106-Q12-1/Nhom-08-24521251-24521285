namespace BAI7
{
    partial class FormAddFood
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
            namefood_txt = new TextBox();
            count_txt = new TextBox();
            address_txt = new TextBox();
            picture_txt = new TextBox();
            describe_rtb = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            clear_btn = new Button();
            add_btn = new Button();
            picturefood_btn = new Button();
            SuspendLayout();
            // 
            // namefood_txt
            // 
            namefood_txt.Location = new Point(223, 80);
            namefood_txt.Name = "namefood_txt";
            namefood_txt.Size = new Size(300, 27);
            namefood_txt.TabIndex = 0;
            // 
            // count_txt
            // 
            count_txt.Location = new Point(223, 132);
            count_txt.Name = "count_txt";
            count_txt.Size = new Size(300, 27);
            count_txt.TabIndex = 1;
            // 
            // address_txt
            // 
            address_txt.Location = new Point(223, 189);
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(300, 27);
            address_txt.TabIndex = 2;
            // 
            // picture_txt
            // 
            picture_txt.Location = new Point(223, 242);
            picture_txt.Name = "picture_txt";
            picture_txt.Size = new Size(192, 27);
            picture_txt.TabIndex = 3;
            // 
            // describe_rtb
            // 
            describe_rtb.Location = new Point(223, 303);
            describe_rtb.Name = "describe_rtb";
            describe_rtb.Size = new Size(300, 120);
            describe_rtb.TabIndex = 4;
            describe_rtb.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(223, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 46);
            label1.TabIndex = 5;
            label1.Text = "Thêm món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(81, 80);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 6;
            label2.Text = "Tên món ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(81, 189);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(81, 132);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 8;
            label4.Text = "Giá cả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(81, 245);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 9;
            label5.Text = "Hình ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(143, 302);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 10;
            label6.Text = "Mô tả";
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(301, 461);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(94, 29);
            clear_btn.TabIndex = 11;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(429, 461);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(94, 29);
            add_btn.TabIndex = 12;
            add_btn.Text = "Thêm";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // picturefood_btn
            // 
            picturefood_btn.Location = new Point(429, 240);
            picturefood_btn.Name = "picturefood_btn";
            picturefood_btn.Size = new Size(94, 29);
            picturefood_btn.TabIndex = 13;
            picturefood_btn.Text = "Browse";
            picturefood_btn.UseVisualStyleBackColor = true;
            picturefood_btn.Click += picturefood_btn_Click;
            // 
            // FormAddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 541);
            Controls.Add(picturefood_btn);
            Controls.Add(add_btn);
            Controls.Add(clear_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(describe_rtb);
            Controls.Add(picture_txt);
            Controls.Add(address_txt);
            Controls.Add(count_txt);
            Controls.Add(namefood_txt);
            Name = "FormAddFood";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox namefood_txt;
        private TextBox count_txt;
        private TextBox address_txt;
        private TextBox picture_txt;
        private RichTextBox describe_rtb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button clear_btn;
        private Button add_btn;
        private Button picturefood_btn;
    }
}