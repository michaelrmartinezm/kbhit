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
    public class SqlRolDALC:RolDALC
    {
        public override RolBE RolObtener(int idRol)
        {
            SqlConnection Conn = null;
            SqlCommand cmdRolObtener = null;
            String sqlRolObtener;
            SqlParameter prmIdRol;
            SqlDataReader drRol;

            try
            {
                RolBE objRolBE = new RolBE();

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlRolObtener = "uspRolObtener";
                cmdRolObtener = Conn.CreateCommand();
                cmdRolObtener.CommandText = sqlRolObtener;
                cmdRolObtener.CommandType = CommandType.StoredProcedure;

                prmIdRol = cmdRolObtener.CreateParameter();
                prmIdRol.ParameterName = "@IdRol";
                prmIdRol.SqlDbType = SqlDbType.Int;
                prmIdRol.Value = idRol;

                cmdRolObtener.Parameters.Add(prmIdRol);

                cmdRolObtener.Connection.Open();
                drRol = cmdRolObtener.ExecuteReader();

                if (drRol.Read())
                {
                    objRolBE.IdRol = drRol.GetInt32(drRol.GetOrdinal("IdRol"));
                    objRolBE.DescripcionRol = drRol.GetString(drRol.GetOrdinal("DescripcionRol"));
                }

                cmdRolObtener.Connection.Close();
                cmdRolObtener.Dispose();

                Conn.Dispose();

                return objRolBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }

        public override List<RolBE> RolListar()
        {
            SqlConnection Conn = null;
            SqlCommand cmdRolListar = null;
            String sqlRolListar;
            SqlDataReader drRol;

            try
            {
                List<RolBE> lsRolBE = new List<RolBE>();

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlRolListar = "uspRolListar";
                cmdRolListar = Conn.CreateCommand();
                cmdRolListar.CommandText = sqlRolListar;
                cmdRolListar.CommandType = CommandType.StoredProcedure;

                cmdRolListar.Connection.Open();
                drRol = cmdRolListar.ExecuteReader();

                while (drRol.Read())
                {
                    RolBE objRolBE = new RolBE();
                    objRolBE.IdRol = drRol.GetInt32(drRol.GetOrdinal("IdRol"));
                    objRolBE.DescripcionRol = drRol.GetString(drRol.GetOrdinal("DescripcionRol"));
                    lsRolBE.Add(objRolBE);
                }

                cmdRolListar.Connection.Close();
                cmdRolListar.Dispose();

                Conn.Dispose();

                return lsRolBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }
    }
}