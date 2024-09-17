using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Carservice
    {
        public string id { get; set; }
        public string bookingReference { get; set; }
        public string provider { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? cancelationDate { get; set; }
        public DateTime? lastUpdateDate { get; set; }
        public string status { get; set; }
        public string confirmationErrorCause { get; set; }
        public bool reav { get; set; }
        public string country { get; set; }
        public string pickup { get; set; }
        public string pickupDestinationCode { get; set; }
        public string dropoff { get; set; }
        public string dropoffDestinationCode { get; set; }
        public string vendor { get; set; }
        public string vehicleName { get; set; }
        public DateTime endDate { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<CancelPolicy> cancelPolicy { get; set; }
    }
}
