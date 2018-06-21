using System;
using System.Collections.Generic;

namespace Exercise_01_uniqueUserNames
{
    public class uniqueUserNames
    {
        public static void Main(string[] args)
        {
            ReceiveUserNames();
        }

        //Receives user names from the console.
        static void ReceiveUserNames()
        {
            var userNameArhive = new Queue<string>();
            var userName = string.Empty;
            var numberOfUserNames = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfUserNames; index++)
            {
                userName = Console.ReadLine();
                RecordUniqueUserName(userName, userNameArhive);
            }

            PrintUniqueUsernames(userNameArhive);
        }

        //Records unique user names.
        static void RecordUniqueUserName(string userName, Queue<string> userNameArhive)
        {
            if (!userNameArhive.Contains(userName))
            {
                userNameArhive.Enqueue(userName);
            }
        }

        //Prints unique user names.
        static void PrintUniqueUsernames(Queue<string> userNameArhive)
        {
            while (userNameArhive.Count > 0)
            {
                Console.WriteLine(userNameArhive.Dequeue());
            }
        }
    }
}