using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOnlineShop
{
    public class Cart
    {
        public string productTitle;
        public DateTime timeOrder;
        public TimeSpan timeDelivery;
        public Client user;
        public string commentsCurrier;
        public Dictionary<Product, double> order;

        public Cart(string productTitle, DateTime timeOrder, TimeSpan timeDelivery, Client user, string commentsCurrier)
        {
            this.productTitle = productTitle;
            this.timeOrder = timeOrder;
            this.timeDelivery = timeDelivery;
            this.user = user;
            this.commentsCurrier = commentsCurrier;
            this.order = new Dictionary<Product, double>();
        }
        //+ CalculationSum(double) : double
        public void AddProduct(Product product)
        {
            order.Add(product, 1);
        }
    }
}
