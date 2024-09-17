
namespace AIO.Entities.Bookings
{
    public class Baggage
    {
        public bool perPerson { get; set; }
        public string personId { get; set; }
        public int quantity { get; set; }
        public string weight { get; set; }
        public TotalPrice totalPrice { get; set; }
        public bool isReturn { get; set; }
    }
}
