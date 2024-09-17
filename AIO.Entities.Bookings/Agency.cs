using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class Agency
    {
        public string externalId { get; set; }
        public string name { get; set; }
        public string addressText { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string province { get; set; }
        public Country country { get; set; }
        public string phoneNumber { get; set; }
        public string documentNumber { get; set; }
        public string contactPersonName { get; set; }
        public string contactPersonLastName { get; set; }
        public string email { get; set; }
        public string businessName { get; set; }
        public Fee fee { get; set; }
        public double taxes { get; set; }
        public string invoiceType { get; set; }
        public bool active { get; set; }
        public string managementGroup { get; set; }
        public string internalRemarks { get; set; }
        public bool deferredPaymentAllowed { get; set; }
        public int deferredDays { get; set; }
        //public double deferredLimit { get; set; }//100000000000
        public object deferredLimit { get; set; }//100000000000
        public IList<object> providerConfigs { get; set; }
        public string logoUrl { get; set; }
        public string logoContentType { get; set; }
        public SocialNetworks socialNetworks { get; set; }
        public Hotel hotel { get; set; }
    }
}
