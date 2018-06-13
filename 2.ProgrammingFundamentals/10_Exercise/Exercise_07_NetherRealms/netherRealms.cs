using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Exercise_07_NetherRealms
{
    public class netherRealms
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receive input from console.
        static void ReceiveInput()
        {
            var input = Console.ReadLine().Split(',', ' ').Select(x => x.Trim()).ToList();

            CreateDemons(input);
        }

        //Create demons and record the.
        static void CreateDemons(List<string> input)
        {
            var listOfDemons = new List<Demon>();

            foreach (var demon in input)
            {
                if(demon!=string.Empty)
                {
                    Demon newDemon = new Demon();
                    newDemon.Name = demon;
                    newDemon.Health = CalculateHealth(demon);
                    newDemon.Attack = CalculateAttack(demon);

                    listOfDemons.Add(newDemon);
                }
            }

            PrintDemons(listOfDemons);
        }

        //Calculate demon's health.
        static BigInteger CalculateHealth(string demon)
        {
            var healthPattern = @"[^\d\-\.\*\/\+]";
            var health = new BigInteger();
            var temp = Regex.Matches(demon, healthPattern);

            foreach (Match healthPoint in temp)
            {
                health += (int)char.Parse(healthPoint.Value);
            }

            return health;
        }

        //Calculata demon's attack.
        static double CalculateAttack(string demon)
        {
            var attackPattern = @"([-+]?(\d+\.)?\d+)";
            var modifierPattern = @"[(\*?|/?)]";
            var attack = 0.0;
            var temp = Regex.Matches(demon, attackPattern);
            var modifiers = Regex.Matches(demon, modifierPattern);

            foreach (Match attackPoint in temp)
            {
                  attack = attack + double.Parse(attackPoint.Value);                   
            }

            foreach (Match modifier in modifiers)
            {
                switch (modifier.Value)
                {
                    case "/":
                        attack = attack / 2;
                        break;
                    case "*":
                        attack = attack * 2;
                        break;
                }
            }

            return attack;
        }

        //Print the demons and their statistics on the console.
        static void PrintDemons(List<Demon> listOfDemons)
        {
            foreach (var demon in listOfDemons.OrderBy(x => x.Name))
            {
                Console.WriteLine(demon.Name + " - "
                    + demon.Health + " health, "
                    + string.Format("{0:0.00}", demon.Attack)
                    + " damage ");
            }
        }
    }
}

//class Demon creates objects newDeamon.
public class Demon
{
    private string name;
    private BigInteger health;
    private double attack;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public BigInteger Health
    {
        get
        {
            return this.health;
        }
        set
        {
            this.health = value;
        }
    }

    public double Attack
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

    public Demon()
    {
        this.name = Name;
        this.health = Health;
        this.attack = Attack;
    }
}