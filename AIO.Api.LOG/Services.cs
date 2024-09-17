using System;
using System.ServiceModel;
using System.Web.Script.Serialization;

namespace AIO.Api.LOG
{
    public class Services
    {
        private string pMicroSite { get; set; }
        private string pBaseUrl { get; set; }

        public Services(string MicroSite, string BaseUrl)
        {
            pMicroSite = MicroSite;
            pBaseUrl = BaseUrl;
        }

        /// <summary>
        /// Registra los datos del log
        /// </summary>
        /// <param name="Contenido">BookingTrip en formato json</param>
        /// <param name="BookedId">Codigo del TTL</param>
        /// <param name="Firma">Firma del Asesor TSO</param>
        /// <param name="Mensaje">Mensaje del proceso</param>
        /// <param name="Type">Tipo de mensaje. [3:WARN, 5:INFO, 8:ERROR, 9:FATAL, 10:ERROR]</param>
        public void SendLog(string Contenido, string BookedId, string Firma, string Mensaje, int Type)
        {
            var serializer = new JavaScriptSerializer();
            var oLog = new LogBooking
            {
                Id = 0,
                Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                Hora = DateTime.Now.ToString("HH:mm:ss"),
                Contenido = Contenido,
                Firma = Firma,
                BookedId = BookedId,
                Observacion = Mensaje,
                Estado = true,
                Microsite = pMicroSite
            };

            switch (Type)
            {
                case 1:
                case 3:
                    oLog.Nivel = "WARN";
                    break;
                case 2:
                case 4:
                case 6:
                case 7:
                case 8:
                    oLog.Nivel = "ERROR";
                    break;
                case 5:
                    oLog.Nivel = "INFO";
                    break;
                case 9:
                    oLog.Nivel = "FATAL";
                    break;
                case 10:
                    oLog.Nivel = "ERROR";
                    break;
            }
            var sValue = serializer.Serialize(oLog).ToString();
            EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
            System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();

            try
            {
                ServiceLogs.Service1Client oServiceLog = new ServiceLogs.Service1Client(binding, baseAddress);
                var result = oServiceLog.Create(sValue);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
