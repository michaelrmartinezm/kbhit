using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;
namespace UPC.Seguridad.DL.DALC
{
    public abstract class FuncionalidadDALC
    {
        public abstract int FuncionalidadInsertar(FuncionalidadBE objFuncionalidadBE);
        public abstract FuncionalidadBE FuncionalidadObtener(int IdFuncionalidad);
        public abstract List<FuncionalidadBE> FuncionalidadListar();
        public abstract void FuncionalidadActualizar(FuncionalidadBE objFuncionalidadBE);
    }
}
