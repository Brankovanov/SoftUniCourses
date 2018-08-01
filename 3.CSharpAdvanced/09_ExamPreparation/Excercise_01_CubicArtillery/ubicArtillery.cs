using System;
using System.Collections.Generic;
using System.Linq;

namespace Excercise_01_CubicArtillery
{
    public class ubicArtillery
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives bunker and weapon information from the console.
        public static void ReceiveInput()
        {
            var bunkerCapacity = int.Parse(Console.ReadLine());
            var bunkerInfo = Console.ReadLine();
            var bunkerList = new Queue<string>();

            while (bunkerInfo != "Bunker Revision")
            {
                bunkerList.Enqueue(bunkerInfo);
                bunkerInfo = Console.ReadLine();
            }

            BunkerRevision(bunkerList, bunkerCapacity);
        }

        //Sorts the bunkers and the weapons stored inside.
        public static void BunkerRevision(Queue<string> bunkerList, int bunkerCapacity)
        {
            var bunkers = new Queue<Bunker>();
            var designation = string.Empty;
            var weapon = 0;

            while (bunkerList.Count > 0)
            {
                var temp = bunkerList.Dequeue().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var token in temp)
                {
                    var gun = int.TryParse(token, out weapon);

                    if (!gun)
                    {
                        designation = token;
                    }
                    else
                    {
                        StoreWeapons(designation, weapon, bunkers, bunkerCapacity);
                    }

                    if (!bunkers.Any(b => b.Name == designation))
                    {
                        Bunker newBunker = new Bunker();
                        newBunker.Name = designation;
                        newBunker.BunkerCap = bunkerCapacity;
                        newBunker.Storage = new Queue<int>();
                        bunkers.Enqueue(newBunker);
                    }
                }
            }
        }

        //Store the weapons in the bunkers.
        public static void StoreWeapons(string designation, int weapon, Queue<Bunker> bunkers, int bunkerCapacity)
        {
            if (bunkers.Peek().BunkerCap - weapon >= 0)
            {
                bunkers.Peek().Storage.Enqueue(weapon);
                bunkers.Peek().BunkerCap -= weapon;
            }
            else
            {
                if (bunkers.Count > 1)
                {
                    if (bunkers.Peek().Storage.Count > 0)
                    {
                            Console.WriteLine(bunkers.Peek().Name + " -> " + string.Join(", ", bunkers.Peek().Storage));
                            bunkers.Dequeue();
                            StoreWeapons(designation, weapon, bunkers, bunkerCapacity);
                    }
                    else
                    {
                            Console.WriteLine(bunkers.Peek().Name + " -> " + "Empty");
                            bunkers.Dequeue();
                            StoreWeapons(designation, weapon, bunkers, bunkerCapacity);
                    }
                }
                else if (bunkers.Count == 1 && bunkerCapacity >= weapon)
                {
                    var checker = bunkers.Peek().BunkerCap;

                    while (checker < weapon)
                    {
                        checker += bunkers.Peek().Storage.First();
                        bunkers.Peek().BunkerCap += bunkers.Peek().Storage.Peek();
                        bunkers.Peek().Storage.Dequeue();
                    }

                    bunkers.Peek().Storage.Enqueue(weapon);
                    bunkers.Peek().BunkerCap -= weapon;
                    checker = 0;
                }
            }
        }
    }

    //Class Bunker - creates objects newBunker that holds thebunkers name, the bunkers capacity and storage.
    public class Bunker
    {
        private string name;
        private int bunkerCap;
        private Queue<int> storage;

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

        public int BunkerCap
        {
            get
            {
                return this.bunkerCap;
            }
            set
            {
                this.bunkerCap = value;
            }
        }

        public Queue<int> Storage
        {
            get
            {
                return this.storage;
            }
            set
            {
                this.storage = value;
            }
        }

        public Bunker()
        {
            this.name = Name;
            this.bunkerCap = BunkerCap;
            this.storage = Storage;
        }
    }
}