using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] comArg = Console.ReadLine().Split('|').ToArray();
            var countriesData = new Dictionary<string, Dictionary<string, long>>();
            while (comArg[0] != "report")
            {
                string country = comArg[1];
                string city = comArg[0];
                var population = int.Parse(comArg[2]);
                if (!countriesData.ContainsKey(country))
                {
                    countriesData[country] = new Dictionary<string, long>();
                    countriesData[country][city] = population;
                }
                else
                {
                    if (!countriesData.ContainsKey(city))
                    {
                        countriesData[country][city] = population;
                    }
                    else
                    {
                        countriesData[country][city] += population;
                    }
                }
                comArg = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var countries in countriesData.OrderByDescending(kvp=>kvp.Value.Values.Sum()))
            {
                var city = countries.Value;
                var totalPopulation = countries.Value.Values.Sum();
                Console.WriteLine($"{countries.Key} (total population: {totalPopulation})");
                foreach (var cities in city.OrderByDescending(kvp=>kvp.Value))
                {
                    var town = cities.Key;
                    var population = cities.Value;
                    Console.WriteLine($"=>{town}: {population}");
                }
            }


        }
    }
}

