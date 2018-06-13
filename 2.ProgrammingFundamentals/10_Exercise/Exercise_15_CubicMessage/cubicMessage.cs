using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise_15_CubicMessage
{
    public class cubicMessage
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Receives the messages on the console.
        static void ReceiveInput()
        {
            var validMessages = new Dictionary<string, string>();
            var message = Console.ReadLine();

            while (message != "Over!")
            {
                var messageLenght = int.Parse(Console.ReadLine());

                CheckForValidMessage(message, messageLenght, validMessages);
                message = Console.ReadLine();
            }

            Print(validMessages);
        }

        //Checks if a message is valid.
        static void CheckForValidMessage(string message, int messageLenght, Dictionary<string, string> validMessages)
        {
            var pattern = $@"(^\d+)([a-zA-Z]{{{messageLenght}}})([^a-zA-Z]*$)";

            if (Regex.IsMatch(message, pattern))
            {
                var validMessage = Regex.Match(message, pattern);

                GenerateVerificationCode(validMessage, validMessages);
            }
        }

        //Generates verification codes for the valid messages.
        static void GenerateVerificationCode(Match validMessage, Dictionary<string, string> validMessages)
        {
            var message = validMessage.Groups[2].Value;
            var cryptedVerification = validMessage.Groups[1].Value + validMessage.Groups[3];
            var verificationCode = string.Empty;

            foreach (var digit in cryptedVerification)
            {
                if (int.TryParse(digit.ToString(), out int index))
                {
                    try
                    {
                        verificationCode += message[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        verificationCode += " ";
                    }
                }
            }

            RecordTheMessage(message, verificationCode, validMessages);
        }

        //Records the message verification code pairs.
        static void RecordTheMessage(string message, string verigicationCode, Dictionary<string, string> validMessages)
        {
            validMessages.Add(message, verigicationCode);
        }

        //Prints the collection of valid messages.
        static void Print(Dictionary<string, string> validMessages)
        {
            foreach (var message in validMessages)
            {
                Console.WriteLine(message.Key + " == " + message.Value);
            }
        }
    }
}