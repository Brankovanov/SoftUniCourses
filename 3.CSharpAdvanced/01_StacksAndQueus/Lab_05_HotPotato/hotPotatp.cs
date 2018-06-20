using System;
using System.Collections.Generic;

namespace Lab_05_HotPotato
{
    public class hotPotatp
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var participants = Console.ReadLine().Split(' ');
            var hotPotato = int.Parse(Console.ReadLine());

            PlayTheGame(participants, hotPotato);
        }

        //Recreates the game of Hotpotato.
        static void PlayTheGame(string[] participants, int hotpotato)
        {
            var temp = new List<string>();
            temp.AddRange(participants);

            var playrsLeftTheGame = new Queue<string>();
            var potato = 1;

            while (temp.Count > 0)
            {
                for (var index = 0; index <= temp.Count - 1; index++)
                {
                    if (potato == hotpotato)
                    {
                        playrsLeftTheGame.Enqueue(temp[index]);
                        temp.Remove(temp[index]);
                        index--;
                        potato = 1;
                    }
                    else
                    {
                        potato++;
                    }
                }
            }

            EndTheGame(playrsLeftTheGame);
        }

        //Prints the playrs in the order they left the game.
        static void EndTheGame(Queue<string> playersLeftTheGame)
        {
            while (playersLeftTheGame.Count > 1)
            {
                Console.WriteLine("Removed " + playersLeftTheGame.Dequeue());
            }

            Console.WriteLine("Last is " + playersLeftTheGame.Dequeue());
        }
    }
}