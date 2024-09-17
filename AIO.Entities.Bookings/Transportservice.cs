using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Transportservice
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
        public string providerBookingReference { get; set; }
        public string departureAirport { get; set; }
        public string arrivalAirport { get; set; }
        public DateTime endDate { get; set; }
        public string returnDepartureAirport { get; set; }
        public string returnArrivalAirport { get; set; }
        public DateTime returnDepartureDate { get; set; }
        public DateTime returnArrivalDate { get; set; }
        public bool onewayPrice { get; set; }
        public string includedBaggage { get; set; }
        public IList<string> remarks { get; set; }
        public string voucherUrl { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<CancelPolicy> cancelPolicy { get; set; }
        public IList<Segment> segment { get; set; }
        public IList<Baggage> baggage { get; set; }
    }
}
