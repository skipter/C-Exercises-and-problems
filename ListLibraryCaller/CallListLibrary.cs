using System;
using System.Linq;
using System.Collections.Generic;
using NumberOperationsLibrary;

namespace ListLibraryCaller
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .ToList();

            var orderedNums = Operations.IntegersSortList(numbers);
            Console.WriteLine(string.Join(" ", orderedNums));
        }
    }
}
