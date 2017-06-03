using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_Playground
{
    class Scope
    {
        private int x = 10;
        private static int y = 20;

        public static void Main()
        {
            int x = 100;
            int y = 200;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Scope.y);
            Console.ReadLine();
        }

        //{
        //    int count = 0;
        //    int m = 10;
        //    int n = 7;
        //    while (m % n >= 0)
        //    {
        //        m = m + 1;
        //        //Console.WriteLine("The current m number is " + m);

        //        n = n + 2;
        //        //Console.WriteLine("The current n number is " + n );

        //        count++;
        //        //Console.WriteLine("The while loop executed " + count + " time(s)");

        //    }
        //    Console.WriteLine("The while loop executed " + count + " time(s)");


        //    //Console.WriteLine("The while loop executes " + count + " times");
        //    Console.ReadLine();
        //}
    }
}
