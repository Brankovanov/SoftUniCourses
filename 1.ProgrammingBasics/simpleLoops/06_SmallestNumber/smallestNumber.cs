using System;

namespace _06_SmallestNumber
{
    public class smallestNumber
    {
        public static void Main(string[] args)
        {
     
                var input = int.Parse(Console.ReadLine());
                var inputNum = 0;
                var num = int.MaxValue;

                for (var n = 1; n <= input; n++)
                {
                    inputNum = int.Parse(Console.ReadLine());

                    if (num > inputNum)
                    {
                        num = inputNum;
                    }

                    inputNum = 0;
                }

                Console.WriteLine(num);
            }
        }
    }
