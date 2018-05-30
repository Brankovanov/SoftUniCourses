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

        //Получава информация за датите от конзолата.
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

        //Създава речници с имената на студентите и датите на посещение.
        static void CreateDates(List<string> temp)
        {
            SortedDictionary<string, List<string>> dictionaryOfDates = new SortedDictionary<string, List<string>>();
            List<string> listOfDates = new List<string>();
            var name = string.Empty;

            foreach (var entry in temp)
            {
                listOfDates = entry.Split(' ', ',').ToList();
                name = listOfDates[0];
                listOfDates.RemoveAt(0);

                if (!dictionaryOfDates.ContainsKey(name))
                {
                    dictionaryOfDates[name] = new List<string>();
                }

                listOfDates.Sort();
                dictionaryOfDates[name].AddRange(listOfDates);
            }

            ReceiveMessages(dictionaryOfDates);
        }

        //Получава съобщения за студентите.
        static void ReceiveMessages(SortedDictionary<string, List<string>> dictionaryOfDates)
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

        //Създава речник с имената на студентите и съобщенията за всеки от тях.
        static void CreateMessages(List<string> temp, SortedDictionary<string, List<string>> dictionaryOfDates)
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
                else if (dictionaryOfMessages.ContainsKey(name) && dictionaryOfDates.ContainsKey(name))
                {
                    dictionaryOfMessages[name].Add(message);
                }
            }

            GenerateReport(dictionaryOfDates, dictionaryOfMessages);
        }

        //Извиква клас GenerateReport и създава обект newReport.
        static void GenerateReport(SortedDictionary<string, List<string>> dictionaryOfDates, Dictionary<string, List<string>> dictionaryOfMessages)
        {
            GenerateReport newReport = new GenerateReport();
            newReport.Dates = dictionaryOfDates;
            newReport.Messages = dictionaryOfMessages;

            PrintReport(newReport);
        }

        //Извиква метод CreateRecord от обекта newReport.
        static void PrintReport(GenerateReport newReport)
        {
            newReport.CreateRecord();
        }
    }

    //Клас GenerateReport. Създава обект, който държи речниците с имената на студентите,
    //датите на посещение и съобщенията. Генерира общ доклад.
    public class GenerateReport
    {
        private SortedDictionary<string, List<string>> dates;
        private Dictionary<string, List<string>> messages;

        public SortedDictionary<string, List<string>> Dates
        {
            get
            {
                return this.dates;
            }
            set
            {
                this.dates = value;
            }
        }

        public Dictionary<string, List<string>> Messages
        {
            get
            {
                return this.messages;
            }
            set
            {
                this.messages = value;
            }
        }

        public GenerateReport()
        {
            this.dates = Dates;
            this.messages = Messages;
        }

        //Създава общ отчет за студентите с датите и съобщенията за тях.
        public void CreateRecord()
        {
            foreach (var name in Dates)
            {
                Console.WriteLine(name.Key);
                Console.WriteLine("Comments:");

                try
                {
                    foreach (var comment in Messages[name.Key])
                    {
                        Console.WriteLine("- " + comment);
                    }
                }
                catch (KeyNotFoundException)
                {
                }

                try
                {
                    Console.WriteLine("Dates attended:");

                    foreach (var date in name.Value)
                    {
                        Console.WriteLine("-- " + date);
                    }
                }
                catch (KeyNotFoundException)
                {
                }
            }
        }
    }
}
