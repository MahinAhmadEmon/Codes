using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AdminDashboard : Form
    {
        private string adminId;

       
        public AdminDashboard(string adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            loadForm(new AdminDetails(this.adminId));
            
        }

        public void loadForm(Object form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
          
            loadForm(new ManageSuppliersForm(this.adminId));
        }

        private void btn_products_Click_1(object sender, EventArgs e)
        {
            loadForm(new ManageProductsForm(this.adminId, true));
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            loadForm(new CatagoryForm(this.adminId));
        }

        private void btn_record_Click_1(object sender, EventArgs e)
        {
            loadForm(new RecordForm());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btn_admin_Click_1(object sender, EventArgs e)
        {
            loadForm(new AdminDetails(this.adminId));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            loadForm(new customerManagement(this.adminId));
        }
    }
}
