using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player theJSWizard = new Player();
            theJSWizard.Name = " the JSWizard ";
            theJSWizard.Attack();
            theJSWizard.Attack("Rusty Axe");
            theJSWizard.Attack("Rusty Axe", 1);
       
            Console.ReadLine();
        }
    }
}
