using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class PlataformaDALC
    {
        public abstract int InsertarPlataformaBE(PlataformaBE obj);
        public abstract PlataformaBE ObtenerPlataformaBE(int iCod);
        public abstract void EliminarPlataformaBE(int iCod);
        public abstract List<PlataformaBE> ListarPlataformaBE();
        public abstract void ActualizarPlataformaBE(PlataformaBE obj);
    }
}
