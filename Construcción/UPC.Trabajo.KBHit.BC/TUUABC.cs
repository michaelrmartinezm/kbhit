using System;
using System.Collections.Generic;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class TUUABC
    {
        public int RegistrarTUUA(TUUABE objTUUABE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TUUADALC objTUUADALC = FabricaDALC.getTUUA();
                TipoVueloDALC objTipoVueloDALC = FabricaDALC.getTipoVuelo();
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();

                Boolean _state = false;
                Boolean state_ = false;

                List<AerolineaBE> lstAerolinea = objAerolineaDALC.ListarAerolineaBE();                
                foreach (AerolineaBE cDto in lstAerolinea)
                {
                    if (cDto.Nombre == objTUUABE.ObjAerolineaBE.Nombre)
                    {
                        objTUUABE.ObjAerolineaBE.CodAerolinea = cDto.CodAerolinea;
                        _state = true;
                        break;
                    }
                }

                List<TipoVueloBE> lstTipoVuelo = objTipoVueloDALC.ListarTipoVueloBE();
                state_ = false;
                foreach (TipoVueloBE cDto in lstTipoVuelo)
                {
                    if (cDto.CodTipoVuelo == objTUUABE.ObjTipoVueloBE.CodTipoVuelo)
                    {
                        objTUUABE.Impuesto = cDto.Impuesto;
                        state_ = true;
                        break;
                    }
                }

                if (_state == true && state_ == true)
                {
                    result = objTUUADALC.InsertarTUUABE(objTUUABE);
                    
                    if (result != 0)
                    {
                        //Guardar el registro;
                        LogBC objLogBC = new LogBC();
                        LogBE objLogBE = new LogBE();
                        objLogBE.CodOperacion = result;
                        objLogBE.Fecha = DateTime.Now;
                        objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                        objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                        objLogBE.Tabla = "TUUA";
                        objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                        int r = (objLogBC.RegistrarLog(objLogBE));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public TUUABE ObtenerTUUA(int codigo)
        {
            TUUABE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TUUADALC objTUUADALC = FabricaDALC.getTUUA();
                obj = objTUUADALC.ObtenerTUUABE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un nuevo registro del sistema";
                    objLogBE.Tabla = "TUUA";
                    objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                    int r = (objLogBC.RegistrarLog(objLogBE));
                    return obj; 
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TUUABE> ListarTUUAs()
        {
            List<TUUABE> lsTUUAs = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TUUADALC objTUUADALC = FabricaDALC.getTUUA();
                lsTUUAs = objTUUADALC.ListarTUUABE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsTUUAs;
        }
    }
}