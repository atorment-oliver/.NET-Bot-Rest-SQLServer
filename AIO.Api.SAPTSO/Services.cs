using AIO.Api.SAPTSO.ServiceCustomer;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Web.Script.Serialization;

namespace AIO.Api.SAPTSO
{
    public class Services
    {
        private string pBaseUrl { get; set; }
        public Services(string BaseUrl)
        {
            pBaseUrl = BaseUrl;
        }

        public long validateCustomer(string ci, string name)
        {
            int idCustTso = 0;

            try
            {
                //PROCESA EL SERVICIO SAPTSO-SI NO Existe LO CREA EN AMBOS, CASO CONTRARIO DEVUELVE AMBOS REGISTROS (TSO / SAP)
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                ServiceSapTsoClient oServiceSapTso = new ServiceSapTsoClient(binding, baseAddress);

                var serializer = new JavaScriptSerializer();

                Customer customer = new Customer()
                {
                    cli_sucursal = 1,
                    cli_ci_num = ci,
                    cli_nombres = name
                };

                var response = oServiceSapTso.SetCliente(serializer.Serialize(customer));
                object objResponse = serializer.DeserializeObject(response);
                var dictionary = (Dictionary<string, object>)objResponse;

                int steResp = (int)dictionary["id"];
                if (steResp > 0)
                {
                    //exito
                    objResponse = serializer.DeserializeObject((string)dictionary["value"]);
                    dictionary = (Dictionary<string, object>)objResponse;
                    idCustTso = (int)dictionary["cli_codigo_tso"];
                }
                else if (steResp == -5)
                {
                    idCustTso = steResp;
                }
            }
            catch (Exception)
            {
                idCustTso = -1;//numero puesto al hazar
                //throw ex;
            }

            return idCustTso;
        }
    }
}
