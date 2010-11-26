using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlPistaDALC:PistaDALC
    {
	    public override int InsertarPistaBE(PistaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

	        SqlParameter codPista;
            SqlParameter codAeropuerto;
            SqlParameter largo;
            SqlParameter ancho;
            SqlParameter tora;
            SqlParameter toda;
            SqlParameter asda;
            SqlParameter lda;
            SqlParameter pavimento;
            SqlParameter designado;
            SqlParameter pcn;
            SqlParameter franja;
            SqlParameter rodaje;
            SqlParameter estado;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspPistaInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codPista = cmd.CreateParameter();
                codPista.Direction = ParameterDirection.ReturnValue;
                codPista.SqlDbType = SqlDbType.Int;

                codAeropuerto = cmd.CreateParameter();
                codAeropuerto.ParameterName = "@CodAeropuerto";
                codAeropuerto.SqlDbType = SqlDbType.Int;
                codAeropuerto.SqlValue = obj.CodAeropuerto;

                largo = cmd.CreateParameter();
                largo.ParameterName = "@Largo";
                largo.SqlDbType = SqlDbType.Int;
                largo.SqlValue = obj.Largo;

                ancho = cmd.CreateParameter();
                ancho.ParameterName = "@Ancho";
                ancho.SqlDbType = SqlDbType.Int;
                ancho.SqlValue = obj.Ancho;

                tora = cmd.CreateParameter();
                tora.ParameterName = "@TORA";
                tora.SqlDbType = SqlDbType.Int;
                tora.SqlValue = obj.Tora;

                toda = cmd.CreateParameter();
                toda.ParameterName = "@TODA";
                toda.SqlDbType = SqlDbType.Int;
                toda.SqlValue = obj.Toda;

                asda = cmd.CreateParameter();
                asda.ParameterName = "@ASDA";
                asda.SqlDbType = SqlDbType.Int;
                asda.SqlValue = obj.Asda;

                lda = cmd.CreateParameter();
                lda.ParameterName = "@LDA";
                lda.SqlDbType = SqlDbType.Int;
                lda.SqlValue = obj.Lda;

                pavimento = cmd.CreateParameter();
                pavimento.ParameterName = "@Pavimento";
                pavimento.SqlDbType = SqlDbType.VarChar;
                pavimento.Size = 500;
                pavimento.SqlValue = obj.Pavimento;

                designado = cmd.CreateParameter();
                designado.ParameterName = "@Designado";
                designado.SqlDbType = SqlDbType.VarChar;
                designado.Size = 500;
                designado.SqlValue = obj.Designado;

                pcn = cmd.CreateParameter();
                pcn.ParameterName = "@PCN";
                pcn.SqlDbType = SqlDbType.VarChar;
                pcn.Size = 500;
                pcn.SqlValue = obj.Pcn;

                franja = cmd.CreateParameter();
                franja.ParameterName = "@Franja";
                franja.SqlDbType = SqlDbType.VarChar;
                franja.Size = 500;
                franja.SqlValue = obj.Franja;

                rodaje = cmd.CreateParameter();
                rodaje.ParameterName = "@Rodaje";
                rodaje.SqlDbType = SqlDbType.VarChar;
                rodaje.Size = 500;
                rodaje.SqlValue = obj.Rodaje;

                estado = cmd.CreateParameter();
                estado.ParameterName = "@Estado";
                estado.SqlDbType = SqlDbType.VarChar;
                estado.Size = 500;
                estado.SqlValue = obj.Estado;

        	    cmd.Parameters.Add(codPista);
                cmd.Parameters.Add(codAeropuerto);
                cmd.Parameters.Add(largo);
                cmd.Parameters.Add(ancho);
                cmd.Parameters.Add(tora);
                cmd.Parameters.Add(toda);
                cmd.Parameters.Add(asda);
                cmd.Parameters.Add(lda);
                cmd.Parameters.Add(pavimento);
                cmd.Parameters.Add(designado);
                cmd.Parameters.Add(pcn);
                cmd.Parameters.Add(franja);
                cmd.Parameters.Add(rodaje);
                cmd.Parameters.Add(estado);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codPista.Value);

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

        public override PistaBE ObtenerPistaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPistaBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPistaBEObtener = "uspPistaObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPistaBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodPista";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                PistaBE obj;
                obj = new PistaBE();

                if (dr.Read())
                {
	                obj.CodPista = dr.GetInt32(dr.GetOrdinal("CodPista"));
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Largo = dr.GetInt32(dr.GetOrdinal("Largo"));
                    obj.Ancho = dr.GetInt32(dr.GetOrdinal("Ancho"));
                    obj.Tora = dr.GetInt32(dr.GetOrdinal("TORA"));
                    obj.Toda = dr.GetInt32(dr.GetOrdinal("TODA"));
                    obj.Asda = dr.GetInt32(dr.GetOrdinal("ASDA"));
                    obj.Lda = dr.GetInt32(dr.GetOrdinal("LDA"));
                    obj.Pavimento = dr.GetString(dr.GetOrdinal("Pavimento"));
                    obj.Designado = dr.GetString(dr.GetOrdinal("Designado"));
                    obj.Pcn = dr.GetString(dr.GetOrdinal("PCN"));
                    obj.Franja = dr.GetString(dr.GetOrdinal("Franja"));
                    obj.Rodaje = dr.GetString(dr.GetOrdinal("Rodaje"));
                    obj.Estado = dr.GetString(dr.GetOrdinal("Estado"));
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

        public override void EliminarPistaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPistaBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPistaBEEliminar = "uspPistaEliminar";
                cmd = new SqlCommand(sqlPistaBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@CodPista";
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

        public override List<PistaBE> ListarPistaBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPistaBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlPistaBEListar = "uspPistaListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPistaBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<PistaBE> lst;
                lst = new List<PistaBE>();

                PistaBE obj;
                while (dr.Read())
                {
                    obj = new PistaBE();
                    obj.CodPista = dr.GetInt32(dr.GetOrdinal("CodPista"));
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Largo = dr.GetInt32(dr.GetOrdinal("Largo"));
                    obj.Ancho = dr.GetInt32(dr.GetOrdinal("Ancho"));
                    obj.Tora = dr.GetInt32(dr.GetOrdinal("TORA"));
                    obj.Toda = dr.GetInt32(dr.GetOrdinal("TODA"));
                    obj.Asda = dr.GetInt32(dr.GetOrdinal("ASDA"));
                    obj.Lda = dr.GetInt32(dr.GetOrdinal("LDA"));
                    obj.Pavimento = dr.GetString(dr.GetOrdinal("Pavimento"));
                    obj.Designado = dr.GetString(dr.GetOrdinal("Designado"));
                    obj.Pcn = dr.GetString(dr.GetOrdinal("PCN"));
                    obj.Franja = dr.GetString(dr.GetOrdinal("Franja"));
                    obj.Rodaje = dr.GetString(dr.GetOrdinal("Rodaje"));
                    obj.Estado = dr.GetString(dr.GetOrdinal("Estado"));
                    
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

        public override void ActualizarPistaBE(PistaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPistaBEActualizar;

    	    SqlParameter id;//codPista
            SqlParameter codAeropuerto;
            SqlParameter largo;
            SqlParameter ancho;
            SqlParameter tora;
            SqlParameter toda;
            SqlParameter asda;
            SqlParameter lda;
            SqlParameter pavimento;
            SqlParameter designado;
            SqlParameter pcn;
            SqlParameter franja;
            SqlParameter rodaje;
            SqlParameter estado;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPistaBEActualizar = "uspPistaActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPistaBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodPista";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodPista;

                codAeropuerto = cmd.CreateParameter();
                codAeropuerto.ParameterName = "@CodAeropuerto";
                codAeropuerto.SqlDbType = SqlDbType.Int;
                codAeropuerto.SqlValue = obj.CodAeropuerto;

                largo = cmd.CreateParameter();
                largo.ParameterName = "@Largo";
                largo.SqlDbType = SqlDbType.Int;
                largo.SqlValue = obj.Largo;

                ancho = cmd.CreateParameter();
                ancho.ParameterName = "@Ancho";
                ancho.SqlDbType = SqlDbType.Int;
                ancho.SqlValue = obj.Ancho;

                tora = cmd.CreateParameter();
                tora.ParameterName = "@TORA";
                tora.SqlDbType = SqlDbType.Int;
                tora.SqlValue = obj.Tora;

                toda = cmd.CreateParameter();
                toda.ParameterName = "@TODA";
                toda.SqlDbType = SqlDbType.Int;
                toda.SqlValue = obj.Toda;

                asda = cmd.CreateParameter();
                asda.ParameterName = "@ASDA";
                asda.SqlDbType = SqlDbType.Int;
                asda.SqlValue = obj.Asda;

                lda = cmd.CreateParameter();
                lda.ParameterName = "@LDA";
                lda.SqlDbType = SqlDbType.Int;
                lda.SqlValue = obj.Lda;

                pavimento = cmd.CreateParameter();
                pavimento.ParameterName = "@Pavimento";
                pavimento.SqlDbType = SqlDbType.VarChar;
                pavimento.Size = 500;
                pavimento.SqlValue = obj.Pavimento;

                designado = cmd.CreateParameter();
                designado.ParameterName = "@Designado";
                designado.SqlDbType = SqlDbType.VarChar;
                designado.Size = 500;
                designado.SqlValue = obj.Designado;

                pcn = cmd.CreateParameter();
                pcn.ParameterName = "@PCN";
                pcn.SqlDbType = SqlDbType.VarChar;
                pcn.Size = 500;
                pcn.SqlValue = obj.Pcn;

                franja = cmd.CreateParameter();
                franja.ParameterName = "@Franja";
                franja.SqlDbType = SqlDbType.VarChar;
                franja.Size = 500;
                franja.SqlValue = obj.Franja;

                rodaje = cmd.CreateParameter();
                rodaje.ParameterName = "@Rodaje";
                rodaje.SqlDbType = SqlDbType.VarChar;
                rodaje.Size = 500;
                rodaje.SqlValue = obj.Rodaje;

                estado = cmd.CreateParameter();
                estado.ParameterName = "@Estado";
                estado.SqlDbType = SqlDbType.VarChar;
                estado.Size = 500;
                estado.SqlValue = obj.Estado;

        	    cmd.Parameters.Add(id);
                cmd.Parameters.Add(codAeropuerto);
                cmd.Parameters.Add(largo);
                cmd.Parameters.Add(ancho);
                cmd.Parameters.Add(tora);
                cmd.Parameters.Add(toda);
                cmd.Parameters.Add(asda);
                cmd.Parameters.Add(lda);
                cmd.Parameters.Add(pavimento);
                cmd.Parameters.Add(designado);
                cmd.Parameters.Add(pcn);
                cmd.Parameters.Add(franja);
                cmd.Parameters.Add(rodaje);
                cmd.Parameters.Add(estado);

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

        public override void AgregarObservador(UsuarioBE _observador)
        {
            LstUsuario.Add(_observador);
        }

        public override void QuitarObservador(UsuarioBE _observador)
        {
            LstUsuario.Remove(_observador);
        }
    }
}