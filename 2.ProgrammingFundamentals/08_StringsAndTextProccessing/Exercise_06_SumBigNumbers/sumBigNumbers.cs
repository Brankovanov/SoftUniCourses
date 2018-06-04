using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_SumBigNumbers
{
    public class sumBigNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава числа, като вход от конзолата.
        static void ReceiveInput()
        {
            var firstNumber = Console.ReadLine().TrimStart('0').ToCharArray();
            var secondNumber = Console.ReadLine().TrimStart('0').ToCharArray();

            SumTwoNumbers(firstNumber, secondNumber);
        }

        //Събира числата символ по символ
        static void SumTwoNumbers(char[] firstNumber, char[] secondNumber)
        {
            firstNumber = firstNumber.Reverse().ToArray();
            secondNumber = secondNumber.Reverse().ToArray();
            List<int> sumList = new List<int>();
            var sum = string.Empty;

            try
            {
                if (firstNumber.Count() >= secondNumber.Count())
                {
                    for (var index = 0; index <= secondNumber.Length - 1; index++)
                    {
                        sumList.Add(int.Parse(firstNumber[index].ToString()) + int.Parse(secondNumber[index].ToString()));
                    }

                    for (var innerIndex = secondNumber.Count(); innerIndex <= firstNumber.Length - 1; innerIndex++)
                    {
                        sumList.Add(int.Parse(firstNumber[innerIndex].ToString()));
                    }
                }
                else
                {
                    for (var index = 0; index <= firstNumber.Length - 1; index++)
                    {
                        sumList.Add(int.Parse(secondNumber[index].ToString()) + int.Parse(firstNumber[index].ToString()));
                    }

                    for (var innerIndex = firstNumber.Length; innerIndex <= secondNumber.Length - 1; innerIndex++)
                    {
                        sumList.Add(int.Parse(secondNumber[innerIndex].ToString()));
                    }
                }
            }
            finally
            {
                for (var ind = 0; ind <= sumList.Count - 1; ind++)
                {
                    if (sumList[ind] >= 10)
                    {
                        sum += sumList[ind].ToString()[1];
                        try
                        {
                            sumList[ind + 1] += 1;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            sum += "1";
                        }
                    }
                    else
                    {
                        sum += sumList[ind].ToString();
                    }
                }

                PrintSum(sum);
            }
        }

        //Oтпечатва резултата на конзолата.
        static void PrintSum(string sum)
        {
            var print = sum.Reverse().ToArray();
            Console.Write(new string(print));
        }
    }
}