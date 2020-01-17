using System;

namespace Lab_04_GandalfTheHungry
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveMenu();
        }

        public static void ReceiveMenu()
        {
            var menu = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var newGandalf = new Gandalf();
            Eat(menu, newGandalf);
        }

        public static void Eat(string[] menu, Gandalf newGandalf)
        {
            foreach (var item in menu)
            {
                newGandalf.Eat(item);
            }

            PrintMood(newGandalf);
        }

        public static void PrintMood(Gandalf newGandalf)
        {
            Console.WriteLine(newGandalf.Mood);
            Console.WriteLine(newGandalf.CalculateMood());
        }
    }
}
