using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class TipoVueloBE
    {
        private int codTipoVuelo;
        private String tipoVuelo;
        private float impuesto;

        public int CodTipoVuelo
        {
            get { return codTipoVuelo; }
            set { codTipoVuelo = value; }
        }
        

        public String TipoVuelo
        {
            get { return tipoVuelo; }
            set { tipoVuelo = value; }
        }
        
        public float Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }
    }
}
