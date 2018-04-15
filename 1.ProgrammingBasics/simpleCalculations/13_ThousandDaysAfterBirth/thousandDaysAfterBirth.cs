using System;
using System.Globalization;

namespace _13_ThousandDaysAfterBirth
{
    public class thousandDaysAfterBirth
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var result = date.AddDays(999);

            Console.WriteLine(result.ToString("dd-MM-yyyy"));
        }
    }
}
