using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevatorUp = true;
            bool elevatorDown = true;
            bool elevatorBroken = true;
            bool elevatorStuckWhileWeAreInIt = true;
            int elevatorNumber = 13;

            if (elevatorUp == true)
            {
                Console.WriteLine("Going up");
            }

            else

            {
                Console.WriteLine("Going down");
            }

            if (elevatorBroken);
            {
                Console.WriteLine("Panic!!");
            }

            if (elevatorStuckWhileWeAreInIt);
            {
                Console.WriteLine("Do you have those Reports for me?");
            }

            if (elevatorNumber > 10) ;
            {
                Console.WriteLine("wrong floor");
            }
            Console.ReadLine();     
        }
    }
}

