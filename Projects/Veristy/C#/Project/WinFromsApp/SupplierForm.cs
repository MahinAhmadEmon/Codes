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

namespace WinFormsApp
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

          
            string supplierName = guna2TextBox1.Text;
            string supplierID = guna2TextBox2.Text;
            string supplierNumber = guna2TextBox3.Text;
            string supplierMail = guna2TextBox4.Text;
            string supplierAge = guna2TextBox5.Text;
            string supplierPassword = guna2TextBox6.Text;

            if (supplierID.Length != 10)
            {
                MessageBox.Show("Supplier ID must be exactly 10 characters.");
                connection.Close();
                return;
            }
            else if (supplierNumber.Length > 11)
            {
                MessageBox.Show("Supplier Number must be 11 digits or less.");
                connection.Close();
                return;
            }
            else if (supplierPassword.Length == 0)
            {
                MessageBox.Show("Password cannot be empty.");
                connection.Close();
                return;
            }

        
            string query = "INSERT INTO Supplier_Detail (sup_name, sup_id, sup_mail, sup_password, sup_phone, sup_age, admin_id) " +
                           "VALUES (@name, @id, @mail, @password, @phone, @age, NULL)";

            SqlCommand command = new SqlCommand(query, connection);

     
            command.Parameters.AddWithValue("@name", supplierName);
            command.Parameters.AddWithValue("@id", supplierID);
            command.Parameters.AddWithValue("@mail", supplierMail);
            command.Parameters.AddWithValue("@password", supplierPassword);
            command.Parameters.AddWithValue("@phone", supplierNumber);
            command.Parameters.AddWithValue("@age", supplierAge);

            command.ExecuteNonQuery();
            MessageBox.Show("Supplier account created successfully.");
            connection.Close();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Supplier_login sup_login_page = new Supplier_login();
            sup_login_page.Show();
            this.Hide();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
