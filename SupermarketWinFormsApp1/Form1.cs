using ConsoleAppOnlineShop;
using System.Collections.Generic;

namespace SupermarketWinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<Product, double> productData;

        public Form1(Dictionary<Product, double> productData)
        {
            InitializeComponent();
            this.productData = productData;
            listBox1.Items.Add(productData.Keys.ToArray()[0].title);
            
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


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
