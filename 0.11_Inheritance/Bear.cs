﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Inheritance
{
    class Bear : Animals
    {

        public bool Hibernate { get; set; }
        public string Meal { get; set; }
        public bool StealsPicnicBasket { get; set; }

        public void Speak()
        {
            Console.WriteLine("GGRRRRRRRRAWW");
        }

    }
}
