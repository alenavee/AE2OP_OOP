using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();

            countries.Add(new Country("Russia", "Europe", 144, new List<string> { "Russian" }, "Moscow"));
            countries.Add(new Country("Canada", "North America", 38, new List<string> { "English", "French" }, "Ottawa"));
            countries.Add(new Country("France", "Europe", 67, new List<string> { "French" }, "Paris"));
            countries.Add(new Country("New Zealand", "Australia", 5, new List<string> { "Maori", "English"}, "Wellington"));
            countries.Add(new Country("Spain", "Europe", 47, new List<string> { "Spanish", "Catalan" }, "Madrid"));

            //output european countries
            foreach (Country c in countries)
            {
                if (c.Continent == "Europe")
                {
                    Console.WriteLine($"Country info: {c.Name}, {c.Continent}");
                    Console.WriteLine($"Population: {c.Population}M, Capital: {c.CapitalCity}");
                    Console.WriteLine("Languages:");
                    foreach (var l in c.Languages){
                        Console.Write(l + " ");
                    }
                }
            }

            Console.WriteLine("\n");

            var sortedCountries = from c in countries
                                  orderby c.Population descending
                                  select c;
            Console.WriteLine("Ordered by population:");

            foreach (Country c in sortedCountries)
                Console.WriteLine($"{c.Name} {c.Population}M");


            Console.WriteLine("\nSearch for a language:");

            string input = Console.ReadLine();
            Console.WriteLine("\nCountries where language is spoken: ");
            foreach (Country c in countries)
            {
                bool check = c.Languages.Any(x => x == input);
                if(check == true)
                {
                    Console.WriteLine(c.Name);
                }
            }

        }
    }
}
