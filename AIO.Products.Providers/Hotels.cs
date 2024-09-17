using TSO = AIO.Api.TSO;
using AIO.Api.TSO.ServiceTSO;
using LOG = AIO.Api.LOG;
using AIO.Entities.Bookings;
using System;
using System.Collections.Generic;

namespace AIO.Products.Providers
{
    public class Hotels
    {
        private string pUserName { get; set; }
        private string pPassword { get; set; }
        private string pMicroSiteId { get; set; }
        private string pBaseUrlTso { get; set; }
        private string pBaseUrlSapTso { get; set; }
        private string pBaseUrlLog { get; set; }

        private const string userAgente5 = "agente5";
        private bool isAgency5 = true;

        private Cliente oCliente;
        private Usuario oUsuario;

        private LOG.Services apiLOG;

        public Hotels(string MicroSiteId, string BaseUrlTso, string BaseUrlSapTso, string BaseUrlLog)
        {
            pMicroSiteId = MicroSiteId;
            pBaseUrlTso = BaseUrlTso;
            pBaseUrlSapTso = BaseUrlSapTso;
            pBaseUrlLog = BaseUrlLog;
        }

        public void Process(IList<Hotelservice> hotelService, User user, ContactPerson contactPerson, InvoiceInfo invoiceInfo, DateTime creationDate, string endDate, int totalPaxBooking)
        {
            apiLOG = new LOG.Services(pMicroSiteId, pBaseUrlLog);

            int i = -1; //valor sin error

            try
            {
                oCliente = new Cliente();
                oUsuario = new Usuario();

                i = validateTSO(user, invoiceInfo, creationDate);
                //verifica si existe algun error
                if (i > 0)
                {
                    //procede a validar el estado del bookingTrip
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private int validateTSO(User user, InvoiceInfo invoiceInfo, DateTime creationDate)
        {
            int i = -1; //valor sin error

            TSO.Services apiTSO = new TSO.Services(pBaseUrlTso);
            decimal decCambio = apiTSO.GetExchangeRate(date: creationDate);
            if (decCambio == -1)
            {
                i = 1; //No Integrado Tipo de Cambio no encontrado en TSO
            }
            else
            {
                string _usuario = userAgente5; //Usuario agencia
                //bool isAgency5 = true;

                if (user.microsite.Equals(pMicroSiteId))
                {
                    _usuario = user.username.ToLower().Trim();
                    isAgency5 = false;
                }

                oUsuario = apiTSO.GetUserData(user: _usuario);
                if (oUsuario == null)
                {
                    i = 2; //No Integrado firma no encontrada en TSO
                }
                else
                {
                    oUsuario.FirmaAgc = user.username.ToUpper().Trim();

                    //Los datos facturacion siempre seran definido en el tag 'invoice info'
                    //El tag 'contactPerson', viene definido solo para el pasajero titular
                    if (user.microsite.Equals(pMicroSiteId.Trim()))
                    {
                        string _ci = "";
                        string _name = "";
                        //Si el microsite es tropicaltours se obtiene los datos del cliente del tag invoiceinfo
                        if (invoiceInfo.requested == true)
                        {
                            _ci = invoiceInfo.documentNumber;
                            _name = invoiceInfo.name;
                        }

                        if (_ci.Length > 0 && _name.Length > 0)
                        {
                            long _num = 0;
                            bool result = long.TryParse(_ci, out _num);
                            if (result == false)
                            {
                                if (_ci == string.Empty || _ci == null)
                                {
                                    result = false;
                                }
                                else
                                {
                                    result = true;
                                }
                            }
                            else if (_num < 1)
                            {
                                result = false;
                            }

                            if (result == true)
                            {
                                var idCustSAPTSO = new Api.SAPTSO.Services(pBaseUrlSapTso).validateCustomer(_ci, _name);
                                if (idCustSAPTSO > 0)
                                {
                                    oCliente = apiTSO.GetCustomerDataId(idCustomer: idCustSAPTSO);
                                }
                                else
                                {
                                    i = 11;
                                }
                            }
                            else
                            {
                                i = 13; //Nit no valido para la factura cliente
                            }
                        }
                        else
                        {
                            i = 14; //error no existe datos de facturacion
                        }
                    }
                    else
                    {
                        //buscar cliente agencia por codigoerp en Tso
                        oCliente = apiTSO.GetCustomerDataCodeERP(user.agency.documentNumber.Trim());
                    }

                    if (oCliente == null)
                    {
                        i = 3; //No Integrado cliente no registrado en SAPTSO
                    }
                }
            }

            return i;
        }

        
    }
}
