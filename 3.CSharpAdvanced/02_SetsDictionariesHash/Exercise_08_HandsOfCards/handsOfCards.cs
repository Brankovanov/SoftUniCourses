using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_08_HandsOfCards
{
    public class handsOfCards
    {
        public static void Main(string[] args)
        {
            ReceivePlayers();
        }

        //Receives the player's information from the console.
        static void ReceivePlayers()
        {
            var gameRecord = new Dictionary<string, HashSet<string>>();
            var player = string.Empty;
            var hand = string.Empty;
            var playerHand = Console.ReadLine();

            while (playerHand != "JOKER")
            {
                var temp = playerHand.Split(':');
                player = temp[0];
                hand = temp[1];

                RecordPlayers(player, hand, gameRecord);
                playerHand = Console.ReadLine();
            }

            PrintGameResults(gameRecord);
        }

        //Records the players and their hands.
        static void RecordPlayers(string player, string hand, Dictionary<string, HashSet<string>> gameRecord)
        {
            if (gameRecord.ContainsKey(player))
            {
                foreach (var item in CreateHand(hand))
                {
                    gameRecord[player].Add(item);
                }
            }
            else
            {
                gameRecord.Add(player, new HashSet<string>(CreateHand(hand)));
            }
        }

        //Creates the players hand from the input.
        static string[] CreateHand(string hand)
        {
            var temp = hand.Split(',').Select(c => c.Trim()).ToArray();
            return temp;
        }

        //Calculates the points of the players.
        static int CalculatePlayerPoints(Queue<string> temp)
        {
            var points = 0;
            var multiplier = 0;

            foreach (var card in temp)
            {
                card.Split();

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
            }

            return points;
        }

        //Prints the results from the game.
        static void PrintGameResults(Dictionary<string, HashSet<string>> gameRecord)
        {
            foreach (var player in gameRecord)
            {
                var temp = new Queue<string>(player.Value.ToArray());
                Console.Write(player.Key + ": ");
                Console.WriteLine(CalculatePlayerPoints(temp));
            }
        }
    }
}