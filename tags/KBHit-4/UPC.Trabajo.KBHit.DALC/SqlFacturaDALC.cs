using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlFacturaDALC : FacturaDALC
    {
        public override int InsertarFactura(FacturaBE obj)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String SqlFacturaInsertar;

            SqlParameter codFactura;
            SqlParameter codAerolinea;
            SqlParameter monto;
            SqlParameter fecha;
            SqlParameter descripcion;

            int iCod;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                SqlFacturaInsertar = "uspFacturaInsertar";

                cmd = Conn.CreateCommand();
                cmd.CommandText = SqlFacturaInsertar;
                cmd.CommandType = CommandType.StoredProcedure;

                codFactura = cmd.CreateParameter();
                codFactura.SqlDbType = SqlDbType.Int;
                codFactura.Direction = ParameterDirection.ReturnValue;

                codAerolinea = cmd.CreateParameter();
                codAerolinea.ParameterName = "@CodAerolinea";
                codAerolinea.SqlDbType = SqlDbType.Int;
                codAerolinea.Value = obj.ObjAerolinea.CodAerolinea;

                fecha = cmd.CreateParameter();
                fecha.ParameterName = "@Fecha";
                fecha.SqlDbType = SqlDbType.DateTime;
                fecha.SqlValue = obj.Fecha;
                
                monto = cmd.CreateParameter();
                monto.ParameterName = "@Monto";
                monto.SqlDbType = SqlDbType.Float;
                monto.Value = obj.Monto;

                descripcion = cmd.CreateParameter();
                descripcion.ParameterName = "@Descripcion";
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 100;
                descripcion.Value = obj.Descripcion;
                             
                cmd.Parameters.Add(codFactura);
                cmd.Parameters.Add(codAerolinea);
                cmd.Parameters.Add(monto);
                cmd.Parameters.Add(fecha);
                cmd.Parameters.Add(descripcion);
                
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                iCod = Convert.ToInt32(codFactura.Value);

                cmd.Connection.Close();

                cmd.Dispose();
                Conn.Dispose();

                return iCod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override FacturaBE ObtenerFactura(int iCod)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String SqlFacturaObtener;

            SqlParameter id;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                SqlFacturaObtener = "uspFacturaObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = SqlFacturaObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                id = cmd.CreateParameter();
                id.ParameterName = "@CodFactura";
                id.SqlDbType = SqlDbType.Int;
                id.Value = iCod;

                cmd.Parameters.Add(id);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                FacturaBE obj;
                obj = new FacturaBE();

                if (dr.Read())
                {
                    obj.CodFactura = dr.GetInt32(dr.GetOrdinal("CodFactura"));
                    obj.Monto = (float)dr.GetDecimal(dr.GetOrdinal("Monto"));
                    obj.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    obj.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
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
                throw ex;
            }
        }
    }
}
