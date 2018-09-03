using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_OnlineRadioDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            ReceiveInformation();
        }

        //Receives songs information from the console.
        public static void ReceiveInformation()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            var songInfo = new List<string>();
            var artistName = string.Empty;
            var songName = string.Empty;
            var time = string.Empty;
            var timeSplit = new string[2];
            var newList = new Playlist();

            for (var song = 1; song <= numberOfSongs; song++)
            {
                songInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim('<', '>')).ToList();
                artistName = songInfo[0];
                songName = songInfo[1];
                time = songInfo[2];
                timeSplit = time.Split(new char[] { ':' });

                try
                {
                    var newSong = new Song(artistName, songName, time);
                    newList.AddSong(newSong);
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            PrintResults(newList);
        }

        //Prints the number of songs on the list and its duration.
        public static void PrintResults(Playlist newList)
        {
            Console.WriteLine("Songs added: " + newList.ListOfSongs.Count);
            var t = TimeSpan.FromSeconds(newList.TotalTime);

            Console.WriteLine("Playlist length: " + t.Hours + "h " + t.Minutes + "m " + t.Seconds + "s");
        }
    }
}