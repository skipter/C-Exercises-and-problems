using System.CodeDom.Compiler;
using System;
using System.Linq;

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        arr = arr.OrderByDescending(c => c).ToArray();

        long bestSum = 0;
        long bestMinSum = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            bestSum += arr[i];
        }

        arr = arr.OrderBy(c => c).ToArray();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            bestMinSum += arr[i];
        }
        Console.WriteLine(bestMinSum + " " + bestSum);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
