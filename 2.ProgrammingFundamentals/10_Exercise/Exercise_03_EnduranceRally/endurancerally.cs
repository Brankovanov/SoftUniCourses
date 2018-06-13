using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_03_EnduranceRally
{
    public class endurancerally
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата.
        static void ReceiveInput()
        {
            var names = Console.ReadLine().Split(' ').Select(x => x.Trim()).ToList();
            var zones = Console.ReadLine().Split(' ').Select(x => Decimal.Parse(x.Trim())).ToList();
            var checkpoints = Console.ReadLine().Split(' ').Select(x => int.Parse(x.Trim())).ToList();

            FuelConsumption(names, zones, checkpoints);
        }

        //Изчислява горивото на съзтезателите.
        static void FuelConsumption(List<string> names, List<decimal> zones, List<int> checkpoints)
        {
            var racers = new Dictionary<string, decimal>();
            var disqualified = new Dictionary<string, int>();

            foreach (var name in names)
            {
                racers[name] = (decimal)name[0];
                var area = 0;

                for (var zone = 0; zone <= zones.Count - 1; zone++)
                {
                    area = zone;
                    if (checkpoints.Contains(zone))
                    {
                        racers[name] += zones[zone];
                    }
                    else
                    {
                        racers[name] -= zones[zone];
                    }

                    if (racers[name] <= 0)
                    {
                        Finish(racers, zone, name);
                        break;
                    }
                }
                if (racers[name] > 0)
                {
                    Finish(racers, area, name);
                }
            }
        }

        //Отпечатва резултатите от съзтезанието на конзолата.
        static void Finish(Dictionary<string, decimal> racers, int zone, string name)
        {
            if (racers[name] <= 0)
            {
                Console.WriteLine(name + " - reached " + zone);
            }
            else
            {
                Console.WriteLine(name + " - fuel left " + string.Format("{0:0.00}", racers[name]));
            }
        }
    }
}