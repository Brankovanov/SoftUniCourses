using System;
using System.IO;

namespace Exercise_07_AdvertisementMessage
{
    public class advertisementMessage
    {
        public static void Main(string[] args)
        {
            File.Delete("./output.txt");
            ProccessInputFile();
        }

        //Обработва входа от файл input.txt - количество обяви, което трябва да се генерира.
        static void ProccessInputFile()
        {
            var numberOfAdds = File.ReadAllLines("./input.txt");
            string[] phrases = File.ReadAllLines("./phrases.txt");
            string[] events = File.ReadAllLines("./events.txt");
            string[] authors = File.ReadAllLines("./author.txt");
            string[] cities = File.ReadAllLines("./cities.txt");

            foreach (var number in numberOfAdds)
            {
                GenerateAdds(int.Parse(number), phrases, events, authors, cities);
            }

            PrintOutput();           
        }

        //Генерира случайна фраза.
        static string RandomPhrase(int i, string[] phrases)
        {
            Random startingIndex = new Random();
            var start = startingIndex.Next(i, phrases.Length - 2);
            Random phraseRandomizer = new Random();
            var randomIndex = phraseRandomizer.Next(start, phrases.Length - 1);
            return phrases[randomIndex];
        }

        //Генерира случайно събитие.
        static string RandomEvent(int i, string[] events)
        {
            Random startingIndex = new Random();
            var start = startingIndex.Next(i, events.Length - 2);
            Random eventRandomizer = new Random();
            var randomIndex = eventRandomizer.Next(start, events.Length - 1);
            return events[randomIndex];
        }

        //Генерира произволен автор.
        static string RandomAuthor(int i, string[] authors)
        {
            Random startingIndex = new Random();
            var start = startingIndex.Next(i, authors.Length - 2);
            Random authorRandomizer = new Random();
            var randomIndex = authorRandomizer.Next(start, authors.Length - 1);
            return authors[randomIndex];
        }

        //Генерира произволен Град.
        static string RandomCity(int i, string[] cities)
        {
            Random startingIndex = new Random();
            var start = startingIndex.Next(i, cities.Length - 2);
            Random cityRandomizer = new Random();
            var randomIndex = cityRandomizer.Next(start, cities.Length - 1);
            return cities[randomIndex];
        }

        //Създава произволната обява.
        static void GenerateAdds(int number, string[] phrases, string[] events, string[] authors, string[] cities)
        {
            for (var i = 1; i <= number; i++)
            {
                AddGenerator newAdd = new AddGenerator();
                newAdd.Phrases = RandomPhrase(i, phrases);
                newAdd.Events = RandomEvent(i, events);
                newAdd.Author = RandomAuthor(i, authors);
                newAdd.Cities = RandomCity(i, cities);

                GenerateOutputFile(newAdd);
            }
        }

        //Извиква метода, от класа AddGenerator, който създава файл output.txt.
        static void GenerateOutputFile(AddGenerator newAdd)
        {         
            newAdd.Generate();
        }

        //Oтпечатва на конзолата съдържанието на файл output.txt.
        static void PrintOutput()
        {
            Console.WriteLine(File.ReadAllText("./output.txt"));
        }
    }

    //Създава обект AddGenerator, който генерира и отпечатва произволна обява.
    public class AddGenerator
    {
        private string phrases;
        private string events;
        private string author;
        private string cities;

        public string Phrases
        {
            get
            {
                return this.phrases;
            }
            set
            {
                this.phrases = value;
            }
        }

        public string Events
        {
            get
            {
                return this.events;
            }
            set
            {
                this.events = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }

        public string Cities
        {
            get
            {
                return this.cities;
            }
            set
            {
                this.cities = value;
            }
        }

        public AddGenerator()
        {
            this.phrases = Phrases;
            this.events = Events;
            this.author = Author;
            this.cities = Cities;
        }

        public void Generate()
        {
            var randomAdd = phrases + " " + events + " " + author + " - " + cities;

            File.AppendAllText("./output.txt", randomAdd + "\r\n");
        }
    }
}
