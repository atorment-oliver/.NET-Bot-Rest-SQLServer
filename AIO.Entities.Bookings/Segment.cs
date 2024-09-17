using System;

namespace AIO.Entities.Bookings
{
    public class Segment
    {
        public string departureAirport { get; set; }
        public string arrivalAirport { get; set; }
        public string departureAirportName { get; set; }
        public string arrivalAirportName { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public string marketingAirlineCode { get; set; }
        public string operatingAirlineCode { get; set; }
        public string flightNumber { get; set; }
        public string bookingClass { get; set; }
        public string cabinClass { get; set; }
        public int durationInMinutes { get; set; }
        public string transportType { get; set; }
        public string airlineReference { get; set; }
    }
}
