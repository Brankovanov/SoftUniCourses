using System;
using System.Linq;

namespace Exercise_07_SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main(string[] args)
        {
            ReceiveNumbers();
        }

        //Receives numbers from the console.
        public static void ReceiveNumbers()
        {
            var numberOne = Console.ReadLine();
            var numberTwo = Console.ReadLine();

            Calculate(numberOne, numberTwo);
        }

        //Calculates the sum of the two numbers.
        public static void Calculate(string numberOne, string numberTwo)
        {
            var one = numberOne.Reverse().Select(x => x.ToString()).ToArray();
            var two = numberTwo.Reverse().Select(y => y.ToString()).ToArray();
            var additive = 0;
            var sum = 0;
            var answer = string.Empty;

            for (var index = 0; index < Math.Max(one.Length, two.Length); index++)
            {
                if (index < Math.Min(one.Length, two.Length))
                {
                    sum = (int.Parse(one[index]) + int.Parse(two[index])) + additive;
                    additive = 0;

                    if (sum <= 9)
                    {
                        answer += sum.ToString();
                    }
                    else
                    {
                        sum = sum % 10;
                        additive = 1;
                        answer += sum.ToString();
                    }
                }
                else if (Math.Max(one.Length, two.Length) == one.Length)
                {
                    sum = (int.Parse(one[index])) + additive;
                    additive = 0;

                    if (sum <= 9)
                    {
                        answer += sum.ToString();
                    }
                    else if (index == Math.Max(one.Length, two.Length) - 1)
                    {
                        if (sum <= 9)
                        {
                            answer += sum.ToString();
                        }
                        else
                        {
                            sum = sum % 10;
                            additive = 1;
                            answer += sum.ToString();
                            answer += additive.ToString();
                        }
                    }
                    else
                    {
                        sum = sum % 10;
                        additive = 1;
                        answer += sum.ToString();
                    }
                }
                else if (Math.Max(one.Length, two.Length) == two.Length)
                {
                    sum = (int.Parse(two[index])) + additive;
                    additive = 0;

                    if (sum <= 9)
                    {
                        answer += sum.ToString();
                    }
                    else if (index == Math.Max(one.Length, two.Length) - 1)
                    {
                        if (sum <= 9)
                        {
                            answer += sum.ToString();
                        }
                        else
                        {
                            sum = sum % 10;
                            additive = 1;
                            answer += sum.ToString();
                            answer += additive.ToString();
                        }
                    }
                    else
                    {
                        sum = sum % 10;
                        additive = 1;
                        answer += sum.ToString();
                    }
                }
            }

            Print(answer);
        }

        //Prints the answer on the console.
        static void Print(string answer)
        {
            Console.WriteLine(string.Join(string.Empty, answer.Reverse()));
        }
    }
}