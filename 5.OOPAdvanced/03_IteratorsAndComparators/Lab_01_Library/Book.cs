using System;

namespace Lab_01_Library
{
    //Creates a book object that holds the book'title, year of publication, and authors.
    public class Book : IComparable<Book>
    {
        private string title;
        private int year;
        private string[] authors;

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

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public string[] Autors
        {
            get
            {
                return this.authors;
            }
            set
            {
                this.authors = value;
            }
        }

        public Book(string name, int yearOfPublication, params string[] authors)
        {
            this.Title = name;
            this.Year = yearOfPublication;
            this.Autors = authors;
        }

        public int CompareTo(Book book)
        {
            if (this.Year.CompareTo(book.Year) != 0)
            {
                return this.Year.CompareTo(book.Year);
            }
            else
            {
                return this.Title.CompareTo(book.Title);
            }
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}