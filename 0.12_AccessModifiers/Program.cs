using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            Acura t1 = new Acura("TL", 2000, 500);
            Acura t2 = new Acura("TT", 3000, 10);

            Console.WriteLine(t1.AcuraDetails());
            Console.WriteLine(t2.AcuraDetails());

            Console.ReadLine();

        }
    }
}
