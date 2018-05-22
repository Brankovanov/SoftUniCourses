using System;

namespace Lab_02_RandomizeWords
{
    public class randomizeWords
    {
        public static void Main(string[] args)
        {
            ReceiveInput();
        }

        //Получава входни данни.
        static void ReceiveInput()
        {
            var input = Console.ReadLine();

            CreateRandomSeQuence(input);
        }

        //Създава обект RandomWords.
        static void CreateRandomSeQuence(string input)
        {
            RandomWords randomSequence = new RandomWords(input);
            randomSequence.Random = input;

            Print(randomSequence);
        }

        //Отпечатва произволна поредица.
        static void Print(RandomWords randomSequence)
        {
            randomSequence.Randomize();
        }
    }

    //Приема входните данни и разбърква думите в тях.
    public class RandomWords
    {
        private string random;

        public string Random
        {
            get
            {
                return this.random;
            }
            set
            {
                this.random = value;
            }
        }

        public RandomWords(string input)
        {
            this.random = input;
        }

        public void Randomize()
        {
            var temp = random.Split();
            Random randomizer = new Random();
            var temporary = string.Empty;
            var secondaryTemporary = string.Empty;

            for (var index = 0; index <= temp.Length - 1; index++)
            {
                var randomIndex = randomizer.Next(index, temp.Length - 1);

                temporary = temp[index];
                secondaryTemporary = temp[randomIndex];
                temp[index] = secondaryTemporary;
                temp[randomIndex] = temporary;

                Console.WriteLine(temp[index]);

                temporary = string.Empty;
                secondaryTemporary = string.Empty;
            }
        }
    }
}

