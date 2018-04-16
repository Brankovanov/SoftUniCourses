using System;
using System.Collections.Generic;

namespace _03_Exercise_PracticeString
{
    public class practiceString
    {
        public static void Main(string[] args)
        {
            var stringList = new List<string>()
            { "Software University","B","y","e","I love programming"};

            foreach(var str in stringList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
