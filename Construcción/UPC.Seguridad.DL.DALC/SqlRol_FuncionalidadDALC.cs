using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Seguridad.BL.BE;
using System.Configuration;

namespace UPC.Seguridad.DL.DALC
{
    public class SqlRol_FuncionalidadDALC:Rol_FuncionalidadDALC
    {
        public override void RolFuncionalidadInsertar(Rol_FuncionalidadBE ObjRolFuncionalidadBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdRolFuncionalidadInsertar = null;
            String sCadena;
            String sqlRolFuncionalidadInsertar;
            SqlParameter prmIdRol;
            SqlParameter prmIdFuncionalidad;

            try
            {
                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;

                sqlRolFuncionalidadInsertar = "uspRolFuncionalidadInsertar";
                Conn = new SqlConnection(sCadena);

                cmdRolFuncionalidadInsertar = Conn.CreateCommand();
                cmdRolFuncionalidadInsertar.CommandType = CommandType.StoredProcedure;
                cmdRolFuncionalidadInsertar.CommandText = sqlRolFuncionalidadInsertar;

                prmIdRol = cmdRolFuncionalidadInsertar.CreateParameter();
                prmIdRol.SqlDbType = SqlDbType.Int;
                prmIdRol.ParameterName = "@IdRol";
                prmIdRol.Value = ObjRolFuncionalidadBE.ObjRolBE.IdRol;

                prmIdFuncionalidad = cmdRolFuncionalidadInsertar.CreateParameter();
                prmIdFuncionalidad.ParameterName = "@IdFuncionalidad";
                prmIdFuncionalidad.SqlDbType = SqlDbType.Int;
                prmIdFuncionalidad.Value = ObjRolFuncionalidadBE.ObjFuncionalidadBE.IdFuncionalidad;

                cmdRolFuncionalidadInsertar.Parameters.Add(prmIdRol);
                cmdRolFuncionalidadInsertar.Parameters.Add(prmIdFuncionalidad);

                cmdRolFuncionalidadInsertar.Connection.Open();
                cmdRolFuncionalidadInsertar.ExecuteNonQuery();
                cmdRolFuncionalidadInsertar.Connection.Close();

                cmdRolFuncionalidadInsertar.Dispose();
                Conn.Dispose();
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }

        public override List<Rol_FuncionalidadBE> RolFuncionalidadListarXRol(RolBE objRolBE, AplicacionBE objAplicacionBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdRolFuncionalidadListarXRol = null;
            String sCadena;
            String sqlRolFuncionalidadListarXRol;
            SqlDataReader drRolFuncionalidad;
            SqlParameter prmIdRol = null;
            SqlParameter prmIdAplicacion = null;

            try
            {
                List<Rol_FuncionalidadBE> lsRolFuncionlidadBE = new List<Rol_FuncionalidadBE>();

                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;
                Conn = new SqlConnection(sCadena);

                sqlRolFuncionalidadListarXRol = "uspRolFuncionalidadListarXRol";
                cmdRolFuncionalidadListarXRol = Conn.CreateCommand();
                cmdRolFuncionalidadListarXRol.CommandText = sqlRolFuncionalidadListarXRol;
                cmdRolFuncionalidadListarXRol.CommandType = CommandType.StoredProcedure;

                prmIdRol = cmdRolFuncionalidadListarXRol.CreateParameter();
                prmIdRol.ParameterName = "@IdRol";
                prmIdRol.SqlDbType = SqlDbType.Int;
                prmIdRol.Value = objRolBE.IdRol;

                prmIdAplicacion = cmdRolFuncionalidadListarXRol.CreateParameter();
                prmIdAplicacion.ParameterName = "@IdAplicacion";
                prmIdAplicacion.SqlDbType = SqlDbType.Int;
                prmIdAplicacion.Value = objAplicacionBE.IdAplicacion;

                cmdRolFuncionalidadListarXRol.Parameters.Add(prmIdRol);
                cmdRolFuncionalidadListarXRol.Parameters.Add(prmIdAplicacion);
                cmdRolFuncionalidadListarXRol.Connection.Open();
                drRolFuncionalidad = cmdRolFuncionalidadListarXRol.ExecuteReader();

                while (drRolFuncionalidad.Read())
                {
                    Rol_FuncionalidadBE objRolFuncionalidadBE = new Rol_FuncionalidadBE();
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    RolDALC objRolDALC = FabricaDALC.getRolDALC();
                    objRolBE = objRolDALC.RolObtener(drRolFuncionalidad.GetInt32(drRolFuncionalidad.GetOrdinal("IdRol")));
                    objRolFuncionalidadBE.ObjRolBE = objRolBE;
                    FuncionalidadDALC objFuncionalidadDALC = FabricaDALC.getFuncionalidadDALC();
                    FuncionalidadBE objFuncionalidadBE = objFuncionalidadDALC.FuncionalidadObtener(drRolFuncionalidad.GetInt32(drRolFuncionalidad.GetOrdinal("IdFuncionalidad")));
                    objRolFuncionalidadBE.ObjFuncionalidadBE = objFuncionalidadBE;
                    lsRolFuncionlidadBE.Add(objRolFuncionalidadBE);
                }

                cmdRolFuncionalidadListarXRol.Connection.Close();
                cmdRolFuncionalidadListarXRol.Dispose();

                Conn.Dispose();

                return lsRolFuncionlidadBE;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            } 
        }
    }
}
