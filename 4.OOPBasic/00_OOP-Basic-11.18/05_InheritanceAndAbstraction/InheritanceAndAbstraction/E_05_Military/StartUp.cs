
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_05_Military
{
    public class StartUp
    {
        static void Main()
        {
            ReceiveInput();
        }

        public static void ReceiveInput()
        {
            var militaryList = new List<Soldier>();
            var info = Console.ReadLine();

            while(info!="End")
            {
                CreateSoldier(info,militaryList);
                info = Console.ReadLine();
            }

            PrintInformation(militaryList);
        }

        public static void CreateSoldier(string info,List<Soldier>militaryList)
        {
            var temp = info.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rank = temp[0];

            switch(rank)
            {
                case "Private":
                    var id = temp[1];
                    var firstName = temp[2];
                    var lastName = temp[3];
                    var salary = decimal.Parse(temp[4]);

                    var newPrivate = new Private(id, firstName, lastName, salary);
                    militaryList.Add(newPrivate);
                    break;

                case "LieutenantGeneral":
                    id = temp[1];
                    firstName = temp[2];
                    lastName = temp[3];
                    salary = decimal.Parse(temp[4]);

                    var newLeutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);

                    for(var priv = 5; priv<temp.Length;priv++)
                    {
                        newLeutenantGeneral.Privates.Add(militaryList.Find(s => s.Id == temp[priv]));
                    }

                    militaryList.Add(newLeutenantGeneral);
                    break;

                case "Engineer":
                    id = temp[1];
                    firstName = temp[2];
                    lastName = temp[3];
                    salary = decimal.Parse(temp[4]);
                    var corps = temp[5];

                    var newEngineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (var rep = 6; rep < temp.Length; rep+=2)
                    {
                        var part = temp[rep];
                        var time = int.Parse(temp[rep + 1]);
                        newEngineer.Repairs.Add(part,time);
                    }

                    militaryList.Add(newEngineer);
                    break;

                case "Commando":
                    id = temp[1];
                    firstName = temp[2];
                    lastName = temp[3];
                    salary = decimal.Parse(temp[4]);
                     corps = temp[5];

                    var newCommando = new Commando(id, firstName, lastName, salary, corps);

                    for (var mis = 6; mis <= temp.Length; mis += 2)
                    {
                        try
                        {
                            var mission = temp[mis];
                            var stat = temp[mis + 1];
                            newCommando.Missions.Add(mission, stat);
                        }
                        catch 
                        { }
                    }

                    militaryList.Add(newCommando);
                    break;

                case "Spy":
                    id = temp[1];
                    firstName = temp[2];
                    lastName = temp[3];
                    salary = decimal.Parse(temp[4]);
                    var codeNumber = int.Parse(temp[5]);

                    var newSpy = new Spy(id, firstName, lastName, codeNumber);

                        militaryList.Add(newSpy);
                    break;
            }
        }

        public static void PrintInformation(List<Soldier> militaryList)
        {
            foreach(var soldier in militaryList)
            {
               var t = soldier.ToString();

                Console.WriteLine(t);
            }
        }
    }
}


