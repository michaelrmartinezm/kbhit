using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;

namespace UPC.Seguridad.DL.DALC
{
    public abstract class ExcepcionDALC
    {
        public abstract int ExcepcionInsertar(ExcepcionBE objExcepcionBE);
        public abstract ExcepcionBE ExcepcionObtener(int IdExcepcion);
        public abstract List<ExcepcionBE> ExcepcionListar();
        public abstract void ExcepcionActualizar(ExcepcionBE objExcepcionBE);
    }
}
