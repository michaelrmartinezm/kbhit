using System;

namespace UPC.Trabajo.KBHit.BE
{
    public class TUUABE
    {
        private int codTUUA;
        private int codBoleto;
        private float impuesto;
        private TipoVueloBE objTipoVueloBE;
        private AerolineaBE objAerolineaBE;
        private int codVuelo;

        public int CodVuelo
        {
            get { return codVuelo; }
            set { codVuelo = value; }
        }

        public AerolineaBE ObjAerolineaBE
        {
            get { return objAerolineaBE; }
            set { objAerolineaBE = value; }
        }

        public TipoVueloBE ObjTipoVueloBE
        {
            get { return objTipoVueloBE; }
            set { objTipoVueloBE = value; }
        }

        public float Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public int CodBoleto
        {
            get { return codBoleto; }
            set { codBoleto = value; }
        }

        public int CodTUUA
        {
            get { return codTUUA; }
            set { codTUUA = value; }
        }
    }
}
