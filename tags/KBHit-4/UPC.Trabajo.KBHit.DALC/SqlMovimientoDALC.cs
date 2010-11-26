using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlMovimientoDALC:MovimientoDALC
    {
	    public override int InsertarMovimientoBE(MovimientoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

    		SqlParameter codMovimiento;
	        SqlParameter codTipoMovimiento;
	        SqlParameter codAerolinea;
	        SqlParameter codAvion;
	        SqlParameter detalle;
	        SqlParameter codAeropuertoOrigen;
	        SqlParameter codAeropuertoDestino;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspMovimientoInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codMovimiento = cmd.CreateParameter();
                codMovimiento.Direction = ParameterDirection.ReturnValue;
                codMovimiento.SqlDbType = SqlDbType.Int;

                codTipoMovimiento = cmd.CreateParameter();
                codTipoMovimiento.ParameterName = "@CodTipoMovimiento";
                codTipoMovimiento.SqlDbType = SqlDbType.Int;
                codTipoMovimiento.SqlValue = obj.CodTipoMovimiento;

                codAerolinea = cmd.CreateParameter();
                codAerolinea.ParameterName = "@CodAerolinea";
                codAerolinea.SqlDbType = SqlDbType.Int;
                codAerolinea.SqlValue = obj.CodAerolinea;

                codAvion = cmd.CreateParameter();
                codAvion.ParameterName = "@CodAvion";
                codAvion.SqlDbType = SqlDbType.Int;
                codAvion.SqlValue = obj.CodAvion;

                detalle = cmd.CreateParameter();
                detalle.ParameterName = "@Detalle";
                detalle.SqlDbType = SqlDbType.VarChar;
                detalle.Size = 500;
                detalle.SqlValue = obj.Detalle;

                codAeropuertoOrigen = cmd.CreateParameter();
                codAeropuertoOrigen.ParameterName = "@CodAeropuertoOrigen";
                codAeropuertoOrigen.SqlDbType = SqlDbType.Int;
                codAeropuertoOrigen.SqlValue = obj.CodAeropuertoOrigen;

                codAeropuertoDestino = cmd.CreateParameter();
                codAeropuertoDestino.ParameterName = "@CodAeropuertoDestino";
                codAeropuertoDestino.SqlDbType = SqlDbType.Int;
                codAeropuertoDestino.SqlValue = obj.CodAeropuertoDestino;

		        cmd.Parameters.Add(codMovimiento);
    	        cmd.Parameters.Add(codTipoMovimiento);
	            cmd.Parameters.Add(codAerolinea);
	            cmd.Parameters.Add(codAvion);
	            cmd.Parameters.Add(detalle);
    		    cmd.Parameters.Add(codAeropuertoOrigen);
	        	cmd.Parameters.Add(codAeropuertoDestino);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codMovimiento.Value);

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

        public override MovimientoBE ObtenerMovimientoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlMovimientoBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlMovimientoBEObtener = "uspMovimientoObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlMovimientoBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodMovimiento";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                MovimientoBE obj;
                obj = new MovimientoBE();

                if (dr.Read())
                {
    			    obj.CodMovimiento = dr.GetInt32(dr.GetOrdinal("CodMovimiento"));
	    	        obj.CodTipoMovimiento = dr.GetInt32(dr.GetOrdinal("CodTipoMovimiento"));
		            obj.CodAerolinea = dr.GetInt32(dr.GetOrdinal("CodAerolinea"));
		            obj.CodAvion = dr.GetInt32(dr.GetOrdinal("CodAvion"));
		            obj.Detalle = dr.GetString(dr.GetOrdinal("Detalle"));
    		        obj.CodAeropuertoOrigen = dr.GetInt32(dr.GetOrdinal("CodAeropuertoOrigen"));
	    	        obj.CodAeropuertoDestino = dr.GetInt32(dr.GetOrdinal("CodAeropuertoDestino"));
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

        public override void EliminarMovimientoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlMovimientoBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlMovimientoBEEliminar = "uspMovimientoEliminar";
                cmd = new SqlCommand(sqlMovimientoBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@CodMovimiento";
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

        public override List<MovimientoBE> ListarMovimientoBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlMovimientoBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlMovimientoBEListar = "uspMovimientoListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlMovimientoBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<MovimientoBE> lst;
                lst = new List<MovimientoBE>();

                MovimientoBE obj;

                while (dr.Read())
                {
                    obj = new MovimientoBE();
                    obj.CodMovimiento = dr.GetInt32(dr.GetOrdinal("CodMovimiento"));
                    obj.CodTipoMovimiento = dr.GetInt32(dr.GetOrdinal("CodTipoMovimiento"));
                    obj.CodAerolinea = dr.GetInt32(dr.GetOrdinal("CodAerolinea"));
                    obj.CodAvion = dr.GetInt32(dr.GetOrdinal("CodAvion"));
                    obj.Detalle = dr.GetString(dr.GetOrdinal("Detalle"));
                    obj.CodAeropuertoOrigen = dr.GetInt32(dr.GetOrdinal("CodAeropuertoOrigen"));
                    obj.CodAeropuertoDestino = dr.GetInt32(dr.GetOrdinal("CodAeropuertoDestino"));
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

        public override void ActualizarMovimientoBE(MovimientoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlMovimientoBEActualizar;

    		SqlParameter id;
	        SqlParameter codTipoMovimiento;
	        SqlParameter codAerolinea;
	        SqlParameter codAvion;
	        SqlParameter detalle;
	    	SqlParameter codAeropuertoOrigen;
		    SqlParameter codAeropuertoDestino;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlMovimientoBEActualizar = "uspMovimientoActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlMovimientoBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodMovimiento";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodMovimiento;

		        codTipoMovimiento = cmd.CreateParameter();
                codTipoMovimiento.ParameterName = "@CodTipoMovimiento";
                codTipoMovimiento.SqlDbType = SqlDbType.Int;
                codTipoMovimiento.SqlValue = obj.CodTipoMovimiento;

                codAerolinea = cmd.CreateParameter();
                codAerolinea.ParameterName = "@CodAerolinea";
                codAerolinea.SqlDbType = SqlDbType.Int;
                codAerolinea.SqlValue = obj.CodAerolinea;

                codAvion = cmd.CreateParameter();
                codAvion.ParameterName = "@CodAvion";
                codAvion.SqlDbType = SqlDbType.Int;
                codAvion.SqlValue = obj.CodAvion;

                detalle = cmd.CreateParameter();
                detalle.ParameterName = "@Detalle";
                detalle.SqlDbType = SqlDbType.VarChar;
                detalle.Size = 500;
                detalle.SqlValue = obj.Detalle;

		        codAeropuertoOrigen = cmd.CreateParameter();
                codAeropuertoOrigen.ParameterName = "@CodAeropuertoOrigen";
                codAeropuertoOrigen.SqlDbType = SqlDbType.Int;
                codAeropuertoOrigen.SqlValue = obj.CodAeropuertoOrigen;

		        codAeropuertoDestino = cmd.CreateParameter();
                codAeropuertoDestino.ParameterName = "@CodAeropuertoDestino";
                codAeropuertoDestino.SqlDbType = SqlDbType.Int;
        		codAeropuertoDestino.SqlValue = obj.CodAeropuertoDestino;
    
        		cmd.Parameters.Add(id);
	            cmd.Parameters.Add(codTipoMovimiento);
	            cmd.Parameters.Add(codAerolinea);
	            cmd.Parameters.Add(codAvion);
    	        cmd.Parameters.Add(detalle);
	        	cmd.Parameters.Add(codAeropuertoOrigen);
		        cmd.Parameters.Add(codAeropuertoDestino);

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
