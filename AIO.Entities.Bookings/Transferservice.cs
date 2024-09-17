using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Transferservice
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
        public string from { get; set; }
        public string to { get; set; }
        public string destinationCode { get; set; }
        public string transferType { get; set; }
        public string productType { get; set; }
        public string vehicleType { get; set; }
        public IList<string> remarks { get; set; }
        public int maximumWaitMinutes { get; set; }
        public int maximumStops { get; set; }
        public string telephoneAssistance { get; set; }
        public bool confirmedPickupTime { get; set; }
        public string voucherUrl { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<CancelPolicy> cancelPolicy { get; set; }
        public string providerTransferCode { get; set; }
    }
}
