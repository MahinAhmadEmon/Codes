using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp
{
    public partial class Cart : Form
    {
        private string customer_id;
        private string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";
        private DataTable cartItems = new DataTable();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

                       int nLeft,

                       int nTop,

                       int nRight,

                       int nBottom,

                       int nWidthEllipse,

                       int nHeightEllipse
         );

        private void ManageProductForm_Load(object sender, EventArgs e)
        {
            Create_bill.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Create_bill.Width, Create_bill.Height, 30, 30));


        }

        public Cart(string customer_id)
        {
            InitializeComponent();
            this.customer_id = customer_id;
            InitializeDataGridView();
            LoadCartItems();
            this.Load += new System.EventHandler(this.ManageProductForm_Load);

        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_id",
                DataPropertyName = "product_id",
                HeaderText = "Product ID",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_name",
                DataPropertyName = "product_name",
                HeaderText = "Product Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_price",
                DataPropertyName = "product_price",
                HeaderText = "Price",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "product_quantity",
                DataPropertyName = "product_quantity",
                HeaderText = "Quantity",
                Width = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "sup_id",
                DataPropertyName = "sup_id",
                HeaderText = "Supplier ID",
                Width = 100
            });

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void LoadCartItems()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cartQuery = "SELECT cart_id FROM registration WHERE customer_id = @customerId";
                    SqlCommand cartCmd = new SqlCommand(cartQuery, connection);
                    cartCmd.Parameters.AddWithValue("@customerId", customer_id);
                    object cartResult = cartCmd.ExecuteScalar();

                    if (cartResult == null || cartResult == DBNull.Value)
                    {
                        MessageBox.Show("No cart found for this customer");
                        return;
                    }

                    string productQuery = @"SELECT p.product_id, p.product_name, p.product_price, 
                                          p.product_quantity, p.sup_id
                                          FROM products p
                                          WHERE p.cart_id = @cartId";
                    SqlDataAdapter adapter = new SqlDataAdapter(productQuery, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@cartId", cartResult);
                    cartItems.Clear();
                    adapter.Fill(cartItems);

                    dataGridView1.DataSource = cartItems;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart items: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    var row = dataGridView1.Rows[e.RowIndex];
                    if (row.Cells["product_id"]?.Value != null)
                    {
                        product_id_textbox.Text = row.Cells["product_id"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting product: " + ex.Message);
            }
        }

        private void btn_get_total_price_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["product_price"]?.Value != null && row.Cells["product_quantity"]?.Value != null)
                    {
                        decimal price = Convert.ToDecimal(row.Cells["product_price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["product_quantity"].Value);
                        total += price * quantity;
                    }
                }
                get_Total_textbox.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total: " + ex.Message);
            }
        }

        private void Create_bill_Click(object sender, EventArgs e)
        {
            if (cartItems.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        decimal totalAmount = decimal.Parse(get_Total_textbox.Text, System.Globalization.NumberStyles.Currency);

                        string orderQuery = @"INSERT INTO orders (order_amount, customer_id) 
                                           VALUES (@orderAmount, @customerId);
                                           SELECT SCOPE_IDENTITY();";
                        SqlCommand orderCmd = new SqlCommand(orderQuery, connection, transaction);
                        orderCmd.Parameters.AddWithValue("@orderAmount", totalAmount);
                        orderCmd.Parameters.AddWithValue("@customerId", customer_id);
                        int orderNo = Convert.ToInt32(orderCmd.ExecuteScalar());

                        string billingQuery = @"INSERT INTO billing_data (total_amount, order_no)
                                             VALUES (@totalAmount, @orderNo)";
                        SqlCommand billingCmd = new SqlCommand(billingQuery, connection, transaction);
                        billingCmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                        billingCmd.Parameters.AddWithValue("@orderNo", orderNo);
                        billingCmd.ExecuteNonQuery();

                        string clearCartQuery = @"UPDATE products 
                                               SET cart_id = NULL 
                                               WHERE cart_id IN (
                                                   SELECT cart_id FROM registration 
                                                   WHERE customer_id = @customerId
                                               )";
                        SqlCommand clearCmd = new SqlCommand(clearCartQuery, connection, transaction);
                        clearCmd.Parameters.AddWithValue("@customerId", customer_id);
                        clearCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Bill created successfully!");
                        LoadCartItems();
                        get_Total_textbox.Text = "$0.00";
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating bill: " + ex.Message);
            }
        }

        private void btn_delete_from_cart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(product_id_textbox.Text))
            {
                MessageBox.Show("Please select a product first");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string productId = product_id_textbox.Text;

                        string productInfoQuery = @"SELECT c.catagory_name
                                        FROM products p
                                        JOIN product_catagory c ON p.catagory_id = c.catagory_id
                                        WHERE p.product_id = @productId";
                        string categoryName = "";

                        using (SqlCommand infoCmd = new SqlCommand(productInfoQuery, connection, transaction))
                        {
                            infoCmd.Parameters.AddWithValue("@productId", productId);
                            object result = infoCmd.ExecuteScalar();
                            if (result != null)
                            {
                                categoryName = result.ToString();
                            }
                        }

                        string removeQuery = @"UPDATE products 
                                    SET cart_id = NULL 
                                    WHERE product_id = @productId 
                                    AND cart_id IN (
                                        SELECT cart_id FROM registration 
                                        WHERE customer_id = @customerId
                                    )";
                        using (SqlCommand removeCmd = new SqlCommand(removeQuery, connection, transaction))
                        {
                            removeCmd.Parameters.AddWithValue("@productId", productId);
                            removeCmd.Parameters.AddWithValue("@customerId", customer_id);
                            int rowsAffected = removeCmd.ExecuteNonQuery();

                            if (rowsAffected == 0)
                            {
                                MessageBox.Show("Product not found in your cart");
                                transaction.Rollback();
                                return;
                            }
                        }

                        string restoreQuery = "UPDATE products SET product_quantity = product_quantity + 1 WHERE product_id = @productId";
                        using (SqlCommand restoreCmd = new SqlCommand(restoreQuery, connection, transaction))
                        {
                            restoreCmd.Parameters.AddWithValue("@productId", productId);
                            restoreCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"Product removed from cart and returned to {categoryName} category");
                        LoadCartItems();
                        product_id_textbox.Text = "";

                        
                        var homePage = Application.OpenForms.OfType<HomePage>().FirstOrDefault();
                        homePage?.RefreshCategoryProducts(categoryName);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error removing from cart: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(customer_id);
            homePage.Show();
            this.Hide();
        }

        private void product_id_textbox_TextChanged(object sender, EventArgs e) { }
        private void get_Total_textbox_TextChanged(object sender, EventArgs e) { }
    }
}