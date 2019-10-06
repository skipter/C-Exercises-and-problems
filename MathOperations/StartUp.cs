using System;
using NumberOperationsLibrary;

namespace MathOperations
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thurdNum = int.Parse(Console.ReadLine());


            int resultDevour = NumberOperationsLibrary.Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultDevour);

            int resultPlus = NumberOperationsLibrary.Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultPlus);

            int resultMinus = NumberOperationsLibrary.Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultMinus);

            int resultMulty = NumberOperationsLibrary.Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultMulty);



        }
    }
}
