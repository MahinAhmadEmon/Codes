namespace WinFormsApp
{
    partial class Cart
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            button4 = new Button();
            Create_bill = new Button();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            get_Total_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            btn_delete_from_cart = new Guna.UI2.WinForms.Guna2Button();
            btn_get_total_price = new Guna.UI2.WinForms.Guna2Button();
            product_id_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new DataGridView();
            product_id = new DataGridViewTextBoxColumn();
            product_quantity = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_price = new DataGridViewTextBoxColumn();
            sup_id = new DataGridViewTextBoxColumn();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(446, 70);
            label1.TabIndex = 0;
            label1.Text = "Shopping Cart";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(25, 632);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(110, 48);
            button4.TabIndex = 7;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Create_bill
            // 
            Create_bill.AutoEllipsis = true;
            Create_bill.BackColor = SystemColors.ActiveCaption;
            Create_bill.Location = new Point(181, 340);
            Create_bill.Name = "Create_bill";
            Create_bill.Size = new Size(140, 66);
            Create_bill.TabIndex = 24;
            Create_bill.Text = "Create bill";
            Create_bill.UseVisualStyleBackColor = false;
            Create_bill.Click += Create_bill_Click;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(get_Total_textbox);
            guna2CustomGradientPanel1.Controls.Add(btn_delete_from_cart);
            guna2CustomGradientPanel1.Controls.Add(btn_get_total_price);
            guna2CustomGradientPanel1.Controls.Add(product_id_textbox);
            guna2CustomGradientPanel1.Controls.Add(dataGridView1);
            guna2CustomGradientPanel1.Controls.Add(Create_bill);
            guna2CustomGradientPanel1.Controls.Add(button4);
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges9;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.SkyBlue;
            guna2CustomGradientPanel1.FillColor2 = Color.LightSkyBlue;
            guna2CustomGradientPanel1.FillColor3 = Color.Cyan;
            guna2CustomGradientPanel1.FillColor4 = Color.DodgerBlue;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CustomGradientPanel1.Size = new Size(1222, 709);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // get_Total_textbox
            // 
            get_Total_textbox.CustomizableEdges = customizableEdges1;
            get_Total_textbox.DefaultText = "";
            get_Total_textbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            get_Total_textbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            get_Total_textbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            get_Total_textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            get_Total_textbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            get_Total_textbox.Font = new Font("Segoe UI", 9F);
            get_Total_textbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            get_Total_textbox.Location = new Point(247, 164);
            get_Total_textbox.Margin = new Padding(3, 5, 3, 5);
            get_Total_textbox.Name = "get_Total_textbox";
            get_Total_textbox.PlaceholderText = "";
            get_Total_textbox.SelectedText = "";
            get_Total_textbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            get_Total_textbox.Size = new Size(179, 36);
            get_Total_textbox.TabIndex = 40;
            get_Total_textbox.TextChanged += get_Total_textbox_TextChanged;
            // 
            // btn_delete_from_cart
            // 
            btn_delete_from_cart.AutoRoundedCorners = true;
            btn_delete_from_cart.BackColor = Color.LightSkyBlue;
            btn_delete_from_cart.CustomizableEdges = customizableEdges3;
            btn_delete_from_cart.DisabledState.BorderColor = Color.DarkGray;
            btn_delete_from_cart.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_delete_from_cart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_delete_from_cart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_delete_from_cart.FillColor = Color.FromArgb(192, 0, 0);
            btn_delete_from_cart.Font = new Font("Segoe UI", 9F);
            btn_delete_from_cart.ForeColor = Color.White;
            btn_delete_from_cart.Image = Properties.Resources.delete1;
            btn_delete_from_cart.Location = new Point(88, 245);
            btn_delete_from_cart.Margin = new Padding(3, 4, 3, 4);
            btn_delete_from_cart.Name = "btn_delete_from_cart";
            btn_delete_from_cart.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_delete_from_cart.Size = new Size(142, 36);
            btn_delete_from_cart.TabIndex = 39;
            btn_delete_from_cart.Text = "Delete from cart";
            btn_delete_from_cart.Click += btn_delete_from_cart_Click;
            // 
            // btn_get_total_price
            // 
            btn_get_total_price.AutoRoundedCorners = true;
            btn_get_total_price.BackColor = Color.LightSkyBlue;
            btn_get_total_price.CustomizableEdges = customizableEdges5;
            btn_get_total_price.DisabledState.BorderColor = Color.DarkGray;
            btn_get_total_price.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_get_total_price.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_get_total_price.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_get_total_price.FillColor = Color.Yellow;
            btn_get_total_price.Font = new Font("Segoe UI", 9F);
            btn_get_total_price.ForeColor = Color.Black;
            btn_get_total_price.Image = Properties.Resources.add1;
            btn_get_total_price.Location = new Point(88, 164);
            btn_get_total_price.Margin = new Padding(3, 4, 3, 4);
            btn_get_total_price.Name = "btn_get_total_price";
            btn_get_total_price.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_get_total_price.Size = new Size(142, 44);
            btn_get_total_price.TabIndex = 38;
            btn_get_total_price.Text = "Get total price";
            btn_get_total_price.Click += btn_get_total_price_Click;
            // 
            // product_id_textbox
            // 
            product_id_textbox.CustomizableEdges = customizableEdges7;
            product_id_textbox.DefaultText = "";
            product_id_textbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            product_id_textbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            product_id_textbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            product_id_textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            product_id_textbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            product_id_textbox.Font = new Font("Segoe UI", 9F);
            product_id_textbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            product_id_textbox.Location = new Point(247, 245);
            product_id_textbox.Margin = new Padding(3, 5, 3, 5);
            product_id_textbox.Name = "product_id_textbox";
            product_id_textbox.PlaceholderText = "";
            product_id_textbox.SelectedText = "";
            product_id_textbox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            product_id_textbox.Size = new Size(179, 36);
            product_id_textbox.TabIndex = 35;
            product_id_textbox.TextChanged += product_id_textbox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product_id, product_quantity, product_name, product_price, sup_id });
            dataGridView1.Location = new Point(509, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(621, 545);
            dataGridView1.TabIndex = 34;
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
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 709);
            Controls.Add(guna2CustomGradientPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cart";
            Text = "Cart";
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button4;
        private Button Create_bill;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox product_id_textbox;
        private Guna.UI2.WinForms.Guna2Button btn_get_total_price;
        private Guna.UI2.WinForms.Guna2Button btn_delete_from_cart;
        private Guna.UI2.WinForms.Guna2TextBox get_Total_textbox;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_quantity;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_price;
        private DataGridViewTextBoxColumn sup_id;
    }
}