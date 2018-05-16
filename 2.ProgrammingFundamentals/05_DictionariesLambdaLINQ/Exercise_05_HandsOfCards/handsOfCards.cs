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
            List<string> listOfCards = new List<string>();
            var input = Console.ReadLine();
            listOfCards.Add(input);

            while (input != "JOKER")
            {
                input = Console.ReadLine();
                listOfCards.Add(input);
            }

            listOfCards.Remove("JOKER");
            CalculateResult(listOfCards);
        }

        static void CalculateResult(List<string> listOfCards)
        {
            Dictionary<string, int> resultOfTheGame = new Dictionary<string, int>();
            List<string> listOfResults = new List<string>();
            var result = 0;

            foreach (var entry in listOfCards)
            {
                listOfResults = entry.Split(' ', ',').ToList();
            }
        }
    }
}
