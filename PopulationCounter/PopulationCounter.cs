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

                string country = tokens[0];
                string city = tokens[1];
                long population = Int64.Parse(tokens[2]);

                if (!dataPopulation.ContainsKey(country))
                {
                    dataPopulation.Add(country, new Dictionary<string, long>());
                    dataPopulation[country].Add(city, population);
                }
            }
        }
    }
}
