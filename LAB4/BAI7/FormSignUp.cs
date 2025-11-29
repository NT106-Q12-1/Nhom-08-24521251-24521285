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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string username = user_txt.Text.Trim();
            string password = password_txt.Text;
            string email = email_txt.Text.Trim();
            string firstName = firstname_txt.Text.Trim();
            string lastName = lastname_txt.Text.Trim();
            string phone = phone_txt.Text.Trim();
            string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string language = language_cbb.Text;
            string sex = male_rbtn.Checked ? "Male" : "Female";
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            bool success = DatabaseFunction.addUser(      
                username, password, email, firstName, lastName, phone,
                birthday, language, sex
            );
            if (success)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!");
                this.Close();
            }
        }
    }
}
