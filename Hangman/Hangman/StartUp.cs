using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var drawer = new Drawer();
            var words = new WordsLibrary();

            CommandPannel(drawer, words);
        }

        public static void CommandPannel(Drawer drawer, WordsLibrary words)
        {
            MessageBank.Intro();

            var command = Console.ReadLine();

            Controller.MainPage(command, drawer, words);
        }

        public static void AddNewWords(Drawer drawer, WordsLibrary words)
        {
            MessageBank.InsertWords();

            var newWord = Console.ReadLine();
            words.AddWords(newWord);

            MessageBank.AddSuccess();
            MessageBank.AddNewWordQuestion();
            var answer = Console.ReadLine();

            Controller.AddWordControll(answer, drawer, words);
        }

        public static void PlayTheGame(Drawer drawer, WordsLibrary words)
        {
            var word = words.ChooseRandomWord();
            var entry = new string('-', word.Length);
            var mistakeCounter = 0;
            var guessedLetters = new List<string>();

            Visualizer.Visualize(word, entry, drawer, guessedLetters, words);
            Guess(word, entry, drawer, guessedLetters, words, mistakeCounter);
        }

        public static void Guess(string word, string entry, Drawer drawer, List<string> guessedLetters, WordsLibrary words, int mistakeCounter)
        {
            var check = true;
            MessageBank.GuesALetter();
            string guess = Console.ReadLine();

            if (guess.Length > 1)
            {
                MessageBank.InvalidCommand();
            }
            else if (guessedLetters.Contains(guess))
            {
                Console.Clear();
                Visualizer.Visualize(word, entry, drawer, guessedLetters, words);
                MessageBank.Duplicate();
                Console.WriteLine();
                Guess(word, entry, drawer, guessedLetters, words, mistakeCounter);
            }
            else if (word.Contains(guess))
            {
                guessedLetters.Add(guess);

                foreach (var ch in word.Where(c => c.ToString() == guess))
                {
                    var index = word.IndexOf(ch.ToString());
                    var temp = entry.ToCharArray();
                    temp[index] = char.Parse(guess);
                    entry = new string(temp);
                }
            }
            else
            {
                guessedLetters.Add(guess);
                mistakeCounter++;

                if (mistakeCounter == 1)
                {
                    drawer.DrawHead();
                }
                else if (mistakeCounter == 2)
                {
                    drawer.DrawNeck();
                }
                else if (mistakeCounter == 3)
                {
                    drawer.DrawBody();
                }
                else if (mistakeCounter == 4)
                {
                    drawer.DrawLeftArm();
                }
                else if (mistakeCounter == 5)
                {
                    drawer.DrawRightArm();
                }
                else if (mistakeCounter == 6)
                {
                    drawer.DrawLeftLeg();
                }
                else if (mistakeCounter == 7)
                {
                    drawer.DrawRightLeg();
                }
            }

            while (check == true)
            {
                if (entry.Contains('-') && mistakeCounter < 7)
                {
                    Console.Clear();
                    Visualizer.Visualize(word, entry, drawer, guessedLetters, words);
                    Guess(word, entry, drawer, guessedLetters, words, mistakeCounter);
                }
                else if (mistakeCounter == 7)
                {
                    Console.Clear();
                    Visualizer.Visualize(word, entry, drawer, guessedLetters, words);
                    MessageBank.Hanged();
                    Console.WriteLine();
                    CommandPannel(drawer, words);
                    check = false;
                }
                else
                {
                    Console.Clear();
                    Visualizer.Visualize(word, entry, drawer, guessedLetters, words);
                    MessageBank.Congratulations();
                    Console.WriteLine();
                    CommandPannel(drawer, words);
                    check = false;
                }
            }
        }
    }
}
