using System;

namespace Lab_02_BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public string Title
        {
            get
            {
                return this.title;
            }
            set

            {
                if (value.Length >= 3)
                {
                    this.title = value;
                }
                else
                {
                    throw new ArgumentException("Title not valid!");
                }
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
                var temp = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ch = temp[1][0];
               
                if(!Char.IsDigit(ch))
                {
                    this.author = value;
                }
                else
                {
                    throw new ArgumentException("Author is not valid!");
                }
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if(value>0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Price not valid!");
                }
            }
        }

        public Book(string author,string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}" + Environment.NewLine+
                $"Title: {this.Title}" + Environment.NewLine +
                $"Author: {this.Author}" + Environment.NewLine +
                $"Price: {this.Price:f2}";
        }
    }
}
