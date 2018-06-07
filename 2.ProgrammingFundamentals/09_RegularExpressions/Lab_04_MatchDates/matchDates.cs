using System;
using System.Text.RegularExpressions;

namespace Lab_04_MatchDates
{
    public class matchDates
    {
        public static void Main(string[] args)
        {
            ReceiveDates();
        }

        //Получава входни дати от конзолата.
        static void ReceiveDates()
        {
            var inputDates = Console.ReadLine();
            SortDates(inputDates);
        }

        //Сортира входните дати и отделя тези, които са в правилния формат.
        static void SortDates(string inputDates)
        {
            var format = @"\b([0-3]{1}[0-9]{1})([.]|[-]|[\/])([JFMASOND]{1}[anebpyulgctovr]{2})\2(\d{4})\b";
            var correctDates = Regex.Matches(inputDates, format);

            PrintDates(correctDates);
        }

        //Отпечатва датите, които са в правилен Формат.
        static void PrintDates(MatchCollection correctDates)
        {
            foreach (Match date in correctDates)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }
        }
    }
}
