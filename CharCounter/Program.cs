using System;

namespace CharCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split();
            long charCounter = 0;
            foreach (var token in input)
            {
                charCounter += token.Length;
            }
            Console.WriteLine(charCounter);
        }
    }
}
