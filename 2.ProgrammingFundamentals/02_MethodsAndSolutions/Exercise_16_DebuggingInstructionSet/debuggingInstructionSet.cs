using System;

namespace Exercise_16_DebuggingInstructionSet
{
    public class debuggingInstructionSet
    {
        public static void Main()
        {
            var input = string.Empty;

            Input(input);
        }

        static void Input(string input)
        {
            input = Console.ReadLine();

            var stringArray = input.Split(' ');

            Calculate(stringArray);

            switch (stringArray[0])
            {
                case "INC":
                    if (stringArray[1].Equals("END"))
                    {
                        return;
                    }
                    else
                    {
                        Input(input);
                    }
                    break;

                case "DEC":
                    if (stringArray[1].Equals("END"))
                    {
                        return;
                    }
                    else
                    {
                        Input(input);
                    }
                    break;

                case "ADD":
                    if (stringArray[2].Equals("END"))
                    {
                        return;
                    }
                    else
                    {
                        Input(input);
                    }
                    break;

                case "MLA":
                    if (stringArray[2].Equals("END"))
                    {
                        return;
                    }
                    else
                    {
                        Input(input);
                    }
                    break;
            }
        }

        static void Calculate(string[] stringArray)
        {
            var command = stringArray[0];
            var result = 0L;

            switch (command)
            {
                case "INC":
                    Console.WriteLine(Increment(stringArray, result));
                    break;

                case "DEC":
                    Console.WriteLine(Decrement(stringArray, result));
                    break;

                case "ADD":
                    Console.WriteLine(Addition(stringArray, result));
                    break;

                case "MLA":
                    Console.WriteLine(Multiplication(stringArray, result));
                    break;
            }
        }

        static long Increment(string[] stringArray, long result)
        {
            result = long.Parse(stringArray[1]);
            result = result + 1;
            return result;
        }

        static long Decrement(string[] stringArray, long result)
        {
            result = long.Parse(stringArray[1]);
            result = result - 1;
            return result;
        }

        static long Addition(string[] stringArray, long result)
        {
            result = long.Parse(stringArray[1]) + long.Parse(stringArray[2]);
            return result;
        }

        static long Multiplication(string[] stringArray, long result)
        {
            result = int.Parse(stringArray[1]) * long.Parse(stringArray[2]);
            return result;
        }
    }
}

