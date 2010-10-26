using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlSalidaDALC:SalidaDALC
    {
	    public override int InsertarSalidaBE(SalidaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

            SqlParameter codSalida;
            SqlParameter codPlanVuelo;
            SqlParameter numero;
            SqlParameter placa;
            SqlParameter reglaVuelo;
            SqlParameter tipoVuelo;
            SqlParameter codAvion;
            SqlParameter codAeropuerto;
            SqlParameter turbulencia;
            SqlParameter equipo;
            SqlParameter velocidad;
            SqlParameter nivel;
            SqlParameter ruta;
            
            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspSalidaInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codSalida = cmd.CreateParameter();
                codSalida.Direction = ParameterDirection.ReturnValue;
                codSalida.SqlDbType = SqlDbType.Int;

                codPlanVuelo = cmd.CreateParameter();
                codPlanVuelo.ParameterName = "@CodPlanVuelo";
                codPlanVuelo.SqlDbType = SqlDbType.Int;
                codPlanVuelo.SqlValue = obj.CodPlanVuelo;

                numero = cmd.CreateParameter();
                numero.ParameterName = "@Numero";
                numero.SqlDbType = SqlDbType.Int;
                numero.SqlValue = obj.Numero;

                placa = cmd.CreateParameter();
                placa.ParameterName = "@Placa";
                placa.SqlDbType = SqlDbType.VarChar;
                placa.Size = 50;
                placa.SqlValue = obj.Placa;

                reglaVuelo = cmd.CreateParameter();
                reglaVuelo.ParameterName = "@ReglaVuelo";
                reglaVuelo.SqlDbType = SqlDbType.VarChar;
                reglaVuelo.Size = 1;
                reglaVuelo.SqlValue = obj.ReglaVuelo;

                tipoVuelo = cmd.CreateParameter();
                tipoVuelo.ParameterName = "@TipoVuelo";
                tipoVuelo.SqlDbType = SqlDbType.VarChar;
                tipoVuelo.Size = 1;
                tipoVuelo.SqlValue = obj.TipoVuelo;

                codAvion = cmd.CreateParameter();
                codAvion.ParameterName = "@CodAvion";
                codAvion.SqlDbType = SqlDbType.Int;
                codAvion.SqlValue = obj.CodAvion;

                codAeropuerto = cmd.CreateParameter();
                codAeropuerto.ParameterName = "@CodAeropuerto";
                codAeropuerto.SqlDbType = SqlDbType.Int;
                codAeropuerto.SqlValue = obj.CodAeropuerto;

                turbulencia = cmd.CreateParameter();
                turbulencia.ParameterName = "@Turbulencia";
                turbulencia.SqlDbType = SqlDbType.VarChar;
                turbulencia.Size = 1;
                turbulencia.SqlValue = obj.Turbulencia;

                equipo = cmd.CreateParameter();
                equipo.ParameterName = "@Equipo";
                equipo.SqlDbType = SqlDbType.VarChar;
                equipo.Size = 50;
                equipo.SqlValue = obj.Equipo;

                velocidad = cmd.CreateParameter();
                velocidad.ParameterName = "@Velocidad";
                velocidad.SqlDbType = SqlDbType.Float;
                velocidad.SqlValue = obj.Velocidad;

                nivel = cmd.CreateParameter();
                nivel.ParameterName = "@Nivel";
                nivel.SqlDbType = SqlDbType.Float;
                nivel.SqlValue = obj.Nivel;

                ruta = cmd.CreateParameter();
                ruta.ParameterName = "@Ruta";
                ruta.SqlDbType = SqlDbType.VarChar;
                ruta.Size = 8000;
                ruta.SqlValue = obj.Ruta;

                cmd.Parameters.Add(codSalida);
                cmd.Parameters.Add(codPlanVuelo);
                cmd.Parameters.Add(numero);
                cmd.Parameters.Add(placa);
                cmd.Parameters.Add(reglaVuelo);
                cmd.Parameters.Add(tipoVuelo);
                cmd.Parameters.Add(codAvion);
                cmd.Parameters.Add(codAeropuerto);
                cmd.Parameters.Add(turbulencia);
                cmd.Parameters.Add(equipo);
                cmd.Parameters.Add(velocidad);
                cmd.Parameters.Add(nivel);
                cmd.Parameters.Add(ruta);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codSalida.Value);

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

        public override SalidaBE ObtenerSalidaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlSalidaBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlSalidaBEObtener = "uspSalidaBEObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlSalidaBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodSalida";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                SalidaBE obj;
                obj = new SalidaBE();

                if (dr.Read())
                {
                    obj.CodSalida = dr.GetInt32(dr.GetOrdinal("CodSalida"));
                    obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
                    obj.Numero = dr.GetInt32(dr.GetOrdinal("Numero"));
                    obj.Placa = dr.GetString(dr.GetOrdinal("Placa"));
                    obj.ReglaVuelo = dr.GetString(dr.GetOrdinal("ReglaVuelo"));
                    obj.TipoVuelo = dr.GetString(dr.GetOrdinal("TipoVuelo"));
                    obj.CodAvion = dr.GetInt32(dr.GetOrdinal("CodAvion"));
                    obj.Hora = dr.GetDateTime(dr.GetOrdinal("Hora"));
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Turbulencia = dr.GetString(dr.GetOrdinal("Turbuencia"));
                    obj.Equipo = dr.GetString(dr.GetOrdinal("Equipo"));
                    obj.Velocidad = dr.GetInt32(dr.GetOrdinal("Velocidad"));
                    obj.Nivel = dr.GetInt32(dr.GetOrdinal("Nivel"));
                    obj.Ruta = dr.GetString(dr.GetOrdinal("Ruta"));
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

        public override void EliminarSalidaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlSalidaBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlSalidaBEEliminar = "uspSalidaEliminar";
                cmd = new SqlCommand(sqlSalidaBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@CodSalida";
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

        public override List<SalidaBE> ListarSalidaBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlSalidaBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlSalidaBEListar = "uspSalidaListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlSalidaBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<SalidaBE> lst;
                lst = new List<SalidaBE>();

                SalidaBE obj;

                while (dr.Read())
                {
                    obj = new SalidaBE();
                    obj.CodSalida = dr.GetInt32(dr.GetOrdinal("CodSalida"));
                    obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
                    obj.Numero = dr.GetInt32(dr.GetOrdinal("Numero"));
                    obj.Placa = dr.GetString(dr.GetOrdinal("Placa"));
                    obj.ReglaVuelo = dr.GetString(dr.GetOrdinal("ReglaVuelo"));
                    obj.TipoVuelo = dr.GetString(dr.GetOrdinal("TipoVuelo"));
                    obj.CodAvion = dr.GetInt32(dr.GetOrdinal("CodAvion"));
                    obj.Hora = dr.GetDateTime(dr.GetOrdinal("Hora"));
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Turbulencia = dr.GetString(dr.GetOrdinal("Turbuencia"));
                    obj.Equipo = dr.GetString(dr.GetOrdinal("Equipo"));
                    obj.Velocidad = dr.GetInt32(dr.GetOrdinal("Velocidad"));
                    obj.Nivel = dr.GetInt32(dr.GetOrdinal("Nivel"));
                    obj.Ruta = dr.GetString(dr.GetOrdinal("Ruta"));
                    
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

        public override void ActualizarSalidaBE(SalidaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlSalidaBEActualizar;

        SqlParameter id;//codSalida
        SqlParameter codPlanVuelo;
        SqlParameter numero;
        SqlParameter placa;
        SqlParameter reglaVuelo;
        SqlParameter tipoVuelo;
        SqlParameter codAvion;
        //SqlParameter hora;
        SqlParameter codAeropuerto;
        SqlParameter turbulencia;
        SqlParameter equipo;
        SqlParameter velocidad;
        SqlParameter nivel;
        SqlParameter ruta;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlSalidaBEActualizar = "uspSalidaActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlSalidaBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodSalida";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodSalida;

		        codPlanVuelo = cmd.CreateParameter();
                codPlanVuelo.ParameterName = "@CodPlanVuelo";
                codPlanVuelo.SqlDbType = SqlDbType.Int;
                codPlanVuelo.SqlValue = obj.CodPlanVuelo;

                numero = cmd.CreateParameter();
                numero.ParameterName = "@Numero";
                numero.SqlDbType = SqlDbType.Int;
                numero.SqlValue = obj.Numero;

                placa = cmd.CreateParameter();
                placa.ParameterName = "@Placa";
                placa.SqlDbType = SqlDbType.VarChar;
                placa.Size = 50;
                placa.SqlValue = obj.Placa;

                reglaVuelo = cmd.CreateParameter();
                reglaVuelo.ParameterName = "@ReglaVuelo";
                reglaVuelo.SqlDbType = SqlDbType.VarChar;
                reglaVuelo.Size = 1;
                reglaVuelo.SqlValue = obj.ReglaVuelo;

                tipoVuelo = cmd.CreateParameter();
                tipoVuelo.ParameterName = "@TipoVuelo";
                tipoVuelo.SqlDbType = SqlDbType.VarChar;
                tipoVuelo.Size = 1;
                tipoVuelo.SqlValue = obj.TipoVuelo;

                codAvion = cmd.CreateParameter();
                codAvion.ParameterName = "@CodAvion";
                codAvion.SqlDbType = SqlDbType.Int;
                codAvion.SqlValue = obj.CodAvion;

                codAeropuerto = cmd.CreateParameter();
                codAeropuerto.ParameterName = "@CodAeropuerto";
                codAeropuerto.SqlDbType = SqlDbType.Int;
                codAeropuerto.SqlValue = obj.CodAeropuerto;

                turbulencia = cmd.CreateParameter();
                turbulencia.ParameterName = "@Turbulencia";
                turbulencia.SqlDbType = SqlDbType.VarChar;
                turbulencia.Size = 1;
                turbulencia.SqlValue = obj.Turbulencia;

                equipo = cmd.CreateParameter();
                equipo.ParameterName = "@Equipo";
                equipo.SqlDbType = SqlDbType.VarChar;
                equipo.Size = 50;
                equipo.SqlValue = obj.Equipo;

                velocidad = cmd.CreateParameter();
                velocidad.ParameterName = "@Velocidad";
                velocidad.SqlDbType = SqlDbType.Float;
                velocidad.SqlValue = obj.Velocidad;

                nivel = cmd.CreateParameter();
                nivel.ParameterName = "@Nivel";
                nivel.SqlDbType = SqlDbType.Float;
                nivel.SqlValue = obj.Nivel;

                ruta = cmd.CreateParameter();
                ruta.ParameterName = "@Ruta";
                ruta.SqlDbType = SqlDbType.VarChar;
                ruta.Size = 8000;
                ruta.SqlValue = obj.Ruta;

        cmd.Parameters.Add(id);
        cmd.Parameters.Add(codPlanVuelo);
        cmd.Parameters.Add(numero);
        cmd.Parameters.Add(placa);
        cmd.Parameters.Add(reglaVuelo);
        cmd.Parameters.Add(tipoVuelo);
        cmd.Parameters.Add(codAvion);
        cmd.Parameters.Add(codAeropuerto);
        cmd.Parameters.Add(turbulencia);
        cmd.Parameters.Add(equipo);
        cmd.Parameters.Add(velocidad);
        cmd.Parameters.Add(nivel);
        cmd.Parameters.Add(ruta);

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
