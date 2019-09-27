using System;

class Solution
{

    // Complete the staircase function below.
    static void staircase(int n)
    {

        //Console.WriteLine(new string(' ', n - 1) + "#");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('#', i +1).PadLeft(n));
            //Console.WriteLine(new string(' ', n - 1) + new string('#', i + 1).PadLeft(n));
        }

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
