using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_13_ArrayManipulator
{
    public class arrayManipulator
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from the console.
        static void ReceiveInput()
        {
            var array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var commands = Console.ReadLine();

            while (commands != "end")
            {
                ExecuteCommands(commands, array);
                commands = Console.ReadLine();
            }

            PrintArray(array);
        }

        //Execute the commands one by one.
        static void ExecuteCommands(string commands, List<int> array)
        {
            var temp = commands.Split(' ').ToList();
            var type = temp[0];
            var modifier = temp[1];

            switch (type)
            {
                case "exchange":

                    array = Exchange(array, modifier);
                    break;

                case "max":

                    if (modifier.Equals("even"))
                    {
                        FindMaxEven(array);
                    }
                    else if (modifier.EndsWith("odd"))
                    {
                        FindMaxOdd(array);
                    }
                    break;

                case "min":

                    if (modifier.Equals("even"))
                    {
                        FindMinEven(array);
                    }
                    else if (modifier.EndsWith("odd"))
                    {
                        FindMinOdd(array);
                    }
                    break;

                case "first":

                    if (temp[2].Equals("even"))
                    {
                        FindFirstNEven(array, modifier);
                    }
                    else if (temp[2].EndsWith("odd"))
                    {

                        FindFirstNOdd(array, modifier);
                    }
                    break;

                case "last":

                    if (temp[2].Equals("even"))
                    {
                        FindLastNEven(array, modifier);
                    }
                    else if (temp[2].EndsWith("odd"))
                    {
                        FindLastNOdd(array, modifier);
                    }
                    break;
            }
        }

        //Split the array and exchange the parts.
        static List<int> Exchange(List<int> array, string modifier)
        {
            var index = int.Parse(modifier);
            var temp = new List<int>();

            if(index<0)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

          index += 1;

            try
            {
                temp.AddRange(array);
                temp.RemoveRange(index, temp.Count - index);
                array.RemoveRange(0, index);
                array.AddRange(temp);
                return array;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid index");
                return array;
            }
        }

        //Finds the biggest even number in the array.
        static void FindMaxEven(List<int> array)
        {
            var temp = array.FindAll(x => x % 2 == 0);

            if (temp.Any())
            {
                var maxEven = array.LastIndexOf(temp.Max());
                Console.WriteLine(maxEven);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        //Finds the biggest odd number in the array.
        static void FindMaxOdd(List<int> array)
        {
            var temp = array.FindAll(x => x % 2 != 0);

            if (temp.Any())
            {
                var maxOdd = array.LastIndexOf(temp.Max());
                Console.WriteLine(maxOdd);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        //Finds the smallest even number in the array.
        static void FindMinEven(List<int> array)
        {
            var temp = array.FindAll(x => x % 2 == 0);

            if (temp.Any())
            {
                var minEven = array.LastIndexOf(temp.Min());
                Console.WriteLine(minEven);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        //Finds the smallest odd number in the array.
        static void FindMinOdd(List<int> array)
        {
            var temp = array.FindAll(x => x % 2 != 0);

            if (temp.Any())
            {
                var minOdd = array.LastIndexOf(temp.Min());
                Console.WriteLine(minOdd);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        //Finds the first even number in the array.
        static void FindFirstNEven(List<int> array, string modifier)
        {
            var output = "[";
            var count = int.Parse(modifier);
            var temp = array.FindAll(x => x % 2 == 0);

            if (count <= array.Count)
            {
                output = "[" + string.Join(", ", temp.Take(count)) + "]";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        //Finds the first odd number in the array.
        static void FindFirstNOdd(List<int> array, string modifier)
        {
            var output = "[";
            var count = int.Parse(modifier);
            var temp = array.FindAll(x => x % 2 != 0);

            if (count <= array.Count)
            {
                output = "[" + string.Join(", ", temp.Take(count)) + "]";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        //Finds the last even number in the array.
        static void FindLastNEven(List<int> array, string modifier)
        {
            var output = string.Empty;
            var count = int.Parse(modifier);
            var temp = array.Where(x => x % 2 == 0);

            if (count <= array.Count)
            {
                output = "[" + string.Join(", ", temp.Reverse().Take(count).Reverse()) + "]";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        //Finds the last odd number in the array.
        static void FindLastNOdd(List<int> array, string modifier)
        {
            var output = string.Empty;
            var count = int.Parse(modifier);
            var temp = array.Where(x => x % 2 != 0);

            if (count <= array.Count)
            {
                output = "[" + string.Join(", ", temp.Reverse().Take(count).Reverse()) + "]";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        //Print the final array.
        static void PrintArray(List<int> array)
        {
            var finalOutput = "[";
            foreach (var number in array)
            {
                finalOutput += number + ", ";
            }

            finalOutput = finalOutput.Remove(finalOutput.Length - 2, 2);
            finalOutput += "]";

            Console.WriteLine(finalOutput);
        }
    }
}