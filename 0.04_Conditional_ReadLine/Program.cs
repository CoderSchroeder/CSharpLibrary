using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            if (feelingNumber == "5")
            {
                Console.WriteLine("Wowie Zowie, man. Thats good to hear.");
            }
            if (feelingNumber != "5")
            {
                Console.WriteLine("i hope you get better!");
            } 
            else
            {
                Console.WriteLine("Please try again, read the instructions");
            }

            Console.ReadLine();

        }
    }
}
