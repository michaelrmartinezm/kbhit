using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class AvionDALC
    {
        public abstract int InsertarAvionBE(AvionBE obj);
        public abstract AvionBE ObtenerAvionBE(int iCod);
        public abstract void EliminarAvionBE(int iCod);
        public abstract List<AvionBE> ListarAvionBE();
        public abstract void ActualizarAvionBE(AvionBE obj);
    }
}
