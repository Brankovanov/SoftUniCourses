using System;
using System.Text.RegularExpressions;

namespace Exercise_02_MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main(string[] args)
        {
            ReceiveNumber();
        }

        //Receives names from the console.
        public static void ReceiveNumber()
        {
            var numberPattern = new Regex(@"(^(\+359)+( )2( )([0-9]{3})( )([0-9]{4})$)|(^(\+359)+(-)2(-)([0-9]{3})(-)([0-9]{4})$)");
            var number = Console.ReadLine();

            while (number != "end")
            {
                FindValidNames(number, numberPattern);
                number = Console.ReadLine();
            }
        }

        //Finds if the given name is valid.
        public static void FindValidNames(string number, Regex numberPatter)
        {
            var validNumber = numberPatter.IsMatch(number);

            if (validNumber == true)
            {
                Console.WriteLine("-> " + number);
            }
            else
            {
                Console.WriteLine("-> Invalid");
            }
        }
    }
}