using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Seguridad.BL.BE
{
    public class Rol_FuncionalidadBE
    {
        private RolBE _ObjRolBE;
        private FuncionalidadBE _ObjFuncionalidadBE;

        public FuncionalidadBE ObjFuncionalidadBE
        {
            get { return _ObjFuncionalidadBE; }
            set { _ObjFuncionalidadBE = value; }
        }

        public RolBE ObjRolBE
        {
            get { return _ObjRolBE; }
            set { _ObjRolBE = value; }
        }
    }
}
