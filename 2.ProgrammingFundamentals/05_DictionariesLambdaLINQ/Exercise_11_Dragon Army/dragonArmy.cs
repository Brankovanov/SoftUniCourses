using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_11_Dragon_Army
{
    public class dragonArmy
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        static void ReceiveInput()
        {
            List<string> temp = new List<string>();

            var numberOfDragons = int.Parse(Console.ReadLine());

            for (var index = 0; index <= numberOfDragons - 1; index++)
            {
                temp.Add(Console.ReadLine());
            }

            CreateArmy(temp);
        }

        static void CreateArmy(List<string> temp)
        {
            Dictionary<string, SortedDictionary<string, string>> dragonArmy = new Dictionary<string, SortedDictionary<string, string>>();
            List<string> dragonList = new List<string>();
            var type = string.Empty;
            var name = string.Empty;
            var damage = string.Empty;
            var health = string.Empty;
            var armour = string.Empty;

            foreach (var dragon in temp)
            {
                dragonList = dragon.Split(' ').ToList();

                type = dragonList[0];
                name = dragonList[1];
                damage = dragonList[2];
                health = dragonList[3];
                armour = dragonList[4];

                CreateArmy(type, name, damage, health, armour, dragonArmy);

                type = string.Empty;
                name = string.Empty;
                damage = string.Empty;
                health = string.Empty;
                armour = string.Empty;
            }

            PrintDragons(dragonArmy);
        }

        static void CreateArmy(string type, string name, string damage, string health, string armour,
                               Dictionary<string, SortedDictionary<string, string>> dragonArmy)
        {
            var stats = string.Empty;

            if (!dragonArmy.ContainsKey(type))
            {
                dragonArmy[type] = new SortedDictionary<string, string>();
            }

            if (!dragonArmy[type].ContainsKey(name))
            {
                if (damage != "null")
                {
                    stats += damage;
                    stats += " ";
                }
                else
                {
                    stats += "45";
                    stats += " ";
                }

                if (health != "null")
                {
                    stats += health;
                    stats += " ";
                }
                else
                {
                    stats += "250";
                    stats += " ";
                }

                if (armour != "null")
                {
                    stats += armour;
                    stats += " ";
                }
                else
                {
                    stats += "10";
                    stats += " ";
                }
            }
            else
            {
                if (damage != "null")
                {
                    stats += damage;
                    stats += " ";
                }
                else
                {
                    stats += "45";
                    stats += " ";
                }

                if (health != "null")
                {
                    stats += health;
                    stats += " ";
                }
                else
                {
                    stats += "250";
                    stats += " ";
                }

                if (armour != "null")
                {
                    stats += armour;
                    stats += " ";
                }
                else
                {
                    stats += "10";
                    stats += " ";
                }
            }

            dragonArmy[type][name] = stats;
        }

        static void PrintDragons(Dictionary<string, SortedDictionary<string, string>> dragonArmy)
        {
            List<string> tempStats = new List<string>();
            var averageDamage = 0.0;
            var averageHealth = 0.0;
            var averageArmour = 0.0;
            var damage = string.Empty;
            var health = string.Empty;
            var armour = string.Empty;

            foreach (var color in dragonArmy)
            {
                Console.Write(color.Key + "::");

                foreach (var stats in color.Value)
                {
                    tempStats = stats.Value.Split(' ').ToList();
                    averageDamage += double.Parse(tempStats[0]);
                    averageHealth += double.Parse(tempStats[1]);
                    averageArmour += double.Parse(tempStats[2]);
                }

                averageDamage = averageDamage / color.Value.Count;
                averageHealth = averageHealth / color.Value.Count;
                averageArmour = averageArmour / color.Value.Count;

                Console.WriteLine("(" + String.Format("{0:0.00}", averageDamage) + "/" + String.Format("{0:0.00}", averageHealth) + "/" + String.Format("{0:0.00}", averageArmour) + ")");

                averageDamage = 0;
                averageHealth = 0;
                averageArmour = 0;
                tempStats.Clear();

                foreach (var dragon in color.Value)
                {
                    tempStats = dragon.Value.Split(' ').ToList();
                    damage = tempStats[0];
                    health = tempStats[1];
                    armour = tempStats[2];

                    Console.WriteLine("-" + dragon.Key + " -> " + "damage: " + damage + ", health: " + health + ", armor: " + armour);
                }
            }
        }
    }
}