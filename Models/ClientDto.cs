using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Test.Models
{
    public class ClientDto
    {
        public string OrderNumber {  get; set; }
        public DateTime Date {  get; set; }
        public string CustomerName {  get; set; }
        public int ItemCount { get; set; }
        public double TotalPrice { get; set; }

        public List<ProductDto> OrderDetailsList { get; set; }

    }
}
