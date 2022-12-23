using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_list
{
    public class Product
    {
        public string? Name { get; set; }
        public byte Count { get; set; } = 1;
        public bool IsBuy { get; set; } = false;
    }
}
