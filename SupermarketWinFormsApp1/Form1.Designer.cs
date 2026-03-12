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
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            listOfProducts = new ListBox();
            textBox6 = new TextBox();
            richTextBox1 = new RichTextBox();
            FinalCart = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(366, 271);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 0;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(297, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 90);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(587, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(511, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(504, 38);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(587, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 138);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(587, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 193);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 15;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(594, 189);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(544, 309);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            textBox6.Location = new Point(299, 135);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 18;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(297, 172);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(153, 84);
            richTextBox1.TabIndex = 19;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // FinalCart
            // 
            FinalCart.FormattingEnabled = true;
            FinalCart.ItemHeight = 25;
            FinalCart.Location = new Point(859, 23);
            FinalCart.Name = "FinalCart";
            FinalCart.Size = new Size(180, 379);
            FinalCart.TabIndex = 20;
            FinalCart.SelectedIndexChanged += Cart_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 450);
            Controls.Add(FinalCart);
            Controls.Add(richTextBox1);
            Controls.Add(textBox6);
            Controls.Add(listOfProducts);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Button button2;
        private ListBox listOfProducts;
        private TextBox textBox6;
        private RichTextBox richTextBox1;
        private ListBox FinalCart;
    }
}
