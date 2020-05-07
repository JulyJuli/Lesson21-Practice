using System;

namespace Development
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shop = new OnlineShop();

            var bigCastomer = new Customer{ Name = "Big" };
            shop.NewProduct += bigCastomer.GotNewGoods;
            shop.NewProduct += bigCastomer.GoodsProcessing;

            var smallCastomer = new Customer{ Name = "Small" };
            shop.NewProduct += smallCastomer.GotNewGoods;

            var alcohol = new Product{ Name = "Jameson", Price = 1000, CategoryName = Category.Alcohol};
            var food = new Product{ Name = "Onion", Price = 12, CategoryName = Category.Food};

            shop.GoodReciving(alcohol);
            shop.GoodReciving(food);
        }
    }
}
