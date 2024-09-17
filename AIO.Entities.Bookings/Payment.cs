namespace AIO.Entities.Bookings
{
    public class Payment
    {
        public int id { get; set; }
        public string orderNumber { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public string paymentType { get; set; }
        public string paymentSystem { get; set; }
        public string paymentConfigurationId { get; set; }
        public string paymentConfigurationDescription { get; set; }
        public bool deferredPayment { get; set; }
        public double deferredAmount { get; set; }
        public string deferredLimitDate { get; set; }
        public string secondPaymentDate { get; set; }
        public int remainderCount { get; set; }
        public BoniversumPayerResponse boniversumPayerResponse { get; set; }
    }
}
