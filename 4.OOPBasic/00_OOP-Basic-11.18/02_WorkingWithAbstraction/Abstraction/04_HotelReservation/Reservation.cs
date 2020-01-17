namespace _04_HotelReservation
{
    public class Reservation
    {
        private int numberOfDays;
        private int season;
        private int discountType;

        public double PricePerDay { get; set; }

        public int NumberOfDays
        {
            get
            {
                return this.numberOfDays;
            }
            set
            {
                this.numberOfDays = value;
            }
        }

        public int Season
        {
            get
            {
                return this.season;
            }
            set
            {
                this.season = value;
            }
        }

        public int DiscountType
        {
            get
            {
                return this.discountType;

            }
            set
            {
                this.discountType = value;
            }
        }

        public Reservation(double pricePerDay, int numberOfDays, int seasons, int discountTypes)
        {
            this.PricePerDay = pricePerDay;
            this.NumberOfDays = numberOfDays;
            this.Season = seasons;
            this.DiscountType = discountTypes;
        }

}
}
