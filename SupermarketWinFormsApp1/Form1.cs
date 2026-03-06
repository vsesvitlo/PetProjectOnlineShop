using ConsoleAppOnlineShop;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SupermarketWinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<Product, double> productData; //product+ price
        Dictionary<string, Product> productList; // title + product

        public Form1(Dictionary<Product, double> productData)
        {
            InitializeComponent();
            this.productData = productData;
            //listBox1.Items.Add(productData.Keys.ToArray()[0].title);
            this.productList = new Dictionary<string, Product>();
            foreach (Product item in productData.Keys)
            {
                productList.Add(item.title, item);
                listBox2.Items.Add(item.title);
            }
            Random random = new Random();
            listBox2.SelectedItem = productList.Keys.ToArray()[random.Next( 0, productList.Keys.Count)];
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //usersdatabase--
            // cart++
            //Product bread = new Product("00001", "Fresh Bread", "Nice bread...", 77);

            Client client = new Client("Prague", "Hlavni", "227", new DateOnly(1991, 5, 15), "Jan", "Buchta", "09cjfen", null, null, "997432");
            Cart cart = new Cart(DateTime.Now, new TimeSpan(0, 12, 6, 76), client, "");
            //cart.AddProduct(productData., 1);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"Hello {textBox1.Text}");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem != null)
            {
                string selectedValue= listBox2.SelectedItem.ToString();
                textBox6.Text = productList[selectedValue].title;
                richTextBox1.Text = productList[selectedValue].description;
                textBox2.Text = productList[selectedValue].price.ToString();
               // MessageBox.Show($"You selected: {selectedValue}");
            }
        }
    }
}
