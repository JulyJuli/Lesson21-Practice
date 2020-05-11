using System;
using System.Collections.Generic;

namespace Lesson21_Practice
{
    public class Customer
    {
        public string Name { get; set; }

        public void GotNewGoods1(object sender, GoodsInfoEventArgs goodInfo)//, Customer customer
        {
            Console.WriteLine($"The product was recieved: {goodInfo.ProductName}; cost: {goodInfo.Cost} by {Name}");
        }
        public void GoodsProcessing(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"Hi {Name} from second handler!!");
        }

        public decimal MyDeligateProc(decimal i)
        {
            return i * i;
        }

        public void ObjectHendler(object sender, object args)
        {
            var convertedArgs = args as List<int>;
            foreach(var i in convertedArgs)
            {
                Console.WriteLine(i+"!");
            }                
        }
    }
}
