using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;

namespace UPC.Seguridad.DL.DALC
{
    public abstract class UsuarioDALC
    {
        public abstract int UsuarioInsertar(UsuarioBE objUsuarioBE);
        public abstract UsuarioBE UsuarioObtener(int idUsuario);
        public abstract UsuarioBE UsuarioValidar(int idUsuario, String sContrasenia);
        public abstract int UsuarioExiste(String sLogin);
    }
}
