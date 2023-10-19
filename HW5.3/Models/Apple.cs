using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._3.Models
{
    internal class Apple : Fruit
    {
        public Apple(int vitaminA, int vitaminB,decimal price, string sort):base(price,sort)
        {
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }

        public int VitaminA { get; set; }
        public int VitaminB { get; set; }
        public override void Taste()
        {
            Console.WriteLine("Tastes like apple");
        }
    }
}
