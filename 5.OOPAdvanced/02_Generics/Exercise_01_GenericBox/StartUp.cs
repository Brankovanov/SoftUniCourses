using System;
using System.Linq;

namespace Exercise_01_GenericBox
{
    public class StartUp
    {
        static void Main()
        {
            var numberOfItems = int.Parse(Console.ReadLine());
            var stringBox = new Box<string>();
            var intBox = new Box<int>();
            var doubleBox = new Box<double>();

            for (var index = 0; index < numberOfItems; index++)
            {
                var item = Console.ReadLine();

                if (int.TryParse(item, out int number))
                {
                    intBox.Add(number);
                }
                else if (double.TryParse(item, out double n))
                {
                    doubleBox.Add(n);
                }
                else
                {
                    stringBox.Add(item);
                }
            }

            var comparer = Console.ReadLine();

            if (int.TryParse(comparer, out int num))
            {
                intBox.Comparer = num;
            }
            else if (double.TryParse(comparer, out double nu))
            {
                doubleBox.Add(nu);
            }
            else
            {
                stringBox.Comparer = comparer;
            }

            if (stringBox.Collection.Count > 0)
            {
                SwapElement(stringBox);
                PrintElement(stringBox);
                CompareElements(stringBox);
            }

            if (intBox.Collection.Count > 0)
            {
                SwapElement(intBox);
                PrintElement(intBox);
                CompareElements(intBox);
            }

            if (doubleBox.Collection.Count > 0)
            {
                SwapElement(doubleBox);
                PrintElement(doubleBox);
                CompareElements(doubleBox);
            }
        }

        //Swap two elements in a string box.
        public static void SwapElement(Box<string> stringBox)
        {
            var elements = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            var firstIndex = elements[0];
            var secondIndex = elements[1];

            stringBox.Swap(firstIndex, secondIndex);
        }

        //Swap two elements in a int box.
        public static void SwapElement(Box<int> intBox)
        {
            var elements = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            var firstIndex = elements[0];
            var secondIndex = elements[1];

            intBox.Swap(firstIndex, secondIndex);
        }

        //Swap two elements in a double box.
        public static void SwapElement(Box<double> doubleBox)
        {
            var elements = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            var firstIndex = elements[0];
            var secondIndex = elements[1];

            doubleBox.Swap(firstIndex, secondIndex);
        }

        //Print the boxes elements and information.
        public static void PrintElement(Box<string> stringBox)
        {
            Console.WriteLine(stringBox.ToString());
        }

        //Print the boxes elements and information.
        public static void PrintElement(Box<int> intBox)
        {
            Console.WriteLine(intBox.ToString());
        }

        //Print the boxes elements and information.
        public static void PrintElement(Box<double> doubleBox)
        {
            Console.WriteLine(doubleBox.ToString());
        }

        //Compare the box elements to the given comparer
        public static void CompareElements(Box<int> intBox)
        {
            Console.WriteLine(intBox.CompareTo());
        }

        //Compare the box elements to the given comparer
        public static void CompareElements(Box<string> stringBox)
        {
            Console.WriteLine(stringBox.CompareTo());
        }

        //Compare the box elements to the given comparer
        public static void CompareElements(Box<double> doubleBox)
        {
            Console.WriteLine(doubleBox.CompareTo());
        }
    }
}