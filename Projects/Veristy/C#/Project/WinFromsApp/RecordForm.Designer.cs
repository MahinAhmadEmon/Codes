namespace WinFormsApp
{
    partial class RecordForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            search_text_box = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btn_search = new Guna.UI2.WinForms.Guna2Button();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            dataGridView1 = new DataGridView();
            Bill_id = new DataGridViewTextBoxColumn();
            Bill_date = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            order_no = new DataGridViewTextBoxColumn();
            customer_id = new DataGridViewTextBoxColumn();
            cart_id = new DataGridViewTextBoxColumn();
            btn_delete = new Guna.UI2.WinForms.Guna2Button();
            bill_id_textBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // search_text_box
            // 
            search_text_box.AutoRoundedCorners = true;
            search_text_box.CustomizableEdges = customizableEdges1;
            search_text_box.DefaultText = "";
            search_text_box.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            search_text_box.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            search_text_box.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            search_text_box.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            search_text_box.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            search_text_box.Font = new Font("Segoe UI", 9F);
            search_text_box.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            search_text_box.Location = new Point(13, 105);
            search_text_box.Margin = new Padding(3, 5, 3, 5);
            search_text_box.Name = "search_text_box";
            search_text_box.PlaceholderText = "";
            search_text_box.SelectedText = "";
            search_text_box.ShadowDecoration.CustomizableEdges = customizableEdges2;
            search_text_box.Size = new Size(179, 36);
            search_text_box.TabIndex = 46;
            search_text_box.TextChanged += search_text_box_TextChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel1.Location = new Point(13, 63);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(147, 26);
            guna2HtmlLabel1.TabIndex = 43;
            guna2HtmlLabel1.Text = "Search by Bill Id";
            // 
            // btn_search
            // 
            btn_search.AutoRoundedCorners = true;
            btn_search.CustomizableEdges = customizableEdges3;
            btn_search.DisabledState.BorderColor = Color.DarkGray;
            btn_search.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_search.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_search.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_search.Font = new Font("Segoe UI", 9F);
            btn_search.ForeColor = Color.White;
            btn_search.Image = Properties.Resources.search1;
            btn_search.Location = new Point(199, 105);
            btn_search.Margin = new Padding(3, 4, 3, 4);
            btn_search.Name = "btn_search";
            btn_search.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_search.Size = new Size(96, 36);
            btn_search.TabIndex = 40;
            btn_search.Text = "Search";
            btn_search.Click += btn_search_Click;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.Transparent;
            guna2CustomGradientPanel1.Controls.Add(dataGridView1);
            guna2CustomGradientPanel1.Controls.Add(btn_delete);
            guna2CustomGradientPanel1.Controls.Add(bill_id_textBox);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel3);
            guna2CustomGradientPanel1.Controls.Add(guna2HtmlLabel1);
            guna2CustomGradientPanel1.Controls.Add(search_text_box);
            guna2CustomGradientPanel1.Controls.Add(btn_search);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges9;
            guna2CustomGradientPanel1.FillColor = Color.LightSteelBlue;
            guna2CustomGradientPanel1.FillColor2 = Color.AliceBlue;
            guna2CustomGradientPanel1.FillColor4 = Color.RoyalBlue;
            guna2CustomGradientPanel1.Location = new Point(0, -1);
            guna2CustomGradientPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CustomGradientPanel1.Size = new Size(1132, 760);
            guna2CustomGradientPanel1.TabIndex = 50;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Bill_id, Bill_date, total_amount, order_no, customer_id, cart_id });
            dataGridView1.Location = new Point(168, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 460);
            dataGridView1.TabIndex = 51;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Bill_id
            // 
            Bill_id.HeaderText = "Bill_id";
            Bill_id.MinimumWidth = 6;
            Bill_id.Name = "Bill_id";
            Bill_id.Width = 125;
            // 
            // Bill_date
            // 
            Bill_date.HeaderText = "Bill_date";
            Bill_date.MinimumWidth = 6;
            Bill_date.Name = "Bill_date";
            Bill_date.Width = 125;
            // 
            // total_amount
            // 
            total_amount.HeaderText = "total_amount";
            total_amount.MinimumWidth = 6;
            total_amount.Name = "total_amount";
            total_amount.Width = 125;
            // 
            // order_no
            // 
            order_no.HeaderText = "order_no";
            order_no.MinimumWidth = 6;
            order_no.Name = "order_no";
            order_no.Width = 125;
            // 
            // customer_id
            // 
            customer_id.HeaderText = "customer_id";
            customer_id.MinimumWidth = 6;
            customer_id.Name = "customer_id";
            customer_id.Width = 125;
            // 
            // cart_id
            // 
            cart_id.HeaderText = "cart_id";
            cart_id.MinimumWidth = 6;
            cart_id.Name = "cart_id";
            cart_id.Width = 125;
            // 
            // btn_delete
            // 
            btn_delete.AutoRoundedCorners = true;
            btn_delete.CustomizableEdges = customizableEdges5;
            btn_delete.DisabledState.BorderColor = Color.DarkGray;
            btn_delete.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_delete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_delete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_delete.FillColor = Color.FromArgb(192, 0, 0);
            btn_delete.Font = new Font("Segoe UI", 9F);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.delete3;
            btn_delete.Location = new Point(893, 105);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_delete.Size = new Size(96, 36);
            btn_delete.TabIndex = 48;
            btn_delete.Text = "Delete";
            btn_delete.Click += btn_delete_Click;
            // 
            // bill_id_textBox
            // 
            bill_id_textBox.AutoRoundedCorners = true;
            bill_id_textBox.CustomizableEdges = customizableEdges7;
            bill_id_textBox.DefaultText = "";
            bill_id_textBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            bill_id_textBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            bill_id_textBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            bill_id_textBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            bill_id_textBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            bill_id_textBox.Font = new Font("Segoe UI", 9F);
            bill_id_textBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            bill_id_textBox.Location = new Point(695, 105);
            bill_id_textBox.Margin = new Padding(3, 5, 3, 5);
            bill_id_textBox.Name = "bill_id_textBox";
            bill_id_textBox.PlaceholderText = "";
            bill_id_textBox.SelectedText = "";
            bill_id_textBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            bill_id_textBox.Size = new Size(179, 36);
            bill_id_textBox.TabIndex = 49;
            bill_id_textBox.TextChanged += bill_id_textBox_TextChanged;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Tahoma", 12F);
            guna2HtmlLabel3.Location = new Point(695, 63);
            guna2HtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(54, 26);
            guna2HtmlLabel3.TabIndex = 50;
            guna2HtmlLabel3.Text = "Bill Id";
            // 
            // RecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1132, 760);
            Controls.Add(guna2CustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecordForm";
            Text = "recordsForm";
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox search_text_box;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2TextBox bill_id_textBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Bill_id;
        private DataGridViewTextBoxColumn Bill_date;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn order_no;
        private DataGridViewTextBoxColumn customer_id;
        private DataGridViewTextBoxColumn cart_id;
    }
}