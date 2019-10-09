using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dataPopulation = new Dictionary<string, Dictionary<string, long>>();

            string incomeData = Console.ReadLine();

            while (incomeData != "report")
            {
                string[] tokens = incomeData.Split('|').ToArray();

                string country = tokens[1];
                string city = tokens[0];
                long population = Int64.Parse(tokens[2]);

                if (!dataPopulation.ContainsKey(country))
                {
                    dataPopulation.Add(country, new Dictionary<string, long>());
                    dataPopulation[country].Add(city, population);
                }

                if (dataPopulation.ContainsKey(country))
                {
                    if (!dataPopulation[country].ContainsKey(city))
                    {
                        dataPopulation[country].Add(city, 0);
                    }
                    else
                    {
                        dataPopulation[country][city] = population;
                    }
                }

                incomeData = Console.ReadLine();
            }

            foreach (var item in dataPopulation.OrderByDescending(x => x.Value.Values.Sum()))
            {
                var country = item.Key;
                Console.WriteLine("{0} (total population: {1})", country, item.Value.Values.Sum());

                foreach (var items in item.Value.OrderByDescending(p => p.Value))
                {
                    var city = items.Key;
                    long popUp = items.Value;
                    Console.WriteLine($"=>{city}: {popUp}");
                }
            }
        }
    }
}
