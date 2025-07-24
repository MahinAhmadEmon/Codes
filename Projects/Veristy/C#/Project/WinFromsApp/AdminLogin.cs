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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string admin_id = guna2TextBox2.Text;
                string adminName = guna2TextBox1.Text;

              
                string query = "SELECT * FROM Admin_Details WHERE admin_id = @adminId AND UPPER(admin_name) = @adminName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminId", admin_id);
                command.Parameters.AddWithValue("@adminName", adminName.ToUpper());

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    AdminDashboard adminDashboard = new AdminDashboard(admin_id);
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Wrong ID or name.");
                }

                reader.Close();
            }

        }
    }
}
