using System;

namespace Practice21.Shop
{
    public class Customer
    {
        public string Name { get; set; }
        public void GotNewGoods(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"The product was recieved : {goodInfo.ProductName}; cost {goodInfo.Cost} by {Name}");
        }

        public void GotProcessing(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"Hi {Name} from second handler");
        }
       
    }
}
