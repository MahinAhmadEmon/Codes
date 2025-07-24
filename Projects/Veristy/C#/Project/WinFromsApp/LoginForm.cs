using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace WinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CreateAccount createAccountForm = new CreateAccount();

           
            createAccountForm.Show();

            this.Hide();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string customer_id = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            string query = "SELECT * FROM registration WHERE customer_id = '" + customer_id + "' AND password = '" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                
                HomePage homePage = new HomePage(customer_id);
                homePage.Show();
                this.Hide();
            }
            else
            {
               
                MessageBox.Show("Wrong ID or Password.");
            }

            connection.Close();
        }



        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            CreateAccount createAccountForm = new CreateAccount();

            createAccountForm.Show();

            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SmartKroy smartKroyForm = new SmartKroy();
            smartKroyForm.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
            this.Hide();
        }
    }
}
