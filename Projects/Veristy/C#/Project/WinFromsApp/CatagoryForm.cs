using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CatagoryForm : Form
    {
        private string loggedInAdminId;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeft, int nTop, int nRight, int nBottom,
           int nWidthEllipse, int nHeightEllipse
       );

        public CatagoryForm(string adminId)
        {
            InitializeComponent();
            this.loggedInAdminId = adminId;
            InitializeDataGridView();
            LoadCategoryData();
        }


        private void CategoryForm_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 30, 30));
            btn_edit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_edit.Width, btn_edit.Height, 30, 30));
            btn_delete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_delete.Width, btn_delete.Height, 30, 30));

       
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

          
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_catagory_id",
                DataPropertyName = "catagory_id",
                HeaderText = "ID",
                Width = 80,
                MinimumWidth = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_catagory_name",
                DataPropertyName = "catagory_name",
                HeaderText = "Name",
                Width = 150,
                MinimumWidth = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "col_catagory_desc",
                DataPropertyName = "catagory_description",
                HeaderText = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200
            });

            
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowTemplate.Height = 25;
        }

        private void LoadCategoryData()
        {
            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT catagory_id, catagory_name, catagory_description FROM product_catagory";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        var descText = row.Cells["col_catagory_desc"].Value?.ToString() ?? "";
                        var textSize = TextRenderer.MeasureText(descText, dataGridView1.Font,
                                        new Size(dataGridView1.Columns["col_catagory_desc"].Width, 0),
                                        TextFormatFlags.WordBreak);

                        row.Height = textSize.Height + 5;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category data: " + ex.Message);
            }
        }

        private void LoadSelectedCategory()
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                guna2TextBox1.Text = row.Cells["col_catagory_id"].Value?.ToString();
                guna2TextBox2.Text = row.Cells["col_catagory_name"].Value?.ToString();
                guna2TextBox3.Text = row.Cells["col_catagory_desc"].Value?.ToString();
            }
        }

        private void ClearInputFields()
        {
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox3.Text = "";
        }


        //public CatagoryForm()
        //{
        //    InitializeComponent();
        //}

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text) ||
               string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                MessageBox.Show("ID and Name are required");
                return;
            }

            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO product_catagory 
                                    (catagory_id, catagory_name, catagory_description, admin_id)
                                    VALUES (@id, @name, @desc, @adminId)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", guna2TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@adminId", loggedInAdminId);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Category added successfully");
                        ClearInputFields();
                        LoadCategoryData();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627
                    ? "Category ID already exists"
                    : "Error adding category: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a category to edit");
                return;
            }

            string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE product_catagory SET 
                                    catagory_name = @name,
                                    catagory_description = @desc
                                    WHERE catagory_id = @id";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", guna2TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", guna2TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Category updated successfully");
                        LoadCategoryData();
                    }
                    else
                    {
                        MessageBox.Show("Category not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                MessageBox.Show("Please select a category to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this category?",
                "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM product_catagory WHERE catagory_id = @id";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", guna2TextBox1.Text.Trim());

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Category deleted successfully");
                            ClearInputFields();
                            LoadCategoryData();
                        }
                        else
                        {
                            MessageBox.Show("Category not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message);
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoadSelectedCategory();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var descText = row.Cells["col_catagory_desc"].Value?.ToString() ?? "";
                var textSize = TextRenderer.MeasureText(descText, dataGridView1.Font,
                                new Size(dataGridView1.Columns["col_catagory_desc"].Width, 0),
                                TextFormatFlags.WordBreak);

                row.Height = textSize.Height + 5;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {

        }
    }
}
