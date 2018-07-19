using System;
using System.Text.RegularExpressions;

namespace Lab_07_ValidUserName
{
    public class ValidUsername
    {
        public static void Main(string[] args)
        {
            ReceiveLogs();
        }

        //Receive user logs from the console.
        public static void ReceiveLogs()
        {
            var log = Console.ReadLine();

            while (log != "END")
            {
                FindUserName(log);
                log = Console.ReadLine();
            }
        }

        //Finds the valid usernames in the logs.
        public static void FindUserName(string log)
        {
            var pattern = new Regex(@"^[\w-]{3,16}$");
            var username = pattern.IsMatch(log);
            Print(username);
        }

        //Prints whether the received username is valid or not.
        public static void Print(bool username)
        {
            if (username == true)
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