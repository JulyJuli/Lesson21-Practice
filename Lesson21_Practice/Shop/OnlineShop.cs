using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Practice.Shop
{
    public class OnlineShop
    {
        private IList<Product> products = new List<Product>();

        public event EventHandler<GoodsInfoEventArgs> NewProductReceived = delegate { };

        public void GoodReceiving(Product product)
        {
            products.Add(product);
            NewProductReceived(null, new GoodsInfoEventArgs() { Cost = product.Cost, ProductName = product.ProductName });
        }
    }
}
