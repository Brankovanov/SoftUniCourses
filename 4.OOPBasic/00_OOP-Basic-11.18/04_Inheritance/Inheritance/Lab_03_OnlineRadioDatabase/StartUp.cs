using System;

namespace Lab_03_OnlineRadioDatabase
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveSongs();
        }

        public static void ReceiveSongs()
        {
            var numberOfSongs = int.Parse(Console.ReadLine());
            var onlineRadio = new OnlineRadio();

            for (var song = 0; song < numberOfSongs; song++)
            {
                var songInformation = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.None);
                var artistName = songInformation[0];
                var songName = songInformation[1];
                var songLenght = songInformation[2].Split(new char[] { ':' }, StringSplitOptions.None);
                var minutes = int.Parse(songLenght[0]);
                var seconds = int.Parse(songLenght[1]);

                try
                {
                    var newSong = new Song(artistName, songName, minutes, seconds);
                    onlineRadio.PlayList.Add(newSong);
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException x)
                {
                    Console.WriteLine(x.Message);                  
                }              
            }

            PrintResult(onlineRadio);
        }

        public static void PrintResult(OnlineRadio onlineRadio)
        {
            Console.WriteLine($"Songs added: {onlineRadio.PlayList.Count}");
            Console.WriteLine($"Playlist lenght: {onlineRadio.CalculateLenght()}");
        }
    }
}
