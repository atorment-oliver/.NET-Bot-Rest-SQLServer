using AIO.Api.TSO.ServiceTSO;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace AIO.Api.TSO
{
    public class Services
    {
        private string pBaseUrl { get; set; }
        public Services(string BaseUrl)
        {
            pBaseUrl = BaseUrl;
        }

        /// <summary>
        /// Obtiene el tipo de cambio de TSO
        /// </summary>
        /// <param name="date">fecha a obtener el tipo de cambio</param>
        /// <returns>Valor del tipo de cambio</returns>
        public decimal GetExchangeRate(DateTime date)
        {
            try
            {
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                WsTsofSoapClient oServicioTSO = new WsTsofSoapClient(binding, baseAddress);
                TipoCambio oTipoCambio = oServicioTSO.TipoCambioProvider_GetByFechaCambio(date);

                return oTipoCambio != null ? oTipoCambio.MontoCambio : -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los datos del usuario en TSO
        /// </summary>
        /// <param name="user">login user</param>
        /// <returns>Datos del usuario</returns>
        public Usuario GetUserData(string user)
        {
            try
            {
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                WsTsofSoapClient oServicioTSO = new WsTsofSoapClient(binding, baseAddress);

                return oServicioTSO.UsuarioProvider_GetByLoginIdEstado(user, 1);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Obtiene el file para la intergacion
        /// </summary>
        /// <param name="descripcionFile">Descripcion del File</param>
        /// <param name="idCliente">Id del cliente a generar el file</param>
        /// <param name="idUsuarioCreacion">Id del usuario que generara el file</param>
        /// <returns>Identificador del file</returns>
        public long GetTicketFileId(string descripcionFile, long idCliente, int idUsuarioCreacion)
        {
            try
            {
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                WsTsofSoapClient oServicioTSO = new WsTsofSoapClient(binding, baseAddress);

                Correlativo oCorrelativo = oServicioTSO.CorrelativoProvider_GetByNombreTabla("FILE");

                int NumeroTabla = oCorrelativo.NumeroTabla;
                oCorrelativo.NumeroTabla += 1;
                oServicioTSO.CorrelativoProvider_Update(oCorrelativo);

                TicketFile oTicketFile = new TicketFile
                {
                    DescripcionFile = descripcionFile,
                    FechaCreacion = DateTime.Now,
                    IdCliente = idCliente,
                    IdUsuarioCreacion = idUsuarioCreacion,
                    NumeroFile = NumeroTabla,
                    IdEstado = 1
                };
                oTicketFile = oServicioTSO.TicketFileProvider_DeepSave(oTicketFile);

                return oTicketFile.IdTicketFile;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Determina la existencia de un Ticket en TSO
        /// </summary>
        /// <param name="numeroTicket">Numero de Ticket de buscar</param>
        /// <returns>Boolean</returns>
        public bool ExistTicket(string numeroTicket)
        {
            try
            {
                bool isExist = true;
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                WsTsofSoapClient oServicioTSO = new WsTsofSoapClient(binding, baseAddress);

                Ticket oTicket1 = oServicioTSO.TicketProvider_GetByNumeroTicket(numeroTicket);

                if (oTicket1 != null)
                {
                    isExist = false;
                }

                return isExist;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Obtiene el detalle de los servicios de un proveedor
        /// </summary>
        /// <param name="idServicioDetalle">Identificador del Tipo de Servicio</param>
        /// <returns>Detalle del servicio</returns>
        public ProveedorDetalle GetProviderDetail(string idServicioDetalle)
        {
            try
            {
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                WsTsofSoapClient oServicioTSO = new WsTsofSoapClient(binding, baseAddress);
                IList<ProveedorDetalle> lista = new List<ProveedorDetalle>();
                StringBuilder parametros = new StringBuilder();
                parametros.AppendFormat("DescripcionTobo='{0}'", idServicioDetalle);
                lista = oServicioTSO.ProveedorDetalleProvider_Find(parametros.ToString());
                ProveedorDetalle proveedorDetalle = new ProveedorDetalle();
                if (lista.Count > 0 && lista != null)
                {
                    proveedorDetalle = lista[0];
                }
                else
                {
                    proveedorDetalle = null;
                }
                return proveedorDetalle;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los datos del cliente
        /// </summary>
        /// <param name="codeERP">Codigo SAP a buscar</param>
        /// <returns>Datos del cliente</returns>
        public Cliente GetCustomerDataCodeERP(string codeERP)
        {
            try
            {
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                WsTsofSoapClient oServicioTSO = new WsTsofSoapClient(binding, baseAddress);
                IList<Cliente> lista = new List<Cliente>();
                StringBuilder parametros = new StringBuilder();
                parametros.AppendFormat("CodigoErp='{0}'", codeERP);
                lista = oServicioTSO.ClienteProvider_Find(parametros.ToString());
                Cliente oCliente = new Cliente();
                if (lista.Count > 0 && lista != null)
                {
                    oCliente = lista[0];
                }
                else
                {
                    oCliente = null;
                }
                return oCliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Cliente GetCustomerDataId(long idCustomer)
        {
            try
            {
                EndpointAddress baseAddress = new EndpointAddress(pBaseUrl);
                System.ServiceModel.Channels.Binding binding = new BasicHttpBinding();
                WsTsofSoapClient oServicioTSO = new WsTsofSoapClient(binding, baseAddress);
                Cliente oCliente = oServicioTSO.ClienteProvider_GetByIdCliente(idCustomer);

                return oCliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
