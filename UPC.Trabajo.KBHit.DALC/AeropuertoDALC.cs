using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class AeropuertoDALC
    {
        public abstract int InsertarAeropuertoBE(AeropuertoBE obj);
        public abstract AeropuertoBE ObtenerAeropuertoBE(int iCod);
        public abstract void EliminarAeropuertoBE(int iCod);
        public abstract List<AeropuertoBE> ListarAeropuertoBE();
        public abstract void ActualizarAeropuertoBE(AeropuertoBE obj);
        public abstract AeropuertoBE ObtenerAeropuertoBENombre(String nombre);
    }
}
