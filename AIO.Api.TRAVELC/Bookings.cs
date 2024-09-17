using AIO.Entities.Bookings;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace AIO.Api.TRAVELC
{
    public class Bookings
    {
        ///// <summary>
        ///// Authentication token
        ///// </summary>
        //private string pAuthToken;
        ///// <summary>
        ///// Microsite
        ///// </summary>
        //private string pMicrosite;
        ///// <summary>
        ///// From creation date (yyyyMMdd)
        ///// </summary>
        //private string pFrom;
        ///// <summary>
        ///// To creation date (yyyyMMdd)
        ///// </summary>
        //private string pTo;
        ///// <summary>
        ///// First result
        ///// </summary>
        //private string pFirst;
        ///// <summary>
        ///// Number of results
        ///// </summary>
        //private string pLimit;
        private string pBaseUrl { get; set; }

        /// <summary>
        /// Constructor Booking
        /// </summary>
        public Bookings(string BaseUrl)
        {
            //pAuthToken = AuthToken;
            //pMicrosite = Microsite;
            //pFrom = From;
            //pTo = To;
            //pFirst = First;
            //pLimit = Limit;
            pBaseUrl = BaseUrl;
        }
        /// <summary>
        /// This method queries for trip bookings. You can filter by operator or by microsite (if you have authorization to do so). You must enter a range of dates to search for bookings. Check XSD in wadl file: /resources/booking?_wadl
        /// </summary>
        /// <param name="AuthToken">Authentication token</param>
        /// <param name="Operator">Operator</param>
        /// <param name="From">From creation date (yyyyMMdd)</param>
        /// <param name="To">To creation date (yyyyMMdd)</param>
        /// <param name="First">First result</param>
        /// <returns>Bookings by microsite</returns>
        public Booking GetBookings(string AuthToken, string Operator, string From, string To, string First)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var client = new RestClient(pBaseUrl);

                var request = new RestRequest("resources/booking/getBookings", Method.GET)
                    .AddHeader("auth-token", AuthToken)
                    .AddQueryParameter("from", From)
                    .AddQueryParameter("to", To)
                    .AddQueryParameter("operator", Operator)
                    .AddQueryParameter("first", First);

                IRestResponse response = client.Execute(request);

                //pStatusCode = response.StatusCode;

                if (response.ErrorException != null)
                {
                    string message = string.Format("{0}{1}StatusDescription:{2} ", ((RestResponseBase)response).ErrorMessage, Environment.NewLine, ((RestResponseBase)response).StatusDescription);
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }
                else if (response.StatusCode != HttpStatusCode.OK)
                {
                    //oToken.expirationInSeconds = null;
                    string message = string.Format("{0}{1}StatusDescription:{2} ", ((RestResponseBase)response).Content, Environment.NewLine, ((RestResponseBase)response).StatusDescription);
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }

                return JsonConvert.DeserializeObject<Booking>(response.Content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Check XSD in wadl file: /resources/booking?_wadl
        /// </summary>
        /// <param name="AuthToken">Authentication token</param>
        /// <param name="MicrositeId">Microsite</param>
        /// <param name="Ref">Reference</param>
        /// <returns>Booking by Reference</returns>
        public BookedTrip GetBooking(string AuthToken, string MicrositeId, string Ref)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            try
            {
                var client = new RestClient(pBaseUrl);

                var request = new RestRequest("resources/booking/getBookings/{micrositeId}/{ref}", Method.GET)
                .AddHeader("auth-token", AuthToken)
                .AddUrlSegment("micrositeId", MicrositeId)
                .AddUrlSegment("ref", Ref);

                IRestResponse response = client.Execute(request);

                //pStatusCode = response.StatusCode;

                if (response.ErrorException != null)
                {
                    string message = string.Format("{0}{1}StatusDescription:{2} ", ((RestResponseBase)response).ErrorMessage, Environment.NewLine, ((RestResponseBase)response).StatusDescription);
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }
                else if (response.StatusCode != HttpStatusCode.OK)
                {
                    //oToken.expirationInSeconds = null;
                    string message = string.Format("{0}{1}StatusDescription:{2} ", ((RestResponseBase)response).Content, Environment.NewLine, ((RestResponseBase)response).StatusDescription);
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }

                return JsonConvert.DeserializeObject<BookedTrip>(response.Content);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
