using System;

namespace _04_FruitOrVegetable
{
    public class fruitOrVegetable
    {
        public static void Main(string[] args)
        {
            var product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                    Console.Write("fruit");
                    break;
                case "apple":
                    Console.Write("fruit");
                    break;
                case "kiwi":
                    Console.Write("fruit");
                    break;
                case "cherry":
                    Console.Write("fruit");
                    break;
                case "lemon":
                    Console.Write("fruit");
                    break;
                case "grapes":
                    Console.Write("fruit");
                    break;
                case "tomato":
                    Console.Write("vegetable");
                    break;
                case "cucumber":
                    Console.Write("vegetable");
                    break;
                case "pepper":
                    Console.Write("vegetable");
                    break;
                case "carrot":
                    Console.Write("vegetable");
                    break;
                default:
                    Console.Write("unknown");
                    break;
            }
        }
    }
}
