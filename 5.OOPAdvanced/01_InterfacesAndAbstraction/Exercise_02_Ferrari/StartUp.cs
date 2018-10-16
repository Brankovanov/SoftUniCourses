using System;

namespace Exercise_02_Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            var driver = Console.ReadLine();

            ICar ferrari = new Ferrari(driver);

            Console.WriteLine(ferrari.ToString());
        }
    }
}