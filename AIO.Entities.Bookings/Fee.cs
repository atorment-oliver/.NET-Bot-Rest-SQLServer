using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIO.Entities.Bookings
{
    public class Fee
    {
        public OnlyHotelGroundFee onlyHotelGroundFee { get; set; }
        public OnlyFlightGroundFee onlyFlightGroundFee { get; set; }
        public FlightHotelGroundServicesFee flightHotelGroundServicesFee { get; set; }
        public MultidestinationGroundServicesFee multidestinationGroundServicesFee { get; set; }
        public OnlyTicketFee onlyTicketFee { get; set; }
        public OnlyHotelInsuranceFee onlyHotelInsuranceFee { get; set; }
        public OnlyFlightInsuranceFee onlyFlightInsuranceFee { get; set; }
        public FlightHotelInsuranceFee flightHotelInsuranceFee { get; set; }
        public MultidestinationInsuranceFee multidestinationInsuranceFee { get; set; }
        public OnlyTicketInsuranceFee onlyTicketInsuranceFee { get; set; }
        public OnlyFlightTransportFee onlyFlightTransportFee { get; set; }
        public FlightHotelTransportFee flightHotelTransportFee { get; set; }
        public MultidestinationTransportFee multidestinationTransportFee { get; set; }
        public OnlyHotelFee onlyHotelFee { get; set; }
        public FlightHotelHotelFee flightHotelHotelFee { get; set; }
        public MultidestinationHotelFee multidestinationHotelFee { get; set; }
    }
}
