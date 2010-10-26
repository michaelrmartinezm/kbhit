using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;

namespace UPC.Seguridad.DL.DALC
{
    public abstract class Rol_FuncionalidadDALC
    {
        public abstract void RolFuncionalidadInsertar(Rol_FuncionalidadBE ObjRolFuncionalidadBE);
        public abstract List<Rol_FuncionalidadBE> RolFuncionalidadListarXRol(RolBE objRolBE, AplicacionBE objAplicacionBE);
    }
}
    