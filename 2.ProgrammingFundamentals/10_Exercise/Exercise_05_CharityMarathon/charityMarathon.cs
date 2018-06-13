using System;

namespace Exercise_05_CharityMarathon
{
    public class charityMarathon
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава вход от конзолата. 
        static void ReceiveInput()
        {
            var numberOfDays = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageNumberOfLabs = int.Parse(Console.ReadLine());
            var lenghtOfTheTrack = double.Parse(Console.ReadLine());
            var capacityOfTheTrack = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            CalculateCollectedMoney(numberOfDays, numberOfRunners, averageNumberOfLabs, lenghtOfTheTrack, capacityOfTheTrack, moneyPerKilometer);
        }

        //Изчислява парите събрани по време на маратона.
        static void CalculateCollectedMoney(int numberOfDays, int numberOfRunners, int averageNumberOfLabs, double lenghtOfTheTrack, int capacityOfTheTrack, double moneyPerKilomete)
        {
            var totalKilometersRanPerRunner = 0.0;
            var totalKilometersRanInTheMarathon = 0.0;
            var moneyCollected = 0.0;
            var totalcapacityOfTheTrack = 0;

            totalcapacityOfTheTrack = capacityOfTheTrack * numberOfDays;

            if (numberOfRunners > totalcapacityOfTheTrack)
            {
                numberOfRunners = totalcapacityOfTheTrack;
            }

            totalKilometersRanPerRunner = (averageNumberOfLabs * (lenghtOfTheTrack / 1000));
            totalKilometersRanInTheMarathon = totalKilometersRanPerRunner * numberOfRunners;
            moneyCollected = totalKilometersRanInTheMarathon * moneyPerKilomete;

            Print(moneyCollected);
        }

        //Отпечатва на конзолата общото количество събрани пари.
        static void Print(double moneyCollected)
        {
            Console.WriteLine("Money raised: " + string.Format("{0:0.00}", moneyCollected));
        }
    }
}