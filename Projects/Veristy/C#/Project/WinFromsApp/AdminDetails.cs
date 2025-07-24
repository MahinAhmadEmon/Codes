using Microsoft.Data.SqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AdminDetails : Form
    {
        private string adminId;
        private string connectionString = "Data Source=DESKTOP-ORBKK1T\\SQLEXPRESS; Initial Catalog=SmartKroy; Integrated Security=True; Trust Server Certificate=True";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom,
            int nWidthEllipse, int nHeightEllipse
        );

        public AdminDetails(string adminId)
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.adminId = adminId;
            LoadAdminData(); 
        }

       
        private void LoadAdminData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT admin_id, admin_name FROM admin_details WHERE admin_id = @adminId";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@adminId", adminId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id_text_box.Text = reader["admin_id"].ToString();
                        name_text_box.Text = reader["admin_name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin data: " + ex.Message);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            edit_name_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, edit_name_btn.Width, edit_name_btn.Height, 30, 30));
            edit_id_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, edit_id_btn.Width, edit_id_btn.Height, 30, 30));
        }

        private void edit_id_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_text_box.Text))
            {
                MessageBox.Show("Please enter a new ID");
                return;
            }

            string newId = id_text_box.Text.Trim();

            if (newId == adminId)
            {
                MessageBox.Show("This is already your current ID");
                return;
            }

            if (MessageBox.Show("Are you sure you want to change your admin ID? This will update all related records.",
                "Confirm ID Change", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

               
                    string checkQuery = "SELECT COUNT(*) FROM admin_details WHERE admin_id = @newId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@newId", newId);
                        if ((int)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("This ID already exists. Please choose a different ID.");
                            return;
                        }
                    }

                  
                    var fkTables = new List<string>
            {
                "product_catagory",
                "products","Supplier_Detail"
                
            };

                  
                    foreach (string table in fkTables)
                    {
                        string disableQuery = $"ALTER TABLE {table} NOCHECK CONSTRAINT ALL";
                        new SqlCommand(disableQuery, connection).ExecuteNonQuery();
                    }

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                         
                            string updateAdminQuery = "UPDATE admin_details SET admin_id = @newId WHERE admin_id = @oldId";
                            using (SqlCommand cmd = new SqlCommand(updateAdminQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@newId", newId);
                                cmd.Parameters.AddWithValue("@oldId", adminId);
                                if (cmd.ExecuteNonQuery() == 0)
                                {
                                    throw new Exception("Admin record not found");
                                }
                            }

                          
                            foreach (string table in fkTables)
                            {
                                string updateQuery = $"UPDATE {table} SET admin_id = @newId WHERE admin_id = @oldId";
                                using (SqlCommand cmd = new SqlCommand(updateQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@newId", newId);
                                    cmd.Parameters.AddWithValue("@oldId", adminId);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            adminId = newId;
                            MessageBox.Show("Admin ID updated successfully with all references");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw; 
                        }
                        finally
                        {
                            
                            foreach (string table in fkTables)
                            {
                                string enableQuery = $"ALTER TABLE {table} CHECK CONSTRAINT ALL";
                                new SqlCommand(enableQuery, connection).ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating admin ID: {ex.Message}");
            }
        }


        
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void id_text_box_TextChanged(object sender, EventArgs e) { }

        private void name_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void edit_name_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_text_box.Text))
            {
                MessageBox.Show("Please enter a new name");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE admin_details SET admin_name = @name WHERE admin_id = @adminId";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", name_text_box.Text.Trim());
                    cmd.Parameters.AddWithValue("@adminId", adminId);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("name updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update name");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating name: " + ex.Message);
            }
        }
    }
}