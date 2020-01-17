using System;
using System.Collections.Generic;
using System.Text;

namespace _04_HotelReservation
{
    public class Calculator
    {
        public static double Calculate(Reservation reservation)
        {
            var finalPrice = 0.0;

            if (reservation.DiscountType != 0)
            {
                finalPrice = (reservation.NumberOfDays * (reservation.PricePerDay * reservation.Season))
                - ((reservation.NumberOfDays * (reservation.PricePerDay * reservation.Season))*reservation.DiscountType/100);
            }
            else
            {
                 finalPrice = (reservation.NumberOfDays * (reservation.PricePerDay * reservation.Season));
            }
            
            return finalPrice;
        }

    }
}
