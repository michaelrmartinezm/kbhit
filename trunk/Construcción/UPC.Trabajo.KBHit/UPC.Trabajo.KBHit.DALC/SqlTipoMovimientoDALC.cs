using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlTipoMovimientoDALC:TipoMovimientoDALC
    {
    	public override int InsertarTipoMovimientoBE(TipoMovimientoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

	        SqlParameter codTipoMovimiento;
            SqlParameter descripcion;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspTipoMovimientoInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codTipoMovimiento = cmd.CreateParameter();
                codTipoMovimiento.Direction = ParameterDirection.ReturnValue;
                codTipoMovimiento.SqlDbType = SqlDbType.Int;

                descripcion = cmd.CreateParameter();
                descripcion.ParameterName = "@Descripcion";
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 1000;
                descripcion.SqlValue = obj.Descripcion;

		        cmd.Parameters.Add(codTipoMovimiento);
	            cmd.Parameters.Add(descripcion);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codTipoMovimiento.Value);

                cmd.Connection.Close();

                cmd.Dispose();
                Conn.Dispose();

                return iCod;
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                Conn.Dispose();
                throw;
            }
        }

        public override TipoMovimientoBE ObtenerTipoMovimientoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoMovimientoBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTipoMovimientoBEObtener = "uspTipoMovimientoObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTipoMovimientoBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodTipoMovimiento";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                TipoMovimientoBE obj;
                obj = new TipoMovimientoBE();

                if (dr.Read())
                {
			        obj.CodTipoMovimiento = dr.GetInt32(dr.GetOrdinal("CodTipoMovimiento"));
		            obj.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
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
                throw;
            }
        }

        public override void EliminarTipoMovimientoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoMovimientoBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTipoMovimientoBEEliminar = "uspTipoMovimientoEliminar";
                cmd = new SqlCommand(sqlTipoMovimientoBEEliminar, Conn);

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
                throw;
            }
        }

        public override List<TipoMovimientoBE> ListarTipoMovimientoBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoMovimientoBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlTipoMovimientoBEListar = "uspTipoMovimientoListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTipoMovimientoBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<TipoMovimientoBE> lst;
                lst = new List<TipoMovimientoBE>();

                TipoMovimientoBE obj;

                while (dr.Read())
                {
                    obj = new TipoMovimientoBE();
			        obj.CodTipoMovimiento = dr.GetInt32(dr.GetOrdinal("CodTipoMovimiento"));
    		        obj.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    
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
                throw;
            }
        }

        public override void ActualizarTipoMovimientoBE(TipoMovimientoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTipoMovimientoBEActualizar;

		    SqlParameter id;
	        SqlParameter descripcion;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTipoMovimientoBEActualizar = "uspTipoMovimientoActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTipoMovimientoBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodTipoMovimiento";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodTipoMovimiento;

                descripcion = cmd.CreateParameter();
                descripcion.ParameterName = "@Descripcion";
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 1000;
                descripcion.SqlValue = obj.Descripcion;

        		cmd.Parameters.Add(id);
	            cmd.Parameters.Add(descripcion);

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
                throw;
            }
        }
    }
}
