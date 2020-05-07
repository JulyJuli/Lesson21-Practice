using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Practice.Shop
{
    public class Customer
    {
        public string Name { get; set; }

        public void GotNewGoods(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"The product was received by {Name}: {goodInfo.ProductName}; cost: {goodInfo.Cost}");
        }

        public void GoodsProcessing(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"Hi {Name} from second handler!!");
        }
    }
}
