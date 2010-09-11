using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlPlataformaDALC:PlataformaDALC
    {
	    public override int InsertarPlataformaBE(PlataformaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

		    SqlParameter codPlataforma;
	        SqlParameter codAeropuerto;
	        SqlParameter naves;
	        SqlParameter pavimento;
	        SqlParameter pcn;
	        SqlParameter dimensiones;
	        SqlParameter naveMaxPermisible;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspPlataformaInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codPlataforma = cmd.CreateParameter();
                codPlataforma.Direction = ParameterDirection.ReturnValue;
                codPlataforma.SqlDbType = SqlDbType.Int;

                codAeropuerto = cmd.CreateParameter();
                codAeropuerto.ParameterName = "@CodAeropuerto";
                codAeropuerto.SqlDbType = SqlDbType.Int;
                codAeropuerto.SqlValue = obj.CodAeropuerto;

                naves = cmd.CreateParameter();
                naves.ParameterName = "@Naves";
                naves.SqlDbType = SqlDbType.Int;
                naves.SqlValue = obj.Naves;

                pavimento = cmd.CreateParameter();
                pavimento.ParameterName = "@Pavimento";
                pavimento.SqlDbType = SqlDbType.VarChar;
                pavimento.Size = 500;
                pavimento.SqlValue = obj.Pavimento;

                pcn = cmd.CreateParameter();
                pcn.ParameterName = "@PCN";
                pcn.SqlDbType = SqlDbType.VarChar;
                pcn.Size = 500;
                pcn.SqlValue = obj.Pcn;

                dimensiones = cmd.CreateParameter();
                dimensiones.ParameterName = "@Dimensiones";
                dimensiones.SqlDbType = SqlDbType.VarChar;
                dimensiones.Size = 500;
                dimensiones.SqlValue = obj.Dimensiones;

                naveMaxPermisible = cmd.CreateParameter();
                naveMaxPermisible.ParameterName = "@NaveMaxPermisible";
                naveMaxPermisible.SqlDbType = SqlDbType.VarChar;
                naveMaxPermisible.Size = 500;
                naveMaxPermisible.SqlValue = obj.NaveMaxPermisible;

		        cmd.Parameters.Add(codPlataforma);
    	        cmd.Parameters.Add(codAeropuerto);
	            cmd.Parameters.Add(naves);
	            cmd.Parameters.Add(pavimento);
	            cmd.Parameters.Add(pcn);
    	        cmd.Parameters.Add(dimensiones);
	            cmd.Parameters.Add(naveMaxPermisible);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codPlataforma.Value);

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

        public override PlataformaBE ObtenerPlataformaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlataformaBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPlataformaBEObtener = "uspPlataformaObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPlataformaBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodPlataforma";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                PlataformaBE obj;
                obj = new PlataformaBE();

                if (dr.Read())
                {
        			obj.CodPlataforma = dr.GetInt32(dr.GetOrdinal("CodPlataforma"));
    		        obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
	    	        obj.Naves = dr.GetInt32(dr.GetOrdinal("Naves"));
	    	        obj.Pavimento = dr.GetString(dr.GetOrdinal("Pavimento"));
		            obj.Pcn = dr.GetString(dr.GetOrdinal("PCN"));
		            obj.Dimensiones = dr.GetString(dr.GetOrdinal("Dimensiones"));
		            obj.NaveMaxPermisible = dr.GetString(dr.GetOrdinal("NaveMaxPermisible"));
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

        public override void EliminarPlataformaBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlataformaBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPlataformaBEEliminar = "uspPlataformaEliminar";
                cmd = new SqlCommand(sqlPlataformaBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@CodPlataforma";
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

        public override List<PlataformaBE> ListarPlataformaBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlataformaBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlPlataformaBEListar = "uspPlataformaListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPlataformaBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<PlataformaBE> lst;
                lst = new List<PlataformaBE>();

                PlataformaBE obj;

                while (dr.Read())
                {
                    obj = new PlataformaBE();
                    obj.CodPlataforma = dr.GetInt32(dr.GetOrdinal("CodPlataforma"));
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
                    obj.Naves = dr.GetInt32(dr.GetOrdinal("Naves"));
                    obj.Pavimento = dr.GetString(dr.GetOrdinal("Pavimento"));
                    obj.Pcn = dr.GetString(dr.GetOrdinal("PCN"));
                    obj.Dimensiones = dr.GetString(dr.GetOrdinal("Dimensiones"));
                    obj.NaveMaxPermisible = dr.GetString(dr.GetOrdinal("NaveMaxPermisible"));
                    
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

        public override void ActualizarPlataformaBE(PlataformaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlPlataformaBEActualizar;

	        SqlParameter id;
	        SqlParameter codAeropuerto;
	        SqlParameter naves;
	        SqlParameter pavimento;
	        SqlParameter pcn;
	        SqlParameter dimensiones;
	        SqlParameter naveMaxPermisible;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlPlataformaBEActualizar = "uspPlataformaBEActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlPlataformaBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodPlataforma";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodPlataforma;

		        codAeropuerto = cmd.CreateParameter();
                codAeropuerto.ParameterName = "@CodAeropuerto";
                codAeropuerto.SqlDbType = SqlDbType.Int;
                codAeropuerto.SqlValue = obj.CodAeropuerto;

                naves = cmd.CreateParameter();
                naves.ParameterName = "@Naves";
                naves.SqlDbType = SqlDbType.Int;
                naves.SqlValue = obj.Naves;

                pavimento = cmd.CreateParameter();
                pavimento.ParameterName = "@Pavimento";
                pavimento.SqlDbType = SqlDbType.VarChar;
                pavimento.Size = 500;
                pavimento.SqlValue = obj.Pavimento;

                pcn = cmd.CreateParameter();
                pcn.ParameterName = "@PCN";
                pcn.SqlDbType = SqlDbType.VarChar;
                pcn.Size = 500;
                pcn.SqlValue = obj.Pcn;

                dimensiones = cmd.CreateParameter();
                dimensiones.ParameterName = "@Dimensiones";
                dimensiones.SqlDbType = SqlDbType.VarChar;
                dimensiones.Size = 500;
                dimensiones.SqlValue = obj.Dimensiones;

                naveMaxPermisible = cmd.CreateParameter();
                naveMaxPermisible.ParameterName = "@NaveMaxPermisible";
                naveMaxPermisible.SqlDbType = SqlDbType.VarChar;
                naveMaxPermisible.Size = 500;
                naveMaxPermisible.SqlValue = obj.NaveMaxPermisible;

    		    cmd.Parameters.Add(id);
	            cmd.Parameters.Add(codAeropuerto);
	            cmd.Parameters.Add(naves);
	            cmd.Parameters.Add(pavimento);
    	        cmd.Parameters.Add(pcn);
	            cmd.Parameters.Add(dimensiones);
	            cmd.Parameters.Add(naveMaxPermisible);

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
