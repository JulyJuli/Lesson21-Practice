using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork21.Shop
{
   public class OnlineShop
    {
        private IList<Product> products = new List<Product>();
        public event EventHandler<GoodsInfoEventsArgs> NewProductReceived = delegate { };
        public event EventHandler <object>TestObject = delegate { };

        public void GoodRecieving(Product product)
        {
            products.Add(product);
            NewProductReceived(null, new GoodsInfoEventsArgs() { Cost = product.Cost, ProductName = product.ProductName });

            TestObject?.Invoke(null, new List<int>() { 1, 2, 3 });
        }
    }
}
