using ConsoleAppOnlineShop;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SupermarketWinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<Product, double> productData; //product+ quantity
        Dictionary<string, Product> searchObject; // title + product
        ProductList productList;

        public Form1(Dictionary<Product, double> productData)
        {
            InitializeComponent();
            this.productData = productData;
            this.productList = new ProductList((productData));
            //listBox1.Items.Add(productData.Keys.ToArray()[0].title);
            this.searchObject = new Dictionary<string, Product>();
            foreach (Product item in productData.Keys)
            {
                searchObject.Add(item.title, item);
                listOfProducts.Items.Add(item.title);
            }
            Random random = new Random();
            listOfProducts.SelectedItem = searchObject.Keys.ToArray()[random.Next(0, searchObject.Keys.Count)];
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //usersdatabase--
            // cart++
            //Product bread = new Product("00001", "Fresh Bread", "Nice bread...", 77);

            Client client = new Client("Prague", "Hlavni", "227", new DateOnly(1991, 5, 15), "Jan", "B", "09cjfen", null, null, "997432");
            Cart cart = new Cart(DateTime.Now, new TimeSpan(0, 12, 6, 76), client, "");
            cart.AddProduct(searchObject[listOfProducts.SelectedItem.ToString()], 1);
            //MessageBox.Show(searchObject[listOfProducts.SelectedItem.ToString()].ToString());
            //MessageBox.Show(productList.productData.ContainsKey(searchObject[listOfProducts.SelectedItem.ToString()]).ToString());
            productList.RemoveProductQuantity(searchObject[listOfProducts.SelectedItem.ToString()], 1);
            MessageBox.Show((productList.ShowQuantity((searchObject[listOfProducts.SelectedItem.ToString()])).ToString()));

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

            if (listOfProducts.SelectedItem != null)
            {
                string selectedValue = listOfProducts.SelectedItem.ToString();
                textBox6.Text = searchObject[selectedValue].title;
                richTextBox1.Text = searchObject[selectedValue].description;
                textBox2.Text = searchObject[selectedValue].price.ToString();
                // MessageBox.Show($"You selected: {selectedValue}");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
