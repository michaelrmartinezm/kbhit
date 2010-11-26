using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class AerolineaBE
    {
        private int codAerolinea;

        public int CodAerolinea
        {
            get { return codAerolinea; }
            set { codAerolinea = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String ruc;

        public String Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        private String procedencia;

        public String Procedencia
        {
            get { return procedencia; }
            set { procedencia = value; }
        }

        private byte[] logotipo;

        public byte[] Logotipo
        {
            get { return logotipo; }
            set { logotipo = value; }
        }
    }
}
