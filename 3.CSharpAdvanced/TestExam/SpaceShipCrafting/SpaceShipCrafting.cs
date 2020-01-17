using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceShipCrafting
{
    public class SpaceShipCrafting
    {
        static void Main()
        {
            ReceiveIngrediants();

        }

        public static void ReceiveIngrediants()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var liquids = new Queue<int>();

            foreach (var liquid in input)
            {
                liquids.Enqueue(int.Parse(liquid));
            }

            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var items = new Stack<int>();

            foreach (var item in input)
            {
                items.Push(int.Parse(item));
            }

            CreateMaterials(liquids, items);
        }

        public static void CreateMaterials(Queue<int> liquids, Stack<int> items)
        {
            var advancedMaterials = new Dictionary<string, int>();
            advancedMaterials.Add("Glass", 0);
            advancedMaterials.Add("Aluminium", 0);
            advancedMaterials.Add("Lithium", 0);
            advancedMaterials.Add("Carbon fiber", 0);

            while (liquids.Count > 0 && items.Count > 0)
            {
                var mixture = liquids.Peek() + items.Peek();


                switch (mixture)
                {
                    case 25:
                       
                            advancedMaterials["Glass"]++;
                       

                        liquids.Dequeue();
                        items.Pop();

                        break;
                    case 50:
                        
                            advancedMaterials["Aluminium"]++;
                       

                        liquids.Dequeue();
                        items.Pop();
                        break;
                    case 75:
                      
                            advancedMaterials["Lithium"]++;
                       
                        liquids.Dequeue();
                        items.Pop();
                        break;
                    case 100:
                       
                            advancedMaterials["Carbon fiber"]++;
                        
                        liquids.Dequeue();
                        items.Pop();
                        break;
                    default:
                        liquids.Dequeue();
                        var modifiedItem = items.Pop() + 3;
                        items.Push(modifiedItem);
                        break;
                }

            }

            Results(advancedMaterials, liquids, items);
        }

        public static void Results(Dictionary<string, int> advancedMaterials, Queue<int> liquids, Stack<int> items)
        {
            if ((advancedMaterials.ContainsKey("Glass") && advancedMaterials["Glass"] >= 1) &&
                (advancedMaterials.ContainsKey("Aluminium") && advancedMaterials["Aluminium"] >= 1) &&
                (advancedMaterials.ContainsKey("Lithium") && advancedMaterials["Lithium"] >= 1) &&
                (advancedMaterials.ContainsKey("Carbon fiber") && advancedMaterials["Carbon fiber"] >= 1))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count < 1)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine("Liquids: "+string.Join(", ",liquids));              
            }

            if (items.Count < 1)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine("Physical items left: " + string.Join(", ", items));
            }

            foreach(var material in advancedMaterials.OrderBy(n=>n.Key))
            {
                Console.WriteLine(material.Key + ": " + material.Value);
            }
        }
    }
}
