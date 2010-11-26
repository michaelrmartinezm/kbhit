using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class InformacionVueloDALC
    {
        public abstract int InsertarInformacionVueloBE(InformacionVueloBE obj);
        public abstract InformacionVueloBE ObtenerInformacionVueloBE(int iCod);
        public abstract List<InformacionVueloBE> ListarInformacionVueloBE();
    }
}
