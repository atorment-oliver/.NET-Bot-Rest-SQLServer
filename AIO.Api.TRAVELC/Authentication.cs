using AIO.Entities.Authentication;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace AIO.Api.TRAVELC
{
    public class Authentication
    {
        private string pUserName { get; set; }
        private string pPassword { get; set; }
        private string pMicroSiteId { get; set; }
        private string pBaseUrl { get; set; }

        public Authentication(string UserName, string Password, string MicroSiteId, string BaseUrl)
        {
            pUserName = UserName;
            pPassword = Password;
            pMicroSiteId = MicroSiteId;
            pBaseUrl = BaseUrl;
        }

        public Token Authenticate()
        {
            try
            {
                var client = new RestClient(pBaseUrl);

                RestRequest request = new RestRequest("resources/authentication/authenticate") { Method = Method.POST };
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");

                request.AddJsonBody(
                    new
                    {
                        username = pUserName,
                        password = pPassword,
                        micrositeId = pMicroSiteId
                    }
                );

                IRestResponse response = client.Execute(request);

                if (response.ErrorException != null)
                {
                    string message = string.Format("{0}{1}StatusDescription:{2} ", ((RestResponseBase)response).ErrorMessage, Environment.NewLine, ((RestResponseBase)response).StatusDescription);
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }
                else if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = string.Format("{0}{1}StatusDescription:{2} ", ((RestResponseBase)response).Content, Environment.NewLine, ((RestResponseBase)response).StatusDescription);
                    var twilioException = new ApplicationException(message, response.ErrorException);
                    throw twilioException;
                }

                return JsonConvert.DeserializeObject<Token>(response.Content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
