using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class CobroEstacionamientoDALC
    {
        public abstract int InsertarCobroEstacionamientoBE(CobroEstacionamientoBE obj);
        public abstract CobroEstacionamientoBE ObtenerCobroEstacionamientoBE(int iCod);
        public abstract List<CobroEstacionamientoBE> ListarCobroEstacionamientoBE();
    }
}
