using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_02_SoftUniKaraoke
{
    public class softuniKaraoke
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата.
        static void ReceiveInput()
        {
            var participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
            var songs = Console.ReadLine().Split(',').Select(y => y.Trim()).ToList();
            var stagePerformace = Console.ReadLine();

            var name = string.Empty;
            var piece = string.Empty;
            var prize = string.Empty;
            var stage = new List<string>();
            var resultOfCompetition = new Dictionary<string, List<string>>();

            while (stagePerformace != "dawn")
            {
                stage = stagePerformace.Split(',').Select(z => z.Trim()).ToList();
                name = stage[0];
                piece = stage[1];
                prize = stage[2];

                if (participants.Contains(name) && songs.Contains(piece))
                {
                    CreateNewPerformance(name, piece, prize, resultOfCompetition, songs);
                }

                name = string.Empty;
                piece = string.Empty;
                prize = string.Empty;
                stage.Clear();
                stagePerformace = Console.ReadLine();
            }

            Print(resultOfCompetition);
        }

        //Сортира и записва изпълненията.
        static void CreateNewPerformance(string name, string piece, string prize, Dictionary<string, List<string>> resultOfCompetition, List<string> songs)
        {
            if (!resultOfCompetition.ContainsKey(name))
            {
                resultOfCompetition[name] = new List<string>();
            }

            if (!resultOfCompetition[name].Contains(prize))
            {
                resultOfCompetition[name].Add(prize);
            }
        }

        //Принтиране на финалните резултати.
        static void Print(Dictionary<string, List<string>> resultOfCompetition)
        {
            if (!resultOfCompetition.Any())
            {
                Console.Write("No awards");
            }
            else
            {
                foreach (var performer in resultOfCompetition.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
                {
                    Console.WriteLine(performer.Key + ": " + performer.Value.Count + " awards");
                    foreach (var award in performer.Value)
                    {
                        Console.WriteLine("--" + award);
                    }
                }
            }
        }
    }
}