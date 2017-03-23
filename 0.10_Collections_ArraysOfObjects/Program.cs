using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_ArraysOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Country[] countries = new Country[10];
            countries[0] = new Country ("Honduras", "Tegucigalpa");
            countries[1] = new Country("Italy", "Rome");
            countries[2] = new Country("Israel", "Jerusalem");
            countries[3] = new Country("Peru", "Lima");
            countries[4] = new Country("Japan", "Tokyo");
            countries[5] = new Country("Australia", "Sydney");
            countries[6] = new Country("Nicaragua", "Managua");
            countries[7] = new Country("China", "Beijing");
            countries[8] = new Country("South Korea", "Seoul");
            countries[9] = new Country("Germany", "Berlin");

            /*
            foreach(var country in countries)
            {
                Console.WriteLine(country.Name);
                Console.WriteLine(country.Capital);
            }
            */
            foreach(var country in countries)
            {
                country.PrintCountryDetails();
            }
            Console.ReadLine();
        }
    }
}
