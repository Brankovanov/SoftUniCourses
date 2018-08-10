using System;
using System.Collections.Generic;

namespace Exercise_09_FamilyTree
{
    public class FamilyTree
    {
        public static void Main()
        {
            ReceiveInput();
        }

        //Receives input from the console.
        public static void ReceiveInput()
        {
            var familyTree = new List<Person>();
            var familyMembers = new List<string>();
            var familyRelations = new List<string>();
            var person = Console.ReadLine();
            var command = Console.ReadLine();

            while (command != "End")
            {
                ProcessCommand(command, familyMembers, familyRelations);
                command = Console.ReadLine();
            }

            CreatePerson(familyMembers, familyTree);
            CreateFamilyTree(familyRelations, familyTree);
            PrintInformation(familyTree, person);
        }

        //Processes the commands received from the console.
        public static void ProcessCommand(string command, List<string> familyMembers, List<string> familyRelations)
        {
            if (command.Contains("-"))
            {
                familyRelations.Add(command);
            }
            else
            {
                familyMembers.Add(command);
            }
        }

        //Create person in the family tree and updates it.
        public static void CreatePerson(List<string> familyMemebers, List<Person> familyTree)
        {
            foreach (var member in familyMemebers)
            {
                var temp = member.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = string.Join(" ", temp[0], temp[1]);
                var date = temp[2];
                var newPerson = new Person(name, new List<Person>(), new List<Person>(), date);
                familyTree.Add(newPerson);
            }
        }

        //Creates the family tree
        public static void CreateFamilyTree(List<string> familyRelations, List<Person> familyTree)
        {
            foreach (var relation in familyRelations)
            {
                var temp = relation.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                var parent = temp[0];
                var child = temp[1];

                if (parent.Contains("/"))
                {
                    if (child.Contains("/"))
                    {
                        familyTree.Find(p => p.BirthDay == parent).Children.Add(familyTree.Find(c => c.BirthDay == child));
                        familyTree.Find(c => c.BirthDay == child).Parents.Add(familyTree.Find(p => p.BirthDay == parent));
                    }
                    else
                    {
                        familyTree.Find(p => p.BirthDay == parent).Children.Add(familyTree.Find(c => c.Designation == child));
                        familyTree.Find(c => c.Designation == child).Parents.Add(familyTree.Find(p => p.BirthDay == parent));
                    }
                }
                else
                {
                    if (child.Contains("/"))
                    {
                        familyTree.Find(p => p.Designation == parent).Children.Add(familyTree.Find(c => c.BirthDay == child));
                        familyTree.Find(c => c.BirthDay == child).Parents.Add(familyTree.Find(p => p.Designation == parent));
                    }
                    else
                    {
                        familyTree.Find(p => p.Designation == parent).Children.Add(familyTree.Find(c => c.Designation == child));
                        familyTree.Find(c => c.Designation == child).Parents.Add(familyTree.Find(p => p.Designation == parent));
                    }
                }
            }
        }

        //Prints the information about the required person.
        public static void PrintInformation(List<Person> familyTree, string person)
        {
            if (!person.Contains("/"))
            {
                Console.WriteLine(familyTree.Find(p => p.Designation == person).Designation + " " + familyTree.Find(p => p.Designation == person).BirthDay);
                Console.WriteLine("Parents: ");

                foreach (var parent in familyTree.Find(p => p.Designation == person).Parents)
                {
                    Console.WriteLine(parent.Designation + " " + parent.BirthDay);
                }

                Console.WriteLine("Children: ");

                foreach (var child in familyTree.Find(p => p.Designation == person).Children)
                {
                    Console.WriteLine(child.Designation + " " + child.BirthDay);
                }
            }
            else
            {
                Console.WriteLine(familyTree.Find(p => p.BirthDay == person).Designation + " " + familyTree.Find(p => p.BirthDay == person).BirthDay);
                Console.WriteLine("Parents: ");

                foreach (var parent in familyTree.Find(p => p.BirthDay == person).Parents)
                {
                    Console.WriteLine(parent.Designation + " " + parent.BirthDay);
                }

                Console.WriteLine("Children: ");

                foreach (var child in familyTree.Find(p => p.BirthDay == person).Children)
                {
                    Console.WriteLine(child.Designation + " " + child.BirthDay);
                }
            }
        }
    }
}