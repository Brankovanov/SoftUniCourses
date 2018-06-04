using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_07_MultiplyBigNumber
{
    public class multiplyBigNumber
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава числа, като вход от конзолата.
        static void ReceiveInput()
        {
            var bigMultiplier = Console.ReadLine().TrimStart('0').ToCharArray();
            var smallMultiplier = int.Parse(Console.ReadLine());
            var answer = string.Empty;

            if (smallMultiplier == 0)
            {
                answer = "0";
                PrintSum(answer);
            }
            else
            {
                SumTwoNumbers(bigMultiplier, smallMultiplier,answer);
            }
        }

        //Умножава числата символ по символ
        static void SumTwoNumbers(char[] bigMultiplier, int smallMultiploer, string answer)
        {
            bigMultiplier = bigMultiplier.Reverse().ToArray();
            List<int> multiplyList = new List<int>();

            foreach (var digit in bigMultiplier)
            {
                multiplyList.Add(int.Parse(digit.ToString()) * smallMultiploer);
            }

            for (var digit = 0; digit <= multiplyList.Count - 1; digit++)
            {
                if (multiplyList[digit] >= 10)
                {
                    try
                    {
                        answer += (multiplyList[digit] % 10).ToString();
                        multiplyList[digit + 1] += multiplyList[digit] / 10;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                       answer += multiplyList[digit] / 10;
                    }
                   
                }
                else
                {
                    answer += multiplyList[digit].ToString();
                }
            }

            PrintSum(answer);
        }

        //Oтпечатва резултата на конзолата.
        static void PrintSum(string answer)
        {
            var print = answer.Reverse().ToArray();
            Console.Write(new string(print));
        }
    }
}