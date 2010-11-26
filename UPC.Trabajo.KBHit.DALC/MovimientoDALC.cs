using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class MovimientoDALC
    {
        public abstract int InsertarMovimientoBE(MovimientoBE obj);
        public abstract MovimientoBE ObtenerMovimientoBE(int iCod);
        public abstract void EliminarMovimientoBE(int iCod);
        public abstract List<MovimientoBE> ListarMovimientoBE();
        public abstract void ActualizarMovimientoBE(MovimientoBE obj);
    }
}
