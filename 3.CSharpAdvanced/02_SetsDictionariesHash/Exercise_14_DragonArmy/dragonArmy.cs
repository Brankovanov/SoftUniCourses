using System;
using System.Collections.Generic;

namespace Exercise_14_DragonArmy
{
    public class dragonArmy
    {
        public static void Main(string[] args)
        {
            ReceiveDragonArmy();
        }

        //Receivesthe dragon army information from the console.
        static void ReceiveDragonArmy()
        {
            var dragonArmyList = new Dictionary<string, SortedDictionary<string, Dragon>>();
            var numberOfDragons = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfDragons; index++)
            {
                var dragon = Console.ReadLine();
                ProcessDragon(dragon, dragonArmyList);
            }

            PrintDragonArmy(dragonArmyList);
        }

        //Processes the incoming dragons.
        static void ProcessDragon(string dragon, Dictionary<string, SortedDictionary<string, Dragon>> dragonArmyList)
        {
            var damage = 0L;
            var health = 0L;
            var armour = 0L;
            var temp = dragon.Split(' ');
            var type = temp[0];
            var name = temp[1];

            if (temp[2] == "null")
            {
                damage = 45;
            }
            else
            {
                damage = long.Parse(temp[2]);
            }

            if (temp[3] == "null")
            {
                health = 250;
            }
            else
            {
                health = long.Parse(temp[3]);
            }

            if (temp[4] == "null")
            {
                armour = 10;
            }
            else
            {
                armour = long.Parse(temp[4]);
            }

            EnlistTheDragon(type, name, damage, health, armour, dragonArmyList);
        }

        //Records new dragons in the dragon army.
        static void EnlistTheDragon(string type, string name, long damage, long health, long armour, Dictionary<string, SortedDictionary<string, Dragon>> dragonArmyList)
        {
            Dragon newDragon = new Dragon();
            newDragon.Attack = damage;
            newDragon.Defence = armour;
            newDragon.Life = health;

            if (!dragonArmyList.ContainsKey(type))
            {
                dragonArmyList.Add(type, new SortedDictionary<string, Dragon>());
                dragonArmyList[type].Add(name, newDragon);
            }
            else if (dragonArmyList.ContainsKey(type) && dragonArmyList[type].ContainsKey(name))
            {
                dragonArmyList[type][name] = newDragon;
            }
            else if (dragonArmyList.ContainsKey(type) && !dragonArmyList[type].ContainsKey(name))
            {
                dragonArmyList[type].Add(name, newDragon);
            }
        }

        //Prints the assembeled dragon army.
        static void PrintDragonArmy(Dictionary<string, SortedDictionary<string, Dragon>> dragonArmyList)
        {
            var averageHealth = 0.0;
            var averageAttack = 0.0;
            var averageDeffence = 0.0;

            foreach (var type in dragonArmyList)
            {
                foreach (var dragon in type.Value)
                {
                    averageAttack += dragon.Value.Attack;
                    averageDeffence += dragon.Value.Defence;
                    averageHealth += dragon.Value.Life;
                }

                averageAttack = averageAttack / type.Value.Count;
                averageDeffence = averageDeffence / type.Value.Count;
                averageHealth = averageHealth / type.Value.Count;

                Console.WriteLine($"{type.Key}::({String.Format("{0:0.00}", averageAttack)}/{String.Format("{0:0.00}", averageHealth)}/{String.Format("{0:0.00}", averageDeffence)})");

                foreach (var drake in type.Value)
                {
                    Console.WriteLine($"-{drake.Key} -> damage: {drake.Value.Attack}, health: {drake.Value.Life}, armor: {drake.Value.Defence}");
                }

                averageAttack = 0.0;
                averageDeffence = 0.0;
                averageHealth = 0.0;
            }
        }
    }

    //Creates the object newDragon.
    public class Dragon
    {
        private long attack;
        private long life;
        private long defence;

        public long Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                this.attack = value;
            }
        }

        public long Life
        {
            get
            {
                return this.life;
            }
            set
            {
                this.life = value;
            }
        }

        public long Defence
        {
            get
            {
                return this.defence;
            }
            set
            {
                this.defence = value;
            }
        }

        public Dragon()
        {
            this.attack = Attack;
            this.life = Life;
            this.defence = Defence;
        }
    }
}