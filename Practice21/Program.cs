using Practice21.Shop;
using System;

namespace Practice21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shop = new OnlineShop();
            
            var annCustomer = new Customer() { Name = "Ann" };
            shop.NewProductRecieved += annCustomer.GotNewGoods;
            var johnCustomer = new Customer() { Name = "John" };
            shop.NewProductRecieved += johnCustomer.GotNewGoods;
            shop.NewProductRecieved += johnCustomer.GotProcessing;

            var drink = new Product { ProductName = "Gin", Cost = 1005, Category = ProductCategory.Drink };
            var milk = new Product { ProductName = "Bur", Cost = 10, Category = ProductCategory.MilkProduct };

            shop.GoodRecieving(drink);
            shop.GoodRecieving(milk);

            Console.ReadKey();
        }
    }
}
