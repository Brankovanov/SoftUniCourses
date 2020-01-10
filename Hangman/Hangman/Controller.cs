using System;

namespace Hangman
{
    abstract class Controller
    {
        public static void MainPage(string command, Drawer drawer, WordsLibrary words)
        {
            switch (command.ToLower())
            {
                case "add new word":
                    Console.Clear();
                    StartUp.AddNewWords(drawer, words);                    
                    break;

                case "start the game":
                    Console.Clear();
                    StartUp.PlayTheGame(drawer, words);
                    break;

                case "end the game":
                    Console.Clear();
                    MessageBank.GoodbyeMessage();
                    Environment.Exit(1);
                    break;

                default:
                    Console.Clear();
                    MessageBank.InvalidCommand();
                    Console.WriteLine();
                    StartUp.CommandPannel(drawer, words);
                    break;
            }
        }

        public static void AddWordControll(string answer, Drawer drawer, WordsLibrary words)
        {
            switch (answer.ToLower())
            {
                case "yes":
                    Console.Clear();
                    StartUp.AddNewWords(drawer, words);
                    break;
                case "no":
                    Console.Clear();
                    StartUp.CommandPannel(drawer, words);
                    break;
                default:
                    Console.Clear();                
                    MessageBank.InvalidCommand();
                    Console.WriteLine();
                    MessageBank.AddNewWordQuestion();
                    answer = Console.ReadLine();
                    Controller.AddWordControll(answer, drawer, words);
                    break;
            }
        }
    }
}