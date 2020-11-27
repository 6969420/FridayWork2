using System;

namespace FridayWork2
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;

            }
            public void Sleep()
            {
                Console.WriteLine("Cat sleeps");
                hunger += 0.2;
            }
            public void Meow()
            {
                Console.WriteLine("meow");
            }

            public double Hunger
            {
                get { return hunger; }
            }
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Spots", "red");
            Console.WriteLine($"The level of hunger: {newCat.Hunger}");

            while (newCat.Hunger != 1)
            {
                newCat.Sleep();
                newCat.Meow();
            }
            Console.WriteLine($"The level of hunger: {newCat.Hunger}");
        }
    }
}
