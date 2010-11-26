using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlIPAeropuertoDALC : IPAeropuertoDALC
    {
        public override IPAeropuertoBE ObtenerIPAeropuerto(String IP)
        {
            SqlConnection Conn = null;
            SqlCommand cmd = null;
            String sqlIPAeropuertoBEObtener;

            SqlParameter ip;
            SqlDataReader dr;

            try
            {
                Conn = new SqlConnection(Properties.Settings.Default.sCadenaConexion);

                sqlIPAeropuertoBEObtener = "uspIPAeropuertoObtener";

                cmd = Conn.CreateCommand();
                cmd.CommandText = sqlIPAeropuertoBEObtener;
                cmd.CommandType = CommandType.StoredProcedure;

                ip = cmd.CreateParameter();
                ip.ParameterName = "@IP";
                ip.SqlDbType = SqlDbType.VarChar;
                ip.Size = 30;
                ip.SqlValue = IP;

                cmd.Parameters.Add(ip);

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                IPAeropuertoBE obj;
                obj = new IPAeropuertoBE();

                if (dr.Read())
                {
                    obj.IP = dr.GetString(dr.GetOrdinal("IP"));
                    obj.CodAeropuerto = dr.GetInt32(dr.GetOrdinal("CodAeropuerto"));
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
    }
}