using System;
using NumberOperationsLibrary;

namespace CallLibraryFromDiffLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //Plus method a + b
            int resultPlus = Operations.PlusNumbers(a, b);
            Print(resultPlus);

            //Minus method a - b 
            int resultMinus = Operations.MinusNumbers(a, b);
            Print(resultMinus);


            //Devour method a / b
            int resultDevour = Operations.Devour(a, b);
            Print(resultDevour);


            //Multiply method a * b
            int resultMulty = Operations.Multiply(a, b);
            Print(resultMulty);


        }

        //Method for print
        private static void Print(int number)
        {
            Console.WriteLine(number); ;
        }
    }
}
