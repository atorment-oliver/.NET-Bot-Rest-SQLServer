using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Booking
    {
        public Pagination pagination { get; set; }
        public IList<BookedTrip> bookedTrip { get; set; }
    }
}
