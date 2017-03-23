using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string friend = "Kenn";

            switch (friend)
            {
                case "Fred":
                    Console.WriteLine("Hey Fred");
                    break;
                case "Kenn":
                    Console.WriteLine("Hey Kenn");
                    break;
                default:    //best practice, always have a default for switch statements
                    Console.WriteLine("You hit the default");
                    break;
            }
            */

            //TERNARY OPERATOR

            int num1 = 10;

                Console.WriteLine(num1 == 7 ? "Hey this is number 7" : "This isnt number 7");
            //Using a string of name check to see if your name is the sameas your neighbour, 
            //return a message
                Console.ReadLine();
        }
    }
}
