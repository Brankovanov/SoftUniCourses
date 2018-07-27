using System;

namespace Exercise_12_TriFunction
{
    public class TriFunction
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var volume = int.Parse(Console.ReadLine());
            var listName = Console.ReadLine().Split(' ');
            SortNames(volume, listName);
        }

        //Sirts the names by the volume.
        public static void SortNames(int volume, string[] listName)
        {
            var output = string.Empty;
            Func<string, int, string> checkVolume = Check;

            foreach (var name in listName)
            {
                if (checkVolume(name, volume) != null)
                {
                    output += checkVolume(name, volume) + " ";
                    break;
                }
            }

            Print(output);
        }

        //Prints the output on the console.
        public static void Print(string output)
        {
            Console.WriteLine(output);
        }

        //Calculates the volume of the names.
        private static string Check(string name, int volume)
        {
            var sum = 0;

            foreach (var symbol in name)
            {
                sum += (int)symbol;
            }

            if (volume <= sum)
            {
                return name;
            }

            return null;
        }
    }
}