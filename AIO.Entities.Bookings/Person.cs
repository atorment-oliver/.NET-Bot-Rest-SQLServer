namespace AIO.Entities.Bookings
{
    public class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int requestedAge { get; set; }
        public string birthDate { get; set; }
        public string documentNumber { get; set; }
        public string courtesyTitle { get; set; }
        public string documentType { get; set; }
        public string email { get; set; }
        public string phoneCountryCode { get; set; }
        public string phoneAreaCode { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string countryId { get; set; }
        public Municipality municipality { get; set; }
        public string passportExpirationDate { get; set; }
        public Address address { get; set; }
        public string billingNumber { get; set; }
    }
}
