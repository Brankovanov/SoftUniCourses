using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    abstract class MessageBank
    {
        public static void Intro()
        {
            var intro = "Please insert one of the following commands:" + Environment.NewLine
               + "1. Add new word - This command adds new word to the list of words in the game." + Environment.NewLine
               + "2. Start the game - This command starts the game" + Environment.NewLine
               + "3. End the game - This command stops the program";

           Console.WriteLine(intro);
        }

        public static void InvalidCommand()
        {
            var error = "Invalid Command! Please try again.";

            Console.WriteLine(error);
        }

        public static void InsertWords()
        {
            var insertMessage = "Insert the word you want to add:";

            Console.WriteLine(insertMessage);
        }


        public static void AddSuccess()
        {
            var message = "New word added.";

            Console.WriteLine(message);
        }

        public static void AddNewWordQuestion()
        {
            var message = "Do you want to add new word? ";

            Console.WriteLine(message);
        }

        public static void GoodbyeMessage()
        {
            var message = "Goodbye!";

            Console.WriteLine(message);
        }

        public static void GuesALetter()
        {
            var message = "Guess a letter.";

            Console.WriteLine(message);
        }

        public static void Congratulations()
        {
            var message = "Congratulations you win!";

            Console.WriteLine(message);
        }

        public static void Duplicate()
        {
            var message = "You have already guessed this letter.";

            Console.WriteLine(message);
        }

        public static void Mistake()
        {
            var message = "The word does not contain this letter.";

            Console.WriteLine(message);
        }

        public static void Hanged()
        {
            var message = "You are hanged! You lose the game! Try again!";

            Console.WriteLine(message);
        }
    }
}
