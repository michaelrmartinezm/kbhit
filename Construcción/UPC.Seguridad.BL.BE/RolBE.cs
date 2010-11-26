using System;

namespace UPC.Seguridad.BL.BE
{
    public class RolBE
    {
        private int _IdRol;
        private String _DescripcionRol;

        public String DescripcionRol
        {
            get { return _DescripcionRol; }
            set { _DescripcionRol = value; }
        }

        public int IdRol
        {
            get { return _IdRol; }
            set { _IdRol = value; }
        }
    }
}
