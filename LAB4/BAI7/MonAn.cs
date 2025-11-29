using BAI7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BAI7
{
    public partial class MonAn : UserControl
    {
        public MonAn()
        {
            InitializeComponent();
        }
      
        public void SetDishData(Dish dish, string contributorUsername)
        {
            label_ten.Text = dish.Name;
            label1.Text = dish.Price;
            label_address.Text = dish.Address;
            label_contributor.Text = contributorUsername;
            dish.ContributorName = contributorUsername;
            if (!string.IsNullOrEmpty(dish.Url))
            {
                try
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", dish.Url);
                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi tải ảnh
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
