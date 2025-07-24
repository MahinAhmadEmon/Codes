using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class customerManagement : Form
    {
        private string loggedInAdminId;

        public customerManagement(string adminId)
        {
            InitializeComponent();
            this.loggedInAdminId = adminId;
            InitializeDataGridView();
            LoadCustomerData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

        
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_customer_id",
                DataPropertyName = "customer_id",
                HeaderText = "Customer ID",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_first_name",
                DataPropertyName = "first_name",
                HeaderText = "First Name",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_last_name",
                DataPropertyName = "last_name",
                HeaderText = "Last Name",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_gender",
                DataPropertyName = "Gender",
                HeaderText = "Gender",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_contact",
                DataPropertyName = "contact_number",
                HeaderText = "Contact",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_password",
                DataPropertyName = "password",
                HeaderText = "Password",
                Width = 100,
                
            });
        }

        
        private void LoadCustomerData()
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT customer_id, first_name, last_name, Gender, contact_number, password FROM registration";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
            }
        }

       
        private void LoadSelectedCustomer()
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                guna2TextBox1.Text = row.Cells["col_customer_id"].Value?.ToString();
                guna2TextBox2.Text = row.Cells["col_first_name"].Value?.ToString();
                guna2TextBox3.Text = row.Cells["col_last_name"].Value?.ToString();
             
                guna2TextBox4.Text = row.Cells["col_contact"].Value?.ToString();
                guna2TextBox5.Text = row.Cells["col_password"].Value?.ToString();
            }
        }


        private void ClearInputFields()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox5.Text = "";
        }

  
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a customer to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this customer?",
                "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                      
                        string deleteCartQuery = "DELETE FROM cart WHERE cart_id = (SELECT cart_id FROM registration WHERE customer_id = @id)";
                        SqlCommand cartCmd = new SqlCommand(deleteCartQuery, connection);
                        cartCmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());
                        cartCmd.ExecuteNonQuery();

                       
                        string query = "DELETE FROM registration WHERE customer_id = @id";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Customer deleted successfully");
                            ClearInputFields();
                            LoadCustomerData();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoadSelectedCustomer();
            }
        }

        
        private void customerManagement_Load(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox5_TextChanged(object sender, EventArgs e) { }
    }
}