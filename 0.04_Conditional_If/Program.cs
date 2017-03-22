using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditional_If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            if (isOn);
            {
                Console.WriteLine("The Light is on.");
            }
            // Console.ReadLine();

            /*
            Comparison Operators

           == isEqual to 
           >= GreaterThan or Equal To
           <= LessThan or Equal To
           != NotEqual
           > GreaterThan
           < Lessthan
           ! Not
           && And
           || Or

            */

            bool isAdmin = true;
            bool LoggedIn = true;

            if (isAdmin)
            {
                Console.WriteLine("Welcome to the Site Admin!");
            }




            if (!isAdmin) 
            {
                Console.WriteLine("you should not be here");
            }

            if (isAdmin && LoggedIn)
            {
                Console.WriteLine("Hi Admin, you are logged in!");
            }

            Console.ReadLine();
        }    
    }
}
