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
    public class SqlFuncionalidadDALC:FuncionalidadDALC
    {
        public override int FuncionalidadInsertar(FuncionalidadBE objFuncionalidadBE) 
        {
            SqlConnection Conn = null;
            SqlCommand cmdFuncionalidadInsertar = null;
            String sCadena;
            String sqlFuncionalidadInsertar;
            SqlParameter prmIdFuncionalidad;
            SqlParameter prmNombreFuncionalidad;
            SqlParameter prmReferencia;
            SqlParameter prmIdAplicacion;
            int idFuncionalidad;

            try
            {
                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;

                sqlFuncionalidadInsertar = "uspRolUsuarioInsertar";
                Conn = new SqlConnection(sCadena);

                cmdFuncionalidadInsertar = Conn.CreateCommand();
                cmdFuncionalidadInsertar.CommandType = CommandType.StoredProcedure;
                cmdFuncionalidadInsertar.CommandText = sqlFuncionalidadInsertar;

                prmIdFuncionalidad = cmdFuncionalidadInsertar.CreateParameter();
                prmIdFuncionalidad.SqlDbType = SqlDbType.Int;
                prmIdFuncionalidad.Direction = ParameterDirection.ReturnValue;

                prmNombreFuncionalidad = cmdFuncionalidadInsertar.CreateParameter();
                prmNombreFuncionalidad.ParameterName = "@NombreFuncionalidad";
                prmNombreFuncionalidad.SqlDbType = SqlDbType.VarChar;
                prmNombreFuncionalidad.Size = 100;
                prmNombreFuncionalidad.Value = objFuncionalidadBE.NombreFuncionalidad;

                prmReferencia = cmdFuncionalidadInsertar.CreateParameter();
                prmReferencia.ParameterName = "@Referencia";
                prmReferencia.SqlDbType = SqlDbType.VarChar;
                prmReferencia.Size = 300;
                prmReferencia.Value = objFuncionalidadBE.Referencia;

                prmIdAplicacion = cmdFuncionalidadInsertar.CreateParameter();
                prmIdAplicacion.ParameterName = "@IdAplicacion";
                prmIdAplicacion.SqlDbType = SqlDbType.Int;
                prmIdAplicacion.Value = objFuncionalidadBE.ObjAplicacionBE.IdAplicacion;

                cmdFuncionalidadInsertar.Parameters.Add(prmIdFuncionalidad);
                cmdFuncionalidadInsertar.Parameters.Add(prmNombreFuncionalidad);
                cmdFuncionalidadInsertar.Parameters.Add(prmReferencia);
                cmdFuncionalidadInsertar.Parameters.Add(prmIdAplicacion);

                cmdFuncionalidadInsertar.Connection.Open();
                cmdFuncionalidadInsertar.ExecuteNonQuery();
                idFuncionalidad = Convert.ToInt32(prmIdFuncionalidad.Value);
                cmdFuncionalidadInsertar.Connection.Close();

                cmdFuncionalidadInsertar.Dispose();
                Conn.Dispose();

                return idFuncionalidad;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        }
        public override FuncionalidadBE FuncionalidadObtener(int IdFuncionalidad) 
        {
            SqlConnection Conn = null;
            SqlCommand cmdFuncionalidadObtener = null;
            String sCadena;
            String sqlFuncionalidadObtener;
            SqlParameter prmIdFuncionalidad;
            SqlDataReader drFuncionalidad;

            try
            {
                FuncionalidadBE objFuncionalidadBE = new FuncionalidadBE();

                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;
                Conn = new SqlConnection(sCadena);

                sqlFuncionalidadObtener = "uspFuncionalidadObtener";
                cmdFuncionalidadObtener = Conn.CreateCommand();
                cmdFuncionalidadObtener.CommandText = sqlFuncionalidadObtener;
                cmdFuncionalidadObtener.CommandType = CommandType.StoredProcedure;

                prmIdFuncionalidad = cmdFuncionalidadObtener.CreateParameter();
                prmIdFuncionalidad.ParameterName = "@IdFuncionalidad";
                prmIdFuncionalidad.SqlDbType = SqlDbType.Int;
                prmIdFuncionalidad.Value = IdFuncionalidad;

                cmdFuncionalidadObtener.Parameters.Add(prmIdFuncionalidad);

                cmdFuncionalidadObtener.Connection.Open();
                drFuncionalidad = cmdFuncionalidadObtener.ExecuteReader();

                if (drFuncionalidad.Read())
                {
                    objFuncionalidadBE.IdFuncionalidad = drFuncionalidad.GetInt32(drFuncionalidad.GetOrdinal("IdFuncionalidad"));
                    objFuncionalidadBE.NombreFuncionalidad = drFuncionalidad.GetString(drFuncionalidad.GetOrdinal("NombreFuncionalidad"));
                    objFuncionalidadBE.Referencia = drFuncionalidad.GetString(drFuncionalidad.GetOrdinal("Referencia"));
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    AplicacionDALC objAplicacionDALC = FabricaDALC.getAplicacionDALC();
                    AplicacionBE objAplicacionBE = objAplicacionDALC.AplicacionObtenerXCodigo(drFuncionalidad.GetInt32(drFuncionalidad.GetOrdinal("IdAplicacion")));
                    objFuncionalidadBE.ObjAplicacionBE = objAplicacionBE;
                    
                }

                cmdFuncionalidadObtener.Connection.Close();
                cmdFuncionalidadObtener.Dispose();

                Conn.Dispose();

                return objFuncionalidadBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        
        }
        public override List<FuncionalidadBE> FuncionalidadListar() 
        {
            SqlConnection Conn = null;
            SqlCommand cmdFuncionalidadListar = null;
            String sCadena;
            String sqlFuncionalidadListar;
            SqlDataReader drFuncionalidad;

            try
            {
                List<FuncionalidadBE> lsFuncionalidadBE = null;

                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;
                Conn = new SqlConnection(sCadena);

                sqlFuncionalidadListar = "uspFuncionalidadListar";
                cmdFuncionalidadListar = Conn.CreateCommand();
                cmdFuncionalidadListar.CommandText = sqlFuncionalidadListar;
                cmdFuncionalidadListar.CommandType = CommandType.StoredProcedure;

                cmdFuncionalidadListar.Connection.Open();
                drFuncionalidad = cmdFuncionalidadListar.ExecuteReader();

                while (drFuncionalidad.Read())
                {
                    if(lsFuncionalidadBE==null)
                        lsFuncionalidadBE=new List<FuncionalidadBE>();
                    FuncionalidadBE objFuncionalidadBE = new FuncionalidadBE();
                    objFuncionalidadBE.IdFuncionalidad = drFuncionalidad.GetInt32(drFuncionalidad.GetOrdinal("IdFuncionalidad"));
                    objFuncionalidadBE.NombreFuncionalidad = drFuncionalidad.GetString(drFuncionalidad.GetOrdinal("NombreFuncionalidad"));
                    objFuncionalidadBE.Referencia = drFuncionalidad.GetString(drFuncionalidad.GetOrdinal("Referencia"));
                    DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                    AplicacionDALC objAplicacionDALC = FabricaDALC.getAplicacionDALC();
                    AplicacionBE objAplicacionBE=objAplicacionDALC.AplicacionObtenerXCodigo(drFuncionalidad.GetInt32(drFuncionalidad.GetOrdinal("IdAplicacion")));
                    objFuncionalidadBE.ObjAplicacionBE = objAplicacionBE;
                    lsFuncionalidadBE.Add(objFuncionalidadBE);
                }

                cmdFuncionalidadListar.Connection.Close();
                cmdFuncionalidadListar.Dispose();

                Conn.Dispose();

                return lsFuncionalidadBE;
            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            } 
        
        }
        public override void FuncionalidadActualizar(FuncionalidadBE objFuncionalidadBE) 
        {
            SqlConnection Conn = null;
            SqlCommand cmdFuncionalidadActualizar = null;
            String sCadena;
            String sqlFuncionalidadActualizar;
            SqlParameter prmIdFuncionalidad;
            SqlParameter prmNombreFuncionalidad;
            SqlParameter prmReferencia;
            SqlParameter prmIdAplicacion;

            try
            {
                sCadena = ConfigurationManager.ConnectionStrings["ConexionSeguridad"].ConnectionString;
                Conn = new SqlConnection(sCadena);

                sqlFuncionalidadActualizar = "uspFuncionalidadActualizar";
                cmdFuncionalidadActualizar = Conn.CreateCommand();
                cmdFuncionalidadActualizar.CommandText = sqlFuncionalidadActualizar;
                cmdFuncionalidadActualizar.CommandType = CommandType.StoredProcedure;

                prmIdFuncionalidad = cmdFuncionalidadActualizar.CreateParameter();
                prmIdFuncionalidad.ParameterName = "@IdFuncionalidad";
                prmIdFuncionalidad.SqlDbType = SqlDbType.Int;
                prmIdFuncionalidad.Value = objFuncionalidadBE.IdFuncionalidad;

                prmNombreFuncionalidad = cmdFuncionalidadActualizar.CreateParameter();
                prmNombreFuncionalidad.ParameterName = "@NombreFuncionalidad";
                prmNombreFuncionalidad.SqlDbType = SqlDbType.VarChar;
                prmNombreFuncionalidad.Size = 100;
                prmNombreFuncionalidad.Value = objFuncionalidadBE.NombreFuncionalidad;

                prmReferencia = cmdFuncionalidadActualizar.CreateParameter();
                prmReferencia.ParameterName = "@Referencia";
                prmReferencia.SqlDbType = SqlDbType.VarChar;
                prmReferencia.Size = 300;
                prmReferencia.Value = objFuncionalidadBE.Referencia;

                prmIdAplicacion = cmdFuncionalidadActualizar.CreateParameter();
                prmIdAplicacion.ParameterName = "@IdAplicacion";
                prmIdAplicacion.SqlDbType = SqlDbType.Int;
                prmIdAplicacion.Value = objFuncionalidadBE.ObjAplicacionBE.IdAplicacion;

                cmdFuncionalidadActualizar.Parameters.Add(prmIdFuncionalidad);
                cmdFuncionalidadActualizar.Parameters.Add(prmNombreFuncionalidad);
                cmdFuncionalidadActualizar.Parameters.Add(prmReferencia);
                cmdFuncionalidadActualizar.Parameters.Add(prmIdAplicacion);
                cmdFuncionalidadActualizar.Connection.Open();

                cmdFuncionalidadActualizar.Connection.Close();
                cmdFuncionalidadActualizar.Dispose();

                Conn.Dispose();

            }
            catch (Exception e)
            {
                Conn.Dispose();
                throw e;
            }
        
        }
    }
}
