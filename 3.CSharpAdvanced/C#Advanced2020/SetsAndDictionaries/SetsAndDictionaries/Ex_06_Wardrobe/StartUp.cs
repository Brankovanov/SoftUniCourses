using System;
using System.Collections.Generic;

namespace Ex_06_Wardrobe
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveDress();
        }

        private static void ReceiveDress()
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            var numberOfClothes = int.Parse(Console.ReadLine());

            for (var index = 0; index < numberOfClothes; index++)
            {
                var clothes = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                var color = clothes[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (var ind = 1; ind < clothes.Length; ind++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[ind]))
                    {
                        wardrobe[color].Add(clothes[ind], 1);
                    }
                    else
                    {
                        wardrobe[color][clothes[ind]]++;
                    }
                }
            }

            var clothesToFind = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            PrintClosthes(clothesToFind, wardrobe);
        }

        private static void PrintClosthes(string[] clothesToFind, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            foreach (var cl in wardrobe)
            {
                Console.WriteLine($"{cl.Key} clothes:");

                foreach(var c in cl.Value)
                {
                    if(cl.Key==clothesToFind[0] && c.Key==clothesToFind[1])
                    {
                        Console.WriteLine($"* {c.Key} - {c.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {c.Key} - {c.Value}");
                    }
                
                }
            }
        }
    }
}