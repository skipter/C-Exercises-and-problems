using System;

class Solution
{

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        int zeroCounter = 0;
        int positiveCounter = 0;
        int negativeCounter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                zeroCounter++;
            }
            else if (arr[i] > 0)
            {
                positiveCounter++;
            }
            else
            {
                negativeCounter++;
            }
        }

        double pos = (double)positiveCounter / arr.Length;
        double negative = (double)negativeCounter / arr.Length;
        double zero = (double)zeroCounter / arr.Length;

        Console.WriteLine($"{pos:F5}");
        Console.WriteLine($"{negative:F5}");
        Console.WriteLine($"{zero:F5}");

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
