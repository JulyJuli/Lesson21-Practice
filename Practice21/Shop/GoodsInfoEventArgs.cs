using System;
using System.Collections.Generic;
using System.Text;

namespace Practice21.Shop
{
    public class GoodsInfoEventArgs: EventArgs
    {
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
    }
}
