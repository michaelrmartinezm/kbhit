using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class AerolineaBC
    {     
        public int RegistrarAerolinea(AerolineaBE objAerolineaBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                result = objAerolineaDALC.InsertarAerolineaBE(objAerolineaBE);

                if(result!=0)
                {   
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = result;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                    objLogBE.Tabla = "Aerolinea";
                    objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                    int r = (objLogBC.RegistrarLog(objLogBE));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public AerolineaBE ObtenerAerolinea(int codigo)
        {
            AerolineaBE obj=null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                obj = objAerolineaDALC.ObtenerAerolineaBE(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public void ActualizarAerolinea(AerolineaBE objAerolineaBE)
        {
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                objAerolineaDALC.ActualizarAerolineaBE(objAerolineaBE);

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objAerolineaBE.CodAerolinea;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Actualización de un nuevo registro en el sistema";
                objLogBE.Tabla = "Aerolinea";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AerolineaBE> ListarAerolineas()
        {
            List<AerolineaBE> lsAerolineas = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                lsAerolineas = objAerolineaDALC.ListarAerolineaBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsAerolineas;
        }
    }
}