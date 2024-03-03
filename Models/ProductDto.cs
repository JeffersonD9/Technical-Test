using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Test.Models
{
    public class ProductDto

    {
        public string productName { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public string comment { get; set; }
    }
}
