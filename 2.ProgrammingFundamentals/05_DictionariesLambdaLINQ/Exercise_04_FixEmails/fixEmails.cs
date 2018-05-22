using System;
using System.Collections.Generic;

namespace Exercise_04_FixEmails
{
    public class fixEmails
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            List<string> tempList = new List<string>();

            var inputEmails = Console.ReadLine();
            tempList.Add(inputEmails);

            while (inputEmails != "stop")
            {
                inputEmails = Console.ReadLine();
                tempList.Add(inputEmails);
            }

            tempList.Remove("stop");
            CreateWorkingDictionary(tempList);
        }

        static void CreateWorkingDictionary(List<string> tempList)
        {
            Dictionary<string, string> emailsDictionary = new Dictionary<string, string>();

            for (var index = 0; index <= tempList.Count - 1; index += 2)
            {
                if (emailsDictionary.ContainsKey(tempList[index]))
                {
                    emailsDictionary[tempList[index]] += tempList[index + 1];
                }
                else if (tempList[index + 1].Contains(".bg"))
                {
                    emailsDictionary.Add(tempList[index], tempList[index + 1]);
                }
            }

            Print(emailsDictionary);
        }

        static void Print(Dictionary<string, string> emailsDictionary)
        {
            foreach (var email in emailsDictionary)
            {
                Console.WriteLine(email.Key + " -> " + email.Value);
            }
        }
    }
}