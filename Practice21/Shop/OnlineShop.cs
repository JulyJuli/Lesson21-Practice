using System;
using System.Collections.Generic;

namespace Practice21.Shop
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
