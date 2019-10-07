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


            int resultDevour = Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultDevour);

            int resultPlus = Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultPlus);

            int resultMinus = Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultMinus);

            int resultMulty = Operations.Devour(firstNum, thurdNum);
            Console.WriteLine(resultMulty);



        }
    }
}
