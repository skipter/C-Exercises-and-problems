using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution              //Work in hakerrank.com with automatic cases
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        string[] tokens = s.Split(':');
        string hourStr = tokens[0];
        int hour = Int32.Parse(tokens[0]);

        string minutesStr = tokens[1];
        char[] chars = tokens[2].ToCharArray();

        string convertSeconds = "" + chars[0] + chars[1];
        string amPm = "" + chars[2] + chars[3];

        if (amPm == "PM" && hour != 12)
        {
            hour += 12;
            hourStr = "" + hour;
        }
        else if (amPm == "AM" && hour == 12)
        {
            hourStr = "00";
        }

        string result = hourStr + ":" + minutesStr + ":" + convertSeconds;
        return result;

        //DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt",
        //    System.Globalization.CultureInfo.InvariantCulture);
        //string result = dateTime.ToString("HH:mm:ss");
        //return result;
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
