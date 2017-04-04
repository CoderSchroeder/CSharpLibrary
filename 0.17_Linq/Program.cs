using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() {VIN = "A123", Make = "Honda", Model = "Civic", Price = 5000, Year = 2000 },
                new UsedCar() {VIN = "B234", Make = "Toyota", Model = "Avalon", Price = 6000, Year = 2002 },
                new UsedCar() {VIN = "C456", Make = "BMW", Model = "3series", Price = 15000, Year = 2010 },
                new UsedCar() {VIN = "D654", Make = "Porsche", Model = "996GT3", Price = 20000, Year = 2005 },
                new UsedCar() {VIN = "E789", Make = "Mercedes", Model = "S-Class", Price = 55000, Year = 2017 },
                new UsedCar() {VIN = "F901", Make = "Peugeot", Model = "306GTI", Price = 1500, Year = 2006 },
                new UsedCar() {VIN = "G023", Make = "Tesla", Model = "Model-S", Price = 45000, Year = 2016 },
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} is a nice used Car that costs: {2:C}", bmw.Year, bmw.Model, bmw.Price);
            }
           // Console.ReadLine();
            Console.WriteLine("--------------------------------");
           
            var cheapCars = from car in usedCars
                            where car.Price < 10000
                            select car;
            foreach (var cheapCar in cheapCars)
            {
                  Console.WriteLine(" The {0} {1} is a nice cheap Car that costs: {2:C}", 
                      cheapCar.Make, 
                      cheapCar.Model, 
                      cheapCar.Price); 
            }

            Console.WriteLine("--------------------------------");
            var Toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach (var toyota in Toyotas)
            {
                Console.WriteLine(toyota.Model);
            }

            Console.WriteLine("==========================");
            var niceUsedCars = usedCars.Where(car => car.Price > 5000 && car.Make == "Toyota" || car.Make == "BMW");
            foreach (var niceUsedCar in niceUsedCars)
            {
                Console.WriteLine(niceUsedCar.Model + " " + niceUsedCar.VIN);
            }

            Console.WriteLine("==========================");
            Console.WriteLine("Please enter the amount you want to spend");
            int input = Int32.Parse(Console.ReadLine());

            Console.WriteLine("==========================");
            var userCar = usedCars.Where(car => car.Price < input);
            foreach(var car in userCar)
            {
                Console.WriteLine("These vehicles are available for less than {0:C}: {1} {2} {3}",
                    input, car.Year, car.Make, car.Model);
            }

            Console.ReadLine();


        }   

    }

    class UsedCar
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

    }
}
