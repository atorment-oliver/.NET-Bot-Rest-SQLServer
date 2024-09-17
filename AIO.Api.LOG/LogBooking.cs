using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIO.Api.LOG
{
    public class LogBooking
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _fecha;
        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private string _hora;
        public string Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        private string _contenido;
        public string Contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        private string _firma;
        public string Firma
        {
            get { return _firma; }
            set { _firma = value; }
        }

        private string _bookedid;
        public string BookedId
        {
            get { return _bookedid; }
            set { _bookedid = value; }
        }

        private string _observacion;
        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        private string _nivel;
        public string Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        private bool _estado;
        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private string _microsite;
        public string Microsite
        {
            get { return _microsite; }
            set { _microsite = value; }
        }

    }
}
