using System;

namespace Lab_03_OnlineRadioDatabase
{
    public class Song
    {
        private string title;
        private string artist;
        private int minutes;
        private int seconds;


        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    this.title = value;
                }
                else
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
            }
        }

        public string Artist
        {
            get
            {
                return this.artist;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 20)
                {
                    this.artist = value;
                }
                else
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.:");
                }
            }
        }

        public int Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {


                if (value >= 0 && value <= 59)
                {

                    this.seconds = value;
                }
                else
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                }

            }
        }
        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
               
                
                    if (value >= 0 && value <= 14)
                    {
                     
                            this.minutes = value;
                    }
                    else
                    {
                        throw new ArgumentException("Song minutes should be between 0 and 14.");
                    }

            }
        }

        public Song(string artist, string title, int minutes, int seconds)
        {
            this.Artist = artist;
            this.Title = title;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}
