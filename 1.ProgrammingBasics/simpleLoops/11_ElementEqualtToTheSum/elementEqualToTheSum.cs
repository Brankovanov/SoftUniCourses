using System;
using System.Collections.Generic;

namespace _11_ElementEqualtToTheSum
{
    public class elementEqualToTheSum
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var listOfNumbers = new List<int>();

            var num = 0;
            var numMax = 0;
            var sum = 0;
            var check = true;

            for (var i = 1; i <= input; i++)
            {
                num = int.Parse(Console.ReadLine());
                listOfNumbers.Add(num);
                sum = sum + num;

                if (numMax < num)
                {
                    numMax = num;
                }

                num = 0;
            }

            var final = sum;

            foreach (var n in listOfNumbers)
            {

                if (sum / 2 == n && sum % 2 == 0)
                {
                    Console.WriteLine("Yes Sum = " + n);
                    check = false;
                    break;
                }
            }

            if (check == true)
            {
                Console.WriteLine("No Diff = " + Math.Abs((final - numMax) - numMax));
            }
        }
    }
}
