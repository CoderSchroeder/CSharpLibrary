using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Program
    {
        public static string PrintCustmerName { get; private set; }

        static void Main(string[] args)
        {

            Customer theJSWizard = new Customer();
            theJSWizard.AppearsWealthy = false;
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";

            Console.WriteLine(PrintCustmerName);
            Console.ReadLine();

        }
    }
}
