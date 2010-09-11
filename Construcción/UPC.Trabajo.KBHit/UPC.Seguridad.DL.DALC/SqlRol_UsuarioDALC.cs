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
    public class SqlRol_UsuarioDALC:Rol_UsuarioDALC
    {
        public override void RolUsuarioInsertar(Rol_UsuarioBE objRolUsuarioBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdRolUsuarioInsertar = null;
            String sqlRolUsuarioInsertar;
            SqlParameter prmIdRol;
            SqlParameter prmIdUsuario;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlRolUsuarioInsertar = "uspUsuarioRolInsertar";

                cmdRolUsuarioInsertar = Conn.CreateCommand();
                cmdRolUsuarioInsertar.CommandType = CommandType.StoredProcedure;
                cmdRolUsuarioInsertar.CommandText = sqlRolUsuarioInsertar;

                prmIdRol = cmdRolUsuarioInsertar.CreateParameter();
                prmIdRol.SqlDbType = SqlDbType.Int;
                prmIdRol.ParameterName = "@IdRol";
                prmIdRol.Value = objRolUsuarioBE.ObjRolBE.IdRol;

                prmIdUsuario = cmdRolUsuarioInsertar.CreateParameter();
                prmIdUsuario.ParameterName = "@IdUsuario";
                prmIdUsuario.SqlDbType = SqlDbType.Int;
                prmIdUsuario.Value = objRolUsuarioBE.ObjUsuarioBE.IdUsuario;

                cmdRolUsuarioInsertar.Parameters.Add(prmIdRol);
                cmdRolUsuarioInsertar.Parameters.Add(prmIdUsuario);

                cmdRolUsuarioInsertar.Connection.Open();
                cmdRolUsuarioInsertar.ExecuteNonQuery();
                cmdRolUsuarioInsertar.Connection.Close();

                cmdRolUsuarioInsertar.Dispose();
                Conn.Dispose();
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }

        public override List<Rol_UsuarioBE> RolUsuarioListarXRol(RolBE objRolBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdRolUsuarioListarXRol = null;
            String sqlRolUsuarioListarXRol;
            SqlDataReader drRolUsuario;
            SqlParameter prmIdRol = null;

            try
            {
                List<Rol_UsuarioBE> lsRolUsuarioBE = null;

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlRolUsuarioListarXRol = "uspUsuarioRolListarXRol";
                cmdRolUsuarioListarXRol = Conn.CreateCommand();
                cmdRolUsuarioListarXRol.CommandText = sqlRolUsuarioListarXRol;
                cmdRolUsuarioListarXRol.CommandType = CommandType.StoredProcedure;

                prmIdRol = cmdRolUsuarioListarXRol.CreateParameter();
                prmIdRol.ParameterName = "@IdRol";
                prmIdRol.SqlDbType = SqlDbType.Int;
                prmIdRol.Value = objRolBE.IdRol;

                cmdRolUsuarioListarXRol.Parameters.Add(prmIdRol);
                cmdRolUsuarioListarXRol.Connection.Open();
                drRolUsuario = cmdRolUsuarioListarXRol.ExecuteReader();

                while (drRolUsuario.Read())
                {
                    if (lsRolUsuarioBE == null)
                        lsRolUsuarioBE = new List<Rol_UsuarioBE>();
                    Rol_UsuarioBE objRolUsuarioBE = new Rol_UsuarioBE();
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    RolDALC objRolDALC = FabricaDALC.getRolDALC();
                    objRolBE=objRolDALC.RolObtener(drRolUsuario.GetInt32(drRolUsuario.GetOrdinal("IdRol")));
                    objRolUsuarioBE.ObjRolBE = objRolBE;
                    UsuarioDALC objUsuarioDALC = FabricaDALC.getUsuarioDALC();
                    UsuarioBE objUsuarioBE= objUsuarioDALC.UsuarioObtener(drRolUsuario.GetInt32(drRolUsuario.GetOrdinal("IdUsuario")));
                    objRolUsuarioBE.ObjUsuarioBE = objUsuarioBE;
                    lsRolUsuarioBE.Add(objRolUsuarioBE);
                }

                cmdRolUsuarioListarXRol.Connection.Close();
                cmdRolUsuarioListarXRol.Dispose();

                Conn.Dispose();

                return lsRolUsuarioBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            } 
        }

        public override List<Rol_UsuarioBE> RolUsuarioListarxUsuario(UsuarioBE objUsuarioBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdRolUsuarioListarXUsuario = null;
            String sqlRolUsuarioListarXUsuario;
            SqlDataReader drRolUsuario;
            SqlParameter prmIdUsuario = null;

            try
            {
                List<Rol_UsuarioBE> lsRolUsuarioBE = null;

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlRolUsuarioListarXUsuario = "uspUsuarioRolListarXUsuario";
                cmdRolUsuarioListarXUsuario = Conn.CreateCommand();
                cmdRolUsuarioListarXUsuario.CommandText = sqlRolUsuarioListarXUsuario;
                cmdRolUsuarioListarXUsuario.CommandType = CommandType.StoredProcedure;

                prmIdUsuario = cmdRolUsuarioListarXUsuario.CreateParameter();
                prmIdUsuario.ParameterName = "@IdUsuario";
                prmIdUsuario.SqlDbType = SqlDbType.Int;
                prmIdUsuario.Value = objUsuarioBE.IdUsuario;

                cmdRolUsuarioListarXUsuario.Parameters.Add(prmIdUsuario);
                cmdRolUsuarioListarXUsuario.Connection.Open();
                drRolUsuario = cmdRolUsuarioListarXUsuario.ExecuteReader();

                while (drRolUsuario.Read())
                {
                    if (lsRolUsuarioBE == null)
                        lsRolUsuarioBE = new List<Rol_UsuarioBE>();
                    Rol_UsuarioBE objRolUsuarioBE = new Rol_UsuarioBE();
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    RolDALC objRolDALC = FabricaDALC.getRolDALC();
                    RolBE objRolBE =objRolDALC.RolObtener(drRolUsuario.GetInt32(drRolUsuario.GetOrdinal("IdRol")));
                    objRolUsuarioBE.ObjRolBE = objRolBE;
                    UsuarioDALC objUsuarioDALC = FabricaDALC.getUsuarioDALC();
                    objUsuarioBE =objUsuarioDALC.UsuarioObtener(drRolUsuario.GetInt32(drRolUsuario.GetOrdinal("IdUsuario")));
                    objRolUsuarioBE.ObjUsuarioBE = objUsuarioBE;
                    lsRolUsuarioBE.Add(objRolUsuarioBE);
                }

                cmdRolUsuarioListarXUsuario.Connection.Close();
                cmdRolUsuarioListarXUsuario.Dispose();

                Conn.Dispose();

                return lsRolUsuarioBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }
    }
}