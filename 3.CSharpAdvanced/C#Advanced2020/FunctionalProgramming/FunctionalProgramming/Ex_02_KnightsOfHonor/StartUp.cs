using System;

namespace Ex_02_KnightsOfHonor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> printAct = Print;
            printAct(names);
        }

        private static void Print(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
