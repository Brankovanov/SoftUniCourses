using System.Collections.Generic;

namespace Exercise_05_OnlineRadioDatabase
{
    //Creates a playlist class that holds a list of songs and the total time of all the recordings.
    public class Playlist
    {
        private List<Song> listOfSongs;
        private int totalTime;

        public List<Song> ListOfSongs
        {
            get
            {
                return this.listOfSongs;
            }
            set
            {
                this.listOfSongs = value;
            }
        }

        public int TotalTime
        {
            get
            {
                return this.totalTime;
            }
            set
            {
                this.totalTime = value;
            }
        }

        public Playlist()
        {
            this.ListOfSongs = new List<Song>();
            this.TotalTime = totalTime;
        }

        public void AddSong(Song newSong)
        {
            listOfSongs.Add(newSong);
            var temp = newSong.Time.Split(':');
            var minutes = int.Parse(temp[0]);
            var seconds = int.Parse(temp[1]);
            seconds += minutes * 60;
            totalTime += seconds;
        }
    }
}