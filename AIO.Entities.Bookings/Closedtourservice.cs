using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Closedtourservice
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
        public string providerCode { get; set; }
        public int supplierId { get; set; }
        public string name { get; set; }
        public string modality { get; set; }
        public string modalityCode { get; set; }
        public int passengers { get; set; }
        public IList<string> remarks { get; set; }
        public IList<string> destinationCodes { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<CancelPolicy> cancelPolicy { get; set; }
    }
}
