using System;

namespace Lab_03_GenericScale
{
    public class StartUp
    {
        static void Main()
        {
            var newScale = new Scale<string>("a", "a");
            Console.WriteLine(newScale.GetHevier());
        }
    }
}