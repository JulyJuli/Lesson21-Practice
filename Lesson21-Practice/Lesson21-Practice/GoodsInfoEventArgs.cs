using System;

namespace Lesson21_Practice
{
    public class GoodsInfoEventArgs:EventArgs
    { 
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
    }
}
