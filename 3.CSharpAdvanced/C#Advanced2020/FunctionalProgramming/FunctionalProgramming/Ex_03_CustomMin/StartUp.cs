using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_03_CustomMin
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToList();
           
            Console.WriteLine(numbers.Min());
        }
    }
}
