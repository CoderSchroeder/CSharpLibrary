using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Netflix_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Netflix Movie1 = new Netflix();
            Movie1.Name = "Archer";
            Movie1.Genre = "Animated";
            Movie1.Rating = 5.0;
            Movie1.TotalMinutes = 22;
            Movie1.GetSuggestion();
            Movie1.ShowRuntime();
            Console.WriteLine(Movie1.ShowWhoViewed("Levi", " 4 "));

            Movie1.TimeLeft(4);


            Console.WriteLine(Movie1.Name);

            Netflix Movie2 = new Netflix();
            Movie2.Name = "Simpsons";
            Movie2.Genre = "Animated";
            Movie2.Rating = 4.0;
            Movie2.GetSuggestion();


            Netflix Movie3 = new Netflix();
            Movie3.Name = "Futurama";
            Movie3.Genre = "Animated";
            Movie3.Rating = 3.5;
            Movie3.GetSuggestion();




            Console.ReadLine();
        }
    }
}
