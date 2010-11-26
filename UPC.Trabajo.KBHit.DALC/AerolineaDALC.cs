using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class AerolineaDALC
    {
        public abstract int InsertarAerolineaBE(AerolineaBE obj);
        public abstract AerolineaBE ObtenerAerolineaBE(int iCod);
        public abstract void EliminarAerolineaBE(int iCod);
        public abstract List<AerolineaBE> ListarAerolineaBE();
        public abstract void ActualizarAerolineaBE(AerolineaBE obj);
    }
}
