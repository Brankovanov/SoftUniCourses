using System;

namespace _10_Exercise_CenturiesToNanoseconds
{
    public class centuriesToNanoseconds
    {
        public static void Main(string[] args)
        {
            var centuries = int.Parse(Console.ReadLine());

            var years = centuries * 100;
            var days = (int)(years * 365.2422); //A Solar year.
            var hours = days * 24;
            var minutes = hours * 60;
            var seconds = (ulong)minutes * 60;
            var milliseconds = seconds*1000;
            var microseconds = (decimal)milliseconds*1000;
            var nanoseconds = microseconds*1000;

            Console.Write("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
