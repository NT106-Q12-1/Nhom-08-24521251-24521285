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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            textBox1 = new TextBox();
            loadbtn = new Button();
            downbtn = new Button();
            downresbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(29, 84);
            webView21.Name = "webView21";
            webView21.Size = new Size(743, 340);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(629, 27);
            textBox1.TabIndex = 1;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(676, 10);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(96, 29);
            loadbtn.TabIndex = 2;
            loadbtn.Text = "Load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            // 
            // downbtn
            // 
            downbtn.Location = new Point(493, 49);
            downbtn.Name = "downbtn";
            downbtn.Size = new Size(94, 29);
            downbtn.TabIndex = 3;
            downbtn.Text = "Down File";
            downbtn.UseVisualStyleBackColor = true;
            downbtn.Click += downbtn_Click;
            // 
            // downresbtn
            // 
            downresbtn.Location = new Point(593, 49);
            downresbtn.Name = "downresbtn";
            downresbtn.Size = new Size(179, 29);
            downresbtn.TabIndex = 4;
            downresbtn.Text = "Down Resourch";
            downresbtn.UseVisualStyleBackColor = true;
            downresbtn.Click += downresbtn_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downresbtn);
            Controls.Add(downbtn);
            Controls.Add(loadbtn);
            Controls.Add(textBox1);
            Controls.Add(webView21);
            Name = "Bai3";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox textBox1;
        private Button loadbtn;
        private Button downbtn;
        private Button downresbtn;
    }
}
