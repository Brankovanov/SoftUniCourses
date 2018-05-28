using System;

namespace Exercise_02_AdvertisementMessage
{
    public class advertisementMessage
    {
        public static void Main(string[] args)
        {
            ReceiveNumberOfAds();
        }

        //Получава вход - количество обяви, което трябва да се генерира.
        static void ReceiveNumberOfAds()
        {
            var numberOfAdds = int.Parse(Console.ReadLine());
            GenerateAdds(numberOfAdds);
        }

        //Генерира случайна фраза.
        static string RandomPhrase(int i)
        {
            string[] phrases =
           {"Excellent product.","Such a great product.","I always use that product.","Best product of its category.",
            "Exceptional product.","I can’t live without this product." };

            Random startingIndex = new Random();
            var start = startingIndex.Next(i, phrases.Length - 2);
            Random phraseRandomizer = new Random();
            var randomIndex = phraseRandomizer.Next(start, phrases.Length - 1);
            return phrases[randomIndex];
        }

        //Генерира случайно събитие.
        static string RandomEvent(int i)
        {
            string[] events =
            {"Now I feel good.","I have succeeded with this product.","Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.","Try it yourself, I am very satisfied.","I feel great!" };

            Random startingIndex = new Random();
            var start = startingIndex.Next(i, events.Length - 2);
            Random eventRandomizer = new Random();
            var randomIndex = eventRandomizer.Next(start, events.Length - 1);
            return events[randomIndex];
        }

        //Генерира произволен автор.
        static string RandomAuthor(int i)
        {
            string[] authors =
            { "Diana","Petya","Stella","Elena","Katya","Iva","Annie","Eva" };

            Random startingIndex = new Random();
            var start = startingIndex.Next(i, authors.Length - 2);
            Random authorRandomizer = new Random();
            var randomIndex = authorRandomizer.Next(start, authors.Length - 1);
            return authors[randomIndex];
        }

        //Генерира произволен Град.
        static string RandomCity(int i)
        {
            string[] cities =
            {"Burgas", "Sofia","Plovdiv","Varna","Ruse" };

            Random startingIndex = new Random();
            var start = startingIndex.Next(i, cities.Length - 2);
            Random cityRandomizer = new Random();
            var randomIndex = cityRandomizer.Next(start, cities.Length - 1);
            return cities[randomIndex];
        }

        //Създава произволната обява.
        static void GenerateAdds(int numberOfAds)
        {
            for (var i = 1; i <= numberOfAds; i++)
            {
                AddGenerator newAdd = new AddGenerator();
                newAdd.Phrases = RandomPhrase(i);
                newAdd.Events = RandomEvent(i);
                newAdd.Author = RandomAuthor(i);
                newAdd.Cities = RandomCity(i);

                PrintAdd(newAdd);
            }
        }

        //Извиква метода, от класа AddGenerator, който отпечтва обявата.
        static void PrintAdd(AddGenerator newAdd)
        {
            newAdd.Generate();
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

            Console.WriteLine(randomAdd);
        }
    }
}

