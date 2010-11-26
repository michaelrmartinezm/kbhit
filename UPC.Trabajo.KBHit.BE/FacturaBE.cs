using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class FacturaBE
    {
        private int codFactura;
        private AerolineaBE objAerolinea;
        private DateTime fecha;
        private float monto;        
        private String descripcion;        

        public int CodFactura
        {
            get { return codFactura; }
            set { codFactura = value; }
        }

        public AerolineaBE ObjAerolinea
        {
            get { return objAerolinea; }
            set { objAerolinea = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public float Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
