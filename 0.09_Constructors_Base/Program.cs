using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Base
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Using Constructor 1
            Person daniel = new Person();
            daniel.FirstName = "Daniel";
            daniel.LastName = "Schroeder";
            daniel.Age = 32;
            daniel.TestMethod();
            //Using Constructor 2 (custom)
            Person kelly = new Person("Kelly", "Schroeder", 31);

            Minor Abbie = new Minor("Abbie", "Hembrecht", 14, true);
            Abbie.DemoMethod();
            Abbie.TestMethod();

            Console.ReadLine();
        }
    }
}
