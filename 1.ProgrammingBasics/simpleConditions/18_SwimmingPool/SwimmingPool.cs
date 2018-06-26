using System;

namespace _18_SwimmingPool
{
    public class SwimmingPool
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives input from the console.
        static void ReceiveInput()
        {
            var volume = int.Parse(Console.ReadLine());
            var volumePerHourPipeOne = int.Parse(Console.ReadLine());
            var volumePerHourPipeTwo = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            CalculateLitersPumped(volumePerHourPipeOne, volumePerHourPipeTwo, hours, volume);
        }

        //Calculate how many litres of water have flown through the pipes for the given hours.
        static void CalculateLitersPumped(int volumePerHourPipeOne, int volumePerHourPipeTwo, double hours, int volume)
        {
            var totalVolumePipeOne = volumePerHourPipeOne * hours;
            var totalVolumePipeTwo = volumePerHourPipeTwo * hours;
            var totalVolume = totalVolumePipeOne + totalVolumePipeTwo;

            CheckSwimingPool(totalVolumePipeOne, totalVolumePipeTwo, totalVolume, volume, hours);
        }

        //Checks if the swimmingpool is overflowing or he is stillfilling.
        static void CheckSwimingPool(double totalVolumePipeOne, double totalVolumePipeTwo, double totalVolume, int volume, double hours)
        {
            if (volume >= totalVolume)
            {
                var percentage = (int)((totalVolume / volume) * 100);
                var percentageOne = (int)((totalVolumePipeOne / totalVolume) * 100);
                var percentageTwo = (int)((totalVolumePipeTwo / totalVolume) * 100);
                var output = $"The pool is {percentage} % full.Pipe 1: {percentageOne} %.Pipe 2: {percentageTwo} %.";

                Print(output);
            }
            else
            {
                var overflow = totalVolume - volume;
                var output = $"For {hours} hours the pool overflows with {overflow} liters.";

                Print(output);
            }
        }

        //Prints to output.
        static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}