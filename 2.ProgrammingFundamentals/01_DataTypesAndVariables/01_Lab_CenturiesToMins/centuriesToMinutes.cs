using System;

namespace _01_Lab_CenturiesToMins
{
    public class centuriesToMinutes
    {
        public static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());

            var years = centuries * 100;
            var days = (int)(years * 365.2422); //A Solar year.
            var hours = days * 24;
            var minutes = hours * 60;

            Console.Write("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);

        }
    }
}
