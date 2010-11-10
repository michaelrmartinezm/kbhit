using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlAerolineaDALC:AerolineaDALC
    {
	    public override int InsertarAerolineaBE(AerolineaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAerolineaBEInsertar;

            SqlParameter codAerolinea;
            SqlParameter nombre;
            SqlParameter ruc;
            SqlParameter procedencia;
            SqlParameter logotipo;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAerolineaBEInsertar = "uspAerolineaInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAerolineaBEInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codAerolinea = cmd.CreateParameter();
                codAerolinea.Direction = ParameterDirection.ReturnValue;
                codAerolinea.SqlDbType = SqlDbType.Int;

                nombre = cmd.CreateParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.SqlValue = obj.Nombre;

                ruc = cmd.CreateParameter();
                ruc.ParameterName = "@Ruc";
                ruc.SqlDbType = SqlDbType.VarChar;
                ruc.Size = 50;
                ruc.SqlValue = obj.Ruc;

                procedencia = cmd.CreateParameter();
                procedencia.ParameterName = "@Procedencia";
                procedencia.SqlDbType = SqlDbType.VarChar;
                procedencia.Size = 50;
                procedencia.SqlValue = obj.Procedencia;

                logotipo = cmd.CreateParameter();
                logotipo.ParameterName = "@Logotipo";
                logotipo.SqlDbType = SqlDbType.Image;
                logotipo.SqlValue = obj.Logotipo;

                cmd.Parameters.Add(codAerolinea);
                cmd.Parameters.Add(nombre);
                cmd.Parameters.Add(ruc);
                cmd.Parameters.Add(procedencia);
                cmd.Parameters.Add(logotipo);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codAerolinea.Value);

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

	    public override AerolineaBE ObtenerAerolineaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAerolineaBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAerolineaBEObtener = "uspAerolineaObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAerolineaBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                AerolineaBE obj;
                obj = new AerolineaBE();

                if (dr.Read())
                {
                    obj.CodAerolinea = dr.GetInt32(dr.GetOrdinal("CodAerolinea"));
                    obj.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
		            obj.Ruc = dr.GetString(dr.GetOrdinal("RUC"));
		            obj.Procedencia = dr.GetString(dr.GetOrdinal("Procedencia"));
                    obj.Logotipo = (byte[])dr.GetSqlBinary(dr.GetOrdinal("Logotipo"));
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

        public override void EliminarAerolineaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAerolineaBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAerolineaBEEliminar = "uspAerolineaEliminar";
                cmd = new SqlCommand(sqlAerolineaBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@id";
                id.SqlDbType = SqlDbType.Int;
                id.Value = iCod;

                cmd.Parameters.Add(id);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public override List<AerolineaBE> ListarAerolineaBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAerolineaBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlAerolineaBEListar = "uspAerolineaListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAerolineaBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<AerolineaBE> lst;
                lst = new List<AerolineaBE>();

                AerolineaBE obj;

                while (dr.Read())
                {
                    obj = new AerolineaBE();
                    obj.CodAerolinea = dr.GetInt32(dr.GetOrdinal("CodAerolinea"));
                    obj.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    obj.Ruc = dr.GetString(dr.GetOrdinal("RUC"));
                    obj.Procedencia = dr.GetString(dr.GetOrdinal("Procedencia"));
                    //obj.Logotipo = (byte[])dr.GetSqlBinary(dr.GetOrdinal("Logotipo"));
                    
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

        public override void ActualizarAerolineaBE(AerolineaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAerolineaBEActualizar;

            SqlParameter id;
            SqlParameter nombre;
            SqlParameter ruc;
            SqlParameter procedencia;
            SqlParameter logotipo;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAerolineaBEActualizar = "uspAerolineaActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAerolineaBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodAerolinea;

                nombre = cmd.CreateParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                nombre.SqlValue = obj.Nombre;

                ruc = cmd.CreateParameter();
                ruc.ParameterName = "@Ruc";
                ruc.SqlDbType = SqlDbType.VarChar;
                ruc.Size = 50;
                ruc.SqlValue = obj.Ruc;

                procedencia = cmd.CreateParameter();
                procedencia.ParameterName = "@procedencia";
                procedencia.SqlDbType = SqlDbType.VarChar;
                procedencia.Size = 50;
                procedencia.SqlValue = obj.Procedencia;

                logotipo = cmd.CreateParameter();
                logotipo.ParameterName = "@Logotipo";
                logotipo.SqlDbType = SqlDbType.Image;
                logotipo.SqlValue = obj.Logotipo;


                cmd.Parameters.Add(id);
                cmd.Parameters.Add(nombre);
                cmd.Parameters.Add(ruc);
                cmd.Parameters.Add(procedencia);
                cmd.Parameters.Add(logotipo);

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
    }
}