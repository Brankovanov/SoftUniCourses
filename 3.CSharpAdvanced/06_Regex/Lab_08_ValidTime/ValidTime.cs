using System;
using System.Text.RegularExpressions;

namespace Lab_08_ValidTime
{
    public class ValidTime
    {
        public static void Main(string[] args)
        {
            ReceiveTime();
        }

        //Receives time from the console.
        public static void ReceiveTime()
        {
            var time = Console.ReadLine();

            while (time != "End")
            {
                CheckDate(time);
                time = Console.ReadLine();
            }
        }

        //Checks if the incoming time entry is valid.
        public static void CheckDate(string time)
        {
            var timePattern = new Regex("([0]{1}[0-9]{1}|[1]{1}[0-1]{1}):([0-5]{1}[0-9]{1}):([0-5]{1}[0-9]{1}) (AM|PM)");
            var validityChecker = timePattern.IsMatch(time);
            PrintResult(validityChecker);
        }

        //Prints whether the incoming date time format is valid or not. 
        public static void PrintResult(bool validitiChecker)
        {
            if (validitiChecker == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}