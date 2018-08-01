using System;
using System.Text.RegularExpressions;

namespace Exercise_03_CubicMessage
{
    public class CubicMessage
    {
        public static void Main(string[] args)
        {
            ReceiveMessages();
        }

        //Receives messages from the console.
        public static void ReceiveMessages()
        {
            var message = Console.ReadLine();

            while (message != "Over!")
            {
                var lenght = int.Parse(Console.ReadLine());
                ValidateMessages(message, lenght);
                message = Console.ReadLine();
            }
        }

        //Checks if the message is valid.
        public static void ValidateMessages(string message, int lenght)
        {
            var validityPattern = new Regex("^(\\d+)([a-zA-z]{" + lenght + "})([^a-zA-Z]*)$");

            if (validityPattern.IsMatch(message))
            {
                var validMessage = validityPattern.Match(message);
                DecodeMessage(validMessage);
            }
        }

        //Decodes the valid messages.
        public static void DecodeMessage(Match validMessage)
        {
            var decoderKey = validMessage.Groups[1].ToString() + validMessage.Groups[3].ToString();
            var message = validMessage.Groups[2].ToString();
            var verificationCode = string.Empty;
            var index = 0;

            foreach (var ch in decoderKey)
            {
                var checker = int.TryParse(ch.ToString(), out index);

                if (checker && index >= 0 && index < message.Length)
                {
                    verificationCode += message[index].ToString();
                }
                else if (checker && index < 0 || index >= message.Length)
                {
                    verificationCode += " ";
                }
            }

            Print(verificationCode, validMessage);
        }

        //Prints the valid message and verification code on the console.
        public static void Print(string verificationCode, Match validMessage)
        {
            Console.WriteLine(validMessage.Groups[2].ToString() + " == " + verificationCode);
        }
    }
}