using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise_07_ValidUserName
{
    public class ValidUserName
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var userNames = Console.ReadLine();
            ExtractUserNames(userNames);
        }

        //Finds and extracts valid usernames.
        public static void ExtractUserNames(string userNames)
        {
            var temp = userNames.Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var userNamePattern = new Regex("^[a-zA-Z]\\w{3,25}");
            var userName = new List<string>();

            foreach (var name in temp)
            {
                var validUserName = userNamePattern.IsMatch(name);

                if (validUserName == true)
                {
                    userName.Add(name);
                }
            }

            CalculateUserNameLenght(userName);
        }

        //Calulates the username lenghts and took the too longest.
        public static void CalculateUserNameLenght(List<string> userName)
        {
            var maxLenght = 0;
            var firstUser = string.Empty;
            var secondUser = string.Empty;

            for (var name = 1; name < userName.Count; name++)
            {
                if (maxLenght < userName[name].Length + userName[name - 1].Length)
                {
                    maxLenght = userName[name].Length + userName[name - 1].Length;
                    firstUser = userName[name - 1];
                    secondUser = userName[name];
                }
            }

            Print(firstUser, secondUser);
        }

        //Prints the final answer.
        public static void Print(string firstUser, string secondUser)
        {
            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}