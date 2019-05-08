using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers=new List<Person>();

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

        public void AddMember(Person person)
        {
            this.FamilyMembers.Add(person);
        }

        public Person GetOldestMember()
        {
            var age = 0;
            var oldestPerson = new Person();
            foreach(var person in this.FamilyMembers)
            {
                if(person.Age>age)
                {
                    age = person.Age;
                    oldestPerson = person;
                }
            }

            return oldestPerson;
        }

        public string AgeFilter()
        {
            var output = string.Empty;

            foreach(var member in this.FamilyMembers.Where(p => p.Age > 30).OrderBy(n=>n.Name))
            {
                output += member.Name + " - " + member.Age + Environment.NewLine;
            }
            return output;
        }
    }

    
}
