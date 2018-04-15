using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AnimalType
{
    public class animalType
    {
        public static void Main(string[] args)
        {
            var animal = Console.ReadLine();

            if (animal.Equals("dog"))
            {
                Console.WriteLine("mammal");
            }
            else if (animal.Equals("crocodile") || animal.Equals("tortoise") || animal.Equals("snake"))
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
