using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOnlineShop
{
    public class ProductList
    {
        public Dictionary<Product, double> productData;

        public ProductList(Dictionary<Product, double> productData)
        {
            this.productData = productData;
        }
    }
}
