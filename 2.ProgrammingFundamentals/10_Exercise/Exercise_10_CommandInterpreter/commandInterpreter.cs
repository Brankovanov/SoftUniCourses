using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_10_CommandInterpreter
{
    public class commandInterpreter
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var array = Console.ReadLine().Split(' ').Select(x => x.Trim()).ToList();
            var commands = Console.ReadLine();

            while (!commands.Equals("end"))
            {
                CheckCommand(commands, array);
                commands = Console.ReadLine();
            }

            PrintArray(array);
        }

        //Check if the commands are in the correct format.
        static void CheckCommand(string command, List<string> array)
        {
            var start = 0;
            var count = 0;
            var type = string.Empty;
            var temp = new List<String>();

            temp = command.Split(' ').Select(c => c.Trim()).ToList();
            type = temp[0];

            if (!type.Equals("rollLeft") && !type.Equals("rollRight"))
            {
                start = int.Parse(temp[2]);
                count = int.Parse(temp[4]);
            }
            else
            {
                count = int.Parse(temp[1]);
            }

            try
            {
                switch (type)
                {
                    case "reverse":
                        if (start <= array.Count - 1 && start >= 0 && (count + start) <= array.Count && (count + start) >= 0)
                        {
                            ReverseArray(array, start, count);
                            break;
                        }
                        else
                        {
                            PrintInvalidParameters();
                            break;
                        }

                    case "sort":
                        if (start <= array.Count - 1 && start >= 0 && (count + start) <= array.Count && (count + start) >= 0)
                        {
                            SortArray(array, start, count);
                            break;
                        }
                        else
                        {
                            PrintInvalidParameters();
                            break;
                        }

                    case "rollLeft":
                        if (count >= 0)
                        {
                            RollLeft(array, count);
                            break;
                        }
                        else
                        {
                            PrintInvalidParameters();
                            break;
                        }

                    case "rollRight":
                        if (count >= 0)
                        {
                            RollRight(array, count);
                            break;
                        }
                        else
                        {
                            PrintInvalidParameters();
                            break;
                        }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                PrintInvalidParameters();
            }
            catch (ArgumentException)
            {
                PrintInvalidParameters();
            }
        }

        //Reverse a portion of the given array.
        static void ReverseArray(List<string> array, int start, int count)
        {
            array.Reverse(start, count);
        }

        //Sort a portion of the given array.
        static void SortArray(List<string> array, int start, int count)
        {
            if (array.Count != 1)
            {
                array.Sort(start, count, null);
            }
        }

        //Moves the first element last as many times as required.
        static void RollLeft(List<string> array, int count)
        {
            for (var rolls = 1; rolls <= count % array.Count; rolls++)
            {
                array.Add(array[0]);
                array.RemoveAt(0);
            }
        }

        //Moves the last element first as many times as required.
        static void RollRight(List<string> array, int count)
        {
            for (var rolls = 1; rolls <= count % array.Count; rolls++)
            {
                array.Insert(0, array.Last());
                array.RemoveAt(array.Count - 1);
            }
        }

        //Prints the array after the final manipulation.
        static void PrintArray(List<string> array)
        {
            var output = "[";

            foreach (var member in array)
            {
                output += member + ", ";
            }

            output = output.Remove(output.Length - 2, 2) + "]";
            Console.WriteLine(output);
        }

        //Prints message if the input parameters are non existent or otherwise invalid.
        static void PrintInvalidParameters()
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }
}