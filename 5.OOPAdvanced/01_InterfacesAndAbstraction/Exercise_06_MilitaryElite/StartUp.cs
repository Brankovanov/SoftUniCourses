using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_06_MilitaryElite
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInformation();
        }

        //Receives information about hte soldiers from the console. 
        public static void ReceiveInformation()
        {
            var id = string.Empty;
            var firstName = string.Empty;
            var lastName = string.Empty;
            var salary = 0.0;
            var corps = string.Empty;
            var code = 0;
            var barracks = new List<ISoldier>();
            var rank = string.Empty;
            var inp = Console.ReadLine();

            while (inp != "End")
            {
                var input = inp.Split(' ');
                rank = input[0];


                switch (rank)
                {
                    case "Private":
                        CreatePrivate(id, firstName, lastName, salary, barracks, input);
                        break;

                    case "LeutenantGeneral":
                        CreateLeutenant(id, firstName, lastName, salary, barracks, input);
                        break;

                    case "Engineer":
                        CreateEngineer(id, firstName, lastName, salary, barracks, input, corps);
                        break;

                    case "Commando":
                        CreateCommando(id, firstName, lastName, salary, barracks, input, corps);
                        break;

                    case "Spy":
                        CreateSpy(id, firstName, lastName, barracks, input, code);

                        break;
                }

                inp = Console.ReadLine();
            }

            Report(barracks);
        }

        //Createsd private objects.
        public static void CreatePrivate(string id, string firstName, string lastName, double salary, List<ISoldier> barracks, string[] input)
        {
            id = input[1];
            firstName = input[2];
            lastName = input[3];
            salary = double.Parse(input[4]);
            IPrivate newPrivate = new Private(id, firstName, lastName, salary);
            barracks.Add(newPrivate);
        }

        //Createsd leutenant general objects.
        public static void CreateLeutenant(string id, string firstName, string lastName, double salary, List<ISoldier> barracks, string[] input)
        {
            id = input[1];
            firstName = input[2];
            lastName = input[3];
            salary = double.Parse(input[4]);
            ILeutenantGeneral newLeutenant = new LeutenantGeneral(id, firstName, lastName, salary);
            var privates = input.ToList();
            privates.RemoveRange(0, 5);

            foreach (var priv in privates)
            {
                newLeutenant.Privates.AddRange(barracks.Where(s => s.Id == priv));
            }

            barracks.Add(newLeutenant);
        }


        //Createsd engineer objects.
        public static void CreateEngineer(string id, string firstName, string lastName, double salary, List<ISoldier> barracks, string[] input, string corps)
        {
            id = input[1];
            firstName = input[2];
            lastName = input[3];
            salary = double.Parse(input[4]);
            corps = input[5];
            IEngineer newEngineer = new Engineer(corps, id, firstName, lastName, salary);
            var repairs = input.ToList();
            repairs.RemoveRange(0, 6);

            for (var index = 0; index < repairs.Count; index += 2)
            {
                var partName = repairs[index];
                var hours = int.Parse(repairs[index + 1]);
                var repair = new Repair(partName, hours);
                newEngineer.Repairs.Add(repair);
            }

            barracks.Add(newEngineer);
        }

        //Createsd commando objects.
        public static void CreateCommando(string id, string firstName, string lastName, double salary, List<ISoldier> barracks, string[] input, string corps)
        {
            id = input[1];
            firstName = input[2];
            lastName = input[3];
            salary = double.Parse(input[4]);
            corps = input[5];
            ICommando newCommando = new Commando(corps, id, firstName, lastName, salary);
            var missions = input.ToList();
            missions.RemoveRange(0, 6);

            if (missions.Count >= 2)
            {
                for (var index = 0; index < missions.Count; index += 2)
                {
                    var name = missions[index];
                    var stat = missions[index + 1];
                    var mission = new Mission(name, stat);
                    newCommando.Missions.Add(mission);
                }
            }

            barracks.Add(newCommando);
        }

        //Createsd spy objects.
        public static void CreateSpy(string id, string firstName, string lastName, List<ISoldier> barracks, string[] input, int code)
        {
            id = input[1];
            firstName = input[2];
            lastName = input[3];
            code = int.Parse(input[4]);
            ISpy newSpy = new Spy(code, id, firstName, lastName);
            barracks.Add(newSpy);
        }

        //Reports the information about the soldiers in the barracks.
        public static void Report(List<ISoldier> barracks)
        {
            foreach (var unit in barracks)
            {
                Console.WriteLine(unit.ToString());
            }
        }
    }
}