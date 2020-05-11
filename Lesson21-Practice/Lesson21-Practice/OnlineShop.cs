using System;
using System.Collections.Generic;

namespace Lesson21_Practice
{
     public class OnlineShop
    {
        private IList<Product> products = new List<Product>();
        public event EventHandler<GoodsInfoEventArgs> NewProductRecived = delegate { };
        public delegate decimal MyDelegate(decimal i);
        public event EventHandler<Object> TestObj = delegate { };
        public event MyDelegate TestEvent;
        public void GoodReciving(Product product)
        {
            products.Add(product);
            NewProductRecived(null, new GoodsInfoEventArgs() { Cost = product.Cost, ProductName = product.ProductName }) ;
            TestEvent?.Invoke(product.Cost);

            TestObj?.Invoke(null, new List<int>() { 1, 2, 3 });
        }

        

        

    }
}
