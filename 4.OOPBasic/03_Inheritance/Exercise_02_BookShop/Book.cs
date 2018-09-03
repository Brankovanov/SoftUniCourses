using System;
using System.Text;

namespace Exercise_02_BookShop
{
    //Creates a book object that holds the book's title, author and price.
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public virtual string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public virtual string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                var temp = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = string.Empty;

                if (temp.Length < 2)
                {
                    name = temp[0];                                
                }
                else
                {
                    name = temp[1];                
                }

                int.TryParse(name[0].ToString(), out int n);

                if (n != 0)
                {
                    throw new ArgumentException("Author not valid!");
                }
                else
                {
                    this.author = value;
                }
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name).Append("Title: ").AppendLine(this.Title).Append("Author: ").AppendLine(this.Author).Append("Price: ").Append($"{this.Price:f2}").AppendLine();

            return sb.ToString();
        }

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
    }
}