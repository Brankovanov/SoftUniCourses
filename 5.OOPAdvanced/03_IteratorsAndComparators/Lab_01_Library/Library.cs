using System.Collections;
using System.Collections.Generic;

namespace Lab_01_Library
{
    //Creates a library object that holds a list of book objects.
    public class Library : IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

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

        public Library(params Book[] bookCollection)
        {
            this.books = new List<Book>(bookCollection);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //Nested class that creates a enumerator.
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current => this.books[this.index];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return ++this.index < this.books.Count;
            }

            public void Reset()
            {
                this.index = -1;
            }
        }
    }
}