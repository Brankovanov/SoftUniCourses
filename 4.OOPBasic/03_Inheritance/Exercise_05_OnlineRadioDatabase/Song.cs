using System;

namespace Exercise_05_OnlineRadioDatabase
{
    //Creates a song class that holds the song's artist name, song name and duration.
    public class Song
    {
        private string artistName;
        private string songName;
        private string time;

        public string ArtistName
        {
            get
            {
                return this.artistName;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 20)
                {
                    this.artistName = value;
                }
                else
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
            }
        }

        public string SongName
        {
            get
            {
                return this.songName;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    this.songName = value;
                }
                else
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                var temp = value.Split(':');
                var minutes = int.Parse(temp[0]);
                var seconds = int.Parse(temp[1]);

                if (minutes >= 0 && minutes <= 14)
                {
                    if (seconds >= 0 && seconds <= 59)
                    {
                        this.time = value;
                    }
                    else
                    {
                        throw new ArgumentException("Song seconds should be between 0 and 59.");
                    }
                }
                else
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }
            }
        }

        public Song(string artistName, string songName, string time)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Time = time;
        }
    }
}