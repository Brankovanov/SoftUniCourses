using System;
using System.Linq;

namespace Exercise_13_ExchangableWords
{
    public class ExchangableWords
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives commands from the console
        public static void ReceiveInput()
        {
            var input = Console.ReadLine().Split();
            CheckExhangability(input);
        }

        //Check if the words are exchangable.
        public static void CheckExhangability(string[] input)
        {
            var output = string.Empty;
            var one = input[0].ToList();
            var two = input[1].ToList();

            while (one.Count > 0 && two.Count > 0)
            {             
                one.RemoveAll(c=> c == one[0]);
                two.RemoveAll(z => z == two[0]);
            }

            if (one.Count!=two.Count)
            {
                output = "false";
                Print(output);      
            }
            else
            {
                output = "true";
                Print(output);
            }     
        }

        //Prints the output.
        public static void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}