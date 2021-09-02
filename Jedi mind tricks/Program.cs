using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_mind_tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgave 1
            Dictionary<string, int> people= new Dictionary<string, int>();
            people.Add("Mathias", 20);
            people["Bob"] = 24;
            //opgave 2
            Console.WriteLine(people.First());
            //opgave 3
            Dictionary<string, bool> characters = new Dictionary<string, bool>() { { "Luke", true }, { "Han", false }, { "Chewbacca", false } };
            if (characters.Remove("Han"))
            {
                Console.WriteLine("Han has been removed");
            }
            else
            {
                Console.WriteLine("Couldnt find Han");
            }
            //opgave 4
            foreach(var c in characters)
            {
                Console.WriteLine("Key: {0} value: {1}" , c.Key, c.Value);
            }

            Console.ReadKey();
        }
    }
}
