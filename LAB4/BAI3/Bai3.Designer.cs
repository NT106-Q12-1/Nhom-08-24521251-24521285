namespace BAI3
{
    partial class Bai3
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
            textBox1 = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            loadbtn = new Button();
            reloadbtn = new Button();
            downbtn = new Button();
            downresbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(617, 27);
            textBox1.TabIndex = 0;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 92);
            webView21.Name = "webView21";
            webView21.Size = new Size(983, 478);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(4, 24);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(122, 30);
            loadbtn.TabIndex = 2;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            // 
            // reloadbtn
            // 
            reloadbtn.Location = new Point(825, 22);
            reloadbtn.Name = "reloadbtn";
            reloadbtn.Size = new Size(122, 29);
            reloadbtn.TabIndex = 3;
            reloadbtn.Text = "Reload";
            reloadbtn.UseVisualStyleBackColor = true;
            // 
            // downbtn
            // 
            downbtn.Location = new Point(652, 58);
            downbtn.Name = "downbtn";
            downbtn.Size = new Size(94, 29);
            downbtn.TabIndex = 4;
            downbtn.Text = "Down File";
            downbtn.UseVisualStyleBackColor = true;
            downbtn.Click += downbtn_Click;
            // 
            // downresbtn
            // 
            downresbtn.Location = new Point(781, 58);
            downresbtn.Name = "downresbtn";
            downresbtn.Size = new Size(166, 29);
            downresbtn.TabIndex = 5;
            downresbtn.Text = "Down Resource";
            downresbtn.UseVisualStyleBackColor = true;
            downresbtn.Click += downresbtn_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 582);
            Controls.Add(downresbtn);
            Controls.Add(downbtn);
            Controls.Add(reloadbtn);
            Controls.Add(loadbtn);
            Controls.Add(webView21);
            Controls.Add(textBox1);
            Name = "Bai3";
            Text = "Form1";
            Load += Bai3_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button loadbtn;
        private Button reloadbtn;
        private Button downbtn;
        private Button downresbtn;
    }
}
