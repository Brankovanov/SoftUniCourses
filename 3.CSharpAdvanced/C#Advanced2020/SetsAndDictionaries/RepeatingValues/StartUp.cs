using System;
using System.Collections.Generic;
using System.Linq;

namespace RepeatingValues
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveArray();
        }

        private static void ReceiveArray()
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => double.Parse(n)).ToArray();

            FindRepeatingValues(array);
        }

        private static void FindRepeatingValues(double[] array)
        {
            var repeatingValuesDict = new Dictionary<double, int>();

            foreach(var v in array)
            {
                if (repeatingValuesDict.ContainsKey(v))
                {
                    repeatingValuesDict[v]++;
                }
                else
                {
                    repeatingValuesDict.Add(v, 1);
                }
            }

            PrintResult(repeatingValuesDict);
        }

        private static void PrintResult(Dictionary<double, int> repeatingValuesDict)
        {
            foreach(var res in repeatingValuesDict)
            {
                Console.WriteLine(res.Key + " - " + res.Value + " times");
            }
        }
    }
}
