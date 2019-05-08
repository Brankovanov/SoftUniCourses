using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        private string dateOne;
        private string dateTwo;

        public string DateOne
        {
            get
            {
                return this.dateOne;
            }
            set
            {
                this.dateOne = value;
            }
        }

        public string DateTwo
        {
            get
            {
                return this.dateTwo;
            }
            set
            {
                this.dateTwo = value;
            }
        }

        public DateModifier(string firstDate, string secondDate)
        {
            this.DateOne = firstDate;
            this.DateTwo = secondDate;
        }

        public  double CalculateDifference()
        {
            var temp = this.DateOne.Split(' ');
            var year = int.Parse(temp[0]);
            var month = 0;

            if (temp[1].StartsWith('0'))
            {
                month = int.Parse(temp[1][1].ToString());
            }
            else
            {
                month = int.Parse(temp[1]);
            }

            var date = int.Parse(temp[2]);

            var fist = new DateTime(year, month, date);

             temp = this.DateTwo.Split(' ');
             year = int.Parse(temp[0]);
             month = 0;

            if (temp[1].StartsWith('0'))
            {
                month = int.Parse(temp[1][1].ToString());
            }
            else
            {
                month = int.Parse(temp[1]);
            }

             date = int.Parse(temp[2]);

            var second = new DateTime(year, month, date);

            var difference = (fist - second).TotalDays;

            return Math.Abs(difference);
        }
    }
}