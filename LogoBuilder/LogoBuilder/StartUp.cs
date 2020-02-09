using System;

namespace LogoBuilder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ReceiveLogoDimention();
        }

        //Receives an integer that represents the size of the logo.
        private static void ReceiveLogoDimention()
        {
            var logoSize = int.Parse(Console.ReadLine());

            CreateLogo(logoSize);
        }

        //Creates a LogoBuilder object that is used to build the logo.
        private static void CreateLogo(int logoSize)
        {
            var builder = new Builder(logoSize);
            var finalLogo = builder.Build();

            PrintLogo(finalLogo);
        }

        //Prints the final version of the logo.
        private static void PrintLogo(string finalLogo)
        {
            Console.WriteLine(finalLogo);
        }
    }
}