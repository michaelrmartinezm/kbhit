using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlPlanVueloDALC:PlanVueloDALC
    {
	    public override int InsertarPlanVueloBE(PlanDeVueloBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

	        SqlParameter codPlanVuelo;
            SqlParameter codAerolinea;
            SqlParameter destinatario;
            SqlParameter remitente;
            SqlParameter presentador;
            SqlParameter requisitos;
            SqlParameter prioridad;
            //SqlParameter hora;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspPlanVueloInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codPlanVuelo = cmd.CreateParameter();
                codPlanVuelo.Direction = ParameterDirection.ReturnValue;
                codPlanVuelo.SqlDbType = SqlDbType.Int;

                codAerolinea = cmd.CreateParameter();
                codAerolinea.ParameterName = "@CodAerolinea";
                codAerolinea.SqlDbType = SqlDbType.Int;
                codAerolinea.SqlValue = obj.CodAerolinea;

                destinatario = cmd.CreateParameter();
                destinatario.ParameterName = "@Destinatario";
                destinatario.SqlDbType = SqlDbType.VarChar;
                destinatario.Size = 1000;
                destinatario.SqlValue = obj.Destinatario;

                remitente = cmd.CreateParameter();
                remitente.ParameterName = "@Remitente";
                remitente.SqlDbType = SqlDbType.VarChar;
                remitente.Size = 500;
                remitente.SqlValue = obj.Remitente;

                presentador = cmd.CreateParameter();
                presentador.ParameterName = "@Presentador";
                presentador.SqlDbType = SqlDbType.VarChar;
                presentador.Size = 500;
                presentador.SqlValue = obj.Presentador;

                requisitos = cmd.CreateParameter();
                requisitos.ParameterName = "@Requisitos";
                requisitos.SqlDbType = SqlDbType.VarChar;
                requisitos.Size = 1000;
                requisitos.SqlValue = obj.Requisitos;

                prioridad = cmd.CreateParameter();
                prioridad.ParameterName = "@Prioridad";
                prioridad.SqlDbType = SqlDbType.VarChar;
                prioridad.Size = 50;
                prioridad.SqlValue = obj.Prioridad;

        		cmd.Parameters.Add(codPlanVuelo);
	            cmd.Parameters.Add(codAerolinea);
	            cmd.Parameters.Add(destinatario);
	            cmd.Parameters.Add(remitente);
    	        cmd.Parameters.Add(presentador);
	            cmd.Parameters.Add(requisitos);
	            cmd.Parameters.Add(prioridad);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codPlanVuelo.Value);

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

        public override PlanDeVueloBE ObtenerPlanVueloBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlanVueloBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPlanVueloBEObtener = "uspPlanVueloObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPlanVueloBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodPlanVuelo";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                PlanDeVueloBE obj;
                obj = new PlanDeVueloBE();

                if (dr.Read())
                {
        			obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
	    	        obj.CodAerolinea = dr.GetInt32(dr.GetOrdinal("CodAerolinea"));
		            obj.Destinatario = dr.GetString(dr.GetOrdinal("Destinatario"));
		            obj.Remitente = dr.GetString(dr.GetOrdinal("Remitente"));
		            obj.Presentador = dr.GetString(dr.GetOrdinal("Presentador"));
    		        obj.Requisitos = dr.GetString(dr.GetOrdinal("Requesitos"));
	    	        obj.Prioridad = dr.GetString(dr.GetOrdinal("Prioridad"));
		            obj.Hora = dr.GetDateTime(dr.GetOrdinal("Hora"));
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

        public override void EliminarPlanVueloBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlanVueloBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPlanVueloBEEliminar = "uspPlanVueloEliminar";
                cmd = new SqlCommand(sqlPlanVueloBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@CodPlanVuelo";
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

        public override List<PlanDeVueloBE> ListarPlanVueloBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlanVueloBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlPlanVueloBEListar = "uspPlanVueloListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPlanVueloBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<PlanDeVueloBE> lst;
                lst = new List<PlanDeVueloBE>();

                PlanDeVueloBE obj;

                while (dr.Read())
                {
                    obj = new PlanDeVueloBE();
                    obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
                    obj.CodAerolinea = dr.GetInt32(dr.GetOrdinal("CodAerolinea"));
                    obj.Destinatario = dr.GetString(dr.GetOrdinal("Destinatario"));
                    obj.Remitente = dr.GetString(dr.GetOrdinal("Remitente"));
                    obj.Presentador = dr.GetString(dr.GetOrdinal("Presentador"));
                    obj.Requisitos = dr.GetString(dr.GetOrdinal("Requesitos"));
                    obj.Prioridad = dr.GetString(dr.GetOrdinal("Prioridad"));
                    obj.Hora = dr.GetDateTime(dr.GetOrdinal("Hora"));
                    
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

        public override void ActualizarPlanVueloBE(PlanDeVueloBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlanVueloBEActualizar;

		    SqlParameter id; //codPlanVuelo
	        SqlParameter codAerolinea;
	        SqlParameter destinatario;
	        SqlParameter remitente;
	        SqlParameter presentador;
	        SqlParameter requisitos;
	        SqlParameter prioridad;
	        //SqlParameter hora;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPlanVueloBEActualizar = "uspPlanVueloActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPlanVueloBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodPlanVuelo";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodPlanVuelo;

		        codAerolinea = cmd.CreateParameter();
                codAerolinea.ParameterName = "@CodAerolinea";
                codAerolinea.SqlDbType = SqlDbType.Int;
                codAerolinea.SqlValue = obj.CodAerolinea;

                destinatario = cmd.CreateParameter();
                destinatario.ParameterName = "@Destinatario";
                destinatario.SqlDbType = SqlDbType.VarChar;
                destinatario.Size = 1000;
                destinatario.SqlValue = obj.Destinatario;

                remitente = cmd.CreateParameter();
                remitente.ParameterName = "@Remitente";
                remitente.SqlDbType = SqlDbType.VarChar;
                remitente.Size = 500;
                remitente.SqlValue = obj.Remitente;

                presentador = cmd.CreateParameter();
                presentador.ParameterName = "@Presentador";
                presentador.SqlDbType = SqlDbType.VarChar;
                presentador.Size = 500;
                presentador.SqlValue = obj.Presentador;

                requisitos = cmd.CreateParameter();
                requisitos.ParameterName = "@Requisitos";
                requisitos.SqlDbType = SqlDbType.VarChar;
                requisitos.Size = 1000;
                requisitos.SqlValue = obj.Requisitos;

                prioridad = cmd.CreateParameter();
                prioridad.ParameterName = "@Prioridad";
                prioridad.SqlDbType = SqlDbType.VarChar;
                prioridad.Size = 50;
                prioridad.SqlValue = obj.Prioridad;

    		    cmd.Parameters.Add(id);
	            cmd.Parameters.Add(codAerolinea);
	            cmd.Parameters.Add(destinatario);
	            cmd.Parameters.Add(remitente);
    	        cmd.Parameters.Add(presentador);
	            cmd.Parameters.Add(requisitos);
	            cmd.Parameters.Add(prioridad);

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
