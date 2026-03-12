using ConsoleAppOnlineShop;

namespace SupermarketWinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Dictionary<Product, double> productData = new Dictionary<Product, double>();
            productData.Add(new Product("00001", "Fresh Bread", "Nice bread...", 77), 1);
            productData.Add(new Product("00002", "Whole Wheat Bread", "whole wheat bread...", 78), 1);
            productData.Add(new Product("00003", "Butter", "creamy butter...", 112), 1);
            productData.Add(new Product("00004", "Cheddar Cheese", "aged cheddar cheese...", 115), 1);
            productData.Add(new Product("00005", "Eggs Pack", "farm fresh eggs...", 90), 1);
            productData.Add(new Product("00006", "Orange Juice", "fresh orange juice...", 90), 1);
            productData.Add(new Product("00007", "Apple", "red apple...", 10), 1);
            productData.Add(new Product("00008", "Banana", "banana...", 15), 1);
            productData.Add(new Product("00009", "Chicken Breast", "boneless chicken breast...", 160), 1);
            productData.Add(new Product("00010", "Ground Beef", "fresh ground beef...", 344), 1);
            productData.Add(new Product("00011", "Tomato", "fresh tomato...", 40), 1);
            productData.Add(new Product("00012", "Cucumber", "green cucumber...", 35), 1);
            productData.Add(new Product("00013", "Potato", "organic potato...", 30), 1);
            productData.Add(new Product("00014", "Onion", "yellow onion...", 15), 1);
            productData.Add(new Product("00015", "Garlic", "fresh garlic...", 125), 1);
            productData.Add(new Product("00016", "Pasta", "durum wheat pasta...", 32), 1);
            productData.Add(new Product("00017", "Rice", "long grain rice...", 58), 1);
            productData.Add(new Product("00018", "Olive Oil", "extra virgin olive oil...", 100), 1);
            productData.Add(new Product("00019", "Yogurt", "natural yogurt...", 22), 1);
            productData.Add(new Product("00020", "Strawberry Jam", "sweet strawberry jam...", 114), 1);
            productData.Add(new Product("00021", "Peanut Butter", "smooth peanut butter...", 83), 1);
            productData.Add(new Product("00022", "Corn Flakes", "crispy corn flakes...", 87), 1);
            productData.Add(new Product("00023", "Chocolate Bar", "milk chocolate bar...", 76), 1);
            productData.Add(new Product("00024", "Green Tea", "organic green tea...", 119), 1);
            productData.Add(new Product("00025", "Coffee Beans", "roasted coffee beans...", 111), 1);
            productData.Add(new Product("00026", "Fresh Milk", "fresh milk...", 24), 1);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(productData));
        }
    }
}