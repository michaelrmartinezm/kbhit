using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class TipoVueloDALC
    {
        public abstract int InsertarTipoVueloBE(TipoVueloBE obj);
        public abstract void ActualizarTipoVueloBE(TipoVueloBE obj);
        public abstract TipoVueloBE ObtenerTipoVueloBE(int iCod);        
    }
}
