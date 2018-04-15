using System;

namespace _14_TableOfNumbers
{
    public class tableOfNumbers
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var f = 0;
            var m = input;
          
            for (var line=1; line<=input;line++)
            {
              
                for (var roll = 1; roll <= input; roll++)
                {
                    f++;
                    if(f<=input)
                    {
                        Console.Write(f + " ");
                    }
                    else
                    {
                        m = m - 1;                      
                        Console.Write(m + " ");
                    }
                }
                m = input;              
                f = f - (f - line);
                Console.WriteLine();
            }
        }
    }
}
