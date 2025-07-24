namespace WinFormsApp
{
    partial class CatagoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_add = new Guna.UI2.WinForms.Guna2Button();
            btn_edit = new Guna.UI2.WinForms.Guna2Button();
            btn_delete = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new DataGridView();
            catagory_id = new DataGridViewTextBoxColumn();
            catagory_name = new DataGridViewTextBoxColumn();
            catagory_description = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.AutoRoundedCorners = true;
            btn_add.CustomizableEdges = customizableEdges13;
            btn_add.DisabledState.BorderColor = Color.DarkGray;
            btn_add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_add.Font = new Font("Segoe UI", 9F);
            btn_add.ForeColor = Color.White;
            btn_add.Image = Properties.Resources.add2;
            btn_add.Location = new Point(268, 242);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btn_add.Size = new Size(131, 43);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.AutoRoundedCorners = true;
            btn_edit.CustomizableEdges = customizableEdges15;
            btn_edit.DisabledState.BorderColor = Color.DarkGray;
            btn_edit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_edit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_edit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_edit.Font = new Font("Segoe UI", 9F);
            btn_edit.ForeColor = Color.White;
            btn_edit.Image = Properties.Resources.edit2;
            btn_edit.Location = new Point(480, 242);
            btn_edit.Margin = new Padding(3, 4, 3, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btn_edit.Size = new Size(131, 43);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Edit";
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.AutoRoundedCorners = true;
            btn_delete.CustomizableEdges = customizableEdges17;
            btn_delete.DisabledState.BorderColor = Color.DarkGray;
            btn_delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_delete.FillColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 9F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.delete2;
            btn_delete.Location = new Point(691, 242);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btn_delete.Size = new Size(131, 43);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.Click += btn_delete_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel1.Location = new Point(346, 65);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(24, 26);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "ID";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel2.Location = new Point(346, 124);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(55, 26);
            guna2HtmlLabel2.TabIndex = 5;
            guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel3.Location = new Point(346, 184);
            guna2HtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(103, 26);
            guna2HtmlLabel3.TabIndex = 6;
            guna2HtmlLabel3.Text = "Description";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.AutoRoundedCorners = true;
            guna2TextBox1.CustomizableEdges = customizableEdges19;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(459, 55);
            guna2TextBox1.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2TextBox1.Size = new Size(179, 36);
            guna2TextBox1.TabIndex = 7;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.AutoRoundedCorners = true;
            guna2TextBox2.CustomizableEdges = customizableEdges21;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(459, 114);
            guna2TextBox2.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2TextBox2.Size = new Size(179, 36);
            guna2TextBox2.TabIndex = 8;
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.AutoRoundedCorners = true;
            guna2TextBox3.CustomizableEdges = customizableEdges23;
            guna2TextBox3.DefaultText = "";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Segoe UI", 9F);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Location = new Point(459, 174);
            guna2TextBox3.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2TextBox3.Size = new Size(179, 36);
            guna2TextBox3.TabIndex = 9;
            guna2TextBox3.TextChanged += guna2TextBox3_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { catagory_id, catagory_name, catagory_description });
            dataGridView1.Location = new Point(268, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 314);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // catagory_id
            // 
            catagory_id.HeaderText = "catagory_id";
            catagory_id.MinimumWidth = 6;
            catagory_id.Name = "catagory_id";
            catagory_id.Width = 125;
            // 
            // catagory_name
            // 
            catagory_name.HeaderText = "catagory_name";
            catagory_name.MinimumWidth = 6;
            catagory_name.Name = "catagory_name";
            catagory_name.Width = 125;
            // 
            // catagory_description
            // 
            catagory_description.HeaderText = "catagory_description";
            catagory_description.MinimumWidth = 6;
            catagory_description.Name = "catagory_description";
            catagory_description.Width = 125;
            // 
            // CatagoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1071, 660);
            Controls.Add(dataGridView1);
            Controls.Add(guna2TextBox3);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CatagoryForm";
            Text = "Product Catagory Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn catagory_id;
        private DataGridViewTextBoxColumn catagory_name;
        private DataGridViewTextBoxColumn catagory_description;
        private Button back_button;
    }
}