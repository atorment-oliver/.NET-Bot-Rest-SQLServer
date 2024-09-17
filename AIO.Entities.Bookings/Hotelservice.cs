using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Hotelservice
    {
        public string id { get; set; }
        public string bookingReference { get; set; }
        public string provider { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? cancelationDate { get; set; } //DateTime? = nullable
        public DateTime? lastUpdateDate { get; set; }
        public string status { get; set; }
        public string confirmationErrorCause { get; set; }
        public bool reav { get; set; }
        public string country { get; set; }
        public string operatorProvider { get; set; }
        public string hotelId { get; set; }
        public string hotelName { get; set; }
        public int nights { get; set; }
        public string mealPlan { get; set; }
        public string locationName { get; set; }
        public string destinationCode { get; set; }
        public string destinationName { get; set; }
        public HotelData hotelData { get; set; }
        public IList<string> remarks { get; set; }
        public string category { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<CancelPolicy> cancelPolicy { get; set; }
        public IList<Room> room { get; set; }
    }
}
