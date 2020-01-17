﻿namespace Lab_02_BookShop
{
    public class GoldenEditionBook : Book
    {

        public override decimal Price
        {
            get
            {
                return base.Price;
            }
            protected set
            {
                base.Price = value + (value * 0.3m);
            }
        }
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {

        }
    }
}
