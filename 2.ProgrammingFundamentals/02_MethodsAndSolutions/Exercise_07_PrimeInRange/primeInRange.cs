using System;

namespace Exercise_07_PrimeInRange
{
    public class primeInRange
    {
        public static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            PrintPrimesInRange(startNum, endNum);
        }

        static void PrintPrimesInRange(int startNum, int endNum)
        {
            var counter = 0;

            for (var start = startNum; start <= endNum; start++)
            {
                var check = 0;

                if (start >1)
                {
                    for (var dev = 2; dev < start; dev++)
                    {
                        if (start % dev == 0)
                        {
                            check++;
                            break;
                        }
                    }

                    if (check == 0)
                    {
                        if (counter > 0)
                        {
                            Console.Write(", ");
                        }

                        counter++;

                        Console.Write(start);
                    }        
                }
            }
        }
    }
}
