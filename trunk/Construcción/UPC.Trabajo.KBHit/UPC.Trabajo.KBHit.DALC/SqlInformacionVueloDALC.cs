using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlInformacionVueloDALC:InformacionVueloDALC
    {
	    public override int InsertarInformacionVueloBE(InformacionVueloBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInsertar;

		    SqlParameter codInfoVuelo;
	        SqlParameter codPlanVuelo;
	        SqlParameter horas;
	        SqlParameter min;
	        SqlParameter personas;
	        SqlParameter uhf;
	        SqlParameter vhf;
	        SqlParameter elt;
	        SqlParameter polar;
	        SqlParameter desierto;
	        SqlParameter maritimo;
	        SqlParameter selva;
	        SqlParameter fluor;
	        SqlParameter luz;
	        SqlParameter numero;
	        SqlParameter capacidad;
	        SqlParameter cubierta;
	        SqlParameter color;
	        SqlParameter marcasNave;
	        SqlParameter observaciones;
	        SqlParameter piloto;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInsertar = "uspInformacionVueloInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codInfoVuelo = cmd.CreateParameter();
                codInfoVuelo.Direction = ParameterDirection.ReturnValue;
                codInfoVuelo.SqlDbType = SqlDbType.Int;

                codPlanVuelo = cmd.CreateParameter();
                codPlanVuelo.ParameterName = "@CodPlanVuelo";
                codPlanVuelo.SqlDbType = SqlDbType.Int;
                codPlanVuelo.SqlValue = obj.CodPlanVuelo;

                horas = cmd.CreateParameter();
                horas.ParameterName = "@Horas";
                horas.SqlDbType = SqlDbType.Int;
                horas.SqlValue = obj.Horas;

                min = cmd.CreateParameter();
                min.ParameterName = "@Min";
                min.SqlDbType = SqlDbType.Int;
                min.SqlValue = obj.Min;

                personas = cmd.CreateParameter();
                personas.ParameterName = "@Personas";
                personas.SqlDbType = SqlDbType.Int;
                personas.SqlValue = obj.Personas;

                uhf = cmd.CreateParameter();
                uhf.ParameterName = "@UFH";
                uhf.SqlDbType = SqlDbType.Int;
                uhf.SqlValue = obj.Uhf;

                vhf = cmd.CreateParameter();
                vhf.ParameterName = "@VHF";
                vhf.SqlDbType = SqlDbType.Int;
                vhf.SqlValue = obj.Vhf;

                elt = cmd.CreateParameter();
                elt.ParameterName = "@ELT";
                elt.SqlDbType = SqlDbType.Int;
                elt.SqlValue = obj.Elt;

                polar = cmd.CreateParameter();
                polar.ParameterName = "@Polar";
                polar.SqlDbType = SqlDbType.Int;
                polar.SqlValue = obj.Polar;

                desierto = cmd.CreateParameter();
                desierto.ParameterName = "@Desierto";
                desierto.SqlDbType = SqlDbType.Int;
                desierto.SqlValue = obj.Desierto;

                maritimo = cmd.CreateParameter();
                maritimo.ParameterName = "@Maritimo";
                maritimo.SqlDbType = SqlDbType.Int;
                maritimo.SqlValue = obj.Maritimo;

                selva = cmd.CreateParameter();
                selva.ParameterName = "@Selva";
                selva.SqlDbType = SqlDbType.Int;
                selva.SqlValue = obj.Selva;

                fluor = cmd.CreateParameter();
                fluor.ParameterName = "@Fluor";
                fluor.SqlDbType = SqlDbType.Int;
                fluor.SqlValue = obj.Fluor;

                luz = cmd.CreateParameter();
                luz.ParameterName = "@Luz";
                luz.SqlDbType = SqlDbType.Int;
                luz.SqlValue = obj.Luz;

                numero = cmd.CreateParameter();
                numero.ParameterName = "@Numero";
                numero.SqlDbType = SqlDbType.Int;
                numero.SqlValue = obj.Numero;

                capacidad = cmd.CreateParameter();
                capacidad.ParameterName = "@Capacidad";
                capacidad.SqlDbType = SqlDbType.Int;
                capacidad.SqlValue = obj.Capacidad;

                cubierta = cmd.CreateParameter();
                cubierta.ParameterName = "@Cubierta";
                cubierta.SqlDbType = SqlDbType.Int;
                cubierta.SqlValue = obj.Cubierta;

                color = cmd.CreateParameter();
                color.ParameterName = "@Color";
                color.SqlDbType = SqlDbType.VarChar;
                color.Size = 500;
                color.SqlValue = obj.Color;

                marcasNave = cmd.CreateParameter();
                marcasNave.ParameterName = "@MarcasNaves";
                marcasNave.SqlDbType = SqlDbType.VarChar;
                marcasNave.Size = 500;
                marcasNave.SqlValue = obj.MarcasNave;

                observaciones = cmd.CreateParameter();
                observaciones.ParameterName = "@Observaciones";
                observaciones.SqlDbType = SqlDbType.VarChar;
                observaciones.Size = 1000;
                observaciones.SqlValue = obj.Observaciones;

                piloto = cmd.CreateParameter();
                piloto.ParameterName = "@Piloto";
                piloto.SqlDbType = SqlDbType.VarChar;
                piloto.Size = 500;
                piloto.SqlValue = obj.Piloto;

    		    cmd.Parameters.Add(codInfoVuelo);
	            cmd.Parameters.Add(codPlanVuelo);
	            cmd.Parameters.Add(horas);
    	        cmd.Parameters.Add(min);
	            cmd.Parameters.Add(personas);
	            cmd.Parameters.Add(uhf);
	            cmd.Parameters.Add(vhf);
    	        cmd.Parameters.Add(elt);
	            cmd.Parameters.Add(polar);
	            cmd.Parameters.Add(desierto);
	            cmd.Parameters.Add(maritimo);
    	        cmd.Parameters.Add(selva);
	            cmd.Parameters.Add(fluor);
	            cmd.Parameters.Add(luz);
	            cmd.Parameters.Add(numero);
    	        cmd.Parameters.Add(capacidad);
	            cmd.Parameters.Add(cubierta);
	            cmd.Parameters.Add(color);
	            cmd.Parameters.Add(marcasNave);
    	        cmd.Parameters.Add(observaciones);
	            cmd.Parameters.Add(piloto);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                iCod = Convert.ToInt32(codInfoVuelo.Value);

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

        public override InformacionVueloBE ObtenerInformacionVueloBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInformacionVueloBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInformacionVueloBEObtener = "uspInformacionVueloObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInformacionVueloBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@Id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                InformacionVueloBE obj;
                obj = new InformacionVueloBE();

                if (dr.Read())
                {   
        			obj.CodInfoVuelo = dr.GetInt32(dr.GetOrdinal("CodInfoVuelo"));
	    	        obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
		            obj.Horas = dr.GetInt32(dr.GetOrdinal("Horas"));
		            obj.Min = dr.GetInt32(dr.GetOrdinal("Min"));
		            obj.Personas = dr.GetInt32(dr.GetOrdinal("Personas"));
    		        obj.Uhf = dr.GetInt32(dr.GetOrdinal("UHF"));
	    	        obj.Vhf = dr.GetInt32(dr.GetOrdinal("VHF"));
		            obj.Elt = dr.GetInt32(dr.GetOrdinal("ELT"));
		            obj.Polar = dr.GetInt32(dr.GetOrdinal("Polar"));
		            obj.Desierto = dr.GetInt32(dr.GetOrdinal("Desierto"));
    		        obj.Maritimo = dr.GetInt32(dr.GetOrdinal("Maritimo"));
    		        obj.Selva = dr.GetInt32(dr.GetOrdinal("Selva"));
	    	        obj.Fluor = dr.GetInt32(dr.GetOrdinal("Fluor"));
		            obj.Luz = dr.GetInt32(dr.GetOrdinal("Luz"));
		            obj.Numero = dr.GetInt32(dr.GetOrdinal("Numero"));
		            obj.Capacidad = dr.GetInt32(dr.GetOrdinal("Capacidad"));
    		        obj.Cubierta = dr.GetInt32(dr.GetOrdinal("Cubierta"));
	    	        obj.Color = dr.GetString(dr.GetOrdinal("Color"));
		            obj.MarcasNave = dr.GetString(dr.GetOrdinal("MarcasNave"));
		            obj.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
		            obj.Piloto = dr.GetString(dr.GetOrdinal("Piloto"));
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

	    /*public void EliminarInformacionVueloBE(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInformacionVueloBEEliminar;

            SqlParameter id;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInformacionVueloBEEliminar = "uspInformacionVueloBEEliminar";
                cmd = new SqlCommand(sqlInformacionVueloBEEliminar, Conn);

                id = new SqlParameter();
                id.ParameterName = "@Id";
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
        }*/

        public override List<InformacionVueloBE> ListarInformacionVueloBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInformacionVueloBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlInformacionVueloBEListar = "uspInformacionVueloListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInformacionVueloBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<InformacionVueloBE> lst;
                lst = new List<InformacionVueloBE>();

                InformacionVueloBE obj;

                while (dr.Read())
                {
                    obj = new InformacionVueloBE();
                    obj.CodInfoVuelo = dr.GetInt32(dr.GetOrdinal("CodInfoVuelo"));
                    obj.CodPlanVuelo = dr.GetInt32(dr.GetOrdinal("CodPlanVuelo"));
                    obj.Horas = dr.GetInt32(dr.GetOrdinal("Horas"));
                    obj.Min = dr.GetInt32(dr.GetOrdinal("Min"));
                    obj.Personas = dr.GetInt32(dr.GetOrdinal("Personas"));
                    obj.Uhf = dr.GetInt32(dr.GetOrdinal("UHF"));
                    obj.Vhf = dr.GetInt32(dr.GetOrdinal("VHF"));
                    obj.Elt = dr.GetInt32(dr.GetOrdinal("ELT"));
                    obj.Polar = dr.GetInt32(dr.GetOrdinal("Polar"));
                    obj.Desierto = dr.GetInt32(dr.GetOrdinal("Desierto"));
                    obj.Maritimo = dr.GetInt32(dr.GetOrdinal("Maritimo"));
                    obj.Selva = dr.GetInt32(dr.GetOrdinal("Selva"));
                    obj.Fluor = dr.GetInt32(dr.GetOrdinal("Fluor"));
                    obj.Luz = dr.GetInt32(dr.GetOrdinal("Luz"));
                    obj.Numero = dr.GetInt32(dr.GetOrdinal("Numero"));
                    obj.Capacidad = dr.GetInt32(dr.GetOrdinal("Capacidad"));
                    obj.Cubierta = dr.GetInt32(dr.GetOrdinal("Cubierta"));
                    obj.Color = dr.GetString(dr.GetOrdinal("Color"));
                    obj.MarcasNave = dr.GetString(dr.GetOrdinal("MarcasNave"));
                    obj.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
                    obj.Piloto = dr.GetString(dr.GetOrdinal("Piloto"));
                    
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

	    /*public void ActualizarInformacionVueloBE(InformacionVueloBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlInformacionVueloBEActualizar;

		    SqlParameter id;
	        SqlParameter codPlanVuelo;
	        SqlParameter horas;
	        SqlParameter min;
	        SqlParameter personas;
	        SqlParameter uhf;
	        SqlParameter vhf;
	        SqlParameter elt;
	        SqlParameter polar;
	        SqlParameter desierto;
	        SqlParameter maritimo;
	        SqlParameter selva;
	        SqlParameter fluor;
	        SqlParameter luz;
	        SqlParameter numero;
	        SqlParameter capacidad;
	        SqlParameter cubierta;
	       	SqlParameter color;
	        SqlParameter marcasNave;
	        SqlParameter observaciones;
	        SqlParameter piloto;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlInformacionVueloBEActualizar = "uspInformacionVueloBEActualizar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlInformacionVueloBEActualizar;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@Id";
                id.SqlDbType = SqlDbType.Int;
                id.SqlValue = obj.CodInfoVuelo;

                codPlanVuelo = cmd.CreateParameter();
                codPlanVuelo.ParameterName = "@Estado";
                codPlanVuelo.SqlDbType = SqlDbType.VarChar;
                codPlanVuelo.Size = 50;
                codPlanVuelo.SqlValue = obj.CodPlanVuelo;

                horas = cmd.CreateParameter();
                horas.ParameterName = "@Ciudad";
                horas.SqlDbType = SqlDbType.VarChar;
                horas.Size = 50;
                horas.SqlValue = obj.Horas;

                min = cmd.CreateParameter();
                min.ParameterName = "@Iata";
                min.SqlDbType = SqlDbType.VarChar;
                min.Size = 50;
                min.SqlValue = obj.Min;

                personas = cmd.CreateParameter();
                personas.ParameterName = "@Oasi";
                personas.SqlDbType = SqlDbType.VarChar;
                personas.Size = 50;
                personas.SqlValue = obj.Personas;

                uhf = cmd.CreateParameter();
                uhf.ParameterName = "@Elevacion";
                uhf.SqlDbType = SqlDbType.VarChar;
                uhf.Size = 50;
                uhf.SqlValue = obj.Uhf;

                vhf = cmd.CreateParameter();
                vhf.ParameterName = "@Elevacion";
                vhf.SqlDbType = SqlDbType.VarChar;
                vhf.Size = 50;
                vhf.SqlValue = obj.Vhf;

                elt = cmd.CreateParameter();
                elt.ParameterName = "@Sei";
                elt.SqlDbType = SqlDbType.VarChar;
                elt.Size = 50;
                elt.SqlValue = obj.Elt;

                polar = cmd.CreateParameter();
                polar.ParameterName = "@Fuel";
                polar.SqlDbType = SqlDbType.VarChar;
                polar.Size = 50;
                polar.SqlValue = obj.Polar;

                desierto = cmd.CreateParameter();
                desierto.ParameterName = "@Operacion";
                desierto.SqlDbType = SqlDbType.VarChar;
                desierto.Size = 50;
                desierto.SqlValue = obj.Desierto;

                maritimo = cmd.CreateParameter();
                maritimo.ParameterName = "@Fecha";
                maritimo.SqlDbType = SqlDbType.VarChar;
                maritimo.Size = 50;
                maritimo.SqlValue = obj.Maritimo;

                selva = cmd.CreateParameter();
                selva.ParameterName = "@Fuel";
                selva.SqlDbType = SqlDbType.VarChar;
                selva.Size = 50;
                selva.SqlValue = obj.Selva;

                fluor = cmd.CreateParameter();
                fluor.ParameterName = "@Operacion";
                fluor.SqlDbType = SqlDbType.VarChar;
                fluor.Size = 50;
                fluor.SqlValue = obj.Fluor;

                luz = cmd.CreateParameter();
                luz.ParameterName = "@Fecha";
                luz.SqlDbType = SqlDbType.VarChar;
                luz.Size = 50;
                luz.SqlValue = obj.Luz;

                numero = cmd.CreateParameter();
                numero.ParameterName = "@Fuel";
                numero.SqlDbType = SqlDbType.VarChar;
                numero.Size = 50;
                numero.SqlValue = obj.Numero;

                capacidad = cmd.CreateParameter();
                capacidad.ParameterName = "@Operacion";
                capacidad.SqlDbType = SqlDbType.VarChar;
                capacidad.Size = 50;
                capacidad.SqlValue = obj.Capacidad;

                cubierta = cmd.CreateParameter();
                cubierta.ParameterName = "@Fecha";
                cubierta.SqlDbType = SqlDbType.VarChar;
                cubierta.Size = 50;
                cubierta.SqlValue = obj.Cubierta;

                color = cmd.CreateParameter();
                color.ParameterName = "@Fecha";
                color.SqlDbType = SqlDbType.VarChar;
                color.Size = 50;
                color.SqlValue = obj.Color;

                marcasNave = cmd.CreateParameter();
                marcasNave.ParameterName = "@Fecha";
                marcasNave.SqlDbType = SqlDbType.VarChar;
                marcasNave.Size = 50;
                marcasNave.SqlValue = obj.MarcasNave;

                observaciones = cmd.CreateParameter();
                observaciones.ParameterName = "@Fecha";
                observaciones.SqlDbType = SqlDbType.VarChar;
                observaciones.Size = 50;
                observaciones.SqlValue = obj.Observaciones;

                piloto = cmd.CreateParameter();
                piloto.ParameterName = "@Fecha";
                piloto.SqlDbType = SqlDbType.VarChar;
                piloto.Size = 50;
                piloto.SqlValue = obj.Piloto;

		        cmd.Parameters.Add(id);
    	        cmd.Parameters.Add(codPlanVuelo);
	            cmd.Parameters.Add(horas);
	            cmd.Parameters.Add(min);
	            cmd.Parameters.Add(personas);
    	        cmd.Parameters.Add(uhf);
	            cmd.Parameters.Add(vhf);
	            cmd.Parameters.Add(elt);
	            cmd.Parameters.Add(polar);
    	        cmd.Parameters.Add(desierto);
	            cmd.Parameters.Add(maritimo);
	            cmd.Parameters.Add(selva);
	            cmd.Parameters.Add(fluor);
    	        cmd.Parameters.Add(luz);
	            cmd.Parameters.Add(numero);
	            cmd.Parameters.Add(capacidad);
	            cmd.Parameters.Add(cubierta);
    	        cmd.Parameters.Add(color);
	            cmd.Parameters.Add(marcasNave);
	            cmd.Parameters.Add(observaciones);
	            cmd.Parameters.Add(piloto);

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
        }*/
    }
}
