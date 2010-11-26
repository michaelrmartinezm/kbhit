using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class SalidaDALC
    {
        public abstract int InsertarSalidaBE(SalidaBE obj);
        public abstract SalidaBE ObtenerSalidaBE(int iCod);
        public abstract void EliminarSalidaBE(int iCod);
        public abstract List<SalidaBE> ListarSalidaBE();
        public abstract void ActualizarSalidaBE(SalidaBE obj);
    }
}
