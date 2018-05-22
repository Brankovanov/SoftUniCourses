using System;
using System.Globalization;

namespace Lab_01_DayOfWeek
{
    public class dayOfWeek
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }
        
        //Получаване на входна информация.
        static void ReceiveInput()
        {
            var date = Console.ReadLine();

            CreateDate(date);
        }

        //Създава дата.
        static void CreateDate(string date)
        {
            Day firstDay = new Day(date);
            firstDay.Date = date;

            Print(firstDay);
        }

        //Отпечатва резултат.
        static void Print(Day firstDay)
        {
            firstDay.CreateDate();
        }
    }

    //Клас Day - създава обект Day и отпечатва.
    public class Day
    {
        private string date;

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public Day(string date)
        {
            this.date = date;
        }

        public void CreateDate()
        {
            var newDate = date.Split('-');
            var outPut = new DateTime(int.Parse(newDate[2]), int.Parse(newDate[1]), int.Parse(newDate[0]));
            Console.Write(outPut.DayOfWeek);
        }
    }
}
