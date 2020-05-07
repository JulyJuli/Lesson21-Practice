using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21.Shop
{
    public class OnlineShop
    {
        private IList<Product> products = new List<Product>();

        public event EventHandler<GoodsInfoEventArgs> NewProductRecieved = delegate { };

        public void GoodRecieving(Product product)
        {
            products.Add(product);
            NewProductRecieved(null, new GoodsInfoEventArgs() { Cost = product.Cost, ProductName = product.ProductName });
        }
    }
}
