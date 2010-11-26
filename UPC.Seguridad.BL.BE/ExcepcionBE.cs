using System;

namespace UPC.Seguridad.BL.BE
{
    public class ExcepcionBE
    {
        private int _IdExcepcion;
        private String _Mensaje;
        private String _StackTrace;
        private DateTime _FechaCliente;
        private DateTime _FechaServidor;
        private String _IPCliente;
        private String _Usuario;

        public String Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public String IPCliente
        {
            get { return _IPCliente; }
            set { _IPCliente = value; }
        }

        public DateTime FechaServidor
        {
            get { return _FechaServidor; }
            set { _FechaServidor = value; }
        }

        public DateTime FechaCliente
        {
            get { return _FechaCliente; }
            set { _FechaCliente = value; }
        }

        public String StackTrace
        {
            get { return _StackTrace; }
            set { _StackTrace = value; }
        }

        public String Mensaje
        {
            get { return _Mensaje; }
            set { _Mensaje = value; }
        }

        public int IdExcepcion
        {
            get { return _IdExcepcion; }
            set { _IdExcepcion = value; }
        }
    }
}
