using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise_06_ValidUsername
{
    public class validUsername
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава списък с регистрации от конзолаа.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();
            SortInput(input);
        }

        //Сортира получените регистрации и отсява валидните.
        static void SortInput(string input)
        {
            var pattern = @"(\b[a-zA-Z_][a-zA-Z0-9_]{1,23})[^\s?|\/?|\\?|(?|)?]\b";
            var userName = Regex.Matches(input, pattern);
            var tempList = new List<string>();

            foreach (var user in userName)
            {
                tempList.Add(user.ToString());
            }

            CalculateOutput(tempList);
        }

        //Изчислява най-дългите последователни имена.
        static void CalculateOutput(List<string> tempList)
        {
            var temp = 0;
            var biggest = 0;
            var output = string.Empty;

            for (var index = 1; index <= tempList.Count - 1; index++)
            {
                temp = tempList[index - 1].Length + tempList[index].Length;

                if (temp > biggest)
                {
                    biggest = temp;
                    temp = 0;
                    output = tempList[index - 1] + "\n" + tempList[index];
                }
                else
                {
                    temp = 0;
                }
            }

            PrintBiggest(output);
        }

        //Отпечатва най-тългите две имена в списъка.
        static void PrintBiggest(string output)
        {
            Console.WriteLine(output);
        }
    }
}