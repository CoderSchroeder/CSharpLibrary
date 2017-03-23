using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Student Daniel = new Student();
            Daniel.FirstName = "Daniel";
            Daniel.LastName = "Schroeder";
            Daniel.Age = 32;

            Student Shelby = new Student("Shelby");
            Student charlesMichael = new Student("Charles", "Michael", 30, "Assassin");
            Student jeremiah = new Student("Jeremiah", "Miller", 30, "Padawan");

        }
    }
}
