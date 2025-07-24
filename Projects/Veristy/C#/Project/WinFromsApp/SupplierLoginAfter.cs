using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp;

namespace WinFormsApp1
{
    public partial class SupplierLoginAfter : Form
    {
        private string SupId;
        public SupplierLoginAfter(string supId)
        {
            InitializeComponent();
            this.SupId = supId;
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier_login supplierLoginForm = new Supplier_login();
            supplierLoginForm.Show();
            this.Hide();
        }

        private void LoadProducts()
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_id",
                DataPropertyName = "product_id",
                HeaderText = "Product ID",
                Width = 180
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_name",
                DataPropertyName = "product_name",
                HeaderText = "Product Name",
                Width = 170
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_quantity",
                DataPropertyName = "product_quantity",
                HeaderText = "Quantity",
                Width = 160
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_price",
                DataPropertyName = "product_price",
                HeaderText = "Price",
                Width = 200
            });

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT product_id, product_name, product_quantity, product_price FROM products WHERE sup_id = @supId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@supId", this.SupId);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE products SET product_name = @name, product_quantity = @qty, product_price = @price WHERE product_id = @id AND sup_id = @supId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                command.Parameters.AddWithValue("@name", textBox4.Text.Trim());
                command.Parameters.AddWithValue("@qty", textBox3.Text.Trim());
                command.Parameters.AddWithValue("@price", textBox2.Text.Trim());
                command.Parameters.AddWithValue("@supId", this.SupId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Product updated successfully!");
                    else
                        MessageBox.Show("Failed to update. Product not found or you don't have permission.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                LoadProducts();
            }
        }

        private void PopulateTextBoxesFromGrid(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                
                if (row.IsNewRow) return;

                textBox1.Text = row.Cells["product_id"].Value?.ToString();
                textBox4.Text = row.Cells["product_name"].Value?.ToString();
                textBox3.Text = row.Cells["product_quantity"].Value?.ToString();
                textBox2.Text = row.Cells["product_price"].Value?.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PopulateTextBoxesFromGrid(e.RowIndex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PopulateTextBoxesFromGrid(e.RowIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO products (product_id, product_name, product_quantity, product_price, sup_id) VALUES (@id, @name, @qty, @price, @supId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                command.Parameters.AddWithValue("@name", textBox4.Text.Trim());
                command.Parameters.AddWithValue("@qty", textBox3.Text.Trim());
                command.Parameters.AddWithValue("@price", textBox2.Text.Trim());
                command.Parameters.AddWithValue("@supId", this.SupId);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                LoadProducts();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM products WHERE product_id = @id AND sup_id = @supId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", textBox1.Text.Trim());
                command.Parameters.AddWithValue("@supId", this.SupId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!");
                       
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete. Product not found or you don't have permission.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                LoadProducts();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}