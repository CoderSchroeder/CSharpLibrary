using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankAccount = 50000;
            int debt = 13500;
            int difference = bankAccount - debt;


            Console.WriteLine("I have {0:C} in my Bank Account, and I am {1:C} in Debt", bankAccount, debt);
            if (difference >= 7000)
            {
                Console.WriteLine("I have money");
            }

            else if (difference > 6999 && difference > 2000) ;
            {
                Console.WriteLine("Freddy needs to go");
            }
            { 
            if (difference < 50)
            
                Console.WriteLine("Eat Ramen");
            }
            Console.ReadLine();
        }
    }
}
