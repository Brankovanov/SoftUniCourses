using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_05_BookLibrary
{
    public class bookLibrary
    {
        public static void Main(string[] args)
        {
            ReceiveBooks();
        }

        //Получава информация за книгите от конзолата.
        static void ReceiveBooks()
        {
            List<string> temporaryListOfBooks = new List<string>();

            var numberOfBooks = int.Parse(Console.ReadLine());

            for (var index = 1; index <= numberOfBooks; index++)
            {
                temporaryListOfBooks.Add(Console.ReadLine());
            }

            CreateBooks(temporaryListOfBooks);
        }

        //Създава обект newBook за всяка книга и го запазва в списък libraryCatalogue.
        static void CreateBooks(List<string> temporaryListOfBooks)
        {
            List<Book> libraryCatalogue = new List<Book>();
            List<string> listOfProperties = new List<string>();
            List<string> temp = new List<string>();
            DateTime tempDate = new DateTime();

            foreach (var biblio in temporaryListOfBooks)
            {
                listOfProperties = biblio.Split(' ').ToList();

                Book newBook = new Book();
                newBook.Title = listOfProperties[0];
                newBook.Author = listOfProperties[1];
                newBook.Publisher = listOfProperties[2];
                temp = listOfProperties[3].ToString().Split('.').ToList();
                tempDate = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));
                newBook.ReleaseDate = tempDate;
                newBook.ISBN = listOfProperties[4];
                newBook.Price = double.Parse(listOfProperties[5]);
                libraryCatalogue.Add(newBook);
                listOfProperties.Clear();
                temp.Clear();
                tempDate = new DateTime();
            }

            Library newLibrary = new Library();
            newLibrary.Books = libraryCatalogue;

            Print(newLibrary);
        }

        //Извиква метод CalculatePrices в клас Library.
        static void Print(Library newLibrary)
        {
            newLibrary.CalculatePrices();
        }
    }

    //Клас Book създава обект newBook.
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private DateTime releaseDate;
        private string isbn;
        private double price;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
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

        public string Publisher
        {
            get
            {
                return this.publisher;
            }
            set
            {
                this.publisher = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }

        public string ISBN
        {
            get
            {
                return this.isbn;
            }
            set
            {
                this.isbn = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public Book()
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }

    //Клас Library. Приема списъка с обектите newBook, изчислява обща цена на книгите с един автор и я принтира.
    public class Library
    {
        private List<Book> books;

        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }

        public Library()
        {
            this.Books = books;
        }

        public void CalculatePrices()
        {
            Dictionary<string, double> authorPrices = new Dictionary<string, double>();

            foreach (var b in books)
            {
                if (authorPrices.ContainsKey(b.Author))
                {
                    authorPrices[b.Author] += b.Price;
                }
                else
                {
                    authorPrices.Add(b.Author, b.Price);
                }
            }

            Print(authorPrices);
        }

        public void Print(Dictionary<string, double> autorPrices)
        {
            var output = autorPrices.OrderByDescending(x => x.Value).ThenBy(y => y.Key);

            foreach (var key in output)
            {
                Console.WriteLine(key.Key + " -> " + String.Format("{0:0.00}", key.Value));
            }
        }
    }
}