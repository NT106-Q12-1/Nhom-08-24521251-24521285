namespace BAI2
{
    partial class Bai2
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
            rtbResult = new RichTextBox();
            btnDownload = new Button();
            tbFile = new TextBox();
            tbURL = new TextBox();
            SuspendLayout();
            // 
            // rtbResult
            // 
            rtbResult.Location = new Point(30, 100);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(741, 338);
            rtbResult.TabIndex = 7;
            rtbResult.Text = "";
            // 
            // btnDownload
            // 
            btnDownload.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDownload.Location = new Point(630, 12);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(141, 36);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // tbFile
            // 
            tbFile.Font = new Font("Segoe UI", 10F);
            tbFile.Location = new Point(30, 48);
            tbFile.Name = "tbFile";
            tbFile.Size = new Size(574, 30);
            tbFile.TabIndex = 5;
            // 
            // tbURL
            // 
            tbURL.Font = new Font("Segoe UI", 10F);
            tbURL.Location = new Point(30, 12);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(574, 30);
            tbURL.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbResult);
            Controls.Add(btnDownload);
            Controls.Add(tbFile);
            Controls.Add(tbURL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbResult;
        private Button btnDownload;
        private TextBox tbFile;
        private TextBox tbURL;
    }
}
