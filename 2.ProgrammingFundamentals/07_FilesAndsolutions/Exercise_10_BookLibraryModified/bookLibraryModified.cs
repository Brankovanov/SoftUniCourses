using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise_10_BookLibraryModified
{
    public class bookLibraryModified
    {
        public static void Main(string[] args)
        {
            ReceiveBooks();
        }

        //Получава информация за книгите от конзолата.
        static void ReceiveBooks()
        {
            List<string> temporaryListOfBooks = File.ReadAllLines("./input.txt").ToList();
            var date = temporaryListOfBooks[temporaryListOfBooks.Count - 1];
            temporaryListOfBooks.Remove(temporaryListOfBooks[temporaryListOfBooks.Count - 1]);
            temporaryListOfBooks.Remove(temporaryListOfBooks[0]);

            File.Delete("./output.txt");
            CreateBooks(temporaryListOfBooks, date);
            Print();
        }

        //Създава обект newBook за всяка книга и го запазва в списък libraryCatalogue.
        static void CreateBooks(List<string> temporaryListOfBooks, string date)
        {
            List<Book> libraryCatalogue = new List<Book>();
            List<string> listOfProperties = new List<string>();
            List<string> temp = new List<string>();
            DateTime tempDate = new DateTime();
            DateTime dateOfPublish = new DateTime();
            temp = date.Split('.').ToList();
            dateOfPublish = new DateTime(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]));
            temp.Clear();

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
            newLibrary.DateOfPublication = dateOfPublish;

            CreateOutput(newLibrary);
        }

        //Извиква метод SortByDateOfPublication() в клас Library.
        static void CreateOutput(Library newLibrary)
        {
            newLibrary.SortByDateOfPublication();
        }

        //Принтира съдържанието на файл output.txt.
        static void Print()
        {
            Console.WriteLine(File.ReadAllText("./output.txt"));
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

    //Клас Library. Приема списъка с обектите newBook и принтира книгите с дата на издаване след датата dateOfPublication.
    public class Library
    {
        private List<Book> books;
        private DateTime dateOfPublication;

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

        public DateTime DateOfPublication
        {
            get
            {
                return this.dateOfPublication;
            }
            set
            {
                this.dateOfPublication = value;
            }
        }

        public Library()
        {
            this.Books = books;
        }

        //Сортира книгите в библиотеката по дата на публикация.
        public void SortByDateOfPublication()
        {
            Dictionary<string, DateTime> sortedByDateOfPublication = new Dictionary<string, DateTime>();

            foreach (var b in books)
            {
                if (sortedByDateOfPublication.ContainsKey(b.Title) && b.ReleaseDate > dateOfPublication)
                {
                    sortedByDateOfPublication[b.Title] = b.ReleaseDate;
                }
                else if (!sortedByDateOfPublication.ContainsKey(b.Title) && b.ReleaseDate > dateOfPublication)
                {
                    sortedByDateOfPublication.Add(b.Title, b.ReleaseDate);
                }
            }

            CreteOutputFile(sortedByDateOfPublication);
        }

        //Създава файл output.txt, който съдържа сортираните книги. 
        public void CreteOutputFile(Dictionary<string, DateTime> sortedByDateOfPublication)
        {
            var output = sortedByDateOfPublication.OrderBy(x => x.Value).ThenBy(y => y.Key);
            List<string> tempDate = new List<string>();
            var issueDate = string.Empty;

            foreach (var key in output)
            {
                tempDate = key.Value.ToString().Split('/').ToList();

                if (int.Parse(tempDate[0]) < 10)
                {
                    issueDate = tempDate[1] + "." + "0" + tempDate[0] + "." + tempDate[2];
                }
                else
                {
                    issueDate = tempDate[1] + "." + tempDate[0] + "." + tempDate[2];
                }

                File.AppendAllText("./output.txt", key.Key + " -> " + issueDate.Remove(issueDate.Count() - 11, 11) + "\r\n");
                tempDate.Clear();
                issueDate = string.Empty;
            }
        }
    }
}
