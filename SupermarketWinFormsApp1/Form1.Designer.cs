namespace SupermarketWinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            listOfProducts = new ListBox();
            textBox6 = new TextBox();
            richTextBox1 = new RichTextBox();
            FinalCart = new ListBox();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Plus = new DataGridViewButtonColumn();
            Quantities = new DataGridViewTextBoxColumn();
            Minus = new DataGridViewButtonColumn();
            PricePer1 = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewButtonColumn();
            productBindingSource = new BindingSource(components);
            cartBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(352, 281);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 0;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(200, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 94);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 31);
            textBox2.TabIndex = 3;
            textBox2.Text = "Price";
            // 
            // listOfProducts
            // 
            listOfProducts.FormattingEnabled = true;
            listOfProducts.ItemHeight = 25;
            listOfProducts.Location = new Point(12, 34);
            listOfProducts.Name = "listOfProducts";
            listOfProducts.Size = new Size(180, 379);
            listOfProducts.TabIndex = 17;
            listOfProducts.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(210, 142);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(157, 31);
            textBox6.TabIndex = 18;
            textBox6.Text = "Title";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(200, 179);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(327, 97);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "Description";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // FinalCart
            // 
            FinalCart.FormattingEnabled = true;
            FinalCart.ItemHeight = 25;
            FinalCart.Location = new Point(198, 334);
            FinalCart.Name = "FinalCart";
            FinalCart.Size = new Size(245, 104);
            FinalCart.TabIndex = 20;
            FinalCart.SelectedIndexChanged += Cart_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(203, 282);
            button3.Name = "button3";
            button3.Size = new Size(42, 31);
            button3.TabIndex = 22;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(298, 282);
            button4.Name = "button4";
            button4.Size = new Size(45, 31);
            button4.TabIndex = 23;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeight = 54;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product, Plus, Quantities, Minus, PricePer1, Price, Remove });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Location = new Point(583, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(821, 242);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 8;
            Product.Name = "Product";
            Product.Width = 110;
            // 
            // Plus
            // 
            Plus.HeaderText = "Plus";
            Plus.MinimumWidth = 8;
            Plus.Name = "Plus";
            Plus.Resizable = DataGridViewTriState.True;
            Plus.SortMode = DataGridViewColumnSortMode.Automatic;
            Plus.Text = "+";
            Plus.Width = 80;
            // 
            // Quantities
            // 
            Quantities.HeaderText = "Quantity";
            Quantities.MinimumWidth = 8;
            Quantities.Name = "Quantities";
            Quantities.Width = 116;
            // 
            // Minus
            // 
            Minus.HeaderText = "Minus";
            Minus.MinimumWidth = 8;
            Minus.Name = "Minus";
            Minus.Resizable = DataGridViewTriState.True;
            Minus.SortMode = DataGridViewColumnSortMode.Automatic;
            Minus.Text = "-";
            Minus.Width = 96;
            // 
            // PricePer1
            // 
            PricePer1.HeaderText = "Price per 1 product";
            PricePer1.MinimumWidth = 8;
            PricePer1.Name = "PricePer1";
            PricePer1.Width = 199;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 85;
            // 
            // Remove
            // 
            Remove.HeaderText = "Remove";
            Remove.MinimumWidth = 8;
            Remove.Name = "Remove";
            Remove.Resizable = DataGridViewTriState.True;
            Remove.SortMode = DataGridViewColumnSortMode.Automatic;
            Remove.Text = "Remove";
            Remove.Width = 112;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(ConsoleAppOnlineShop.Product);
            // 
            // cartBindingSource
            // 
            cartBindingSource.DataSource = typeof(ConsoleAppOnlineShop.Cart);
            cartBindingSource.CurrentChanged += cartBindingSource_CurrentChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(608, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 31);
            textBox1.TabIndex = 25;
            textBox1.Text = "Total: ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1107, 314);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 31);
            textBox3.TabIndex = 26;
            textBox3.Text = "0 czk";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(257, 283);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(2);
            label1.Size = new Size(28, 31);
            label1.TabIndex = 27;
            label1.Text = "1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(426, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 31);
            textBox4.TabIndex = 28;
            textBox4.Text = "Quantity, store";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 554);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(FinalCart);
            Controls.Add(richTextBox1);
            Controls.Add(textBox6);
            Controls.Add(listOfProducts);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private ListBox listOfProducts;
        private TextBox textBox6;
        private RichTextBox richTextBox1;
        private ListBox FinalCart;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private BindingSource cartBindingSource;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label1;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewButtonColumn Plus;
        private DataGridViewTextBoxColumn Quantities;
        private DataGridViewButtonColumn Minus;
        private DataGridViewTextBoxColumn PricePer1;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Remove;
        private TextBox textBox4;
    }
}
