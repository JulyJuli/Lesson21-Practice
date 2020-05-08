using System;

namespace Lesson21.Shop
{
   public class GoodsInfoEventArgs/*:EventArgs*/
    {
        public string ProductName { get; set; }

        public decimal Cost { get; set; }
    }
}
