using System;
using System.Collections.Generic;

namespace _13_EqualPairs
{
    public class equalPairs
    {
        public static void Main(string[] args)
        {

            var input = int.Parse(Console.ReadLine());

            var num = 0;
            var pair = 0;
            var listOfPairs = new List<int>();
            var finalPair = 0;
            var maxDiff = 0;

            for (var n = 1; n <= input; n++)
            {
                for (var m = 1; m <= 2; m++)
                {
                    num = int.Parse(Console.ReadLine());

                    pair = pair + num;
                }

                listOfPairs.Add(pair);
                pair = 0;
            }


            for (var x = 0; x <= listOfPairs.Count; x++)
            {
                if (listOfPairs.Count==1)
                {
                    finalPair = listOfPairs[0];
                    break;
                }
                if (x !=listOfPairs.Count - 1)
                {
                    if (listOfPairs[x] == listOfPairs[x + 1])
                    {
                        finalPair = listOfPairs[x];
                    }
                    else if (maxDiff == 0)
                    {
                        maxDiff = listOfPairs[x] - listOfPairs[x + 1];
                    }
                    else if (maxDiff < Math.Abs(listOfPairs[x] - listOfPairs[x + 1]))
                    {
                        maxDiff = listOfPairs[x] - listOfPairs[x + 1];
                    }
                }
                else 
                {
                    break;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value=" + finalPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + Math.Abs(maxDiff));
            }
        }
    }
}
