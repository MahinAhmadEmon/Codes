using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class HomePage : Form
    {
        private string customer_id;
        private ClothesUser clothesUser;
        private PCPartsUser pcPartsUser;
        private HouseProductUser houseProductUser;

        public HomePage(string customer_id)
        {
            InitializeComponent();
            this.customer_id = customer_id;
            ShowHomeUser();
        }

        public void RefreshCategoryProducts(string categoryId)
        {
            try
            {
                if (this.IsDisposed) return;

                this.Invoke((MethodInvoker)delegate {
                    switch (categoryId.ToLower())
                    {
                        case "clothing":
                            if (clothesUser != null && this.Controls.Contains(clothesUser))
                                clothesUser.LoadClothingProducts();
                            break;
                        case "electronic":
                            if (pcPartsUser != null && this.Controls.Contains(pcPartsUser))
                                pcPartsUser.LoadElectronicProducts();
                            break;
                        case "house_product":
                            if (houseProductUser != null && this.Controls.Contains(houseProductUser))
                                houseProductUser.LoadHouseProducts();
                            break;
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error refreshing category: " + ex.Message);
            }
        }

        private void ShowHomeUser()
        {
            ClearCurrentUserControls();
            HomeUser homeUser = new HomeUser();
            homeUser.Dock = DockStyle.Fill;
            this.Controls.Add(homeUser);
            homeUser.BringToFront();
        }

        private void ClearCurrentUserControls()
        {
            var controlsToRemove = this.Controls.OfType<UserControl>().ToList();
            foreach (var control in controlsToRemove)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearCurrentUserControls();
            clothesUser = new ClothesUser(customer_id);
            clothesUser.Dock = DockStyle.Fill;
            this.Controls.Add(clothesUser);
            clothesUser.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearCurrentUserControls();
            pcPartsUser = new PCPartsUser(customer_id);
            pcPartsUser.Dock = DockStyle.Fill;
            this.Controls.Add(pcPartsUser);
            pcPartsUser.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ClearCurrentUserControls();
            houseProductUser = new HouseProductUser(customer_id);
            houseProductUser.Dock = DockStyle.Fill;
            this.Controls.Add(houseProductUser);
            houseProductUser.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowHomeUser();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cart cartForm = new Cart(customer_id);
            cartForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SmartKroy smartKroyForm = new SmartKroy();
            smartKroyForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
           
        }
    }
}