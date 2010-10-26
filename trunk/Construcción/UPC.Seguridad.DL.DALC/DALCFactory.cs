using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Seguridad.DL.DALC
{
    public abstract class DALCFactory
    {
        public const int SQL = 1;

        public abstract UsuarioDALC getUsuarioDALC();
        public abstract RolDALC getRolDALC();
        public abstract AplicacionDALC getAplicacionDALC();
        public abstract FuncionalidadDALC getFuncionalidadDALC();
        public abstract Rol_UsuarioDALC getRolUsuarioDALC();
        public abstract Rol_FuncionalidadDALC getRolFuncionalidadDALC();
        public abstract ExcepcionDALC getExcepcionDALC();

        public static DALCFactory getFabrica(int iTipoFabrica)
        {
            switch (iTipoFabrica)
            {
                case SQL: return SqlDALCFactory.getFabrica();
                default: return null;
            }
        }
    }
}
