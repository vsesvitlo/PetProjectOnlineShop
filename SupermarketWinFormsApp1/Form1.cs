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
                    textBox3.Text = cart.CalculationSum().ToString();
                }
            }
            if (check == false)
            {
                dataGridView1.Rows.Add(
                    searchObject[listOfProducts.SelectedItem.ToString()].title,
                    Plus.UseColumnTextForButtonValue,
                    quantity,
                    Minus.UseColumnTextForButtonValue, 
                    searchObject[listOfProducts.SelectedItem.ToString()].price, 
                    searchObject[listOfProducts.SelectedItem.ToString()].price * quantity, 
                    Remove.UseColumnTextForButtonValue
                    );
               // MessageBox.Show($"You selected: {Plus.Text.GetType()}");
                textBox3.Text = cart.CalculationSum().ToString();

            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listOfProducts.SelectedItem != null)
            {
                string selectedValue = listOfProducts.SelectedItem.ToString();
                textBox6.Text = searchObject[selectedValue].title;
                richTextBox1.Text = searchObject[selectedValue].description;
                textBox2.Text = searchObject[selectedValue].price.ToString();
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
            quantity += 1;
            label1.Text = quantity.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //-

            if (quantity > 0)
            {
                quantity -= 1;
                label1.Text = quantity.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove")
            {
                dataGridView1.Rows.RemoveAt(e.ColumnIndex);
            }
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
    }
}
