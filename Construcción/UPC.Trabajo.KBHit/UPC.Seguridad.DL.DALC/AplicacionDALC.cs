using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;

namespace UPC.Seguridad.DL.DALC
{
    public abstract class AplicacionDALC
    {
        public abstract int AplicacionInsertar(AplicacionBE objAplicacionBE);
        public abstract AplicacionBE AplicacionObtenerXNombre(String sNombreAplicacion);
        public abstract AplicacionBE AplicacionObtenerXCodigo(int idAplicacion);
        public abstract List<AplicacionBE> AplicacionListar();
        public abstract void AplicacionActualizar(AplicacionBE objAplicacionBE);
    }
}
