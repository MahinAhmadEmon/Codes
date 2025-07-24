using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp
{
    public partial class RecordForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom,
            int nWidthEllipse, int nHeightEllipse
        );
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

        public RecordForm()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            this.Load += RecordForm_Load;
            this.AutoScaleMode = AutoScaleMode.Font;
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeDataGridView();
                LoadBillingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

        
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

           
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colBillId",
                DataPropertyName = "bill_id",
                HeaderText = "Bill ID",
                Width = 130
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colBillDate",
                DataPropertyName = "bill_date",
                HeaderText = "Bill Date",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "d" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTotalAmount",
                DataPropertyName = "total_amount",
                HeaderText = "Total Amount",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colOrderNo",
                DataPropertyName = "order_no",
                HeaderText = "Order No",
                Width = 130
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colCustomerId",
                DataPropertyName = "customer_id",
                HeaderText = "Customer ID",
                Width = 140
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colCartId",
                DataPropertyName = "cart_id",
                HeaderText = "Cart ID",
                Width = 140
            });
        }

        private void LoadBillingData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT b.bill_id, b.bill_date, b.total_amount, b.order_no, 
                                   o.customer_id, r.cart_id
                                   FROM billing_data b
                                   JOIN orders o ON b.order_no = o.order_no
                                   JOIN registration r ON o.customer_id = r.customer_id";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading billing data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search_text_box.Text))
            {
                MessageBox.Show("Please enter a Bill ID to search.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(search_text_box.Text, out int billId))
            {
                MessageBox.Show("Please enter a valid numeric Bill ID.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT b.bill_id, b.bill_date, b.total_amount, b.order_no, 
                             o.customer_id, r.cart_id
                             FROM billing_data b
                             JOIN orders o ON b.order_no = o.order_no
                             JOIN registration r ON o.customer_id = r.customer_id
                             WHERE b.bill_id = @BillId";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@BillId", billId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            StringBuilder message = new StringBuilder();
                            message.AppendLine("Search Result:");
                            message.AppendLine("----------------------------");
                            message.AppendLine($"Bill ID: {reader["bill_id"]}");
                            message.AppendLine($"Date: {Convert.ToDateTime(reader["bill_date"]):d}");
                            message.AppendLine($"Amount: {Convert.ToDecimal(reader["total_amount"]):C2}");
                            message.AppendLine($"Order No: {reader["order_no"]}");
                            message.AppendLine($"Customer ID: {reader["customer_id"]}");
                            message.AppendLine($"Cart ID: {reader["cart_id"]}");
                            message.AppendLine("----------------------------");

                            MessageBox.Show(message.ToString(), "Bill Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"No bill found with ID: {billId}", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@BillId", billId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for bill: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bill_id_textBox.Text))
            {
                MessageBox.Show("Please enter a Bill ID to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(bill_id_textBox.Text, out int billId))
            {
                MessageBox.Show("Please enter a valid numeric Bill ID.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you want to delete bill with ID: {billId}?",
                                            "Confirm Delete",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT order_no FROM billing_data WHERE bill_id = @BillId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@BillId", billId);
                    object orderNoObj = checkCmd.ExecuteScalar();

                    if (orderNoObj != null)
                    {
                        int orderNo = Convert.ToInt32(orderNoObj);

                        
                        string deleteBillingQuery = "DELETE FROM billing_data WHERE bill_id = @BillId";
                        SqlCommand deleteBillingCmd = new SqlCommand(deleteBillingQuery, connection);
                        deleteBillingCmd.Parameters.AddWithValue("@BillId", billId);
                        deleteBillingCmd.ExecuteNonQuery();

                      
                        string deleteOrderQuery = "DELETE FROM orders WHERE order_no = @OrderNo";
                        SqlCommand deleteOrderCmd = new SqlCommand(deleteOrderQuery, connection);
                        deleteOrderCmd.Parameters.AddWithValue("@OrderNo", orderNo);
                        deleteOrderCmd.ExecuteNonQuery();

                        MessageBox.Show($"Bill with ID {billId} and its order have been deleted.",
                            "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadBillingData();
                    }
                    else
                    {
                        MessageBox.Show($"No bill found with ID: {billId}",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting bill: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2HtmlLabel1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void search_text_box_TextChanged(object sender, EventArgs e) { }
        private void bill_id_textBox_TextChanged(object sender, EventArgs e) { }
    }
}