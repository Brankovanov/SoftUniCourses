using System;
using System.Linq;

namespace Exercise_08_MultiplyBigNumbers
{
    public class MultiplyBigNumbers
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
            Multiply(numberOne, numberTwo);
        }

        //Multiplyies the given numbers.
        public static void Multiply(string numberOne, string numberTwo)
        {
            var multiplier = string.Empty;
            var output = string.Empty;
            var additive = 0;

            for (var secondIndex = 0; secondIndex < numberTwo.Length; secondIndex++)
            {
                for (var firstIndex = 0; firstIndex < numberOne.Length; firstIndex++)
                {
                    if (int.Parse(numberOne[numberOne.Length - 1 - firstIndex].ToString()) *
                        int.Parse(numberTwo[numberTwo.Length - 1 - secondIndex].ToString()) + additive <= 9)
                    {
                        multiplier += (int.Parse(numberOne[numberOne.Length - 1 - firstIndex].ToString()) *
                    int.Parse(numberTwo[numberTwo.Length - 1 - secondIndex].ToString()) + additive).ToString();
                        additive = 0;
                    }
                    else
                    {
                        if (numberOne.Length - 1 - firstIndex != 0)
                        {
                            multiplier += ((int.Parse(numberOne[numberOne.Length - 1 - firstIndex].ToString()) *
                            int.Parse(numberTwo[numberTwo.Length - 1 - secondIndex].ToString()) + additive) % 10).ToString();
                            additive = (int.Parse(numberOne[numberOne.Length - 1 - firstIndex].ToString()) *
                            int.Parse(numberTwo[numberTwo.Length - 1 - secondIndex].ToString()) + additive) / 10;
                        }
                        else
                        {
                            multiplier += ((int.Parse(numberOne[numberOne.Length - 1 - firstIndex].ToString()) *
                           int.Parse(numberTwo[numberTwo.Length - 1 - secondIndex].ToString()) + additive) % 10).ToString();
                            additive = (int.Parse(numberOne[numberOne.Length - 1 - firstIndex].ToString()) *
                            int.Parse(numberTwo[numberTwo.Length - 1 - secondIndex].ToString()) + additive) / 10;
                            multiplier += additive;
                        }
                    }
                }

                multiplier = string.Join(string.Empty, multiplier.Reverse());
                output = Calculate(output, multiplier);
            }

            Print(output);
        }

        //Calculates the sum of the two numbers.
        public static string Calculate(string output, string multiplier)
        {
            var one = output.Reverse().Select(x => x.ToString()).ToArray();
            var two = multiplier.Reverse().Select(y => y.ToString()).ToArray();
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

            return answer;
        }

        //Prints the answer on the console.
        static void Print(string output)
        {
            Console.WriteLine(string.Join(string.Empty, output.Reverse()));
        }
    }
}