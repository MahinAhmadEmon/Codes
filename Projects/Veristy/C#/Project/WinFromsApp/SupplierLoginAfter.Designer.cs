namespace WinFormsApp1
{
    partial class SupplierLoginAfter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            dataGridView1 = new DataGridView();
            product_id = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_quantity = new DataGridViewTextBoxColumn();
            product_price = new DataGridViewTextBoxColumn();
            button5 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            create_button = new Button();
            label1 = new Label();
            button1 = new Button();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.Transparent;
            guna2CustomGradientPanel1.Controls.Add(dataGridView1);
            guna2CustomGradientPanel1.Controls.Add(button5);
            guna2CustomGradientPanel1.Controls.Add(button3);
            guna2CustomGradientPanel1.Controls.Add(textBox4);
            guna2CustomGradientPanel1.Controls.Add(textBox3);
            guna2CustomGradientPanel1.Controls.Add(textBox2);
            guna2CustomGradientPanel1.Controls.Add(label5);
            guna2CustomGradientPanel1.Controls.Add(label4);
            guna2CustomGradientPanel1.Controls.Add(label3);
            guna2CustomGradientPanel1.Controls.Add(label2);
            guna2CustomGradientPanel1.Controls.Add(textBox1);
            guna2CustomGradientPanel1.Controls.Add(create_button);
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.Controls.Add(button1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.Aqua;
            guna2CustomGradientPanel1.FillColor2 = Color.LightYellow;
            guna2CustomGradientPanel1.FillColor3 = Color.Cornsilk;
            guna2CustomGradientPanel1.FillColor4 = Color.DarkOrange;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Margin = new Padding(3, 4, 3, 4);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(1131, 768);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product_id, product_name, product_quantity, product_price });
            dataGridView1.Location = new Point(171, 479);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(763, 188);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // product_id
            // 
            product_id.HeaderText = "product_id";
            product_id.MinimumWidth = 6;
            product_id.Name = "product_id";
            product_id.Width = 180;
            // 
            // product_name
            // 
            product_name.HeaderText = "product_name";
            product_name.MinimumWidth = 6;
            product_name.Name = "product_name";
            product_name.Width = 180;
            // 
            // product_quantity
            // 
            product_quantity.HeaderText = "product_quantity";
            product_quantity.MinimumWidth = 6;
            product_quantity.Name = "product_quantity";
            product_quantity.Width = 180;
            // 
            // product_price
            // 
            product_price.HeaderText = "product_price";
            product_price.MinimumWidth = 6;
            product_price.Name = "product_price";
            product_price.Width = 170;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(686, 428);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 15;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(533, 428);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(533, 182);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(533, 236);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(533, 288);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 292);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 236);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 288);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(392, 184);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 4;
            label2.Text = "product Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(533, 127);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // create_button
            // 
            create_button.BackColor = Color.Transparent;
            create_button.ForeColor = Color.Black;
            create_button.Location = new Point(380, 428);
            create_button.Margin = new Padding(3, 4, 3, 4);
            create_button.Name = "create_button";
            create_button.Size = new Size(86, 31);
            create_button.TabIndex = 2;
            create_button.Text = "Create";
            create_button.UseVisualStyleBackColor = false;
            create_button.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(392, 130);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Product ID";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(27, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SupplierLoginAfter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 768);
            Controls.Add(guna2CustomGradientPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SupplierLoginAfter";
            Text = "Supplier Login After";
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button create_button;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Button button5;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_quantity;
        private DataGridViewTextBoxColumn product_price;
    }
}
