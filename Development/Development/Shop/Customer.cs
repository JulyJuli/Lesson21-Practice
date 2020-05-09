using System;

namespace Development
{
    public class Customer
    {
        public string Name { get; set; }

        public void GotNewGoods(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"The product was recived: {goodInfo.Name}, price = {goodInfo.Price} by {Name}");
        }

        public void GoodsProcessing(object sender, GoodsInfoEventArgs goodInfo)
        {
            Console.WriteLine($"Hi {Name} from second handler!");
        }
    }
}
