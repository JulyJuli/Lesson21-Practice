using Lesson21_Practice.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shop = new OnlineShop();

            var annCustomer = new Customer() { Name = "Ann" };
            shop.NewProductReceived += annCustomer.GotNewGoods;

            var johnCustomer = new Customer() { Name = "John" };
            shop.NewProductReceived += johnCustomer.GotNewGoods;
            shop.NewProductReceived += johnCustomer.GoodsProcessing;

            var drink = new Product() { ProductName = "Gin", Cost = 1005, Category = ProductCategory.Drink };
            var milk = new Product() { ProductName = "Bur", Cost = 10, Category = ProductCategory.Dairy };

            shop.GoodReceiving(drink);
            shop.GoodReceiving(milk);
        }
    }
}
