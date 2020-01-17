using System;

namespace _01_PersonalInformation
{
    class StartUp
    {
        static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            
            var team = new Team("Team");

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();

                  var person = new Person( cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                team.AddPlayers(person);    
            }

            Console.WriteLine(team.ToString());
        }
    }
}