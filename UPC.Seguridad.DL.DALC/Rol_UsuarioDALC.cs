using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;

namespace UPC.Seguridad.DL.DALC
{
    public abstract class Rol_UsuarioDALC
    {
        public abstract void RolUsuarioInsertar(Rol_UsuarioBE objRolUsuarioBE);
        public abstract List<Rol_UsuarioBE> RolUsuarioListarXRol(RolBE objRolBE);
        public abstract List<Rol_UsuarioBE> RolUsuarioListarxUsuario(UsuarioBE objUsuarioBE);
    }
}
