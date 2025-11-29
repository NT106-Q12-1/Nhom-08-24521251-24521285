using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI7
{
    public partial class FormAddFood : Form
    {
        public FormAddFood()
        {
            InitializeComponent();
        }

        private void picturefood_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn ảnh món ăn";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture_txt.Text = openFileDialog.FileName;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            namefood_txt.Text = "";
            count_txt.Text = "";
            address_txt.Text = "";
            picture_txt.Text = "";
            describe_rtb.Text = "";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = namefood_txt.Text.Trim();
            string price = count_txt.Text.Trim();
            string address = address_txt.Text.Trim();
            string url = picture_txt.Text.Trim(); 
            string mota = describe_rtb.Text.Trim();
            try
            {
                SessionManager.AddDish(
                    name,
                    mota,
                    price,
                    url,
                    address
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn");
            }
        }
    }
}
