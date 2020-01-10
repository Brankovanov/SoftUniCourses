using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    abstract class Visualizer
    {
        public static void Visualize(string word,string entry,Drawer drawer, List<string> guessedLetters, WordsLibrary words)
        {
            Console.WriteLine(entry);

            drawer.DrawGallow();

            Console.WriteLine("Guessed Letters: " + string.Join(", ", guessedLetters).TrimEnd(','));
        }
    }
}
