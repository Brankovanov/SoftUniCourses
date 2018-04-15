using System;

namespace _16_NumberOperations
{
    public class numberOperations
    {
        public static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var operators = Console.ReadLine();


            switch (operators)
            {
                case "+":

                    var result = num1 + num2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + result + " " + "- even");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + result + " " + "- odd");
                    }

                    break;

                case "-":

                    result = num1 - num2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + result + " " + "- even");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + result + " " + "- odd");
                    }

                    break;

                case "*":

                    result = num1 * num2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + result + " " + "- even");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + result + " " + "- odd");
                    }

                    break;

                case "/":

                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + Math.Round(result, 2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide " + num1 + " by zero");
                    }

                    break;

                case "%":


                    if (num2 != 0)
                    {
                        result = num1 % num2;
                        Console.WriteLine(num1 + " " + operators + " " + num2 + " = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide " + num1 + " by zero");
                    }

                    break;

                default:

                    Console.WriteLine("Invalid operator");

                    break;
            }

        }
    }
}
