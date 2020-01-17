using System.Collections.Generic;

namespace Lab_03_OnlineRadioDatabase
{
    public class OnlineRadio
    {
        private List<Song> playList;

        public List<Song> PlayList
        {
            get
            {
                return this.playList;
            }
            set
            {
                this.playList = value;
            }
        }

        public OnlineRadio()
        {
            this.PlayList = new List<Song>();
        }

        public string CalculateLenght()
        {
            var seconds = 0;
            var minutes = 0;
            var hours = 0;

            foreach(var s in this.PlayList)
            {
                seconds += s.Seconds;
                minutes += s.Minutes;
            }

            minutes += seconds / 60;
            seconds = seconds % 60;
            hours += minutes / 60;
            minutes = minutes % 60;

            return $"{hours}h {minutes}m {seconds}s";

        }
    }
}