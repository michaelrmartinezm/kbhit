using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class TipoMovimientoDALC
    {
        public abstract int InsertarTipoMovimientoBE(TipoMovimientoBE obj);
        public abstract TipoMovimientoBE ObtenerTipoMovimientoBE(int iCod);
        public abstract void EliminarTipoMovimientoBE(int iCod);
        public abstract List<TipoMovimientoBE> ListarTipoMovimientoBE();
        public abstract void ActualizarTipoMovimientoBE(TipoMovimientoBE obj);
    }
}
