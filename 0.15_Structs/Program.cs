using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry Paul = new AddressBookEntry()
            {
                Address = "123 Coder ln",
                City = "Westfield",
                State = "IN",
                Zip = "44850",
                FirstName = "Paul",
                LastName = "O'Connor",
                Age = 40,
            };

            AddressBookEntry John = new AddressBookEntry()
            {
                Address = "456 Dirt Road",
                City = "Eastfield",
                State = "IN",
                Zip = "44550",
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
            };

            AddressBookEntry Daniel = new AddressBookEntry()
            {
                Address = "321",
                City = "Mishawaka",
                State = "IN",
                Zip = "44456",
                FirstName = "Daniel",
                LastName = "Schroeder",
                Age = 32,
            };

            AddressBookEntry Bob = new AddressBookEntry()
            {
                Address = "789 Visual ln",
                City = "Northfield",
                State = "IN",
                Zip = "44660",
                FirstName = "Bob",
                LastName = "Smith",
                Age = 50,
            };

            //Create 3 more Address Book entries !!DONE
            //Create a constructor in the AddressBook Entry where a user has to pass in 
            //3 parameters: FirstName, LastName, Age

            Console.WriteLine(Paul.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(John.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(Daniel.GetAddress());
            Console.WriteLine("");
            Console.WriteLine(Bob.GetAddress());
            Console.ReadLine();
        }


        struct AddressBookEntry
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public string Address;
            public string City;
            public string State;
            public string Zip;

            public string GetAddress()
            {
                return $"Address: {Address}\nCity:{City}\nState: {State}\nZip: {Zip}";
            }

        }
    }
}
