using HW5._3.Models;
using System.Reflection;

namespace HW5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket =
            {
                new Apple(10,20,20.4m,"Yashil alma"),
                new Pineapple(30,40,50.3m,"Ananas"),
                new Orange(50,22.4m,"Apelsin")
            };
            foreach (Fruit fruit in Basket)
            {
                Type type = fruit.GetType();
                Console.WriteLine(type.Name);
                foreach (var member in type.GetProperties())
                {
                    Console.WriteLine($"{member.Name} - {member.GetValue(fruit)}");
                }
                Console.WriteLine("------------------------------");
            }
        }

    }
}