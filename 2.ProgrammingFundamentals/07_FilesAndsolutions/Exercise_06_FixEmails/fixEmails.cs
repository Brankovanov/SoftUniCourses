using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_06_FixEmails
{
    public class fixEmails
    {
        public static void Main(string[] args)
        {
            ProccessInput();
        }

        //Обработва входа от фахка input.txt.
        static void ProccessInput()
        {
            List<string> tempList = File.ReadAllLines("./input.txt").ToList();
            CreateWorkingDictionary(tempList);
            PrintOutput();
        }

        //Създава речник, който съдържа работещо имейл адреси и имената на юзърите.
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

            File.Delete("./output.txt");
            CreateOutputFile(emailsDictionary);
        }

        //Създава файл output.txt, където се съхраняват работещите имейли и имената на юзърите.
        static void CreateOutputFile(Dictionary<string, string> emailsDictionary)
        {
            foreach (var email in emailsDictionary)
            {
                File.AppendAllText("./output.txt", email.Key + " -> ");
                File.AppendAllText("./output.txt", email.Value.ToString() + "\r\n");
            }
        }

        //Отпечатва на конзолата информацията от файл output.txt.
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("./output.txt"));
        }
    }
}

