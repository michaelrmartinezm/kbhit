using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class FacturaDALC
    {
        public abstract int InsertarFactura(FacturaBE obj);
        public abstract FacturaBE ObtenerFactura(int iCod);
    }
}
