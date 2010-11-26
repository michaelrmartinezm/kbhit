using System;

namespace UPC.Seguridad.BL.BE
{
    public class AplicacionBE
    {
        private int _IdAplicacion;
        private String _NombreAplicacion;
        private String _DescripcionAplicacion;
        private String _TipoAplicacion;

        public String TipoAplicacion
        {
            get { return _TipoAplicacion; }
            set { _TipoAplicacion = value; }
        }

        public String DescripcionAplicacion
        {
            get { return _DescripcionAplicacion; }
            set { _DescripcionAplicacion = value; }
        }

        public String NombreAplicacion
        {
            get { return _NombreAplicacion; }
            set { _NombreAplicacion = value; }
        }

        public int IdAplicacion
        {
            get { return _IdAplicacion; }
            set { _IdAplicacion = value; }
        }
    }
}
