using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_HandsOfCards
{
    public class handsOfCards
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            List<string> listOfPlayers = new List<string>();

            var input = Console.ReadLine();
            listOfPlayers.Add(input);

            while (input != "JOKER")
            {
                input = Console.ReadLine();
                listOfPlayers.Add(input);
            }

            listOfPlayers.Remove("JOKER");

            CreateGameRecord(listOfPlayers);
        }

        static void CreateGameRecord(List<string> listOfPlayers)
        {
            Dictionary<string, int> gameRecord = new Dictionary<string, int>();
            List<string> temp = new List<string>();
            var name = string.Empty;
            var finalPoints = 0;
            var card = string.Empty;

            foreach (var player in listOfPlayers)
            {
                temp = player.Split(' ', ',').ToList();
                temp.RemoveAll(X => X == "");
                name = temp[0];

                for (var index = 1; index <= temp.Count - 1; index++)
                {
                    card = temp[index];
                    CalculatePoints(card, finalPoints, gameRecord, name);

                    if (temp.Contains(card))
                    {
                        temp.RemoveAll(x => x == card);
                        index -= 1;
                    }

                    card = string.Empty;
                }

                temp.RemoveRange(0, temp.Count);
                name = string.Empty;
                finalPoints = 0;
            }

            Print(gameRecord);
        }

        static void CalculatePoints(string card, int finalPoints, Dictionary<string, int> gameRecord, string name)
        {
            var points = 0;
            card.Split();
            var multiplier = 0;

            switch (card[1])
            {
                case 'S':
                    multiplier = 4;
                    break;
                case 'H':
                    multiplier = 3;
                    break;
                case 'D':
                    multiplier = 2;
                    break;
                case 'C':
                    multiplier = 1;
                    break;
                case '0':
                    switch (card[2])
                    {
                        case 'S':
                            multiplier = 4;
                            break;
                        case 'H':
                            multiplier = 3;
                            break;
                        case 'D':
                            multiplier = 2;
                            break;
                        case 'C':
                            multiplier = 1;
                            break;
                    }
                    break;
            }

            switch (card[0])
            {
                case '1':
                    points += (10 * multiplier);
                    break;
                case '2':
                    points += (2 * multiplier);
                    break;
                case '3':
                    points += (3 * multiplier);
                    break;
                case '4':
                    points += (4 * multiplier);
                    break;
                case '5':
                    points += (5 * multiplier);
                    break;
                case '6':
                    points += (6 * multiplier);
                    break;
                case '7':
                    points += (7 * multiplier);
                    break;
                case '8':
                    points += (8 * multiplier);
                    break;
                case '9':
                    points += (9 * multiplier);
                    break;
                case 'J':
                    points += (11 * multiplier);
                    break;
                case 'Q':
                    points += (12 * multiplier);
                    break;
                case 'K':
                    points += (13 * multiplier);
                    break;
                case 'A':
                    points += (14 * multiplier);
                    break;
            }

            finalPoints += points;
            FillTheDict(gameRecord, finalPoints, name);
        }

        static void FillTheDict(Dictionary<string, int> gameRecord, int finalPoints, string name)
        {
            if (gameRecord.ContainsKey(name))
            {
                gameRecord[name] += finalPoints;
            }
            else
            {
                gameRecord.Add(name, finalPoints);
            }


        }

        static void Print(Dictionary<string, int> gameRecord)
        {
            foreach (var entry in gameRecord)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
