using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ManageProductsForm : Form
    {
        private string currentUserID;
        private bool isAdmin;
        private string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom,
            int nWidthEllipse, int nHeightEllipse
        );


        public ManageProductsForm()
        {
            InitializeComponent();
        }

        public ManageProductsForm(string userId, bool adminFlag)
        {
            InitializeComponent();
            this.currentUserID = userId;
            this.isAdmin = adminFlag;
            InitializeDataGridView();
            LoadCategoryComboBox();
            LoadProductData();
        }

        private void ManageProductForm_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 30, 30));
            btn_edit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_edit.Width, btn_edit.Height, 30, 30));
            btn_delete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_delete.Width, btn_delete.Height, 30, 30));
            approve_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, approve_button.Width, approve_button.Height, 30, 30));
            disapprove_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, disapprove_button.Width, disapprove_button.Height, 30, 30));
            approve_button.Visible = isAdmin;
            disapprove_button.Visible = isAdmin;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_product_id",
                DataPropertyName = "product_id",
                HeaderText = "Product ID",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_product_name",
                DataPropertyName = "product_name",
                HeaderText = "Product Name",
                Width = 150,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_quantity",
                DataPropertyName = "product_quantity",
                HeaderText = "Quantity",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_price",
                DataPropertyName = "product_price",
                HeaderText = "Price",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_supplier",
                DataPropertyName = "added_by",
                HeaderText = "Added By",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_category",
                DataPropertyName = "catagory_name",
                HeaderText = "Category",
                Width = 120
            });

     
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void LoadCategoryComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT catagory_id, catagory_name FROM product_catagory";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(new
                        {
                            Text = reader["catagory_name"].ToString(),
                            Value = reader["catagory_id"].ToString()
                        });
                    }

                    comboBox1.DisplayMember = "Text";
                    comboBox1.ValueMember = "Value";
                    comboBox1.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void LoadProductData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT p.product_id, p.product_name, p.product_quantity, 
                                    p.product_price, 
                                    COALESCE(p.sup_id, p.admin_id) as added_by,
                                    c.catagory_name
                                    FROM products p
                                    LEFT JOIN product_catagory c ON p.catagory_id = c.catagory_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void LoadSelectedProduct()
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                guna2TextBox1.Text = row.Cells["col_product_id"].Value?.ToString();
                guna2TextBox2.Text = row.Cells["col_product_name"].Value?.ToString();
                guna2TextBox3.Text = row.Cells["col_quantity"].Value?.ToString();
                guna2TextBox4.Text = row.Cells["col_price"].Value?.ToString();

                string categoryName = row.Cells["col_category"].Value?.ToString();
                foreach (var item in comboBox1.Items)
                {
                    dynamic comboItem = item;
                    if (comboItem.Text == categoryName)
                    {
                        comboBox1.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void ClearInputFields()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox4.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text) ||
                string.IsNullOrWhiteSpace(guna2TextBox2.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("ID, Name and Category are required");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO products 
                                    (product_id, product_name, product_quantity, product_price, 
                                    catagory_id, sup_id, admin_id)
                                    VALUES (@id, @name, @qty, @price, @catId, @supId, @adminId)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", guna2TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@qty", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", guna2TextBox4.Text.Trim());

                    dynamic selectedItem = comboBox1.SelectedItem;
                    cmd.Parameters.AddWithValue("@catId", selectedItem.Value);

                    if (isAdmin)
                    {
                        cmd.Parameters.AddWithValue("@supId", DBNull.Value);
                        cmd.Parameters.AddWithValue("@adminId", currentUserID);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@supId", currentUserID);
                        cmd.Parameters.AddWithValue("@adminId", DBNull.Value);
                    }

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product added successfully");
                        ClearInputFields();
                        LoadProductData();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627
                    ? "Product ID already exists"
                    : "Error adding product: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a product to edit");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE products SET 
                                    product_name = @name,
                                    product_quantity = @qty,
                                    product_price = @price,
                                    catagory_id = @catId
                                    WHERE product_id = @id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", guna2TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@qty", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", guna2TextBox4.Text.Trim());

                    dynamic selectedItem = comboBox1.SelectedItem;
                    cmd.Parameters.AddWithValue("@catId", selectedItem.Value);

                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product updated successfully");
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Product not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a product to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this product?",
                "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM products WHERE product_id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Product deleted successfully");
                            ClearInputFields();
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show("Product not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a product to approve");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

           
                    string currentName = guna2TextBox2.Text.Trim();
                    if (currentName.Contains("(approved)") || currentName.Contains("(disapproved)"))
                    {
                        currentName = currentName.Split('(')[0].Trim();
                    }

                    string query = @"UPDATE products SET 
                                    product_name = @name + '(approved)',
                                    admin_id = @adminId
                                    WHERE product_id = @id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", currentName);
                    cmd.Parameters.AddWithValue("@adminId", currentUserID);
                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product approved successfully");
                        ClearInputFields();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Product not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving product: " + ex.Message);
            }
        }

        private void disapprove_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a product to disapprove");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

               
                    string currentName = guna2TextBox2.Text.Trim();
                    if (currentName.Contains("(approved)") || currentName.Contains("(disapproved)"))
                    {
                        currentName = currentName.Split('(')[0].Trim();
                    }

                    string query = @"UPDATE products SET 
                                    product_name = @name + '(disapproved)',
                                    admin_id = @adminId
                                    WHERE product_id = @id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", currentName);
                    cmd.Parameters.AddWithValue("@adminId", currentUserID);
                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product disapproved successfully");
                        ClearInputFields();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Product not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error disapproving product: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoadSelectedProduct();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox4_TextChanged(object sender, EventArgs e) { }
    }
}