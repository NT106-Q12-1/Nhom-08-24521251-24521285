namespace BAI7
{
    partial class MonAn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label_ten = new Label();
            label_gia = new Label();
            label1 = new Label();
            label2 = new Label();
            label_address = new Label();
            label4 = new Label();
            label_contributor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 131);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_ten
            // 
            label_ten.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_ten.Location = new Point(244, 0);
            label_ten.Name = "label_ten";
            label_ten.Size = new Size(405, 47);
            label_ten.TabIndex = 1;
            label_ten.Text = "label1";
            // 
            // label_gia
            // 
            label_gia.AutoSize = true;
            label_gia.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_gia.Location = new Point(188, 35);
            label_gia.Name = "label_gia";
            label_gia.Size = new Size(56, 29);
            label_gia.TabIndex = 2;
            label_gia.Text = "Giá:";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 47);
            label1.TabIndex = 3;
            label1.Text = "label2";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 64);
            label2.Name = "label2";
            label2.Size = new Size(130, 34);
            label2.TabIndex = 4;
            label2.Text = "Địa Chỉ:";
            // 
            // label_address
            // 
            label_address.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_address.Location = new Point(297, 64);
            label_address.Name = "label_address";
            label_address.Size = new Size(460, 44);
            label_address.TabIndex = 5;
            label_address.Text = "label2";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 98);
            label4.Name = "label4";
            label4.Size = new Size(146, 45);
            label4.TabIndex = 6;
            label4.Text = "Người đóng góp";
            // 
            // label_contributor
            // 
            label_contributor.AutoSize = true;
            label_contributor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_contributor.ForeColor = Color.SpringGreen;
            label_contributor.Location = new Point(340, 98);
            label_contributor.Name = "label_contributor";
            label_contributor.Size = new Size(79, 29);
            label_contributor.TabIndex = 7;
            label_contributor.Text = "label2";
            // 
            // MonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label_contributor);
            Controls.Add(label4);
            Controls.Add(label_address);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_gia);
            Controls.Add(label_ten);
            Controls.Add(pictureBox1);
            Name = "MonAn";
            Size = new Size(543, 135);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_ten;
        private System.Windows.Forms.Label label_gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_contributor;
    }
}
