using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork21.Shop
{
  public  class Customer
    {
        public string Name { get; set; }

        public void GotNewGoods(object sender, GoodsInfoEventsArgs goodsInfo)
        {
            Console.WriteLine($"The product was received: {goodsInfo.ProductName}; cost: {goodsInfo.Cost} by {Name}");
        }

        public void GoodsProcessing(object sender, GoodsInfoEventsArgs goodsInfo)
        {
            Console.WriteLine($"Hi from second handler, {Name}!");
        }

        public void ObjectHandler(object  sender, object args)
        {
            var convertedArgs = args as List<int>;
            foreach (var item in convertedArgs)
            {
                Console.WriteLine(item+"!!");
            }
        }
    }
}
