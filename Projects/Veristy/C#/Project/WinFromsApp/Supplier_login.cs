using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp
{
    public partial class Supplier_login : Form
    {
        public Supplier_login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string supplierID = guna2TextBox1.Text;
                string password = guna2TextBox2.Text;

                
                string query = "SELECT * FROM Supplier_Detail WHERE sup_id = @id AND sup_password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", supplierID);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            
                            SupplierLoginAfter loginAfter = new SupplierLoginAfter(supplierID);
                            loginAfter.Show();
                            this.Hide();
                        }
                        else
                        {
                            
                            MessageBox.Show("Invalid Supplier ID or Password.");
                        }
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SupplierForm sup_form = new SupplierForm();
            sup_form.Show();
            this.Hide();
        }
    }
}
