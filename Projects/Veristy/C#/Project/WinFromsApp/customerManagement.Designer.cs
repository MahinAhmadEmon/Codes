namespace WinFormsApp
{
    partial class customerManagement
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dataGridView1 = new DataGridView();
            customer_id = new DataGridViewTextBoxColumn();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            contact_number = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            btn_delete = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Lucida Calligraphy", 25.25F);
            guna2HtmlLabel7.ForeColor = SystemColors.Desktop;
            guna2HtmlLabel7.Location = new Point(249, 13);
            guna2HtmlLabel7.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(387, 57);
            guna2HtmlLabel7.TabIndex = 22;
            guna2HtmlLabel7.Text = "Customer Details";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { customer_id, first_name, last_name, contact_number, password });
            dataGridView1.Location = new Point(377, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(673, 530);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // customer_id
            // 
            customer_id.HeaderText = "customer_id";
            customer_id.MinimumWidth = 6;
            customer_id.Name = "customer_id";
            customer_id.Width = 125;
            // 
            // first_name
            // 
            first_name.HeaderText = "first_name";
            first_name.MinimumWidth = 6;
            first_name.Name = "first_name";
            first_name.Width = 125;
            // 
            // last_name
            // 
            last_name.HeaderText = "last_name";
            last_name.MinimumWidth = 6;
            last_name.Name = "last_name";
            last_name.Width = 125;
            // 
            // contact_number
            // 
            contact_number.HeaderText = "contact_number";
            contact_number.MinimumWidth = 6;
            contact_number.Name = "contact_number";
            contact_number.Width = 125;
            // 
            // password
            // 
            password.HeaderText = "password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.AutoRoundedCorners = true;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(170, 105);
            guna2TextBox1.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(179, 36);
            guna2TextBox1.TabIndex = 24;
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.AutoRoundedCorners = true;
            guna2TextBox2.CustomizableEdges = customizableEdges3;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(170, 186);
            guna2TextBox2.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(179, 36);
            guna2TextBox2.TabIndex = 25;
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // guna2TextBox3
            // 
            guna2TextBox3.AutoRoundedCorners = true;
            guna2TextBox3.CustomizableEdges = customizableEdges5;
            guna2TextBox3.DefaultText = "";
            guna2TextBox3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Font = new Font("Segoe UI", 9F);
            guna2TextBox3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox3.Location = new Point(170, 269);
            guna2TextBox3.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox3.Size = new Size(179, 36);
            guna2TextBox3.TabIndex = 26;
            guna2TextBox3.TextChanged += guna2TextBox3_TextChanged;
            // 
            // guna2TextBox4
            // 
            guna2TextBox4.AutoRoundedCorners = true;
            guna2TextBox4.CustomizableEdges = customizableEdges7;
            guna2TextBox4.DefaultText = "";
            guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Font = new Font("Segoe UI", 9F);
            guna2TextBox4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Location = new Point(170, 348);
            guna2TextBox4.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox4.Name = "guna2TextBox4";
            guna2TextBox4.PlaceholderText = "";
            guna2TextBox4.SelectedText = "";
            guna2TextBox4.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox4.Size = new Size(179, 36);
            guna2TextBox4.TabIndex = 27;
            guna2TextBox4.TextChanged += guna2TextBox4_TextChanged;
            // 
            // guna2TextBox5
            // 
            guna2TextBox5.AutoRoundedCorners = true;
            guna2TextBox5.CustomizableEdges = customizableEdges9;
            guna2TextBox5.DefaultText = "";
            guna2TextBox5.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox5.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox5.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox5.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox5.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox5.Font = new Font("Segoe UI", 9F);
            guna2TextBox5.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox5.Location = new Point(170, 426);
            guna2TextBox5.Margin = new Padding(3, 5, 3, 5);
            guna2TextBox5.Name = "guna2TextBox5";
            guna2TextBox5.PlaceholderText = "";
            guna2TextBox5.SelectedText = "";
            guna2TextBox5.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox5.Size = new Size(179, 36);
            guna2TextBox5.TabIndex = 28;
            guna2TextBox5.TextChanged += guna2TextBox5_TextChanged;
            // 
            // btn_delete
            // 
            btn_delete.AutoRoundedCorners = true;
            btn_delete.CustomizableEdges = customizableEdges11;
            btn_delete.DisabledState.BorderColor = Color.DarkGray;
            btn_delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_delete.FillColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 9F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.delete2;
            btn_delete.Location = new Point(121, 509);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btn_delete.Size = new Size(131, 44);
            btn_delete.TabIndex = 29;
            btn_delete.Text = "Delete";
            btn_delete.Click += btn_delete_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Tahoma", 16F);
            guna2HtmlLabel2.ForeColor = SystemColors.ControlText;
            guna2HtmlLabel2.Location = new Point(36, 186);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(128, 35);
            guna2HtmlLabel2.TabIndex = 31;
            guna2HtmlLabel2.Text = "First name";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Tahoma", 16F);
            guna2HtmlLabel1.ForeColor = SystemColors.ControlText;
            guna2HtmlLabel1.Location = new Point(36, 270);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(125, 35);
            guna2HtmlLabel1.TabIndex = 32;
            guna2HtmlLabel1.Text = "Last name";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Tahoma", 16F);
            guna2HtmlLabel3.ForeColor = SystemColors.ControlText;
            guna2HtmlLabel3.Location = new Point(33, 106);
            guna2HtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(31, 35);
            guna2HtmlLabel3.TabIndex = 33;
            guna2HtmlLabel3.Text = "ID";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Tahoma", 16F);
            guna2HtmlLabel4.ForeColor = SystemColors.ControlText;
            guna2HtmlLabel4.Location = new Point(33, 349);
            guna2HtmlLabel4.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(93, 35);
            guna2HtmlLabel4.TabIndex = 34;
            guna2HtmlLabel4.Text = "Contact";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Tahoma", 16F);
            guna2HtmlLabel5.ForeColor = SystemColors.ControlText;
            guna2HtmlLabel5.Location = new Point(33, 427);
            guna2HtmlLabel5.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(116, 35);
            guna2HtmlLabel5.TabIndex = 35;
            guna2HtmlLabel5.Text = "Password";
            // 
            // customerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1206, 643);
            Controls.Add(guna2HtmlLabel5);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(btn_delete);
            Controls.Add(guna2TextBox5);
            Controls.Add(guna2TextBox4);
            Controls.Add(guna2TextBox3);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(guna2HtmlLabel7);
            ForeColor = SystemColors.InactiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Name = "customerManagement";
            Text = "customer_management";
            Load += customerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn contact_number;
        private DataGridViewTextBoxColumn password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}