using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlAeropuertoDALC:AeropuertoDALC
    {
        public override int InsertarAeropuertoBE(AeropuertoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

            SqlParameter codAeropuerto;
            SqlParameter estado;
            SqlParameter ciudad;
            SqlParameter iata;
            SqlParameter oaci;
            SqlParameter elevacion;
            SqlParameter sei;
            SqlParameter fuel;
            SqlParameter operacion;
            SqlParameter nombre;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspAeropuertoInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codAeropuerto = cmd.CreateParameter();
                codAeropuerto.Direction = ParameterDirection.ReturnValue;
                codAeropuerto.SqlDbType = SqlDbType.Int;

                nombre = cmd.CreateParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 500;
                nombre.SqlValue = obj.Nombre;

                estado = cmd.CreateParameter();
                estado.ParameterName = "@Estado";
                estado.SqlDbType = SqlDbType.VarChar;
                estado.Size = 50;
                estado.SqlValue = obj.Estado;

                ciudad = cmd.CreateParameter();
                ciudad.ParameterName = "@Ciudad";
                ciudad.SqlDbType = SqlDbType.VarChar;
                ciudad.Size = 50;
                ciudad.SqlValue = obj.Ciudad;

                iata = cmd.CreateParameter();
                iata.ParameterName = "@IATA";
                iata.SqlDbType = SqlDbType.VarChar;
                iata.Size = 50;
                iata.SqlValue = obj.Iata;

                oaci = cmd.CreateParameter();
                oaci.ParameterName = "@OACI";
                oaci.SqlDbType = SqlDbType.VarChar;
                oaci.Size = 4;
                oaci.SqlValue = obj.Oaci;

                elevacion = cmd.CreateParameter();
                elevacion.ParameterName = "@Elevacion";
                elevacion.SqlDbType = SqlDbType.Int;
                elevacion.SqlValue = obj.Elevacion;

                sei = cmd.CreateParameter();
                sei.ParameterName = "@SEI";
                sei.SqlDbType = SqlDbType.Int;
                sei.SqlValue = obj.Sei;

                fuel = cmd.CreateParameter();
                fuel.ParameterName = "@Fuel";
                fuel.SqlDbType = SqlDbType.Int;
                fuel.SqlValue = obj.Fuel;

                operacion = cmd.CreateParameter();
                operacion.ParameterName = "@Operacion";
                operacion.SqlDbType = SqlDbType.VarChar;
                operacion.Size = 1000;
                operacion.SqlValue = obj.Operacion;

                cmd.Parameters.Add(estado);
                cmd.Parameters.Add(ciudad);
                cmd.Parameters.Add(iata);
                cmd.Parameters.Add(oaci);
                cmd.Parameters.Add(elevacion);
                cmd.Parameters.Add(sei);
                cmd.Parameters.Add(fuel);
                cmd.Parameters.Add(operacion);
                cmd.Parameters.Add(nombre);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codAeropuerto.Value);

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

        public override AeropuertoBE ObtenerAeropuertoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAeropuertoBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAeropuertoBEObtener = "uspAeropuertoObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAeropuertoBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodAeropuerto";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                AeropuertoBE obj;
                obj = new AeropuertoBE();

                if (dr.Read())
                {
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Estado = dr.GetString(dr.GetOrdinal("Estado"));
    		        obj.Ciudad = dr.GetString(dr.GetOrdinal("Ciudad"));
	    	        obj.Iata = dr.GetString(dr.GetOrdinal("Iata"));
    	    	    obj.Oaci = dr.GetString(dr.GetOrdinal("Oaci"));
    		        obj.Elevacion = dr.GetInt32(dr.GetOrdinal("Elevacion"));
	    	        obj.Sei = dr.GetInt32(dr.GetOrdinal("Sei"));
    		        obj.Fuel = dr.GetInt32(dr.GetOrdinal("Fuel"));
	    	        obj.Operacion = dr.GetString(dr.GetOrdinal("Operacion"));
		            obj.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    obj.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
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

        public override void EliminarAeropuertoBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAeropuertoBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAeropuertoBEEliminar = "uspAeropuertoEliminar";
                cmd = new SqlCommand(sqlAeropuertoBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@CodAeropuerto";
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

        public override List<AeropuertoBE> ListarAeropuertoBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAeropuertoBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlAeropuertoBEListar = "uspAeropuertoListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAeropuertoBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<AeropuertoBE> lst;
                lst = new List<AeropuertoBE>();

                AeropuertoBE obj;

                while (dr.Read())
                {
                    obj = new AeropuertoBE();
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Estado = dr.GetString(dr.GetOrdinal("Estado"));
                    obj.Ciudad = dr.GetString(dr.GetOrdinal("Ciudad"));
                    obj.Iata = dr.GetString(dr.GetOrdinal("Iata"));
                    obj.Oaci = dr.GetString(dr.GetOrdinal("Oaci"));
                    obj.Elevacion = dr.GetInt32(dr.GetOrdinal("Elevacion"));
                    obj.Sei = dr.GetInt32(dr.GetOrdinal("Sei"));
                    obj.Fuel = dr.GetInt32(dr.GetOrdinal("Fuel"));
                    obj.Operacion = dr.GetString(dr.GetOrdinal("Operacion"));
                    obj.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    obj.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
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

        public override void ActualizarAeropuertoBE(AeropuertoBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAeropuertoBEActualizar;

            SqlParameter id;
            SqlParameter estado;
            SqlParameter ciudad;
            SqlParameter iata;
            SqlParameter oaci;
            SqlParameter elevacion;
            SqlParameter sei;
            SqlParameter fuel;
            SqlParameter operacion;
            SqlParameter fecha;
            SqlParameter nombre;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAeropuertoBEActualizar = "uspAeropuertoActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAeropuertoBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@Id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodAeropuerto;

                nombre = cmd.CreateParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 500;
                nombre.SqlValue = obj.Nombre;

                estado = cmd.CreateParameter();
                estado.ParameterName = "@Estado";
                estado.SqlDbType = SqlDbType.VarChar;
                estado.Size = 50;
                estado.SqlValue = obj.Estado;

                ciudad = cmd.CreateParameter();
                ciudad.ParameterName = "@Ciudad";
                ciudad.SqlDbType = SqlDbType.VarChar;
                ciudad.Size = 50;
                ciudad.SqlValue = obj.Ciudad;

                iata = cmd.CreateParameter();
                iata.ParameterName = "@IATA";
                iata.SqlDbType = SqlDbType.VarChar;
                iata.Size = 50;
                iata.SqlValue = obj.Iata;

                oaci = cmd.CreateParameter();
                oaci.ParameterName = "@OASI";
                oaci.SqlDbType = SqlDbType.VarChar;
                oaci.Size = 50;
                oaci.SqlValue = obj.Oaci;

                elevacion = cmd.CreateParameter();
                elevacion.ParameterName = "@Elevacion";
                elevacion.SqlDbType = SqlDbType.VarChar;
                elevacion.Size = 50;
                elevacion.SqlValue = obj.Elevacion;

                sei = cmd.CreateParameter();
                sei.ParameterName = "@SEI";
                sei.SqlDbType = SqlDbType.VarChar;
                sei.Size = 50;
                sei.SqlValue = obj.Sei;

                fuel = cmd.CreateParameter();
                fuel.ParameterName = "@Fuel";
                fuel.SqlDbType = SqlDbType.VarChar;
                fuel.Size = 50;
                fuel.SqlValue = obj.Fuel;

                operacion = cmd.CreateParameter();
                operacion.ParameterName = "@Operacion";
                operacion.SqlDbType = SqlDbType.VarChar;
                operacion.Size = 50;
                operacion.SqlValue = obj.Operacion;

                cmd.Parameters.Add(id);
                cmd.Parameters.Add(estado);
                cmd.Parameters.Add(ciudad);
                cmd.Parameters.Add(iata);
                cmd.Parameters.Add(oaci);
                cmd.Parameters.Add(elevacion);
                cmd.Parameters.Add(sei);
                cmd.Parameters.Add(fuel);
                cmd.Parameters.Add(operacion);
                cmd.Parameters.Add(nombre);

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

        public override AeropuertoBE ObtenerAeropuertoBENombre(String nombre)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAeropuertoBEObtenerNombre;

            SqlParameter _nombre;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAeropuertoBEObtenerNombre = "uspAeropuertoObtenerNombre";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAeropuertoBEObtenerNombre;
                cmd.CommandType = CommandType.StoredProcedure;

                _nombre = cmd.CreateParameter();
                _nombre.ParameterName = "@Nombre";
                _nombre.SqlDbType = SqlDbType.VarChar;
                _nombre.Size = 500;
                _nombre.SqlValue = nombre;

                cmd.Parameters.Add(_nombre);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                AeropuertoBE obj;
                obj = new AeropuertoBE();

                if (dr.Read())
                {
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Estado = dr.GetString(dr.GetOrdinal("Estado"));
                    obj.Ciudad = dr.GetString(dr.GetOrdinal("Ciudad"));
                    obj.Iata = dr.GetString(dr.GetOrdinal("Iata"));
                    obj.Oaci = dr.GetString(dr.GetOrdinal("Oaci"));
                    obj.Elevacion = dr.GetInt32(dr.GetOrdinal("Elevacion"));
                    obj.Sei = dr.GetInt32(dr.GetOrdinal("Sei"));
                    obj.Fuel = dr.GetInt32(dr.GetOrdinal("Fuel"));
                    obj.Operacion = dr.GetString(dr.GetOrdinal("Operacion"));
                    obj.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    obj.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
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
    }
}