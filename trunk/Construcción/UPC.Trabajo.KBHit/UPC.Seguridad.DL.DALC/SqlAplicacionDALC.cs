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
    public class SqlAplicacionDALC:AplicacionDALC
    {
        public override int AplicacionInsertar(AplicacionBE objAplicacionBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdAplicacionInsertar = null;
            String sqlAplicacionInsertar;
            SqlParameter prmIdAplicacion;
            SqlParameter prmNombreAplicacion;
            SqlParameter prmDescripcionAplicacion;
            SqlParameter prmTipoAplicacion;
            int idAplicacion;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAplicacionInsertar = "uspAplicacionInsertar";
                cmdAplicacionInsertar = Conn.CreateCommand();
                cmdAplicacionInsertar.CommandText = sqlAplicacionInsertar;
                cmdAplicacionInsertar.CommandType = CommandType.StoredProcedure;

                prmIdAplicacion = cmdAplicacionInsertar.CreateParameter();
                prmIdAplicacion.Direction = ParameterDirection.ReturnValue;
                prmIdAplicacion.SqlDbType = SqlDbType.Int;

                prmNombreAplicacion = cmdAplicacionInsertar.CreateParameter();
                prmNombreAplicacion.ParameterName = "@NombreAplicacion";
                prmNombreAplicacion.SqlDbType = SqlDbType.VarChar;
                prmNombreAplicacion.Value = objAplicacionBE.NombreAplicacion;

                prmDescripcionAplicacion = cmdAplicacionInsertar.CreateParameter();
                prmDescripcionAplicacion.ParameterName = "@DescripcionAplicacion";
                prmDescripcionAplicacion.SqlDbType = SqlDbType.VarChar;
                prmDescripcionAplicacion.Value = objAplicacionBE.DescripcionAplicacion;

                prmTipoAplicacion = cmdAplicacionInsertar.CreateParameter();
                prmTipoAplicacion.ParameterName = "@TipoAplicacion";
                prmTipoAplicacion.SqlDbType = SqlDbType.VarChar;
                prmTipoAplicacion.Value = objAplicacionBE.TipoAplicacion;

                cmdAplicacionInsertar.Parameters.Add(prmIdAplicacion);
                cmdAplicacionInsertar.Parameters.Add(prmNombreAplicacion);
                cmdAplicacionInsertar.Parameters.Add(prmDescripcionAplicacion);
                cmdAplicacionInsertar.Parameters.Add(prmTipoAplicacion);

                cmdAplicacionInsertar.Connection.Open();
                idAplicacion = Convert.ToInt32(prmIdAplicacion.Value);

                cmdAplicacionInsertar.Connection.Close();
                cmdAplicacionInsertar.Dispose();

                Conn.Dispose();

                return idAplicacion;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }

        public override AplicacionBE AplicacionObtenerXNombre(String sNombreAplicacion)
        {
            SqlConnection Conn = null;
            SqlCommand cmdAplicacionObtener = null;
            String sqlAplicacionObtener;
            SqlParameter prmNombreAplicacion;
            SqlDataReader drAplicacion;

            try
            {
                AplicacionBE objAplicacionBE = new AplicacionBE();

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAplicacionObtener = "uspAplicacionObtener";
                cmdAplicacionObtener = Conn.CreateCommand();
                cmdAplicacionObtener.CommandText = sqlAplicacionObtener;
                cmdAplicacionObtener.CommandType = CommandType.StoredProcedure;

                prmNombreAplicacion = cmdAplicacionObtener.CreateParameter();
                prmNombreAplicacion.ParameterName = "@NombreAplicacion";
                prmNombreAplicacion.SqlDbType = SqlDbType.VarChar;
                prmNombreAplicacion.Value = sNombreAplicacion;

                cmdAplicacionObtener.Parameters.Add(prmNombreAplicacion);

                cmdAplicacionObtener.Connection.Open();
                drAplicacion = cmdAplicacionObtener.ExecuteReader();

                if (drAplicacion.Read())
                {
                    objAplicacionBE.IdAplicacion = drAplicacion.GetInt32(drAplicacion.GetOrdinal("IdAplicacion"));
                    objAplicacionBE.NombreAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("NombreAplicacion"));
                    objAplicacionBE.DescripcionAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("DescripcionAplicacion"));
                    objAplicacionBE.TipoAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("TipoAplicacion"));
                }

                cmdAplicacionObtener.Connection.Close();
                cmdAplicacionObtener.Dispose();

                Conn.Dispose();

                return objAplicacionBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }

        public override AplicacionBE AplicacionObtenerXCodigo(int idAplicacion)
        {
            SqlConnection Conn = null;
            SqlCommand cmdAplicacionObtener = null;
            String sqlAplicacionObtener;
            SqlParameter prmIdAplicacion;
            SqlDataReader drAplicacion;

            try
            {
                AplicacionBE objAplicacionBE = new AplicacionBE();

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlAplicacionObtener = "uspAplicacionObtenerXCodigo";
                cmdAplicacionObtener = Conn.CreateCommand();
                cmdAplicacionObtener.CommandText = sqlAplicacionObtener;
                cmdAplicacionObtener.CommandType = CommandType.StoredProcedure;

                prmIdAplicacion = cmdAplicacionObtener.CreateParameter();
                prmIdAplicacion.ParameterName = "@IdAplicacion";
                prmIdAplicacion.SqlDbType = SqlDbType.Int;
                prmIdAplicacion.Value = idAplicacion;

                cmdAplicacionObtener.Parameters.Add(prmIdAplicacion);

                cmdAplicacionObtener.Connection.Open();
                drAplicacion = cmdAplicacionObtener.ExecuteReader();

                if (drAplicacion.Read())
                {
                    objAplicacionBE.IdAplicacion = drAplicacion.GetInt32(drAplicacion.GetOrdinal("IdAplicacion"));
                    objAplicacionBE.NombreAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("NombreAplicacion"));
                    objAplicacionBE.DescripcionAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("DescripcionAplicacion"));
                    objAplicacionBE.TipoAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("TipoAplicacion"));
                }

                cmdAplicacionObtener.Connection.Close();
                cmdAplicacionObtener.Dispose();

                Conn.Dispose();

                return objAplicacionBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }

        public override List<AplicacionBE> AplicacionListar()
        {
            SqlConnection Conn = null;
            SqlCommand cmdAplicacionListar = null;
            String sqlAplicacionListar;
            SqlDataReader drAplicacion;

            try
            {
                List<AplicacionBE> lsAplicacionBE = new List<AplicacionBE>();

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAplicacionListar = "uspAplicacionListar";
                cmdAplicacionListar = Conn.CreateCommand();
                cmdAplicacionListar.CommandText = sqlAplicacionListar;
                cmdAplicacionListar.CommandType = CommandType.StoredProcedure;

                cmdAplicacionListar.Connection.Open();
                drAplicacion = cmdAplicacionListar.ExecuteReader();

                while (drAplicacion.Read())
                {
                    AplicacionBE objAplicacionBE = new AplicacionBE();
                    objAplicacionBE.IdAplicacion = drAplicacion.GetInt32(drAplicacion.GetOrdinal("IdAplicacion"));
                    objAplicacionBE.NombreAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("NombreAplicacion"));
                    objAplicacionBE.DescripcionAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("DescripcionAplicacion"));
                    objAplicacionBE.TipoAplicacion = drAplicacion.GetString(drAplicacion.GetOrdinal("TipoAplicacion"));
                    lsAplicacionBE.Add(objAplicacionBE);
                }

                cmdAplicacionListar.Connection.Close();
                cmdAplicacionListar.Dispose();

                Conn.Dispose();

                return lsAplicacionBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }

        public override void AplicacionActualizar(AplicacionBE objAplicacionBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdAplicacionActualizar = null;
            String sqlAplicacionActualizar;
            SqlParameter prmIdAplicacion;
            SqlParameter prmNombreAplicacion;
            SqlParameter prmDescripcionAplicacion;
            SqlParameter prmTipoAplicacion;
            int idAplicacion;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAplicacionActualizar = "uspAplicacionActualizar";
                cmdAplicacionActualizar = Conn.CreateCommand();
                cmdAplicacionActualizar.CommandText = sqlAplicacionActualizar;
                cmdAplicacionActualizar.CommandType = CommandType.StoredProcedure;

                prmIdAplicacion = cmdAplicacionActualizar.CreateParameter();
                prmIdAplicacion.ParameterName = "@IdAplicacion";
                prmIdAplicacion.SqlDbType = SqlDbType.Int;
                prmIdAplicacion.Value = objAplicacionBE.IdAplicacion;

                prmNombreAplicacion = cmdAplicacionActualizar.CreateParameter();
                prmNombreAplicacion.ParameterName = "@NombreAplicacion";
                prmNombreAplicacion.SqlDbType = SqlDbType.VarChar;
                prmNombreAplicacion.Value = objAplicacionBE.NombreAplicacion;

                prmDescripcionAplicacion = cmdAplicacionActualizar.CreateParameter();
                prmDescripcionAplicacion.ParameterName = "@DescripcionAplicacion";
                prmDescripcionAplicacion.SqlDbType = SqlDbType.VarChar;
                prmDescripcionAplicacion.Value = objAplicacionBE.DescripcionAplicacion;

                prmTipoAplicacion = cmdAplicacionActualizar.CreateParameter();
                prmTipoAplicacion.ParameterName = "@TipoAplicacion";
                prmTipoAplicacion.SqlDbType = SqlDbType.VarChar;
                prmTipoAplicacion.Value = objAplicacionBE.TipoAplicacion;

                cmdAplicacionActualizar.Parameters.Add(prmIdAplicacion);
                cmdAplicacionActualizar.Parameters.Add(prmNombreAplicacion);
                cmdAplicacionActualizar.Parameters.Add(prmDescripcionAplicacion);
                cmdAplicacionActualizar.Parameters.Add(prmTipoAplicacion);

                cmdAplicacionActualizar.Connection.Open();
                idAplicacion = Convert.ToInt32(prmIdAplicacion.Value);

                cmdAplicacionActualizar.Connection.Close();
                cmdAplicacionActualizar.Dispose();

                Conn.Dispose();

            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }
    }
}