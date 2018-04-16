using System;

namespace _05_Exercise_Boolean
{
    public class boolean
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bolean = Convert.ToBoolean(input);

            if (bolean == true)
            {
                Console.WriteLine("Yes");
            }
            else if (bolean == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
