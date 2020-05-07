using System;
using System.Collections.Generic;

namespace Development
{
    public class OnlineShop
    {
        private IList<Product> products = new List<Product>();

        public event EventHandler<GoodsInfoEventArgs> NewProduct = delegate { };

        public void GoodReciving(Product product)
        {
            products.Add(product);
            NewProduct(null, new GoodsInfoEventArgs{Price = product.Price, Name = product.Name});
        }
    }
}
