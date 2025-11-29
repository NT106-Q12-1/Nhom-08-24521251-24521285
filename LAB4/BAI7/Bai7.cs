using System.Windows.Forms;

namespace BAI7
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            addfood_btn.Enabled = false;
            status_txt.Text = "Unauthencated";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn)
            {
                SessionManager.Logout();
                MessageBox.Show("Đã đăng xuất thành công.");
                Mytab_tab.Controls.Clear();
                UpdateEvents();
            }
            else
            {
                using (FormLogin formlogin = new FormLogin())
                {
                    if (formlogin.ShowDialog() == DialogResult.OK)
                    {
                        UpdateEvents();
                        LoadDishes();
                    }
                }
            }
        }

        private void UpdateEvents()
        {
            if (SessionManager.IsLoggedIn)
            {
                status_txt.Text = "Logging is as " + SessionManager.CurrentUsername;
                login_btn.Text = "Logout";
                addfood_btn.Enabled = true;
            }
            else
            {
                status_txt.Text = "Unauthencated";
                login_btn.Text = "Login";
                addfood_btn.Enabled = false;
            }
        }
        private void LoadDishes()   // hàm load dishes dùng để load các món ăn khi log in 1 phiên
        {
            IEnumerable<Dish> allDishes = SessionManager.list_monan;
            int currentUserId = SessionManager.CurrentUserId;
            List<Dish> listAll = allDishes.ToList();
            List<Dish> listMyContribution = allDishes
                .Where(d => d.ContributorId == currentUserId && currentUserId > 0)
                .ToList();
            DisplayDishesOnTab(All_tab, listAll);
            DisplayDishesOnTab(Mytab_tab, listMyContribution);
        }
        private void DisplayDishesOnTab(TabPage targetTabPage, List<Dish> dishesToDisplay)
        {
            targetTabPage.Controls.Clear();
            int yPos = 5;
            int spacing = 10;

            foreach (var dish in dishesToDisplay)
            {
                MonAn itemControl = new MonAn();
                itemControl.SetDishData(dish, GetUsernameById(dish.ContributorId, dishesToDisplay));

                itemControl.Location = new Point(0, yPos);
                itemControl.Width = targetTabPage.Width - 20;

                targetTabPage.Controls.Add(itemControl);
                yPos += itemControl.Height + spacing;
            }
            targetTabPage.AutoScroll = true;
        }
        private string GetUsernameById(int id, List<Dish> dishesToDisplay)
        {
            if (id == SessionManager.CurrentUserId)
            {
                return SessionManager.CurrentUsername;
            }

            var user = dishesToDisplay.FirstOrDefault(u => u.ContributorId == id);

            if (user != null)
            {
                return user.ContributorName;
            }
            return "Unknown Contributor";
        }

        private void addfood_btn_Click(object sender, EventArgs e)
        {
            using (FormAddFood formaddfood = new FormAddFood())
            {
                if (formaddfood.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Món ăn đã được thêm thành công!");
                    LoadDishes();
                }
            }
        }

        private void ramdom_btn_Click(object sender, EventArgs e)
        {
            List<Dish> monanAll = SessionManager.list_monan;
            List<Dish> dishesToRandomize = new List<Dish>();
            if (this.tabControl1.SelectedTab == Mytab_tab)      
            {
                int currentid = SessionManager.CurrentUserId;
                if (currentid > 0)
                {
                    dishesToRandomize = monanAll.Where(d => d.ContributorId == currentid).ToList();
                }
            }
            else
            {
                dishesToRandomize = monanAll; 
            }
            if (dishesToRandomize.Count == 0)
            {
                string tabName = this.tabControl1.SelectedTab.Text;
                MessageBox.Show("Hiện không có món ăn nào trong tab '{tabName}'.");
                return;
            }
            int list_len = dishesToRandomize.Count;
            Random random_num = new Random();
            int idx = random_num.Next(list_len);
            Dish finaldish = dishesToRandomize[idx];
            string contributorName = GetUsernameById(finaldish.ContributorId, dishesToRandomize);
            MonAn monan = new MonAn();
            monan.SetDishData(finaldish, contributorName);
            int controlWidth = 480;
            int controlHeight = 150;
            monan.Width = controlWidth;
            monan.Height = controlHeight;
            Form randomDishForm = new Form();
            randomDishForm.Text = $"Món Ăn Ngẫu Nhiên của {finaldish.ContributorName}: " + finaldish.Name;
            randomDishForm.ClientSize = new Size(controlWidth + 20, controlHeight + 20);
            randomDishForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            randomDishForm.Controls.Add(monan);
            monan.Location = new Point(10, 10); 
            randomDishForm.ShowDialog();
        }
    }
}
