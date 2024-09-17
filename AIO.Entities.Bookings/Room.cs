namespace AIO.Entities.Bookings
{
    public class Room
    {
        public string id { get; set; }
        public string roomType { get; set; }
        public string roomTypeDescription { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
    }
}
