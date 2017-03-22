using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Demo

            string firstName;
            string lastName;
            string Occupation;

            firstName = "Daniel";
            lastName = "Schroeder";
            Occupation = "newbCoder";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //String Interpolation
            Console.WriteLine("Name: {0}\nOccupation: {1}\n{2}",fullName,Occupation,"Daniel");
                
                
                
            Console.ReadLine();


        }
    }
}
