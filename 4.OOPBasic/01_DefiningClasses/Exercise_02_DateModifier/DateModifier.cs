using System;

namespace Exercise_02_DateModifier
{
    //Records the starting and ending date and calculates how many days are between them.
    public class DateModifier
    {
        private string start;
        private string end;

        public string Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public string End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }

        public DateModifier(string start, string end)
        {
            this.start = start;
            this.end = end;
        }

        public double CountDays(string start, string end)
        {
            return Math.Abs((Convert.ToDateTime(start) - Convert.ToDateTime(end)).TotalDays);
        }
    }
}