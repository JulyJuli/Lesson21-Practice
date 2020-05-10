using ClassWork21.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shop = new OnlineShop();
            var annCustomer = new Customer() { Name = "Ann" };
            //shop.NewProductReceived += annCustomer.GotNewGoods;
            //shop.NewProductReceived += annCustomer.GoodsProcessing;
            shop.TestObject += annCustomer.ObjectHandler;

            //var johnCustomer = new Customer() { Name = "John" };
            //shop.NewProductReceived += johnCustomer.GotNewGoods;

            var drink = new Product() { ProductName = "Jin", Cost = 1000, Category = ProductCategory.Drink };
            var milk= new Product() { ProductName = "Bur", Cost = 10, Category = ProductCategory.MilkProduct };

            shop.GoodRecieving(drink);
            shop.GoodRecieving(milk);

            Console.ReadKey();


        }
    }
}
