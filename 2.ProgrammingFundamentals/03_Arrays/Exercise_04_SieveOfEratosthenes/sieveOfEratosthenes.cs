using System;

namespace Exercise_04_SieveOfEratosthenes
{
    public class sieveOfEratosthenes
    {
        public static void Main(string[] args)
        {
            Input();
        }

        static void Input()
        {
            var range = int.Parse(Console.ReadLine());

            CheckPrime(range);
        }

        static void CheckPrime(int range)
        {
            var counter = 0;

            for (var index = 2; index <= range; index++)
            {
                var check = 0;

                for (var dev = 2; dev < index; dev++)
                {
                    if (index % dev == 0)
                    {
                        check++;
                        break;
                    }
                }

                if (check > 0)
                {
                    check = 0;
                }
                else
                {
                    PrintPrime(index);
                    check = 0;
                }


            }
        }

        static void PrintPrime(int index)
        {
            Console.Write(index + " ");
        }
    }
}




