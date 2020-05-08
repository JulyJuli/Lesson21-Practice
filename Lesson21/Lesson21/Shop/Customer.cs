using System;

namespace Lesson21.Shop
{
    public class Customer
    {
        public string Name { get; set; }

        public void GotNewGoods(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"The product was recieved: {goodInfo.ProductName}; cost: {goodInfo.Cost}");
        }

        public void GoodsProcessing(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"Hi {Name} from second handler");
        }
    }
}
