using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlAvionDALC:AvionDALC
    {
	    public override int InsertarAvionBE(AvionBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

	        SqlParameter codAvion;
            SqlParameter nombre;
            SqlParameter fabricante;
            SqlParameter serie;
            SqlParameter cabinaTripulacion;
            SqlParameter pasajeros;
            SqlParameter longitud;
            SqlParameter envergadura;
            SqlParameter altura;
            SqlParameter pesoVacio;
            SqlParameter pesoMaxDespegue;
            SqlParameter velocidadCrucero;
            SqlParameter velocidadMax;
            SqlParameter carreraPesoMax;
            SqlParameter autonomiaPesoMaxDesp;
            SqlParameter maxFuel;
            SqlParameter motor;
            SqlParameter empuje;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspAvionInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codAvion = cmd.CreateParameter();
                codAvion.Direction = ParameterDirection.ReturnValue;
                codAvion.SqlDbType = SqlDbType.Int;

                nombre = cmd.CreateParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 100;
                nombre.SqlValue = obj.Nombre;

                fabricante = cmd.CreateParameter();
                fabricante.ParameterName = "@Fabricante";
                fabricante.SqlDbType = SqlDbType.VarChar;
                fabricante.Size = 100;
                fabricante.SqlValue = obj.Fabricante;

                serie = cmd.CreateParameter();
                serie.ParameterName = "@Serie";
                serie.SqlDbType = SqlDbType.VarChar;
                serie.Size = 50;
                serie.SqlValue = obj.Serie;

                cabinaTripulacion = cmd.CreateParameter();
                cabinaTripulacion.ParameterName = "@CabinaTripulacion";
                cabinaTripulacion.SqlDbType = SqlDbType.Int;
                cabinaTripulacion.SqlValue = obj.CabinaTripulacion;

                pasajeros = cmd.CreateParameter();
                pasajeros.ParameterName = "@Pasajeros";
                pasajeros.SqlDbType = SqlDbType.Int;
                pasajeros.SqlValue = obj.Pasajeros;

                longitud = cmd.CreateParameter();
                longitud.ParameterName = "@Longitud";
                longitud.SqlDbType = SqlDbType.Float;
                longitud.SqlValue = obj.Longitud;

                envergadura = cmd.CreateParameter();
                envergadura.ParameterName = "@Envergadura";
                envergadura.SqlDbType = SqlDbType.Float;
                envergadura.SqlValue = obj.Envergadura;

                altura = cmd.CreateParameter();
                altura.ParameterName = "@Altura";
                altura.SqlDbType = SqlDbType.Float;
                altura.SqlValue = obj.Altura;

                pesoVacio = cmd.CreateParameter();
                pesoVacio.ParameterName = "@PesoVacio";
                pesoVacio.SqlDbType = SqlDbType.Float;
                pesoVacio.SqlValue = obj.PesoVacio;

                pesoMaxDespegue = cmd.CreateParameter();
                pesoMaxDespegue.ParameterName = "@PesoMaxDespegue";
                pesoMaxDespegue.SqlDbType = SqlDbType.Float;
                pesoMaxDespegue.SqlValue = obj.PesoMaxDespegue;

                velocidadCrucero = cmd.CreateParameter();
                velocidadCrucero.ParameterName = "@VelocidadCrucero";
                velocidadCrucero.SqlDbType = SqlDbType.Float;
                velocidadCrucero.SqlValue = obj.VelocidadCrucero;

                velocidadMax = cmd.CreateParameter();
                velocidadMax.ParameterName = "@VelocidadMax";
                velocidadMax.SqlDbType = SqlDbType.Float;
                velocidadMax.SqlValue = obj.VelocidadMax;

                carreraPesoMax = cmd.CreateParameter();
                carreraPesoMax.ParameterName = "@CarreraPesoMax";
                carreraPesoMax.SqlDbType = SqlDbType.Float;
                carreraPesoMax.SqlValue = obj.CarreraPesoMax;

                autonomiaPesoMaxDesp = cmd.CreateParameter();
                autonomiaPesoMaxDesp.ParameterName = "@AutonomiaPesoMaxDesp";
                autonomiaPesoMaxDesp.SqlDbType = SqlDbType.Float;
                autonomiaPesoMaxDesp.SqlValue = obj.AutonomiaPesoMaxDesp;

                maxFuel = cmd.CreateParameter();
                maxFuel.ParameterName = "@maxFuel";
                maxFuel.SqlDbType = SqlDbType.Float;
                maxFuel.SqlValue = obj.MaxFuel;

                motor = cmd.CreateParameter();
                motor.ParameterName = "@Motor";
                motor.SqlDbType = SqlDbType.VarChar;
                motor.Size = 500;
                motor.SqlValue = obj.Motor;

                empuje = cmd.CreateParameter();
                empuje.ParameterName = "@Empje";
                empuje.SqlDbType = SqlDbType.VarChar;
                empuje.Size = 500;
                empuje.SqlValue = obj.Empuje;

    		    cmd.Parameters.Add(nombre);
        		cmd.Parameters.Add(fabricante);
	        	cmd.Parameters.Add(serie);
		        cmd.Parameters.Add(cabinaTripulacion);
        		cmd.Parameters.Add(pasajeros);
	        	cmd.Parameters.Add(longitud);
		        cmd.Parameters.Add(envergadura);
    		    cmd.Parameters.Add(altura);
    	    	cmd.Parameters.Add(pesoVacio);
	    	    cmd.Parameters.Add(pesoMaxDespegue);
    	    	cmd.Parameters.Add(velocidadCrucero);
	    	    cmd.Parameters.Add(velocidadMax);
    		    cmd.Parameters.Add(carreraPesoMax);
        		cmd.Parameters.Add(autonomiaPesoMaxDesp);
    	    	cmd.Parameters.Add(maxFuel);
    		    cmd.Parameters.Add(motor);
        		cmd.Parameters.Add(empuje);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codAvion.Value);

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

        public override AvionBE ObtenerAvionBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAvionBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAvionBEObtener = "uspAvionObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAvionBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodAvion";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                AvionBE obj;
                obj = new AvionBE();

                if (dr.Read())
                {
        		    obj.CodAvion = dr.GetInt32(dr.GetOrdinal("CodAvion"));
	        	    obj.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
		            obj.Fabricante = dr.GetString(dr.GetOrdinal("Fabricacion"));
		            obj.Serie = dr.GetString(dr.GetOrdinal("Serie"));
    		        obj.CabinaTripulacion = dr.GetInt32(dr.GetOrdinal("CabinaTripulacion"));
    	    	    obj.Pasajeros = dr.GetInt32(dr.GetOrdinal("Pasajeros"));
	    	        obj.Longitud = dr.GetInt32(dr.GetOrdinal("Longitud"));
		            obj.Envergadura = dr.GetInt32(dr.GetOrdinal("Envergadura"));
    		        obj.Altura = dr.GetInt32(dr.GetOrdinal("Altura"));
	    	        obj.PesoVacio = dr.GetInt32(dr.GetOrdinal("PesoVacio"));
    		        obj.PesoMaxDespegue = dr.GetInt32(dr.GetOrdinal("PesoMaxDespegue"));
	    	        obj.VelocidadCrucero = dr.GetInt32(dr.GetOrdinal("VelocidadCrucero"));
    	    	    obj.VelocidadMax = dr.GetInt32(dr.GetOrdinal("VelocidadMax"));
	    	        obj.CarreraPesoMax = dr.GetInt32(dr.GetOrdinal("CarreraPesoMax"));
    		        obj.AutonomiaPesoMaxDesp = dr.GetInt32(dr.GetOrdinal("AutonomiaPesoMaxDesp"));
	    	        obj.MaxFuel = dr.GetInt32(dr.GetOrdinal("MaxFuel"));
    	    	    obj.Motor = dr.GetString(dr.GetOrdinal("Motor"));
	    	        obj.Empuje = dr.GetString(dr.GetOrdinal("Empuje"));
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

        public override void EliminarAvionBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAvionBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAvionBEEliminar = "uspAvionEliminar";
                cmd = new SqlCommand(sqlAvionBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@CodAvion";
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

        public override List<AvionBE> ListarAvionBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAvionBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlAvionBEListar = "uspAvionListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAvionBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<AvionBE> lst;
                lst = new List<AvionBE>();

                AvionBE obj;

                while (dr.Read())
                {
                    obj = new AvionBE();
                    obj.CodAvion = dr.GetInt32(dr.GetOrdinal("CodAvion"));
	        	    obj.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
		            obj.Fabricante = dr.GetString(dr.GetOrdinal("Fabricacion"));
		            obj.Serie = dr.GetString(dr.GetOrdinal("Serie"));
    		        obj.CabinaTripulacion = dr.GetInt32(dr.GetOrdinal("CabinaTripulacion"));
    	    	    obj.Pasajeros = dr.GetInt32(dr.GetOrdinal("Pasajeros"));
	    	        obj.Longitud = dr.GetInt32(dr.GetOrdinal("Longitud"));
		            obj.Envergadura = dr.GetInt32(dr.GetOrdinal("Envergadura"));
    		        obj.Altura = dr.GetInt32(dr.GetOrdinal("Altura"));
	    	        obj.PesoVacio = dr.GetInt32(dr.GetOrdinal("PesoVacio"));
    		        obj.PesoMaxDespegue = dr.GetInt32(dr.GetOrdinal("PesoMaxDespegue"));
	    	        obj.VelocidadCrucero = dr.GetInt32(dr.GetOrdinal("VelocidadCrucero"));
    	    	    obj.VelocidadMax = dr.GetInt32(dr.GetOrdinal("VelocidadMax"));
	    	        obj.CarreraPesoMax = dr.GetInt32(dr.GetOrdinal("CarreraPesoMax"));
		            obj.AutonomiaPesoMaxDesp = dr.GetInt32(dr.GetOrdinal("AutonomiaPesoMaxDesp"));
    		        obj.MaxFuel = dr.GetInt32(dr.GetOrdinal("MaxFuel"));
        		    obj.Motor = dr.GetString(dr.GetOrdinal("Motor"));
	        	    obj.Empuje = dr.GetString(dr.GetOrdinal("Empuje"));
                        
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

        public override void ActualizarAvionBE(AvionBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlAvionBEActualizar;

	        SqlParameter id;
            SqlParameter nombre;
            SqlParameter fabricante;
            SqlParameter serie;
            SqlParameter cabinaTripulacion;
            SqlParameter pasajeros;
            SqlParameter longitud;
            SqlParameter envergadura;
            SqlParameter altura;
            SqlParameter pesoVacio;
            SqlParameter pesoMaxDespegue;
            SqlParameter velocidadCrucero;
            SqlParameter velocidadMax;
            SqlParameter carreraPesoMax;
            SqlParameter autonomiaPesoMaxDesp;
            SqlParameter maxFuel;
            SqlParameter motor;
            SqlParameter empuje;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlAvionBEActualizar = "uspAvionActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlAvionBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodAvion";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodAvion;

                nombre = cmd.CreateParameter();
                nombre.ParameterName = "@Nombre";
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 100;
                nombre.SqlValue = obj.Nombre;

                fabricante = cmd.CreateParameter();
                fabricante.ParameterName = "@Fabricante";
                fabricante.SqlDbType = SqlDbType.VarChar;
                fabricante.Size = 100;
                fabricante.SqlValue = obj.Fabricante;

                serie = cmd.CreateParameter();
                serie.ParameterName = "@Serie";
                serie.SqlDbType = SqlDbType.VarChar;
                serie.Size = 50;
                serie.SqlValue = obj.Serie;

                cabinaTripulacion = cmd.CreateParameter();
                cabinaTripulacion.ParameterName = "@CabinaTripulacion";
                cabinaTripulacion.SqlDbType = SqlDbType.Int;
                cabinaTripulacion.SqlValue = obj.CabinaTripulacion;

                pasajeros = cmd.CreateParameter();
                pasajeros.ParameterName = "@Pasajeros";
                pasajeros.SqlDbType = SqlDbType.Int;
                pasajeros.SqlValue = obj.Pasajeros;

                longitud = cmd.CreateParameter();
                longitud.ParameterName = "@Longitud";
                longitud.SqlDbType = SqlDbType.Float;
                longitud.SqlValue = obj.Longitud;

                envergadura = cmd.CreateParameter();
                envergadura.ParameterName = "@Envergadura";
                envergadura.SqlDbType = SqlDbType.Float;
                envergadura.SqlValue = obj.Envergadura;

                altura = cmd.CreateParameter();
                altura.ParameterName = "@Altura";
                altura.SqlDbType = SqlDbType.Float;
                altura.SqlValue = obj.Altura;

                pesoVacio = cmd.CreateParameter();
                pesoVacio.ParameterName = "@PesoVacio";
                pesoVacio.SqlDbType = SqlDbType.Float;
                pesoVacio.SqlValue = obj.PesoVacio;

                pesoMaxDespegue = cmd.CreateParameter();
                pesoMaxDespegue.ParameterName = "@PesoMaxDespegue";
                pesoMaxDespegue.SqlDbType = SqlDbType.Float;
                pesoMaxDespegue.SqlValue = obj.PesoMaxDespegue;

                velocidadCrucero = cmd.CreateParameter();
                velocidadCrucero.ParameterName = "@VelocidadCrucero";
                velocidadCrucero.SqlDbType = SqlDbType.Float;
                velocidadCrucero.SqlValue = obj.VelocidadCrucero;

                velocidadMax = cmd.CreateParameter();
                velocidadMax.ParameterName = "@VelocidadMax";
                velocidadMax.SqlDbType = SqlDbType.Float;
                velocidadMax.SqlValue = obj.VelocidadMax;

                carreraPesoMax = cmd.CreateParameter();
                carreraPesoMax.ParameterName = "@CarreraPesoMax";
                carreraPesoMax.SqlDbType = SqlDbType.Float;
                carreraPesoMax.SqlValue = obj.CarreraPesoMax;

                autonomiaPesoMaxDesp = cmd.CreateParameter();
                autonomiaPesoMaxDesp.ParameterName = "@AutonomiaPesoDesp";
                autonomiaPesoMaxDesp.SqlDbType = SqlDbType.Float;
                autonomiaPesoMaxDesp.SqlValue = obj.AutonomiaPesoMaxDesp;

                maxFuel = cmd.CreateParameter();
                maxFuel.ParameterName = "@maxFuel";
                maxFuel.SqlDbType = SqlDbType.Float;
                maxFuel.SqlValue = obj.MaxFuel;

                motor = cmd.CreateParameter();
                motor.ParameterName = "@Motor";
                motor.SqlDbType = SqlDbType.VarChar;
                motor.Size = 500;
                motor.SqlValue = obj.Motor;

                empuje = cmd.CreateParameter();
                empuje.ParameterName = "@Empuje";
                empuje.SqlDbType = SqlDbType.VarChar;
                empuje.Size = 500;
                empuje.SqlValue = obj.Empuje;

        		cmd.Parameters.Add(id);
	        	cmd.Parameters.Add(nombre);
		        cmd.Parameters.Add(fabricante);
    		    cmd.Parameters.Add(serie);
    	    	cmd.Parameters.Add(cabinaTripulacion);
	    	    cmd.Parameters.Add(pasajeros);
    	    	cmd.Parameters.Add(longitud);
	    	    cmd.Parameters.Add(envergadura);
    		    cmd.Parameters.Add(altura);
        		cmd.Parameters.Add(pesoVacio);
	        	cmd.Parameters.Add(pesoMaxDespegue);
		        cmd.Parameters.Add(velocidadCrucero);
        		cmd.Parameters.Add(velocidadMax);
	        	cmd.Parameters.Add(carreraPesoMax);
		        cmd.Parameters.Add(autonomiaPesoMaxDesp);
    		    cmd.Parameters.Add(maxFuel);
    	    	cmd.Parameters.Add(motor);
	    	    cmd.Parameters.Add(empuje);

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
