using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les21pr.Shop
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public ProductCategory Category { get; set; }

    }
}
