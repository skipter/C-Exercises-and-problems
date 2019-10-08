using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmailsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();
                 
                if (!data.ContainsKey(input))
                {
                    if (!email.Contains(".us") || email.Contains(".uk"))
                    {
                        data.Add(input, email);
                    }
                }
            }

            foreach (var user in data)
            {
                Console.WriteLine("{0} -> {1}", user.Key, user.Value);
            }
        }
    }
}
