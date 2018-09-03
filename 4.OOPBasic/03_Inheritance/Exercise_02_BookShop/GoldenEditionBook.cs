namespace Exercise_02_BookShop
{
    //Creates a golden edition book object that is derived from the book object.
    public class GoldenEditionBook : Book
    {
        public override decimal Price
        {
            get
            {
                return base.Price;
            }
            set
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