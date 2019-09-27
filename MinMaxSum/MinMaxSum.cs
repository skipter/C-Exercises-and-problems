using System.CodeDom.Compiler;
using System;

class Solution
{

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        int currentSum = 0;
        int bestSum = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            currentSum += arr[i];
        }
        for (int i = 1; i < arr.Length; i++)
        {
            bestSum += arr[i];
        }

    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
