using ConsoleAppOnlineShop;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SupermarketWinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<Product, double> productData; //product+ quantity
        Dictionary<string, Product> searchObject; // title + product
        ProductList productList;
        int quantity;
        Client client;
        Cart cart;

        public Form1(Dictionary<Product, double> productData)
        {
            InitializeComponent();
            this.productData = productData;
            this.productList = new ProductList((productData));
            //listBox1.Items.Add(productData.Keys.ToArray()[0].title);
            this.searchObject = new Dictionary<string, Product>();
            quantity = 1;
            client = new Client("Prague", "Hlavni", "227", new DateOnly(1991, 5, 15), "Jan", "B", "09cjfen", null, null, "997432");
            cart = new Cart(DateTime.Now, new TimeSpan(0, 12, 6, 76), client, "");
            foreach (Product item in productData.Keys)
            {
                searchObject.Add(item.title, item);
                listOfProducts.Items.Add(item.title);
            }
            Random random = new Random();
            listOfProducts.SelectedItem = searchObject.Keys.ToArray()[random.Next(0, searchObject.Keys.Count)];
            listOfProducts.SelectedValueChanged += ChangeItem;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]) > 0)
            {
                cart.AddProduct(searchObject[listOfProducts.SelectedItem.ToString()], quantity);
                FinalCart.Items.Add(listOfProducts.SelectedItem.ToString());
                //MessageBox.Show(searchObject[listOfProducts.SelectedItem.ToString()].ToString());
                //MessageBox.Show(productList.productData.ContainsKey(searchObject[listOfProducts.SelectedItem.ToString()]).ToString());
                productList.RemoveProductQuantity(searchObject[listOfProducts.SelectedItem.ToString()], quantity);
                //MessageBox.Show((productList.ShowQuantity((searchObject[listOfProducts.SelectedItem.ToString()])).ToString()));
                bool check = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    if (item.Cells[0].Value == listOfProducts.SelectedItem)
                    {
                        double allQuantity = quantity + int.Parse(item.Cells[2].Value.ToString());
                        item.Cells[2].Value = allQuantity;
                        item.Cells[5].Value = allQuantity * searchObject[listOfProducts.SelectedItem.ToString()].price;
                        check = true;
                        label3.Text = cart.CalculationSum().ToString();
                    }
                }
                if (check == false)
                {
                    dataGridView1.Rows.Add(
                        searchObject[listOfProducts.SelectedItem.ToString()].title,
                        Plus.Text,
                        quantity,
                        Minus.Text,
                        searchObject[listOfProducts.SelectedItem.ToString()].price,
                        searchObject[listOfProducts.SelectedItem.ToString()].price * quantity,
                        Remove.Text
                        );
                    // MessageBox.Show($"You selected: {Plus.Text.GetType()}");
                    label3.Text = cart.CalculationSum().ToString();

                }
                textBox4.Text = productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]).ToString() + " items";
                quantity = 1;
                label1.Text = quantity.ToString();
            }
            else
            {
                MessageBox.Show("It is all that we have!");

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listOfProducts.SelectedItem != null)
            {
                string selectedValue = listOfProducts.SelectedItem.ToString();
                label5.Text = searchObject[selectedValue].title;
                label4.Text = searchObject[selectedValue].description;
                label6.Text = searchObject[selectedValue].price.ToString() + " czk";
                label7.Text = productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]).ToString() + " items";

                //MessageBox.Show($"You selected: {selectedValue}");
            }

        }
        public void ChangeItem(object sender, EventArgs e)
        {
            quantity = 1;
            label1.Text = quantity.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // +
            if (quantity < productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]))
            {
                quantity += 1;
                label1.Text = quantity.ToString();
            }
            else
            //if (quantity == productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]))
            {
                MessageBox.Show("It is all that we have!");

            }
            /*else
            {
                MessageBox.Show("Please, enter the lower quantity.");
                quantity = (int)(productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]));
                label1.Text = quantity.ToString();
            }*/


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //-

            if (quantity > 1)
            {
                quantity -= 1;
                label1.Text = quantity.ToString();
            }
            else
            {
                MessageBox.Show("The quantity of the product can not be less than 1");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
            {

                int reverse = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                productList.AddProductQuantity(searchObject[listOfProducts.SelectedItem.ToString()], reverse);

                dataGridView1.Rows.RemoveAt(e.RowIndex);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Plus")
            {
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                double reverse = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                //reverse += 1;
                if (productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]) > 0)
                {
                    reverse += 1;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = reverse;
                    productList.RemoveProductQuantity(searchObject[listOfProducts.SelectedItem.ToString()], 1);

                }
                else
                {
                    MessageBox.Show("It is all that we have!");
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Minus")
            {

                double reverse = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]) > 0)
                {
                    reverse -= 1;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = reverse;
                    productList.AddProductQuantity(searchObject[listOfProducts.SelectedItem.ToString()], 1);

                }
            }
            textBox4.Text = productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]).ToString() + " items";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = quantity.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.RemoveAt();
            //(searchObject[listOfProducts.SelectedItem.ToString()].title, 0, quantity, 0, searchObject[listOfProducts.SelectedItem.ToString()].price, searchObject[listOfProducts.SelectedItem.ToString()].price * quantity);

        }

        private void cartBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
