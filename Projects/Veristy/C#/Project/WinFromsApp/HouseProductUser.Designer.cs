namespace WinFormsApp
{
    partial class HouseProductUser
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

        #region Component Designer generated code

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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            product_id = new DataGridViewTextBoxColumn();
            product_quantity = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_price = new DataGridViewTextBoxColumn();
            sup_id = new DataGridViewTextBoxColumn();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            btn_add_to_cart = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 29);
            label4.TabIndex = 7;
            label4.Text = "All House Product";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product_id, product_quantity, product_name, product_price, sup_id });
            dataGridView1.Location = new Point(305, 11);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(542, 409);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // product_id
            // 
            product_id.HeaderText = "product_id";
            product_id.MinimumWidth = 6;
            product_id.Name = "product_id";
            product_id.Width = 85;
            // 
            // product_quantity
            // 
            product_quantity.HeaderText = "product_quantity";
            product_quantity.MinimumWidth = 6;
            product_quantity.Name = "product_quantity";
            product_quantity.Width = 125;
            // 
            // product_name
            // 
            product_name.HeaderText = "product_name";
            product_name.MinimumWidth = 6;
            product_name.Name = "product_name";
            product_name.Width = 115;
            // 
            // product_price
            // 
            product_price.HeaderText = "product_price";
            product_price.MinimumWidth = 6;
            product_price.Name = "product_price";
            product_price.Width = 130;
            // 
            // sup_id
            // 
            sup_id.HeaderText = "sup_id";
            sup_id.MinimumWidth = 6;
            sup_id.Name = "sup_id";
            sup_id.Width = 120;
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
            guna2TextBox1.Location = new Point(122, 79);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(157, 27);
            guna2TextBox1.TabIndex = 34;
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
            guna2TextBox2.Location = new Point(122, 137);
            guna2TextBox2.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(157, 27);
            guna2TextBox2.TabIndex = 35;
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
            guna2TextBox3.Location = new Point(122, 192);
            guna2TextBox3.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox3.Name = "guna2TextBox3";
            guna2TextBox3.PlaceholderText = "";
            guna2TextBox3.SelectedText = "";
            guna2TextBox3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox3.Size = new Size(157, 27);
            guna2TextBox3.TabIndex = 36;
            guna2TextBox3.TextChanged += guna2TextBox3_TextChanged;
            // 
            // btn_add_to_cart
            // 
            btn_add_to_cart.AutoRoundedCorners = true;
            btn_add_to_cart.CustomizableEdges = customizableEdges7;
            btn_add_to_cart.DisabledState.BorderColor = Color.DarkGray;
            btn_add_to_cart.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_add_to_cart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_add_to_cart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_add_to_cart.Font = new Font("Segoe UI", 9F);
            btn_add_to_cart.ForeColor = Color.White;
            btn_add_to_cart.Image = Properties.Resources.add1;
            btn_add_to_cart.Location = new Point(87, 316);
            btn_add_to_cart.Name = "btn_add_to_cart";
            btn_add_to_cart.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_add_to_cart.Size = new Size(115, 33);
            btn_add_to_cart.TabIndex = 37;
            btn_add_to_cart.Text = "Add to cart";
            btn_add_to_cart.Click += btn_add_to_cart_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel1.Location = new Point(22, 86);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(79, 21);
            guna2HtmlLabel1.TabIndex = 41;
            guna2HtmlLabel1.Text = "Product_id";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel2.Location = new Point(22, 145);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(44, 21);
            guna2HtmlLabel2.TabIndex = 42;
            guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel3.Location = new Point(22, 200);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(37, 21);
            guna2HtmlLabel3.TabIndex = 43;
            guna2HtmlLabel3.Text = "Price";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel4.Location = new Point(78, 256);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(119, 21);
            guna2HtmlLabel4.TabIndex = 46;
            guna2HtmlLabel4.Text = "Quantity needed";
            // 
            // guna2TextBox4
            // 
            guna2TextBox4.AutoRoundedCorners = true;
            guna2TextBox4.CustomizableEdges = customizableEdges9;
            guna2TextBox4.DefaultText = "";
            guna2TextBox4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Font = new Font("Segoe UI", 9F);
            guna2TextBox4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox4.Location = new Point(62, 282);
            guna2TextBox4.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox4.Name = "guna2TextBox4";
            guna2TextBox4.PlaceholderText = "";
            guna2TextBox4.SelectedText = "";
            guna2TextBox4.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2TextBox4.Size = new Size(161, 27);
            guna2TextBox4.TabIndex = 45;
            guna2TextBox4.TextChanged += guna2TextBox4_TextChanged;
            // 
            // HouseProductUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2TextBox4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btn_add_to_cart);
            Controls.Add(guna2TextBox3);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Name = "HouseProductUser";
            Size = new Size(893, 436);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2Button btn_add_to_cart;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_quantity;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_price;
        private DataGridViewTextBoxColumn sup_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
    }
}
