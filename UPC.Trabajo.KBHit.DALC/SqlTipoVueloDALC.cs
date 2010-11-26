using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlTipoVueloDALC : TipoVueloDALC
    {
        public override int InsertarTipoVueloBE(TipoVueloBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoVueloBEInsertar;

            SqlParameter codTipoVuelo;
            SqlParameter tipoVuelo;
            SqlParameter impuesto;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTipoVueloBEInsertar = "uspTipoVueloInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTipoVueloBEInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codTipoVuelo = cmd.CreateParameter();
                codTipoVuelo.Direction = ParameterDirection.ReturnValue;
                codTipoVuelo.SqlDbType = SqlDbType.Int;

                tipoVuelo = cmd.CreateParameter();
                tipoVuelo.ParameterName = "@TipoVuelo";
                tipoVuelo.SqlDbType = SqlDbType.VarChar;
                tipoVuelo.Size = 15;
                tipoVuelo.SqlValue = obj.TipoVuelo;

                impuesto = cmd.CreateParameter();
                impuesto.ParameterName = "@Impuesto";
                impuesto.SqlDbType = SqlDbType.Float;
                impuesto.SqlValue = obj.Impuesto;

                cmd.Parameters.Add(codTipoVuelo);
                cmd.Parameters.Add(tipoVuelo);
                cmd.Parameters.Add(impuesto);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codTipoVuelo.Value);

                cmd.Connection.Close();

                cmd.Dispose();
                Conn.Dispose();

                return iCod;
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                Conn.Dispose();
                throw ex;
            }
        }

        public override TipoVueloBE ObtenerTipoVueloBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoVueloBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTipoVueloBEObtener = "uspTipoVueloObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTipoVueloBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                TipoVueloBE obj;
                obj = new TipoVueloBE();

                if (dr.Read())
                {
                    obj.CodTipoVuelo = dr.GetInt32(dr.GetOrdinal("CodTipoVuelo"));
                    obj.TipoVuelo = dr.GetString(dr.GetOrdinal("TipoVuelo"));
                    obj.Impuesto = (float)dr.GetDouble(dr.GetOrdinal("Impuesto"));
                }

                cmd.Connection.Close();

                cmd.Dispose();
                Conn.Dispose();

                return obj;
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                Conn.Dispose();
                throw ex;
            }
        }

        public override void ActualizarTipoVueloBE(TipoVueloBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoVueloBEActualizar;

            SqlParameter id;
            SqlParameter tipoVuelo;
            SqlParameter impuesto;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTipoVueloBEActualizar = "uspTipoVueloActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTipoVueloBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodTipoVuelo;

                tipoVuelo = cmd.CreateParameter();
                tipoVuelo.ParameterName = "@Tipovuelo";
                tipoVuelo.SqlDbType = SqlDbType.VarChar;
                tipoVuelo.Size = 15;
                tipoVuelo.SqlValue = obj.TipoVuelo;

                impuesto = cmd.CreateParameter();
                impuesto.ParameterName = "@Impuesto";
                impuesto.SqlDbType = SqlDbType.Float;
                impuesto.SqlValue = obj.Impuesto;

                cmd.Parameters.Add(id);
                cmd.Parameters.Add(tipoVuelo);
                cmd.Parameters.Add(impuesto);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                cmd.Dispose();
                Conn.Dispose();
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                Conn.Dispose();
                throw ex;
            }
        }

        public override List<TipoVueloBE> ListarTipoVueloBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoVueloBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlTipoVueloBEListar = "uspTipoVueloListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTipoVueloBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<TipoVueloBE> lst;
                lst = new List<TipoVueloBE>();

                TipoVueloBE obj;

                while (dr.Read())
                {
                    obj = new TipoVueloBE();
                    obj.CodTipoVuelo = dr.GetInt32(dr.GetOrdinal("CodTipoVuelo"));
                    obj.TipoVuelo = dr.GetString(dr.GetOrdinal("TipoVuelo"));
                    obj.Impuesto = dr.GetFloat(dr.GetOrdinal("Impuesto"));

                    lst.Add(obj);
                }

                cmd.Connection.Close();

                cmd.Dispose();
                Conn.Dispose();

                return lst;
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                Conn.Dispose();
                throw ex;
            }
        }
    }
}