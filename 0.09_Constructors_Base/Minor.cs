using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Base
{
    class Minor : Person
    {
        // only need a base when refering to a parent class Constructor
        public Minor(string firstName, string lastName, int age, bool IsInSchool) : base(firstName, lastName, age)
        {
            this.IsInSchool = IsInSchool;
        }

        //Property
        public bool IsInSchool { get; set; }

        //Methods
        public override void TestMethod()
        {
            Console.WriteLine("Test Method in minor class(Minor)");
        }

        public void DemoMethod()
        {
            Console.WriteLine("Demo Method in minor class(Minor)");
        }

    }
}
