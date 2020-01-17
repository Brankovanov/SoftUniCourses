using System;
using System.Collections.Generic;

namespace Ex_06_SongQueue
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveInput();
        }

        private static void ReceiveInput()
        {
            var incommingSongs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            var songQueue = new Queue<string>(incommingSongs);

            while (songQueue.Count > 0)
            {
                 var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);

                switch (command[0])
                {
                    case "Play":
                        PlaySong(songQueue);
                        break;
                    case "Add":
                        AddSong(songQueue, command);
                        break;
                    case "Show":
                        ShowSongs(songQueue);
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }

        private static void ShowSongs(Queue<string> songQueue)
        {
            Console.WriteLine(string.Join(", ", songQueue));
        }

        private static void AddSong(Queue<string> songQueue, string[] command)
        {
            var song = string.Join(' ',command,1,command.Length-1);

            if(songQueue.Contains(song))
            {
                Console.WriteLine($"{song} is already contained!");
            }
            else
            {
                songQueue.Enqueue(song);
            }
        }

        private static void PlaySong(Queue<string> songQueue)
        {
            songQueue.Dequeue();
        }
    }
}