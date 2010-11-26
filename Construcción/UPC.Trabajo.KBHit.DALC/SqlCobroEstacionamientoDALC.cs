using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlCobroEstacionamientoDALC : CobroEstacionamientoDALC
    {
        public override int InsertarCobroEstacionamientoBE(CobroEstacionamientoBE objCobroEstacionamientoBE)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlCobroEstacionamientoBEInsertar;

            SqlParameter codEstacionamiento;
            SqlParameter fechaInicio;
            SqlParameter fechaFin;
            SqlParameter impuesto;
            SqlParameter duracion;
            SqlParameter codAerolinea;
            SqlParameter codAvion;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlCobroEstacionamientoBEInsertar = "uspInsertarCobroEstacionamiento";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlCobroEstacionamientoBEInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codEstacionamiento = cmd.CreateParameter();
                codEstacionamiento.SqlDbType = SqlDbType.Int;
                codEstacionamiento.Direction = ParameterDirection.ReturnValue;

                codAvion = cmd.CreateParameter();
                codAvion.ParameterName = "@CodAvion";
                codAvion.SqlDbType = SqlDbType.Int;
                codAvion.Value = objCobroEstacionamientoBE.ObjAvion.CodAvion;

                fechaInicio = cmd.CreateParameter();
                fechaInicio.ParameterName = "@FechaInicio";
                fechaInicio.SqlDbType = SqlDbType.DateTime;
                fechaInicio.Value = objCobroEstacionamientoBE.FechaInicio;

                impuesto = cmd.CreateParameter();
                impuesto.ParameterName = "@Impuesto";
                impuesto.SqlDbType = SqlDbType.Float;
                impuesto.Value = objCobroEstacionamientoBE.Impuesto;

                fechaFin = cmd.CreateParameter();
                fechaFin.ParameterName = "@FechaFin";
                fechaFin.SqlDbType = SqlDbType.DateTime;
                fechaFin.Value = objCobroEstacionamientoBE.FechaInicio;

                codAerolinea = cmd.CreateParameter();
                codAerolinea.ParameterName = "@CodAerolinea";
                codAerolinea.SqlDbType = SqlDbType.Int;
                codAerolinea.Value = objCobroEstacionamientoBE.ObjAerolinea.CodAerolinea;

                duracion = cmd.CreateParameter();
                duracion.ParameterName = "@Duracion";
                duracion.SqlDbType = SqlDbType.DateTime;
                duracion.SqlValue = objCobroEstacionamientoBE.Duracion;

                cmd.Parameters.Add(codEstacionamiento);
                cmd.Parameters.Add(codAvion);
                cmd.Parameters.Add(fechaInicio);
                cmd.Parameters.Add(impuesto);
                cmd.Parameters.Add(fechaFin);
                cmd.Parameters.Add(codAerolinea);
                cmd.Parameters.Add(duracion);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iCod = Convert.ToInt32(codEstacionamiento.Value);

                cmd.Connection.Close();

                cmd.Dispose();
                Conn.Dispose();

                return iCod;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }
        }

        public override CobroEstacionamientoBE ObtenerCobroEstacionamientoBE(int IdCobroEstacionamiento)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlCobroEstacionamientoBEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlCobroEstacionamientoBEObtener = "uspObtenerCobroEstacionamiento";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlCobroEstacionamientoBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodEstacionamiento";
                id.SqlDbType = SqlDbType.Int;
                id.Value = IdCobroEstacionamiento;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                CobroEstacionamientoBE obj;
                obj = new CobroEstacionamientoBE();

                if (dr.Read())
                {
                    obj.CodEstacionamiento = dr.GetInt32(dr.GetOrdinal("CodEstacionamiento"));
                    obj.Duracion = dr.GetInt32(dr.GetOrdinal("Duracion"));
                    obj.Impuesto = (float)dr.GetDouble(dr.GetOrdinal("Impuesto"));
                    obj.FechaInicio = dr.GetDateTime(dr.GetOrdinal("FechaInicio"));
                    obj.FechaFin = dr.GetDateTime(dr.GetOrdinal("FechaFin"));
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();
                    AvionBE objAvionBE = objAvionDALC.ObtenerAvionBE(dr.GetInt32(dr.GetOrdinal("CodAvion")));
                    obj.ObjAvion = objAvionBE;
                    AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                    AerolineaBE objAerolineaBE = objAerolineaDALC.ObtenerAerolineaBE(dr.GetInt32(dr.GetOrdinal("CodAerolinea")));
                    obj.ObjAerolinea = objAerolineaBE;
                }

                cmd.Connection.Close();
                cmd.Dispose();

                Conn.Dispose();

                return obj;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }

        }

        public override List<CobroEstacionamientoBE> ListarCobroEstacionamientoBE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlCobroEstacionamientoBEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlCobroEstacionamientoBEListar = "uspListarCobroEstacionamiento";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlCobroEstacionamientoBEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<CobroEstacionamientoBE> lst;
                lst = new List<CobroEstacionamientoBE>();

                CobroEstacionamientoBE obj;

                while (dr.Read())
                {
                    obj = new CobroEstacionamientoBE();
                    obj.CodEstacionamiento = dr.GetInt32(dr.GetOrdinal("CodEstacionamiento"));
                    obj.Duracion = dr.GetInt32(dr.GetOrdinal("Duracion"));
                    obj.Impuesto = (float)dr.GetDouble(dr.GetOrdinal("Impuesto"));
                    obj.FechaInicio = dr.GetDateTime(dr.GetOrdinal("FechaInicio"));
                    obj.FechaFin = dr.GetDateTime(dr.GetOrdinal("FechaFin"));
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();
                    AvionBE objAvionBE = objAvionDALC.ObtenerAvionBE(dr.GetInt32(dr.GetOrdinal("CodAvion")));
                    obj.ObjAvion = objAvionBE;
                    AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                    AerolineaBE objAerolineaBE = objAerolineaDALC.ObtenerAerolineaBE(dr.GetInt32(dr.GetOrdinal("CodAerolinea")));
                    obj.ObjAerolinea = objAerolineaBE;
                    lst.Add(obj);
                }

                cmd.Connection.Close();
                cmd.Dispose();

                Conn.Dispose();

                return lst;
            }
            catch (Exception ex)
            {
                Conn.Dispose();
                throw ex;
            }

        }
    }
}