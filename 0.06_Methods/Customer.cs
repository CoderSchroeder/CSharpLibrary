﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Customer
    {
       
        
        //Properties
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool AppearsWealthy { get; set; }
        public decimal BankRoll { get; set; }


        //Methods (can name them anything, by convention use action words Print,Write)
        public void PrintCustomerName()
        {
            Console.WriteLine("Hello, {0} {1}", FirstName, LastName);
        }


    }
}
