using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Netflix_Challenge
{
    class Netflix
    {
        //Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public int TotalMinutes { get; set; }

        //Methods

        /// <summary>
        /// Methods with no return
        /// </summary>

        public void GetSuggestion()
        {
            if (this.Rating >= 4)
                Console.WriteLine("You should watch this Show!");
            else
                Console.WriteLine("Dont waste your time");

        }

        public int ShowRuntime()
        {
            Console.WriteLine(this.TotalMinutes);
            return this.TotalMinutes;
        }

        //Methods that have parameters
        public string ShowWhoViewed(string username, string time)
        {
            string details = username + " watched this at " + time;
            Console.WriteLine(details);
            return details;
        }

        //Takes in a parameter of num minutes watched.
        //Returns number of minutes left.
        public int TimeLeft(int minutesViewed)
        {
        int MinutesLeft = this.TotalMinutes - minutesViewed;
            Console.WriteLine("There are " + MinutesLeft + " minutes left in " + this.Name);
            return MinutesLeft;
        }
        
    


        public string PayBill()
        {
            return "You just paid your bill";
        }

    }
}
