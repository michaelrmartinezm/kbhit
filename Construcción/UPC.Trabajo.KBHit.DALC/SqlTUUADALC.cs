using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlTUUADALC : TUUADALC
    {
        public override int InsertarTUUABE(TUUABE objTUUABE)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTUUABEInsertar;

            SqlParameter codTUUA;
            SqlParameter codBoleto;
            SqlParameter codVuelo;
            SqlParameter impuesto;
            SqlParameter codTipoVuelo;
            SqlParameter codAerolinea;
            SqlParameter fecha;
            
            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTUUABEInsertar = "uspTUUAInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTUUABEInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codTUUA = cmd.CreateParameter();
                codTUUA.SqlDbType = SqlDbType.Int;
                codTUUA.Direction = ParameterDirection.ReturnValue;

                codBoleto = cmd.CreateParameter();
                codBoleto.ParameterName = "@CodBoleto";
                codBoleto.SqlDbType = SqlDbType.Int;
                codBoleto.Value = objTUUABE.CodBoleto;

                codVuelo = cmd.CreateParameter();
                codVuelo.ParameterName = "@CodVuelo";
                codVuelo.SqlDbType = SqlDbType.Int;
                codVuelo.Value = objTUUABE.CodVuelo;
                
                impuesto = cmd.CreateParameter();
                impuesto.ParameterName = "@Impuesto";
                impuesto.SqlDbType = SqlDbType.Float;
                impuesto.Value = objTUUABE.Impuesto;

                codTipoVuelo = cmd.CreateParameter();
                codTipoVuelo.ParameterName = "@codTipoVuelo";
                codTipoVuelo.SqlDbType = SqlDbType.Int;
                codTipoVuelo.Value = objTUUABE.ObjTipoVueloBE.CodTipoVuelo;

                codAerolinea = cmd.CreateParameter();
                codAerolinea.ParameterName = "@CodAerolinea";
                codAerolinea.SqlDbType = SqlDbType.Int;
                codAerolinea.Value = objTUUABE.ObjAerolineaBE.CodAerolinea;

                fecha = cmd.CreateParameter();
                fecha.ParameterName = "@fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.SqlValue = objTUUABE.Fecha;

                cmd.Parameters.Add(codTUUA);
                cmd.Parameters.Add(codBoleto);
                cmd.Parameters.Add(codVuelo);
                cmd.Parameters.Add(impuesto);
                cmd.Parameters.Add(codTipoVuelo);
                cmd.Parameters.Add(codAerolinea);
                cmd.Parameters.Add(fecha);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iCod = Convert.ToInt32(codTUUA.Value);
                
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

        public override TUUABE ObtenerTUUABE(int IdTUUA)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTUUABEObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlTUUABEObtener = "uspTUUAObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTUUABEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodTUUA";
                id.SqlDbType = SqlDbType.Int;
                id.Value = IdTUUA;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                TUUABE obj;
                obj = new TUUABE();

                if (dr.Read())
                {
                    obj.CodTUUA = dr.GetInt32(dr.GetOrdinal("CodTUUA"));
                    obj.CodBoleto = dr.GetInt32(dr.GetOrdinal("CodBoleto"));
                    obj.CodVuelo = dr.GetInt32(dr.GetOrdinal("CodVuelo"));
                    obj.Impuesto = dr.GetFloat(dr.GetOrdinal("Impuesto"));
                    obj.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    TipoVueloDALC objTipoVueloDALC = FabricaDALC.getTipoVuelo();
                    TipoVueloBE objTipoVueloBE = objTipoVueloDALC.ObtenerTipoVueloBE(dr.GetInt32(dr.GetOrdinal("CodTipoVuelo")));
                    obj.ObjTipoVueloBE = objTipoVueloBE;
                    AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                    AerolineaBE objAerolineaBE = objAerolineaDALC.ObtenerAerolineaBE(dr.GetInt32(dr.GetOrdinal("CodAerolinea")));
                    obj.ObjAerolineaBE = objAerolineaBE;
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

        public override List<TUUABE> ListarTUUABE()
        {
            SqlDataReader dr;
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlTUUABEListar;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);
                sqlTUUABEListar = "uspTUUAListar";
                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlTUUABEListar;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                List<TUUABE> lst;
                lst = new List<TUUABE>();

                TUUABE obj;

                while (dr.Read())
                {
                    obj = new TUUABE();
                    obj.CodTUUA = dr.GetInt32(dr.GetOrdinal("CodTUUA"));
                    obj.CodBoleto = dr.GetInt32(dr.GetOrdinal("CodBoleto"));
                    obj.CodVuelo = dr.GetInt32(dr.GetOrdinal("CodVuelo"));
                    obj.Impuesto = (float)dr.GetDouble(dr.GetOrdinal("Impuesto"));
                    obj.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    TipoVueloDALC objTipoVueloDALC = FabricaDALC.getTipoVuelo();
                    TipoVueloBE objTipoVueloBE = objTipoVueloDALC.ObtenerTipoVueloBE(dr.GetInt32(dr.GetOrdinal("CodTipoVuelo")));
                    obj.ObjTipoVueloBE = objTipoVueloBE;
                    AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                    AerolineaBE objAerolineaBE = objAerolineaDALC.ObtenerAerolineaBE(dr.GetInt32(dr.GetOrdinal("CodAerolinea")));
                    obj.ObjAerolineaBE = objAerolineaBE;
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