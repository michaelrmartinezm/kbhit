using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class DestinoDALC
    {
        public abstract int InsertarDestinoBE(DestinoBE obj);
        public abstract DestinoBE ObtenerDestinoBE(int iCod);
        public abstract List<DestinoBE> ListarDestinoBE();
    }
}
