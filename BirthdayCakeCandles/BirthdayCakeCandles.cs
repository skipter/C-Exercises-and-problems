using System;
using System.IO;
using System.Linq;

class Solution
{
    // NB its compiling in hackerrank.com in automatic cases
    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {
        int maxNumber = ar.Max();
        int counter = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if (maxNumber == ar[i])
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
