using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._3.Models
{
    internal abstract class Fruit
    {
        protected Fruit(decimal price, string sort)
        {
            Price = price;
            Sort = sort;
        }

        public decimal Price { get; set; }
        public string Sort { get; set; }

        public abstract void Taste();
    }
}
