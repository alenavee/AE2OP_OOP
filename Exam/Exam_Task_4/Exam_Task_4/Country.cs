using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Task_4
{
    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public int Population { get; set; }
        public List<string> Languages { get; set; }
        public string CapitalCity { get; set; }
        public Country(string name, string continent, int population, List<string> languages, string capitalCity)
        {
            Name = name;
            Continent = continent;
            Population = population;
            Languages = languages;
            CapitalCity = capitalCity;
        }
    }
}
