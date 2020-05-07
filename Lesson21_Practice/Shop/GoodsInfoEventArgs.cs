using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_Practice.Shop
{
    public class GoodsInfoEventArgs : EventArgs
    {
        public string ProductName { get; set; }

        public decimal Cost { get; set; }
    }
}
