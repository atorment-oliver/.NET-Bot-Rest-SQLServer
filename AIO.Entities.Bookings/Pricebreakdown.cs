namespace AIO.Entities.Bookings
{
    public class Pricebreakdown
    {
        public NetProvider netProvider { get; set; }
        public OperatorFee operatorFee { get; set; }
        public PaymentFee paymentFee { get; set; }
        public MicrositeFee micrositeFee { get; set; }
        public AgencyFee agencyFee { get; set; }
        public AgencyManagerFee agencyManagerFee { get; set; }
        public AgencyManagementFee agencyManagementFee { get; set; }
        public TotalPrice totalPrice { get; set; }
    }
}
