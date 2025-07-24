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
using System.Runtime.InteropServices;


namespace WinFormsApp
{
    public partial class CreateAccount : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

               int nLeft,

               int nTop,

               int nRight,

               int nBottom,

               int nWidthEllipse,

               int nHeightEllipse
           );
        public CreateAccount()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageProductForm_Load);
        }

        private void ManageProductForm_Load(object sender, EventArgs e)
        {
            guna2GradientButton1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, guna2GradientButton1.Width, guna2GradientButton1.Height, 30, 30));


        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string customer_id = guna2TextBox4.Text;
            string firstName = guna2TextBox6.Text;
            string lastName = guna2TextBox7.Text;
            string phone = guna2TextBox9.Text;
            string gender = guna2TextBox8.Text;
            string password = guna2TextBox10.Text;
            string confirmPassword = guna2TextBox11.Text;

            
            if (customer_id.Length != 10)
            {
                MessageBox.Show("Customer ID must be exactly 10 characters.");
                connection.Close();
                return;
            }
            else if (phone.Length > 11)
            {
                MessageBox.Show("Phone number must be 11 digits or less.");
                connection.Close();
                return;
            }
            else if (!(gender.Equals("Male", StringComparison.OrdinalIgnoreCase) || gender.Equals("Female", StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Gender must be either 'Male' or 'Female'.");
                connection.Close();
                return;
            }
            else if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Passwords do not match.");
                connection.Close();
                return;
            }
            else
            {
                
                string query = "INSERT INTO registration (customer_id, first_name, last_name, Gender, contact_number, password) " +
                               "VALUES (@customer_id, @first_name, @last_name, @gender, @contact_number, @password)";

                SqlCommand command = new SqlCommand(query, connection);

               
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.Parameters.AddWithValue("@first_name", firstName);
                command.Parameters.AddWithValue("@last_name", lastName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@contact_number", phone);
                command.Parameters.AddWithValue("@password", password);

                command.ExecuteNonQuery();
                MessageBox.Show("Account created successfully.");
                connection.Close();
            }

        }
    }
}
