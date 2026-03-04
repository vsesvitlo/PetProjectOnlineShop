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
            productData.Add(new Product("00002", "Fresh Milk", "fresh milk...", 24), 1);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(productData));
        }
    }
}