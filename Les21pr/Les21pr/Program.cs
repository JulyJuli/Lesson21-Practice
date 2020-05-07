using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Les21pr.Shop;

namespace Les21pr
{
    class Program
    {
        public static void Main(string[] args)
        {
            var shop = new OnlineShop();
            

            var annCustomer = new Customer() { Name = "Ann" };

            //shop.TestObject += annCustomer.ObjectHandler;

            shop.NewProductRecieved += annCustomer.GotNewGoods;
            var johnCustomer = new Customer() { Name = "John" };
            shop.NewProductRecieved += johnCustomer.GotNewGoods;
            shop.NewProductRecieved += johnCustomer.GoodsProcessing;

            var drink = new Product() { ProductName = "Gin", Cost = 1005, Category = ProductCategory.Drink };
            var milk = new Product() { ProductName = "Bur", Cost = 10, Category = ProductCategory.MilkProduct };

            shop.GoodRecieving(drink);
            shop.GoodRecieving(milk);


            Console.ReadKey();
        }
    }
}
