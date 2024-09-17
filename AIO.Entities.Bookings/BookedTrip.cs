using System;
using System.Collections.Generic;

namespace AIO.Entities.Bookings
{
    public class BookedTrip
    {
        public string id { get; set; }
        public string bookingReference { get; set; }
        public string customBookingReference { get; set; }
        public string status { get; set; }
        public string tryType { get; set; }
        public int nightsCount { get; set; }
        public int destinationCount { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime startDate { get; set; }
        public string endDate { get; set; }
        public int adultCount { get; set; }
        public int childCount { get; set; }
        public int infantCount { get; set; }
        public ContactPerson contactPerson { get; set; }
        public string agencyBookingReference { get; set; }
        public User user { get; set; }
        public Payment payment { get; set; }
        public string notes { get; set; }
        public string micrositeInvoiceDate { get; set; }
        public string micrositeInvoiceNumber { get; set; }
        public string operatorInvoiceDate { get; set; }
        public string operatorInvoiceNumber { get; set; }
        public string referralId { get; set; }
        public InvoiceInfo invoiceInfo { get; set; }
        public string language { get; set; }
        public Pricebreakdown pricebreakdown { get; set; }
        public IList<Distribution> distributions { get; set; }
        public IList<Hotelservice> hotelservice { get; set; }
        public IList<Transportservice> transportservice { get; set; }
        public IList<Ticketservice> ticketservice { get; set; }
        public IList<Insuranceservice> insuranceservice { get; set; }
        public IList<Transferservice> transferservice { get; set; }
        public IList<Carservice> carservice { get; set; }
        public IList<Manualservice> manualservice { get; set; }
        public IList<Closedtourservice> closedtourservice { get; set; }
        public IList<Invoice> invoices { get; set; }

        //public ArgentineTaxes argentineTaxes { get; set; }
        //public FromIdeaSharedByUser fromIdeaSharedByUser { get; set; }                
        //public InvoicedData invoicedData { get; set; }

    }
}
