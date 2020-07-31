using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string adjective, pluralNoun, superHero;

            Console.WriteLine("Enter a adjective: ");
            adjective = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            pluralNoun= Console.ReadLine();

            Console.WriteLine("Enter a super hero: ");
            superHero = Console.ReadLine();

            Console.WriteLine("Roses are " + adjective);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I hate " + superHero);

            Console.ReadLine();
        }
    }
}
