using System;
using System.Collections.Generic;
using System.Text;

namespace Practice21.Shop
{
    public class OnlineShop
    {
        private IList<Product> products = new List<Product>();
        public event EventHandler<GoodsInfoEventArgs> NewProductRecieved = delegate { };

        public event EventHandler<object> TestObject = delegate { };

        public delegate decimal MyDelegate(decimal i);
        public event MyDelegate TestEvent;

        public void GoodRecieving(Product product)
        {
            products.Add(product);
            NewProductRecieved(null, new GoodsInfoEventArgs() { Cost = product.Cost, ProductName = product.ProductName });
           // TestEvent?.Invoke(product.Cost);

            TestObject?.Invoke(null, new List<int> { 1, 2, 3 });
        }

    }
}
