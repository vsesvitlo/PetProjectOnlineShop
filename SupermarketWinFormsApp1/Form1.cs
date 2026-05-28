using ConsoleAppOnlineShop;
using System.Collections.Generic;
using System.Reflection.Emit;
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
            LoadNewPict();
        }
        private void LoadNewPict()
        {
            try
            {
                string productName = searchObject[listOfProducts.SelectedItem.ToString()].title;
                // You should replace the bold image
                // in the sample below with an icon of your own choosing.
                // Note the escape character used (@) when specifying the path.
                //MessageBox.Show(System.Environment.CurrentDirectory);
                pictureBox1.Image = Image.FromFile
                (System.Environment.CurrentDirectory
                + $@"\Images\{productName}.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pictureBox1.Image = Image.FromFile
                (System.Environment.CurrentDirectory
                + @"\Images\Default.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        //C:\Users\user\source\repos\PetProjectOnlineShop\SupermarketWinFormsApp1\Images
        private void button1_Click(object sender, EventArgs e)
        {
            if (productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]) > 0)
            {
                cart.AddProduct(searchObject[listOfProducts.SelectedItem.ToString()], quantity);
                productList.RemoveProductQuantity(searchObject[listOfProducts.SelectedItem.ToString()], quantity);
                bool check = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    if (item.Cells[0].Value == listOfProducts.SelectedItem)
                    {
                        double allQuantity = quantity + int.Parse(item.Cells[2].Value.ToString());
                        item.Cells[2].Value = allQuantity;
                        item.Cells[5].Value = allQuantity * searchObject[listOfProducts.SelectedItem.ToString()].price;
                        check = true;
                        SetLabel3(cart.CalculationSum());
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
                    SetLabel3(cart.CalculationSum());
                }
                label7.Text = productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]).ToString() + " items";
                quantity = 1;
                label1.Text = quantity.ToString();
            }
            else
            {
                MessageBox.Show("It is all that we have!");
            }
            LoadNewPict();
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

            }
            LoadNewPict();
        }
        public void ChangeItem(object sender, EventArgs e)
        {
            quantity = 1;
            label1.Text = quantity.ToString();
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
            {
                MessageBox.Show("It is all that we have!");

            }
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

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Remove" ||
                (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) < 2 &&
                dataGridView1.Columns[e.ColumnIndex].Name == "Minus"))//?
            {
                int reverse = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                productList.AddProductQuantity(searchObject[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()], reverse);
                cart.RemoveProductQuantity(searchObject[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()], reverse);
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                SetLabel3(cart.CalculationSum());
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Plus")
            {

                double allQuantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) + 1;
                dataGridView1.Rows[e.RowIndex].Cells[5].Value = allQuantity * int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                double reverse = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                if (productList.ShowQuantity(searchObject[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()]) > 0)
                {
                    reverse += 1;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = reverse;
                    productList.RemoveProductQuantity(searchObject[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()], 1);
                    cart.AddProduct(searchObject[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()], 1);
                    SetLabel3(cart.CalculationSum());

                }
                else
                {
                    MessageBox.Show("It is all that we have!");
                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Minus") {
                double reverse = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) >= 0) //?
                {
                    reverse -= 1;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = reverse;
                    productList.AddProductQuantity(searchObject[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()], 1);
                    cart.DecreaseProduct(searchObject[dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()], 1);
                    SetLabel3(cart.CalculationSum());
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }

            label7.Text = productList.ShowQuantity(searchObject[listOfProducts.SelectedItem.ToString()]).ToString() + " items";
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[0].Value == listOfProducts.SelectedItem)
                {
                    item.Cells[5].Value = int.Parse(item.Cells[2].Value.ToString())
                        * searchObject[item.Cells[0].Value.ToString()].price;
                }
            }

        }
       
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = quantity.ToString();
        }

        private void SetLabel3(double sum, string czk = " czk")
        {
            label3.Text = sum.ToString() + czk;
        
        }
    }
}
