using System;

namespace Exercise_02_DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives dates from the console.
        public static void ReceiveInput()
        {
            var startDate = Console.ReadLine().Replace(' ', '/');
            var endDate = Console.ReadLine().Replace(' ', '/');
            var mod = new DateModifier(startDate, endDate);
            PrintDays(mod);
        }

        //Prints the number of days between two dates.
        public static void PrintDays(DateModifier mod)
        {
            Console.WriteLine(mod.CountDays(mod.Start, mod.End));
        }
    }
}