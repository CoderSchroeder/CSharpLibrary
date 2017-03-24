using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Collections_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //         KEY      VALUE
            /* Dictionary<string, string> dictionary = new Dictionary<string, string>();
             dictionary.Add("cat", "annoying creature");
             dictionary.Add("dog", "mans best friend");

             foreach(KeyValuePair<string, string> pair in dictionary)
             {
                 Console.WriteLine("{0} is a {1}", pair.Key, pair.Value);
             }

    */
           //  Console.ReadLine();

             Dictionary<string, string> dictionary = new Dictionary<string, string>();

             dictionary.Add("Russell Crowe", "Gladiator");
             dictionary.Add("Tom Hanks", "Cast away");
             dictionary.Add("Ed Harris", "Pollock");
             dictionary.Add("Julia Roberts", "Erin Brokovich");
             dictionary.Add("Joan Allen", "The Contender");
             dictionary.Add("Juliette Binoche", "Chocolat");

             foreach (KeyValuePair<string, string> pair in dictionary)
             {
                 Console.WriteLine("{0} in {1}", pair.Key, pair.Value);
             }

    

             Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();

             bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolat", "CTHD" });
             bestPictureNoms.Add("2001", new string[] { "Beautiful Mind", "Gosford Park", "In the Bedroom" });
             bestPictureNoms.Add("2002", new string[] { "Chicago", "Gangs of New York", "Harry Potter CS" });

             foreach(KeyValuePair<string, string[]>bestPictureNom in bestPictureNoms)
             {
                 Console.WriteLine("{0}: {1}, {2}, {3}", bestPictureNom.Key, bestPictureNom.Value[0], bestPictureNom.Value[1], bestPictureNom.Value[2]);
             }
             

            Console.WriteLine("please type an Actor to show the movie that won him best picture: ");
            string input1 = Console.ReadLine();
            
            if (dictionary.ContainsKey(input1))
            {
                string valueForKey = dictionary[input1];
                Console.WriteLine("The best pictue in " + input1 + " was " + valueForKey);
            }

            Console.WriteLine("Please type the year to show the movies that were up for an award that year:");
            string input2 = Console.ReadLine();

            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueForKey = bestPictureNoms[input2];
                string nomineeString = string.Join(", ", valueForKey);
                Console.WriteLine("The best nominees in " + input2 + " were " + nomineeString);
            }

            Console.ReadLine();

        }
    }
}
