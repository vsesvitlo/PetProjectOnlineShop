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
            listOfProducts = new ListBox();
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(482, 373);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 0;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(202, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 147);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // button3
            // 
            button3.Location = new Point(200, 375);
            button3.Name = "button3";
            button3.Size = new Size(42, 31);
            button3.TabIndex = 22;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(301, 375);
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
            dataGridView1.Location = new Point(608, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(821, 420);
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
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(254, 375);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(2);
            label1.Size = new Size(28, 31);
            label1.TabIndex = 27;
            label1.Text = "1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(608, 470);
            label2.Name = "label2";
            label2.Size = new Size(658, 31);
            label2.TabIndex = 29;
            label2.Text = "Total:";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(1272, 470);
            label3.Name = "label3";
            label3.Size = new Size(157, 31);
            label3.TabIndex = 30;
            label3.Text = "0 czk";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(202, 246);
            label4.Name = "label4";
            label4.Size = new Size(371, 109);
            label4.TabIndex = 31;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Location = new Point(206, 203);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 32;
            label5.Text = "Title";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ControlLightLight;
            label7.Location = new Point(444, 203);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 34;
            label7.Text = "Quantity, store";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Location = new Point(355, 203);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 33;
            label6.Text = "Price, czk";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 554);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listOfProducts);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private ListBox listOfProducts;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private BindingSource cartBindingSource;
        private Label label1;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewButtonColumn Plus;
        private DataGridViewTextBoxColumn Quantities;
        private DataGridViewButtonColumn Minus;
        private DataGridViewTextBoxColumn PricePer1;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Remove;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}
