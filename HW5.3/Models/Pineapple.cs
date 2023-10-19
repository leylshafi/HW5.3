using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._3.Models
{
    internal class Pineapple : Fruit
    {
        public Pineapple(int vitaminE, int vitaminD,decimal price, string sort) : base(price, sort)
        {
            VitaminE = vitaminE;
            VitaminD = vitaminD;
        }

        public int VitaminE { get; set; }
        public int VitaminD { get; set; }
        public override void Taste()
        {
            Console.WriteLine("Tastes like pineapple");
        }
    }
}
