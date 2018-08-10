using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_01_PersonalProfile
{
    //Creates familia object that holds a list with all family members.
    public class Family
    {
        private List<Person> familyMembers;

        public List<Person> FamilyMembers
        {
            get
            {
                return this.familyMembers;
            }
            set
            {
                this.familyMembers = value;
            }
        }

        //Adds the new famili members.
        public void AddMember(Person member)
        {
            familyMembers.Add(member);
        }

        //Prints the oldest family memer.
        public void PrintOldest(List<Person> familyMembers)
        {
            Console.Write(familyMembers.OrderByDescending(a => a.Age).First().Name + " ");
            Console.Write(familyMembers.OrderByDescending(a => a.Age).First().Age);
        }

        //Prints the people over 30 years old.
        public void PrintPeopleOverThirty(List<Person> familyMembers)
        {
            foreach (var member in familyMembers.Where(a => a.Age > 30).OrderBy(n => n.Name))
            {
                Console.WriteLine(member.Name + " - " + member.Age);
            }
        }
    }
}