using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_19_ExamResults
{
    public class ExamResults
    {
        public static void Main(string[] args)
        {
            ReceiveExamInformation();
        }

        //Receives exam information from the console.
        static void ReceiveExamInformation()
        {
            var studentResult = new Dictionary<string, int>();
            var languages = new Dictionary<string, int>();
            var participants = Console.ReadLine();

            while (participants != "exam finished")
            {
               ProccessResults(participants, studentResult, languages);
                participants = Console.ReadLine();
            }

            PrintExamResults(studentResult, languages);
        }

        //Proccesses the incoming participant information.
        static void ProccessResults(string participants, Dictionary<string, int> studentResults, Dictionary<string, int> languages)
        {
            var temp = participants.Split('-');
            var name = temp[0];
            var language = temp[1];
            var points = 0;

            if (!language.Equals("banned") && !studentResults.ContainsKey(name))
            {
                points = int.Parse(temp[2]);
                studentResults.Add(name, points);

                if (!languages.ContainsKey(language))
                {
                    languages.Add(language, 1);
                }
                else
                {
                    languages[language]++;
                }
            }
            else if (!language.Equals("banned") && studentResults.ContainsKey(name) && int.Parse(temp[2]) > studentResults[name])
            {
                points = int.Parse(temp[2]);
                studentResults[name] = points;

                if (!languages.ContainsKey(language))
                {
                    languages.Add(language, 1);
                }
                else
                {
                    languages[language]++;
                }
            }
            else if (!language.Equals("banned") && studentResults.ContainsKey(name) && int.Parse(temp[2]) <= studentResults[name])
            {

                if (!languages.ContainsKey(language))
                {
                    languages.Add(language, 1);
                }
                else
                {
                    languages[language]++;
                }
            }
            else if (language.Equals("banned") && studentResults.ContainsKey(name))
            {
                studentResults.Remove(name);
            }
        }

        //Prints final results from the exam.
        static void PrintExamResults(Dictionary<string, int> studentResults, Dictionary<string, int> languages)
        {
            Console.WriteLine("Results:");

            foreach (var student in studentResults.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in languages.OrderByDescending(c => c.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}