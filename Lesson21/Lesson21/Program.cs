using Lesson21.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var shop = new OnlineShop();
            

            var annCustomer = new Customer() { Name = "Ann" };
            var johnCustomer = new Customer() { Name = "John" };

            shop.NewProductRecieved += annCustomer.GotNewGoods;
            shop.NewProductRecieved += johnCustomer.GotNewGoods;

            var drink = new Product() { ProductName = "Gin", Cost = 1005, Category = ProductCategory.Drink };
            var milk = new Product() { ProductName = "Bur", Cost = 10, Category = ProductCategory.MilkProduct };

            shop.GoodRecieving(drink);
            shop.GoodRecieving(milk);

            Console.ReadKey();
        }
    }
}
