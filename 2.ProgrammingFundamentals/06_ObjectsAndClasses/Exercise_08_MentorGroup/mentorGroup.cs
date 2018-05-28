using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_08_MentorGroup
{
    public class mentorGroup
    {
        public static void Main(string[] args)
        {
            ReceiveDates();
        }

        static void ReceiveDates()
        {
            var input = string.Empty;
            List<string> temp = new List<string>();

            while (input != "end of dates")
            {
                input = Console.ReadLine();
                temp.Add(input);
            }
            temp.Remove("end of dates");
            CreateDates(temp);
        }

        static void CreateDates(List<string> temp)
        {
            Dictionary<string, List<string>> dictionaryOfDates = new Dictionary<string, List<string>>();
            List<string> listOfDates = new List<string>();
            var name = string.Empty;


            foreach (var entry in temp)
            {
                listOfDates = entry.Split(' ', ',').ToList();
                name = listOfDates[0];

                if (!dictionaryOfDates.ContainsKey(name))
                {
                    dictionaryOfDates[name] = new List<string>();
                }

                for (var index = 1; index < listOfDates.Count; index++)
                {
                    dictionaryOfDates[name].Add(listOfDates[index]);
                }
            }

            foreach (var k in dictionaryOfDates)
            {
                Console.WriteLine(k.Key);

                foreach (var v in k.Value)
                {
                    Console.WriteLine(v);
                }
            }

            ReceiveMessages(dictionaryOfDates);
        }

        static void ReceiveMessages(Dictionary<string, List<string>> dictionaryOfDates)
        {
            var message = string.Empty;
            List<string> temp = new List<string>();

            while (message != "end of comments")
            {
                message = Console.ReadLine();
                temp.Add(message);
            }
            temp.Remove("end of comments");
            CreateMessages(temp, dictionaryOfDates);
        }

        static void CreateMessages(List<string> temp, Dictionary<string, List<string>> dictionaryOfDates)
        {
            Dictionary<string, List<string>> dictionaryOfMessages = new Dictionary<string, List<string>>();
            List<string> listOfMessages = new List<string>();
            var name = string.Empty;
            var message = string.Empty;

            foreach (var entry in temp)
            {
                listOfMessages = entry.Split('-').ToList();
                name = listOfMessages[0];
                message = listOfMessages[1];

                if (!dictionaryOfMessages.ContainsKey(name) && dictionaryOfDates.ContainsKey(name))
                {
                    dictionaryOfMessages[name] = new List<string>();
                    dictionaryOfMessages[name].Add(message);
                }
            
                else if (!dictionaryOfMessages.ContainsKey(name) && dictionaryOfDates.ContainsKey(name))
                {
                    dictionaryOfMessages[name].Add(message);
                }             
            }

            foreach(var asda in dictionaryOfMessages)
            {
                Console.WriteLine(asda.Key);

                foreach(var adadas in asda.Value)
                {
                    Console.WriteLine(adadas);
                }
            }
        }
    }
}
