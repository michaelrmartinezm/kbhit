using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlDestinoDALC:DestinoDALC
    {
	    public override int InsertarDestinoBE(DestinoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

	        SqlParameter codDestino;
            SqlParameter codPlanVuelo;
            SqlParameter tiempoHr;
            SqlParameter tiempoMin;
            SqlParameter codAerodromo;
            SqlParameter codAerodromoAlter;
            SqlParameter codAerodromo2Alter;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspDestinoInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codDestino = cmd.CreateParameter();
                codDestino.Direction = ParameterDirection.ReturnValue;
                codDestino.SqlDbType = SqlDbType.Int;

                codPlanVuelo = cmd.CreateParameter();
                codPlanVuelo.ParameterName = "@CodPlanVuelo";
                codPlanVuelo.SqlDbType = SqlDbType.Int;
                codPlanVuelo.SqlValue = obj.CodPlanVuelo;

                tiempoHr = cmd.CreateParameter();
                tiempoHr.ParameterName = "@TiempoHr";
                tiempoHr.SqlDbType = SqlDbType.VarChar;
                tiempoHr.Size = 50;
                tiempoHr.SqlValue = obj.TiempoHr;

                tiempoMin = cmd.CreateParameter();
                tiempoMin.ParameterName = "@TiempoMin";
                tiempoMin.SqlDbType = SqlDbType.VarChar;
                tiempoMin.Size = 50;
                tiempoMin.SqlValue = obj.TiempoMin;

                codAerodromo = cmd.CreateParameter();
                codAerodromo.ParameterName = "@CodAerodromo";
                codAerodromo.SqlDbType = SqlDbType.Int;
                codAerodromo.SqlValue = obj.CodAerodromo;

                codAerodromoAlter = cmd.CreateParameter();
                codAerodromoAlter.ParameterName = "@CodAerodromoAlter";
                codAerodromoAlter.SqlDbType = SqlDbType.Int;
                codAerodromoAlter.SqlValue = obj.CodAerodromoAlter;

                codAerodromo2Alter = cmd.CreateParameter();
                codAerodromo2Alter.ParameterName = "@CodAerodromo2Alter";
                codAerodromo2Alter.SqlDbType = SqlDbType.Int;
                codAerodromo2Alter.SqlValue = obj.CodAerodromo2Alter;

		        cmd.Parameters.Add(codDestino);
   	 	        cmd.Parameters.Add(codPlanVuelo);
 	            cmd.Parameters.Add(tiempoHr);
  	            cmd.Parameters.Add(tiempoMin);
     	        cmd.Parameters.Add(codAerodromo);
     	        cmd.Parameters.Add(codAerodromoAlter);
  		        cmd.Parameters.Add(codAerodromo2Alter);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codDestino.Value);

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

        public override DestinoBE ObtenerDestinoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlDestinoBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlDestinoBEObtener = "uspDestinoObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlDestinoBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodDestino";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                DestinoBE obj;
                obj = new DestinoBE();

                if (dr.Read())
                {
    		        obj.CodDestino = dr.GetInt32(dr.GetOrdinal("CodDestino"));
	                obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
	                obj.TiempoHr = dr.GetString(dr.GetOrdinal("TiempoHr"));
	                obj.TiempoMin = dr.GetString(dr.GetOrdinal("TiempoMin"));
	      	        obj.CodAerodromo = dr.GetInt32(dr.GetOrdinal("CodAerodromo"));
    	            obj.CodAerodromoAlter = dr.GetInt32(dr.GetOrdinal("CodAerodromoAlter"));
	                obj.CodAerodromo2Alter = dr.GetInt32(dr.GetOrdinal("CodAerodromo2Alter"));
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

	    /*public void EliminarDestinoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlDestinoBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlDestinoBEEliminar = "uspDestinoBEEliminar";
                cmd = new SqlCommand(sqlDestinoBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@Id";
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
        }*/

        public override List<DestinoBE> ListarDestinoBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlDestinoBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlDestinoBEListar = "uspDestinoListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlDestinoBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<DestinoBE> lst;
                lst = new List<DestinoBE>();

                DestinoBE obj;

                while (dr.Read())
                {
                    obj = new DestinoBE();
                    obj.CodDestino = dr.GetInt32(dr.GetOrdinal("CodDestino"));
                    obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
                    obj.TiempoHr = dr.GetString(dr.GetOrdinal("TiempoHr"));
                    obj.TiempoMin = dr.GetString(dr.GetOrdinal("TiempoMin"));
                    obj.CodAerodromo = dr.GetInt32(dr.GetOrdinal("CodAerodromo"));
                    obj.CodAerodromoAlter = dr.GetInt32(dr.GetOrdinal("CodAerodromoAlter"));
                    obj.CodAerodromo2Alter = dr.GetInt32(dr.GetOrdinal("CodAerodromo2Alter"));
                    
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

	    /*public void ActualizarDestinoBE(DestinoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlDestinoBEActualizar;

            SqlParameter id;
	        SqlParameter codPlanVuelo;
            SqlParameter tiempoHr;
            SqlParameter tiempoMin; 
            SqlParameter codAerodromo;
            SqlParameter codAerodromoAlter;
            SqlParameter codAerodromo2Alter;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlDestinoBEActualizar = "uspDestinoBEActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlDestinoBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@Id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodDestino;

		        codPlanVuelo = cmd.CreateParameter();
                codPlanVuelo.ParameterName = "@Estado";
                codPlanVuelo.SqlDbType = SqlDbType.VarChar;
                codPlanVuelo.Size = 50;
                codPlanVuelo.SqlValue = obj.CodPlanVuelo;

                tiempoHr = cmd.CreateParameter();
                tiempoHr.ParameterName = "@Ciudad";
                tiempoHr.SqlDbType = SqlDbType.VarChar;
                tiempoHr.Size = 50;
                tiempoHr.SqlValue = obj.TiempoHr;

                tiempoMin = cmd.CreateParameter();
                tiempoMin.ParameterName = "@Iata";
                tiempoMin.SqlDbType = SqlDbType.VarChar;
                tiempoMin.Size = 50;
                tiempoMin.SqlValue = obj.TiempoMin;

                codAerodromo = cmd.CreateParameter();
                codAerodromo.ParameterName = "@Oasi";
                codAerodromo.SqlDbType = SqlDbType.VarChar;
                codAerodromo.Size = 50;
                codAerodromo.SqlValue = obj.CodAerodromo;

                codAerodromoAlter = cmd.CreateParameter();
                codAerodromoAlter.ParameterName = "@Oasi";
                codAerodromoAlter.SqlDbType = SqlDbType.VarChar;
                codAerodromoAlter.Size = 50;
                codAerodromoAlter.SqlValue = obj.CodAerodromoAlter;

                codAerodromo2Alter = cmd.CreateParameter();
                codAerodromo2Alter.ParameterName = "@Oasi";
                codAerodromo2Alter.SqlDbType = SqlDbType.VarChar;
                codAerodromo2Alter.Size = 50;
                codAerodromo2Alter.SqlValue = obj.CodAerodromo2Alter;

		        cmd.Parameters.Add(id);
           	 	cmd.Parameters.Add(codPlanVuelo);
 	            cmd.Parameters.Add(tiempoHr);
  	            cmd.Parameters.Add(tiempoMin);
     	        cmd.Parameters.Add(codAerodromo);
     	        cmd.Parameters.Add(codAerodromoAlter);
  		        cmd.Parameters.Add(codAerodromo2Alter);

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
        }*/
    }
}
