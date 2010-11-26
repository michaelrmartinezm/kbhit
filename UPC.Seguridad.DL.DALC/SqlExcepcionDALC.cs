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
    public class SqlExcepcionDALC:ExcepcionDALC
    {
        public override int ExcepcionInsertar(ExcepcionBE objExcepcionBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdExcepcionInsertar = null;
            String sCadena;
            String sqlExcepcionInsertar;
            SqlParameter prmIdExcepcion;
            SqlParameter prmMensaje;
            SqlParameter prmStackTrace;
            SqlParameter prmFechaCliente;
            SqlParameter prmIPCliente;
            SqlParameter prmUsuario;
            int idExcepcion;

            try
            {
                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;

                sqlExcepcionInsertar = "uspExcepcionInsertar";
                Conn = new SqlConnection(sCadena);

                cmdExcepcionInsertar = Conn.CreateCommand();
                cmdExcepcionInsertar.CommandType = CommandType.StoredProcedure;
                cmdExcepcionInsertar.CommandText = sqlExcepcionInsertar;

                prmIdExcepcion = cmdExcepcionInsertar.CreateParameter();
                prmIdExcepcion.SqlDbType = SqlDbType.Int;
                prmIdExcepcion.Direction = ParameterDirection.ReturnValue;

                prmMensaje = cmdExcepcionInsertar.CreateParameter();
                prmMensaje.ParameterName = "@Mensaje";
                prmMensaje.SqlDbType = SqlDbType.VarChar;
                prmMensaje.Size = 8000;
                prmMensaje.Value = objExcepcionBE.Mensaje;

                prmStackTrace = cmdExcepcionInsertar.CreateParameter();
                prmStackTrace.ParameterName = "@StackTrace";
                prmStackTrace.SqlDbType = SqlDbType.VarChar;
                prmStackTrace.Size = 8000;
                prmStackTrace.Value = objExcepcionBE.StackTrace;

                prmFechaCliente = cmdExcepcionInsertar.CreateParameter();
                prmFechaCliente.ParameterName = "@FechaCliente";
                prmFechaCliente.SqlDbType = SqlDbType.DateTime;
                prmFechaCliente.Value = objExcepcionBE.FechaCliente;

                prmIPCliente = cmdExcepcionInsertar.CreateParameter();
                prmIPCliente.ParameterName = "@IPCliente";
                prmIPCliente.SqlDbType = SqlDbType.VarChar;
                prmIPCliente.Size = 23;
                prmIPCliente.Value = objExcepcionBE.IPCliente;

                prmUsuario = cmdExcepcionInsertar.CreateParameter();
                prmUsuario.ParameterName = "@Usuario";
                prmUsuario.SqlDbType = SqlDbType.VarChar;
                prmUsuario.Size = 30;
                prmUsuario.Value = objExcepcionBE.Usuario;

                cmdExcepcionInsertar.Parameters.Add(prmIdExcepcion);
                cmdExcepcionInsertar.Parameters.Add(prmMensaje);
                cmdExcepcionInsertar.Parameters.Add(prmStackTrace);
                cmdExcepcionInsertar.Parameters.Add(prmFechaCliente);
                cmdExcepcionInsertar.Parameters.Add(prmIPCliente);
                cmdExcepcionInsertar.Parameters.Add(prmUsuario);

                cmdExcepcionInsertar.Connection.Open();
                cmdExcepcionInsertar.ExecuteNonQuery();
                idExcepcion = Convert.ToInt32(prmIdExcepcion.Value);
                cmdExcepcionInsertar.Connection.Close();

                cmdExcepcionInsertar.Dispose();
                Conn.Dispose();

                return idExcepcion;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }

        public override ExcepcionBE ExcepcionObtener(int IdExcepcion)
        {
            SqlConnection Conn = null;
            SqlCommand cmdExcepcionObtener = null;
            String sCadena;
            String sqlExcepcionObtener;
            SqlParameter prmIdExcepcion;
            SqlDataReader drExcepcion;

            try
            {
                ExcepcionBE objExcepcionBE = new ExcepcionBE();

                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;
                Conn = new SqlConnection(sCadena);

                sqlExcepcionObtener = "uspExcepcionObtener";
                cmdExcepcionObtener = Conn.CreateCommand();
                cmdExcepcionObtener.CommandText = sqlExcepcionObtener;
                cmdExcepcionObtener.CommandType = CommandType.StoredProcedure;

                prmIdExcepcion = cmdExcepcionObtener.CreateParameter();
                prmIdExcepcion.ParameterName = "@IdExcepcion";
                prmIdExcepcion.SqlDbType = SqlDbType.Int;
                prmIdExcepcion.Value = IdExcepcion;

                cmdExcepcionObtener.Parameters.Add(prmIdExcepcion);

                cmdExcepcionObtener.Connection.Open();
                drExcepcion = cmdExcepcionObtener.ExecuteReader();

                if (drExcepcion.Read())
                {
                    objExcepcionBE.StackTrace = drExcepcion.GetString(drExcepcion.GetOrdinal("StackTrace"));
                    objExcepcionBE.Usuario = drExcepcion.GetString(drExcepcion.GetOrdinal("Usuario"));
                    objExcepcionBE.Mensaje = drExcepcion.GetString(drExcepcion.GetOrdinal("Mensaje"));
                    objExcepcionBE.IPCliente = drExcepcion.GetString(drExcepcion.GetOrdinal("IPCliente"));
                    objExcepcionBE.FechaCliente = drExcepcion.GetDateTime(drExcepcion.GetOrdinal("FechaCliente"));
                    objExcepcionBE.FechaServidor = drExcepcion.GetDateTime(drExcepcion.GetOrdinal("FechaServidor"));
                   
                }

                cmdExcepcionObtener.Connection.Close();
                cmdExcepcionObtener.Dispose();

                Conn.Dispose();

                return objExcepcionBE;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }
        public override List<ExcepcionBE> ExcepcionListar() 
        {
            SqlConnection Conn = null;
            SqlCommand cmdExcepcionListar = null;
            String sCadena;
            String sqlExcepcionListar;
            SqlDataReader drExcepcion;

            try
            {
                List<ExcepcionBE> lsExcepcionBE = new List<ExcepcionBE>();

                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;
                Conn = new SqlConnection(sCadena);

                sqlExcepcionListar = "uspExcepcionListar";
                cmdExcepcionListar = Conn.CreateCommand();
                cmdExcepcionListar.CommandText = sqlExcepcionListar;
                cmdExcepcionListar.CommandType = CommandType.StoredProcedure;

                cmdExcepcionListar.Connection.Open();
                drExcepcion = cmdExcepcionListar.ExecuteReader();

                while (drExcepcion.Read())
                {
                    ExcepcionBE objExcepcionBE = new ExcepcionBE();
                    objExcepcionBE.IdExcepcion = drExcepcion.GetInt32(drExcepcion.GetOrdinal("IdExcepcion"));
                    objExcepcionBE.StackTrace = drExcepcion.GetString(drExcepcion.GetOrdinal("StackTrace"));
                    objExcepcionBE.Usuario = drExcepcion.GetString(drExcepcion.GetOrdinal("Usuario"));
                    objExcepcionBE.Mensaje = drExcepcion.GetString(drExcepcion.GetOrdinal("Mensaje"));
                    objExcepcionBE.IPCliente = drExcepcion.GetString(drExcepcion.GetOrdinal("IPCliente"));
                    objExcepcionBE.FechaCliente = drExcepcion.GetDateTime(drExcepcion.GetOrdinal("FechaCliente"));
                    objExcepcionBE.FechaServidor = drExcepcion.GetDateTime(drExcepcion.GetOrdinal("FechaServidor"));
                    lsExcepcionBE.Add(objExcepcionBE);
                }

                cmdExcepcionListar.Connection.Close();
                cmdExcepcionListar.Dispose();

                Conn.Dispose();

                return lsExcepcionBE;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }                
        
        }
        public override void ExcepcionActualizar(ExcepcionBE objExcepcionBE) 
        {
            SqlConnection Conn = null;
            SqlCommand cmdExcepcionActualizar = null;
            String sCadena;
            String sqlExcepcionActualizar;
            SqlParameter prmIdExcepcion;
            SqlParameter prmMensaje;
            SqlParameter prmStackTrace;
            SqlParameter prmFechaCliente;
            SqlParameter prmIPCliente;
            SqlParameter prmUsuario;

            try
            {
                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;
                Conn = new SqlConnection(sCadena);

                sqlExcepcionActualizar = "uspExcepcionActualizar";
                cmdExcepcionActualizar = Conn.CreateCommand();
                cmdExcepcionActualizar.CommandText = sqlExcepcionActualizar;
                cmdExcepcionActualizar.CommandType = CommandType.StoredProcedure;

                prmIdExcepcion = cmdExcepcionActualizar.CreateParameter();
                prmIdExcepcion.ParameterName = "@IdExcepcion";
                prmIdExcepcion.SqlDbType = SqlDbType.Int;
                prmIdExcepcion.Value = objExcepcionBE.IdExcepcion;

                prmMensaje = cmdExcepcionActualizar.CreateParameter();
                prmMensaje.ParameterName = "@Mensaje";
                prmMensaje.SqlDbType = SqlDbType.VarChar;
                prmMensaje.Size = 8000;
                prmMensaje.Value = objExcepcionBE.Mensaje;

                prmStackTrace = cmdExcepcionActualizar.CreateParameter();
                prmStackTrace.ParameterName = "@StackTrace";
                prmStackTrace.SqlDbType = SqlDbType.VarChar;
                prmStackTrace.Size = 8000;
                prmStackTrace.Value = objExcepcionBE.StackTrace;

                prmFechaCliente = cmdExcepcionActualizar.CreateParameter();
                prmFechaCliente.ParameterName = "@FechaCliente";
                prmFechaCliente.SqlDbType = SqlDbType.DateTime;
                prmFechaCliente.Value = objExcepcionBE.FechaCliente;

                prmIPCliente = cmdExcepcionActualizar.CreateParameter();
                prmIPCliente.ParameterName = "@IPCliente";
                prmIPCliente.SqlDbType = SqlDbType.VarChar;
                prmIPCliente.Size = 23;
                prmIPCliente.Value = objExcepcionBE.IPCliente;

                prmUsuario = cmdExcepcionActualizar.CreateParameter();
                prmUsuario.ParameterName = "@Usuario";
                prmUsuario.SqlDbType = SqlDbType.VarChar;
                prmUsuario.Size = 30;
                prmUsuario.Value = objExcepcionBE.Usuario;

                cmdExcepcionActualizar.Parameters.Add(prmIdExcepcion);
                cmdExcepcionActualizar.Parameters.Add(prmMensaje);
                cmdExcepcionActualizar.Parameters.Add(prmStackTrace);
                cmdExcepcionActualizar.Parameters.Add(prmFechaCliente);
                cmdExcepcionActualizar.Parameters.Add(prmIPCliente);
                cmdExcepcionActualizar.Parameters.Add(prmUsuario);
                cmdExcepcionActualizar.Connection.Open();
         
                cmdExcepcionActualizar.Connection.Close();
                cmdExcepcionActualizar.Dispose();

                Conn.Dispose();

            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        
        
        }
    }
}
