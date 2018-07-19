using System;
using System.Text.RegularExpressions;

namespace Exercise_01_MatchFullName
{
    public class MatchFullName
    {
        public static void Main(string[] args)
        {
            ReceiveName();
        }

        //Receives names from the console.
        public static void ReceiveName()
        {
            var namePattern = new Regex("^[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}");
            var name = Console.ReadLine();

            while (name!="end")
            {
                FindValidNames(name, namePattern);
                name = Console.ReadLine();
            }
        }

        //Finds if the given name is valid.
        public static void FindValidNames(string name, Regex namePatter)
        {
            var validName = namePatter.IsMatch(name);

            if(validName == true)
            {
                Console.WriteLine("-> " + name);
            }
            else
            {
                Console.WriteLine("-> Invalid");
            }
        }
    }
}