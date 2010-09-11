using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Seguridad.BL.BE
{
    public class Rol_UsuarioBE
    {
        private RolBE _ObjRolBE;
        private UsuarioBE _ObjUsuarioBE;

        public UsuarioBE ObjUsuarioBE
        {
            get { return _ObjUsuarioBE; }
            set { _ObjUsuarioBE = value; }
        }

        public RolBE ObjRolBE
        {
            get { return _ObjRolBE; }
            set { _ObjRolBE = value; }
        }

    }
}
