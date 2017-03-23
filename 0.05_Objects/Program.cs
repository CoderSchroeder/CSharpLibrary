using System;

namespace _0._05_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Donuts appleCinnamon = new Donuts();
            appleCinnamon.Filling = "apple pie";
            appleCinnamon.isSpecial = false;
            appleCinnamon.Price = 0.99M;
            appleCinnamon.Type = "filled";

            Console.WriteLine(appleCinnamon.Filling);

            Donuts longJohn = new Donuts();
            longJohn.Filling = "Bavarian Creme";





            Console.ReadLine();

        }
    }
}
