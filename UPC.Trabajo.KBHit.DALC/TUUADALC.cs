using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class TUUADALC
    {
        public abstract int InsertarTUUABE(TUUABE obj);
        public abstract TUUABE ObtenerTUUABE(int iCod);
        public abstract List<TUUABE> ListarTUUABE();
    }
}
