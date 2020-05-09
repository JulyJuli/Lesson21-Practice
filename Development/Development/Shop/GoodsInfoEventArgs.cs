using System;

namespace Development
{
    public class GoodsInfoEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
