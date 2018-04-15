using System;

namespace _09_PasswordGuess
{
    public class passwordGuess
    {
        public static void Main(string[] args)
        {
            var pass = Console.ReadLine();

            if (pass.Equals("s3cr3t!P@ssw0rd"))
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
