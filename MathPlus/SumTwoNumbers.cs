using System;

namespace MathPlus
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = MathOperation.MathPlusIntegers(a ,b);
            Console.WriteLine(result);

            //int result = MathPlusIntegers(a, b);
            //Console.WriteLine(result);
        }

        //private static int MathPlusIntegers(int a, int b)
        //{
        //    int result = a + b;
        //    return result;
        //}
    }
}
