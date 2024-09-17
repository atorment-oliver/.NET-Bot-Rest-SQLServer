using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Distribution
    {
        public string id { get; set; }
        public IList<Person> person { get; set; }
    }
}
