using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Data Types*****");

            //string is a data-type (words)
            string name = "Daniel";
            string teacher;

            teacher = "Paul";

            Console.WriteLine(name);
            Console.WriteLine(teacher + " is a suave guy " + name + " is learning from him" );
            Console.ReadLine();
        }
    }
}
