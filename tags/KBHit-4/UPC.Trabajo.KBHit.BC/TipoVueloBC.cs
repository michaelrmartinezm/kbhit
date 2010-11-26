using System;
using System.Collections.Generic;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class TipoVueloBC
    {

        public int RegistrarTipoVuelo(TipoVueloBE objTipoVueloBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TipoVueloDALC objTipoVueloDALC = FabricaDALC.getTipoVuelo();
                result = objTipoVueloDALC.InsertarTipoVueloBE(objTipoVueloBE);

                if (result != 0)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = result;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                    objLogBE.Tabla = "TipoVuelo";
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

        public TipoVueloBE ObtenerTipoVuelo(int codigo)
        {
            TipoVueloBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TipoVueloDALC objTipoVueloDALC = FabricaDALC.getTipoVuelo();
                obj = objTipoVueloDALC.ObtenerTipoVueloBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un registro del sistema";
                    objLogBE.Tabla = "TipoVuelo";
                    objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                    int r = (objLogBC.RegistrarLog(objLogBE));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public void ActualizarTipoVuelo(TipoVueloBE objTipoVueloBE)
        {
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TipoVueloDALC objTipoVueloDALC = FabricaDALC.getTipoVuelo();
                objTipoVueloDALC.ActualizarTipoVueloBE(objTipoVueloBE);

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objTipoVueloBE.CodTipoVuelo;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Se actualizó un registro del sistema";
                objLogBE.Tabla = "TipoVuelo";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}