using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UPC.Seguridad.DL.DALC
{
    public class SqlUsuarioDALC: UsuarioDALC
    {
        public override int UsuarioInsertar(UsuarioBE objUsuarioBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmdUsuarioInsertar = null;
            String sqlUsuarioInsertar;
            SqlParameter prmIdUsuario;
            SqlParameter prmLogin;
            SqlParameter prmContrasenia;
            SqlParameter prmNombreUsuario;
            SqlParameter prmApellidoPaterno;
            SqlParameter prmApellidoMaterno;
            SqlParameter prmDNI;
            int idUsuario;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlUsuarioInsertar = "uspUsuarioInsertar";
                cmdUsuarioInsertar = Conn.CreateCommand();
                cmdUsuarioInsertar.CommandText = sqlUsuarioInsertar;
                cmdUsuarioInsertar.CommandType = CommandType.StoredProcedure;

                prmIdUsuario = cmdUsuarioInsertar.CreateParameter();
                prmIdUsuario.Direction = ParameterDirection.ReturnValue;
                prmIdUsuario.SqlDbType = SqlDbType.Int;

                prmLogin = cmdUsuarioInsertar.CreateParameter();
                prmLogin.ParameterName = "@Login";
                prmLogin.SqlDbType = SqlDbType.VarChar;
                prmLogin.Value = objUsuarioBE.Login;

                prmContrasenia = cmdUsuarioInsertar.CreateParameter();
                prmContrasenia.ParameterName = "@Contrasenia";
                prmContrasenia.SqlDbType = SqlDbType.VarChar;
                prmContrasenia.Value = objUsuarioBE.Contrasenia;

                prmNombreUsuario = cmdUsuarioInsertar.CreateParameter();
                prmNombreUsuario.ParameterName = "@NombreUsuario";
                prmNombreUsuario.SqlDbType = SqlDbType.VarChar;
                prmNombreUsuario.Value = objUsuarioBE.NombreUsuario;

                prmApellidoPaterno = cmdUsuarioInsertar.CreateParameter();
                prmApellidoPaterno.ParameterName = "@ApellidoPaterno";
                prmApellidoPaterno.SqlDbType = SqlDbType.VarChar;
                prmApellidoPaterno.Value = objUsuarioBE.ApellidoPaterno;

                prmApellidoMaterno = cmdUsuarioInsertar.CreateParameter();
                prmApellidoMaterno.ParameterName = "@ApellidoMaterno";
                prmApellidoMaterno.SqlDbType = SqlDbType.VarChar;
                prmApellidoMaterno.Value = objUsuarioBE.ApellidoMaterno;

                prmDNI = cmdUsuarioInsertar.CreateParameter();
                prmDNI.ParameterName = "@DNI";
                prmDNI.SqlDbType = SqlDbType.VarChar;
                prmDNI.Value = objUsuarioBE.DNI;

                cmdUsuarioInsertar.Parameters.Add(prmIdUsuario);
                cmdUsuarioInsertar.Parameters.Add(prmLogin);
                cmdUsuarioInsertar.Parameters.Add(prmContrasenia);
                cmdUsuarioInsertar.Parameters.Add(prmNombreUsuario);
                cmdUsuarioInsertar.Parameters.Add(prmApellidoPaterno);
                cmdUsuarioInsertar.Parameters.Add(prmApellidoMaterno);
                cmdUsuarioInsertar.Parameters.Add(prmDNI);

                cmdUsuarioInsertar.Connection.Open();
                idUsuario = Convert.ToInt32(prmIdUsuario.Value);

                cmdUsuarioInsertar.Connection.Close();
                cmdUsuarioInsertar.Dispose();

                Conn.Dispose();

                return idUsuario;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }

        public override UsuarioBE UsuarioValidar(int idUsuario, String sContrasenia)
        {
            SqlConnection Conn = null;
            SqlCommand cmdUsuarioObtener = null;
            String sqlUsuarioObtener;
            SqlParameter prmIdUsuario;
            SqlParameter prmContrasenia;
            SqlDataReader drUsuario;

            try
            {
                UsuarioBE objUsuarioBE = new UsuarioBE();

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlUsuarioObtener = "uspUsuarioValidar";
                cmdUsuarioObtener = Conn.CreateCommand();
                cmdUsuarioObtener.CommandText = sqlUsuarioObtener;
                cmdUsuarioObtener.CommandType = CommandType.StoredProcedure;

                prmIdUsuario = cmdUsuarioObtener.CreateParameter();
                prmIdUsuario.ParameterName = "@IdUsuario";
                prmIdUsuario.SqlDbType = SqlDbType.Int;
                prmIdUsuario.Value = idUsuario;

                prmContrasenia = cmdUsuarioObtener.CreateParameter();
                prmContrasenia.ParameterName = "@Contrasenia";
                prmContrasenia.SqlDbType = SqlDbType.VarChar;
                prmContrasenia.Value = sContrasenia;

                cmdUsuarioObtener.Parameters.Add(prmIdUsuario);
                cmdUsuarioObtener.Parameters.Add(prmContrasenia);

                cmdUsuarioObtener.Connection.Open();
                drUsuario = cmdUsuarioObtener.ExecuteReader();

                if (drUsuario.Read())
                {
                    objUsuarioBE.IdUsuario = drUsuario.GetInt32(drUsuario.GetOrdinal("IdUsuario"));
                    objUsuarioBE.Login = drUsuario.GetString(drUsuario.GetOrdinal("Login"));
                    objUsuarioBE.Contrasenia = drUsuario.GetString(drUsuario.GetOrdinal("Contrasenia"));
                    objUsuarioBE.NombreUsuario = drUsuario.GetString(drUsuario.GetOrdinal("NombreUsuario"));
                    objUsuarioBE.ApellidoPaterno = drUsuario.GetString(drUsuario.GetOrdinal("ApellidoPaterno"));
                    objUsuarioBE.ApellidoMaterno = drUsuario.GetString(drUsuario.GetOrdinal("ApellidoMaterno"));
                    objUsuarioBE.DNI = drUsuario.GetString(drUsuario.GetOrdinal("DNI"));
                }

                cmdUsuarioObtener.Connection.Close();
                cmdUsuarioObtener.Dispose();

                Conn.Dispose();

                return objUsuarioBE;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }

        public override int UsuarioExiste(String sLogin)
        {
            SqlConnection Conn = null;
            SqlCommand cmdUsuarioExiste = null;
            String sqlUsuarioExiste;
            SqlParameter prmLogin;
            SqlDataReader drUsuario;

            try
            {
                int idUsuario = 0;

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlUsuarioExiste = "uspUsuarioExiste";
                cmdUsuarioExiste = Conn.CreateCommand();
                cmdUsuarioExiste.CommandText = sqlUsuarioExiste;
                cmdUsuarioExiste.CommandType = CommandType.StoredProcedure;

                prmLogin = cmdUsuarioExiste.CreateParameter();
                prmLogin.ParameterName = "@Login";
                prmLogin.SqlDbType = SqlDbType.VarChar;
                prmLogin.Value = sLogin;

                cmdUsuarioExiste.Parameters.Add(prmLogin);

                cmdUsuarioExiste.Connection.Open();
                drUsuario = cmdUsuarioExiste.ExecuteReader();

                if (drUsuario.Read())
                {
                    idUsuario = drUsuario.GetInt32(drUsuario.GetOrdinal("IdUsuario"));
                }

                cmdUsuarioExiste.Connection.Close();
                cmdUsuarioExiste.Dispose();

                Conn.Dispose();

                return idUsuario;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }

        public override UsuarioBE UsuarioObtener(int idUsuario)
        {
            SqlConnection Conn = null;
            SqlCommand cmdUsuarioObtener = null;
            String sqlUsuarioObtener;
            SqlParameter prmIdUsuario;
            SqlDataReader drUsuario;

            try
            {
                UsuarioBE objUsuarioBE = null;

                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlUsuarioObtener = "uspUsuarioObtener";
                cmdUsuarioObtener = Conn.CreateCommand();
                cmdUsuarioObtener.CommandText = sqlUsuarioObtener;
                cmdUsuarioObtener.CommandType = CommandType.StoredProcedure;

                prmIdUsuario = cmdUsuarioObtener.CreateParameter();
                prmIdUsuario.ParameterName = "@IdUsuario";
                prmIdUsuario.SqlDbType = SqlDbType.Int;
                prmIdUsuario.Value = idUsuario;

                cmdUsuarioObtener.Parameters.Add(prmIdUsuario);

                cmdUsuarioObtener.Connection.Open();
                drUsuario = cmdUsuarioObtener.ExecuteReader();

                if (drUsuario.Read())
                {
                    if (objUsuarioBE == null)
                        objUsuarioBE = new UsuarioBE();
                    objUsuarioBE.IdUsuario = drUsuario.GetInt32(drUsuario.GetOrdinal("IdUsuario"));
                    objUsuarioBE.Login = drUsuario.GetString(drUsuario.GetOrdinal("Login"));
                    objUsuarioBE.Contrasenia = drUsuario.GetString(drUsuario.GetOrdinal("Contrasenia"));
                    objUsuarioBE.NombreUsuario = drUsuario.GetString(drUsuario.GetOrdinal("NombreUsuario"));
                    objUsuarioBE.ApellidoPaterno = drUsuario.GetString(drUsuario.GetOrdinal("ApellidoPaterno"));
                    objUsuarioBE.ApellidoMaterno = drUsuario.GetString(drUsuario.GetOrdinal("ApellidoMaterno"));
                    objUsuarioBE.DNI = drUsuario.GetString(drUsuario.GetOrdinal("DNI"));
                }

                cmdUsuarioObtener.Connection.Close();
                cmdUsuarioObtener.Dispose();

                Conn.Dispose();

                return objUsuarioBE;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }
    }
}