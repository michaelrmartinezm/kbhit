using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class DestinoBC
    {

        public int RegistrarDestino(DestinoBE objDestinoBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                DestinoDALC objDestinoDALC = FabricaDALC.getDestinoDALC();
                result = objDestinoDALC.InsertarDestinoBE(objDestinoBE);

                if (result != 0)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = result;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                    objLogBE.Tabla = "Destino";
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

        public DestinoBE ObtenerDestino(int codigo)
        {
            DestinoBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                DestinoDALC objDestinoDALC = FabricaDALC.getDestinoDALC();
                obj = objDestinoDALC.ObtenerDestinoBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = obj.CodDestino;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un registro del sistema";
                    objLogBE.Tabla = "Destino";
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

        //public void ActualizarDestino(DestinoBE objDestinoBE)
        //{
        //    try
        //    {
        //        DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
        //        DestinoDALC objDestinoDALC = FabricaDALC.getDestinoDALC();
        //        objDestinoDALC.ActualizarDestinoBE(objDestinoBE);
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        public List<DestinoBE> ListarDestinos()
        {
            List<DestinoBE> lsDestinos = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                DestinoDALC objDestinoDALC = FabricaDALC.getDestinoDALC();
                lsDestinos = objDestinoDALC.ListarDestinoBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsDestinos;
        }
    }
}