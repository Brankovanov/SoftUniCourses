using System;
using System.Text.RegularExpressions;

namespace Lab_02_MatchPhoneNumbers
{
    public class matchPhoneNumbers
    {
        public static void Main(string[] args)
        {
            ReceivePhoneNumbers();
        }

        //Получава списък с телефонни номера от конзолата.
        static void ReceivePhoneNumbers()
        {
            var phoneNumbers = Console.ReadLine();
            SortPhoneNumbers(phoneNumbers);
        }

        //Сортира получените номера. 
        static void SortPhoneNumbers(string phoneNumbers)
        {
            var filter = @"\+[359]{3}([-]|[ ])[2]{1}\1[0-9]{3}\1[0-9]{4}\b";
            var phones = Regex.Matches(phoneNumbers, filter);
            var output = string.Empty;

            foreach(Match phone in phones)
            {
                output+= phone.Value + ", ";
            }

            output = output.Remove(output.Length - 2, 1);
            PrintPhone(output);
        }

        //Принтира получените телефонни номера след филтрирането на входната информация.
        static void PrintPhone(string output)
        {
            Console.Write(output);
        }
    }
}
