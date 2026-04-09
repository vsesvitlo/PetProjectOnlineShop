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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            listOfProducts = new ListBox();
            textBox6 = new TextBox();
            richTextBox1 = new RichTextBox();
            FinalCart = new ListBox();
            textBox7 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            listOfProducts.SelectionMode = SelectionMode.MultiSimple;
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
            richTextBox1.Size = new Size(243, 96);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "Description";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // FinalCart
            // 
            FinalCart.FormattingEnabled = true;
            FinalCart.ItemHeight = 25;
            FinalCart.Location = new Point(507, 34);
            FinalCart.Name = "FinalCart";
            FinalCart.Size = new Size(487, 379);
            FinalCart.TabIndex = 20;
            FinalCart.SelectedIndexChanged += Cart_SelectedIndexChanged;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(245, 282);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(47, 31);
            textBox7.TabIndex = 21;
            textBox7.Text = "1";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(200, 282);
            button3.Name = "button3";
            button3.Size = new Size(42, 31);
            button3.TabIndex = 22;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(292, 281);
            button4.Name = "button4";
            button4.Size = new Size(45, 31);
            button4.TabIndex = 23;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox7);
            Controls.Add(FinalCart);
            Controls.Add(richTextBox1);
            Controls.Add(textBox6);
            Controls.Add(listOfProducts);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox7;
        private Button button3;
        private Button button4;
    }
}
