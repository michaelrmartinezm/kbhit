using System;
using System.Collections.Generic;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class CobroEstacionamientoBC
    {
        public int RegistrarCobroEstacionamiento(CobroEstacionamientoBE objCobroEstacionamientoBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                CobroEstacionamientoDALC objCobroEstacionamientoDALC = FabricaDALC.getCobroEstacionamientoDALC();
                AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();

                Boolean state = false;

                List<AerolineaBE> lstAerolinea = objAerolineaDALC.ListarAerolineaBE();
                foreach (AerolineaBE cDto in lstAerolinea)
                {
                    if (cDto.Nombre == objCobroEstacionamientoBE.ObjAerolinea.Nombre)
                    {
                        objCobroEstacionamientoBE.ObjAerolinea.CodAerolinea = cDto.CodAerolinea;
                        state = true;
                        break;
                    }
                }

                if (state == true)
                {
                    result = objCobroEstacionamientoDALC.InsertarCobroEstacionamientoBE(objCobroEstacionamientoBE);

                    if (result != 0)
                    {
                        //Guardar el registro;
                        LogBC objLogBC = new LogBC();
                        LogBE objLogBE = new LogBE();
                        objLogBE.CodOperacion = result;
                        objLogBE.Fecha = DateTime.Now;
                        objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                        objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                        objLogBE.Tabla = "CobroEstacionamiento";
                        objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                        int r = (objLogBC.RegistrarLog(objLogBE));
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CobroEstacionamientoBE ObtenerCobroEstacionamiento(int codigo)
        {
            CobroEstacionamientoBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                CobroEstacionamientoDALC objCobroEstacionamientoDALC = FabricaDALC.getCobroEstacionamientoDALC();
                obj = objCobroEstacionamientoDALC.ObtenerCobroEstacionamientoBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un nuevo registro del sistema";
                    objLogBE.Tabla = "CobroEstacionamiento";
                    objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                    int r = (objLogBC.RegistrarLog(objLogBE));
                }

                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CobroEstacionamientoBE> ListarCobroEstacionamientos()
        {
            List<CobroEstacionamientoBE> lsCobroEstacionamientos = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                CobroEstacionamientoDALC objCobroEstacionamientoDALC = FabricaDALC.getCobroEstacionamientoDALC();
                lsCobroEstacionamientos = objCobroEstacionamientoDALC.ListarCobroEstacionamientoBE();

                return lsCobroEstacionamientos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}