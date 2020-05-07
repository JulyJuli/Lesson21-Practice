using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les21pr.Shop
{
    public class Customer
    {
        public string Name { get; set; }
        public void GotNewGoods(object sendler, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"The product was recieved: {goodInfo.ProductName}, cost {goodInfo.Cost} by {Name}");
        }
        public void GoodsProcessing(object sendler, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"Hi {Name} from second handler!!");
        }

        public decimal MyDelegateProcessor(decimal i)
        {
            return i * i;
        }
        //public void ObjectHandler(object sender, object args)
        //{
        //    var convertedArgs = args as List<int>;
        //    foreach(var element in convertedArgs)
        //    {
        //        Console.WriteLine(element + "!!");
        //    }
        //}

    }
}
