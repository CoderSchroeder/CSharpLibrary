using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Bear barryTheBear = new Bear();
            barryTheBear.Weight = 2000;

            Dog Freddy = new Dog();
            Freddy.Weight = 250;
            Freddy.Name = "Fred the odd one";
            Freddy.HasEyes = true;

            Console.WriteLine(Freddy.Weight);

            barryTheBear.Walks();
            barryTheBear.Speak();

            Polarbear cokeACola = new Polarbear();
            

            Console.ReadLine();

        }
    }
}
