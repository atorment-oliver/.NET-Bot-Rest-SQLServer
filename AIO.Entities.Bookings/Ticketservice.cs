using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Ticketservice
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
        public string ticketName { get; set; }
        public string ticketModality { get; set; }
        public string ticketType { get; set; }
        public string duration { get; set; }
        public string meetingPoint { get; set; }
        public IList<string> included { get; set; }
        public IList<Restriction> restrictions { get; set; }
        public string description { get; set; }
        public string destination { get; set; }
        public IList<string> remarks { get; set; }
        public string voucherUrl { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<CancelPolicy> cancelPolicy { get; set; }
    }
}
