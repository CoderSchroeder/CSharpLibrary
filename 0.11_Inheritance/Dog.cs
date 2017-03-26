using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Dog : Animals
    {

        public bool HasTail { get; set; }
        public bool IsFriendly { get; set; }
        public string Name { get; set; }


        public void Goodboy()
        {
            Console.WriteLine("bark");
        }

        public void ADHD()
        {
            Console.WriteLine("Squirrel");
        }


    }
}
