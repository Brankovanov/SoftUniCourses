using System;

namespace _17_SpecialNumbers
{
    public class specialNumbers
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var counter = 0;

            for (var n = 1111; n <= 9999; n++)
            {
                foreach (var ch in n.ToString())
                {
                    if (int.Parse(ch.ToString()) == 0)
                    {
                        break;
                    }
                    else if (input % int.Parse(ch.ToString()) != 0)
                    {
                        break;
                    }        
                    else
                    {
                        counter++;
                    }

                }

                if (counter == 4)
                {
                    Console.Write(n + " ");
                    counter = 0;
                }
                else
                {
                    counter = 0;
                }
            }
        }
    }
}
