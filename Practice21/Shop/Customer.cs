using System;
using System.Collections.Generic;
using System.Text;

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
        public decimal MeDelegateProcessor(decimal i)
        {
            return i * i;
        }
        public void ObjectHandler(object sender, object args)
        {
            var convertedArgs = args as List<int>;
            foreach(var element in convertedArgs)
            {
                Console.WriteLine(element);
            }
        }
    }
}
