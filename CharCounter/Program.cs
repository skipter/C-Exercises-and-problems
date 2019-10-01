using System;

namespace CharCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            long charCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                charCounter++;
            }
            Console.WriteLine(charCounter);
        }
    }
}
