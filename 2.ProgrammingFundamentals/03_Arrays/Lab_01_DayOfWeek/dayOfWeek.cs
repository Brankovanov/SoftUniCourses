using System;

namespace Lab_01_DayOfWeek
{
    public class dayOfWeek
    {
        public static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var input = Input();

            printDay(input, daysOfWeek);
        }

        static int Input()
        {
            return int.Parse(Console.ReadLine());
        }

        static void printDay(int input, string[] daysOfWeek)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine(daysOfWeek[input - 1].ToString());
                    break;
                case 2:
                    Console.WriteLine(daysOfWeek[input - 1].ToString());
                    break;
                case 3:
                    Console.WriteLine(daysOfWeek[input - 1].ToString());
                    break;
                case 4:
                    Console.WriteLine(daysOfWeek[input - 1].ToString());
                    break;
                case 5:
                    Console.WriteLine(daysOfWeek[input - 1].ToString());
                    break;
                case 6:
                    Console.WriteLine(daysOfWeek[input - 1].ToString());
                    break;
                case 7:
                    Console.WriteLine(daysOfWeek[input - 1].ToString());
                    break; ;
                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}
