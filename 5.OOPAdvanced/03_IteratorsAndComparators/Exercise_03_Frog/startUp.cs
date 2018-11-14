using System;
using System.Linq;

namespace Exercise_03_Frog
{
    public class startUp
    {
        public static void Main()
        {
            var receiveLake = Console.ReadLine().Split(',').Select(s => int.Parse(s)).ToArray();
            var lake = new Lake(receiveLake);
            Console.WriteLine(lake.JumpingFrog().Replace(" ", ", "));
        }
    }
}