using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Manualservice
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
        public string description { get; set; }
        public string pnr { get; set; }
        public string providerName { get; set; }
        public string paymentType { get; set; }
        public bool promotionCode { get; set; }
        public string type { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<CancelPolicy> cancelPolicy { get; set; }
    }
}
