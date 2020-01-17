using System;
using System.Collections.Generic;

namespace Ex_07_Explicit
{
    public class Explicit
    {
        static void Main()
        {
            var citizenArhive = new List<IResident>();
            var input = Console.ReadLine();


            while(input!="End")
            {
                var temp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                IResident newCitizen = new Citizen(temp[0]);
                citizenArhive.Add(newCitizen);
                input = Console.ReadLine();
            }

            foreach(var citizen in citizenArhive)
            {
                Console.WriteLine(citizen.Name);
                Console.WriteLine(citizen.GetName());
               
            }

        }
    }
}
