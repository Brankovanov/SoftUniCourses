using System;
using System.Globalization;

namespace Lab_09_HolidaysBetweenTwoDatesRefactoring
{
    public class HolidaysBetweenTwoDatesRefactoring
    {
        public static void Main(string[] args)
        {
            var startDate = new DateTime();
            var endDate = new DateTime();
            var holidaysCount = 0;

            Input(startDate, endDate, holidaysCount);       
        }

        static void Input(DateTime startDate, DateTime endDate, int holidaysCount)
        {
            startDate = DateTime.ParseExact(Console.ReadLine(),"d.m.yyyy", CultureInfo.InvariantCulture);

            endDate = DateTime.ParseExact(Console.ReadLine(),"d.m.yyyy", CultureInfo.InvariantCulture);

            CountHolidays(startDate, endDate, holidaysCount);
        }

        static void CountHolidays(DateTime startDate, DateTime endDate, int holidaysCount)
        {
            for (var date = startDate; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }            
            }

            Console.WriteLine(holidaysCount);
        }
    }
}

