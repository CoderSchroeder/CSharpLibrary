using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ForEach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

                    //place in the array  0   1   2   3   4  5
            int[] lottoNums = new int[] { 15, 4, 16, 32, 20, 7 };
            string[] names = new string[] { "James", "Paul", "Daniel", "Levi" };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(lottoNums[5]);
            
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("===================");

            foreach (int number in lottoNums)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

        }
    }
}
