using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ManageSuppliersForm : Form
    {
        private string loggedInAdminId;

        public ManageSuppliersForm(string adminId)
        {
            InitializeComponent();
            this.loggedInAdminId = adminId;
            InitializeDataGridView();
            LoadSupplierData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_sup_name",
                DataPropertyName = "sup_name",
                HeaderText = "Name",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_sup_id",
                DataPropertyName = "sup_id",
                HeaderText = "Supplier ID",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_sup_mail",
                DataPropertyName = "sup_mail",
                HeaderText = "Email",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_sup_phone",
                DataPropertyName = "sup_phone",
                HeaderText = "Phone",
                Width = 140
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_sup_age",
                DataPropertyName = "sup_age",
                HeaderText = "Age",
                Width = 150
            });
        }

      
        private void LoadSupplierData()
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT sup_name, sup_id, sup_mail, sup_phone, sup_age FROM Supplier_Detail";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier data: " + ex.Message);
            }
        }

        
        private void LoadSelectedSupplier()
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                guna2TextBox2.Text = row.Cells["col_sup_name"].Value?.ToString();
                guna2TextBox1.Text = row.Cells["col_sup_id"].Value?.ToString();
                guna2TextBox4.Text = row.Cells["col_sup_phone"].Value?.ToString();
                guna2TextBox5.Text = row.Cells["col_sup_mail"].Value?.ToString();
                guna2TextBox3.Text = row.Cells["col_sup_age"].Value?.ToString();
                
            }
        }

        
        private void ClearInputFields()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox6.Text = "";
        }

       
        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text) ||
                string.IsNullOrWhiteSpace(guna2TextBox2.Text) ||
                string.IsNullOrWhiteSpace(guna2TextBox6.Text)) 
            {
                MessageBox.Show("Name, Supplier ID and Password are required");
                return;
            }

            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Supplier_Detail 
                                    (sup_name, sup_id, sup_mail, sup_password, sup_phone, sup_age, admin_id)
                                    VALUES (@name, @id, @mail, @pass, @phone, @age, @adminId)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", guna2TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@mail", guna2TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", guna2TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", guna2TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@adminId", loggedInAdminId);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Supplier added successfully");
                        ClearInputFields();
                        LoadSupplierData();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627
                    ? "Supplier ID already exists"
                    : "Error adding supplier: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                MessageBox.Show("Please select a supplier to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this supplier?",
                "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Supplier_Detail WHERE sup_id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Supplier deleted successfully");
                            ClearInputFields();
                            LoadSupplierData();
                        }
                        else
                        {
                            MessageBox.Show("Supplier not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting supplier: " + ex.Message);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a supplier to edit");
                return;
            }

            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Supplier_Detail SET 
                                    sup_name = @name,
                                    sup_mail = @mail,
                                    sup_phone = @phone,
                                    sup_age = @age,
                                    sup_password = @pass
                                    WHERE sup_id = @id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", guna2TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@mail", guna2TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", guna2TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", guna2TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Supplier updated successfully");
                        LoadSupplierData();
                    }
                    else
                    {
                        MessageBox.Show("Supplier not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox5_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox6_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoadSelectedSupplier();
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}