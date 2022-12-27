using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_list
{
// класс Продукт для сохранения с полями Имя, Количество и Куплен да/нет
    public class Product
    {
        public string? Name { get; set; }
        public byte Count { get; set; } = 1;
        public bool IsBuy { get; set; } = false;
    }
}
