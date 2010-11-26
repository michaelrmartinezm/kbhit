using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class InformacionVueloBC
    {

        public int RegistrarInformacionVuelo(InformacionVueloBE objInformacionVueloBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                InformacionVueloDALC objInformacionVueloDALC = FabricaDALC.getInformacionVueloDALC();
                result = objInformacionVueloDALC.InsertarInformacionVueloBE(objInformacionVueloBE);

                if (result != 0)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = result;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                    objLogBE.Tabla = "InformacionVuelo";
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

        public InformacionVueloBE ObtenerInformacionVuelo(int codigo)
        {
            InformacionVueloBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                InformacionVueloDALC objInformacionVueloDALC = FabricaDALC.getInformacionVueloDALC();
                obj = objInformacionVueloDALC.ObtenerInformacionVueloBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un registro del sistema";
                    objLogBE.Tabla = "InformacionVuelo";
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

        //public void ActualizarInformacionVuelo(InformacionVueloBE objInformacionVueloBE)
        //{
        //    try
        //    {
        //        DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
        //        InformacionVueloDALC objInformacionVueloDALC = FabricaDALC.getInformacionVueloDALC();
        //        objInformacionVueloDALC.ActualizarInformacionVueloBE(objInformacionVueloBE);
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        public List<InformacionVueloBE> ListarInformacionVuelos()
        {
            List<InformacionVueloBE> lsInformacionVuelos = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                InformacionVueloDALC objInformacionVueloDALC = FabricaDALC.getInformacionVueloDALC();
                lsInformacionVuelos = objInformacionVueloDALC.ListarInformacionVueloBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsInformacionVuelos;
        }
    }
}