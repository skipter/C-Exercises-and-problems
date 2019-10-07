using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberOperationsLibrary
{
    public class Operations
    {
        public static int PlusNumbers(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int MinusNumbers (int a, int b)
        {
            int result = Math.Abs(a - b);
            return result;
        }

        public static int Multiply (int a, int b)
        {
            int result = a * b;
            return result;
        }

        public static int Devour (int a, int b)
        {
            int result = a / b;
            return result;
        }

        public static List<int> IntegersSortList (List<int> numbers)
        {
            numbers.Sort();

            return numbers;
        }
    }
}
