using System.Collections.Generic;

namespace Lab_01_Library
{
    //Holds the compare logic for the comparable elements.
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            if (firstBook.Title.CompareTo(secondBook.Title) != 0)
            {
                return firstBook.Title.CompareTo(secondBook.Title);
            }
            else
            {
                return firstBook.Year.CompareTo(secondBook.Year);
            }
        }
    }
}