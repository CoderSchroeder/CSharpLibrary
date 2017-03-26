using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_AccessModifiers
{
    class Car
    {

        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }

        protected string CarDetails()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}";
        }
    }

    class Acura : Car
    {
        private int Price;

        public Acura(string model, int year, int Price)
        {
            this.Make = "Acura";
            this.Model = model;
            this.Year = year;
            this.Price = Price;
        }
       
        public string AcuraDetails()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}";
        }


    }

}



/* *****Keyword***************Applicable To***************Meaning******************************************		
        public 				  Class, Member				No restrictions
        protected			  Member					Access limited to the class and derived classes
        private				  Member					Access limited to the class.
*/