using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class WordsLibrary
    {
        private List<String> words;

        public List<string> Words { get => words; set => words = value; }

        public void AddWords(string word)
        {
            this.Words.Add(word);
        }

        public string ChooseRandomWord()
        {
            var randomizer = new Random(DateTime.Now.Millisecond);

            return this.Words[randomizer.Next(this.Words.Count-1)];

        }

        public WordsLibrary()
        {
            this.Words = new List<string>() 
            { "dragon", "horse", "cat", "dog", "mouse", "mountain", "computer", "television" };
        }
    }
}
