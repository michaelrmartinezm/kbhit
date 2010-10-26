using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Seguridad.DL.DALC
{
    public class SqlDALCFactory:DALCFactory
    {
        private SqlDALCFactory()
        {
 
        }

        private static SqlDALCFactory instancia = null;

        public static SqlDALCFactory getFabrica()
        {
            if (instancia == null)
                instancia = new SqlDALCFactory();
            return instancia;
        }

        public override UsuarioDALC getUsuarioDALC()
        {
            return new SqlUsuarioDALC();
        }

        public override RolDALC getRolDALC()
        {
            return new SqlRolDALC();
        }

        public override AplicacionDALC getAplicacionDALC()
        {
            return new SqlAplicacionDALC();
        }

        public override FuncionalidadDALC getFuncionalidadDALC()
        {
            return new SqlFuncionalidadDALC();
        }

        public override Rol_FuncionalidadDALC getRolFuncionalidadDALC()
        {
            return new SqlRol_FuncionalidadDALC();
        }

        public override Rol_UsuarioDALC getRolUsuarioDALC()
        {
            return new SqlRol_UsuarioDALC();
        }

        public override ExcepcionDALC getExcepcionDALC()
        {
            return new SqlExcepcionDALC();
        }
    }
}