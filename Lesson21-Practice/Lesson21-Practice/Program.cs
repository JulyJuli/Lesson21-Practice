using System;

namespace Lesson21_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new OnlineShop();
           
            //shop.NewProductRecived += CustomerEventHandler.GotNewGoods;

            var annCustomer = new Customer() { Name = "Ann" };
            //shop.NewProductRecived += annCustomer.GotNewGoods1;
            shop.TestObj += annCustomer.ObjectHendler;

            //var johnCuctomer = new Customer() { Name = "John" };
            //shop.NewProductRecived += johnCuctomer.GotNewGoods1;

            //shop.TestEvent += annCustomer.MyDeligateProc;
            //shop.TestEvent += johnCuctomer.MyDeligateProc;
            var drink = new Product() { ProductName = "Gin", Cost = 840, Category = EnumProducts.Drink };
            var milk = new Product() { ProductName = "Korovkino", Cost = 17, Category = EnumProducts.MilkProduct };

            shop.GoodReciving(drink);
            shop.GoodReciving(milk);

            Console.WriteLine(annCustomer.MyDeligateProc(12));
            
        }

       
    }
}
