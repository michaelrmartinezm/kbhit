using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class AeropuertoBC
    {
        
        public AeropuertoBE ObtenerAeropuerto(int codigo)
        {
            AeropuertoBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AeropuertoDALC objAeropuertoDALC = FabricaDALC.getAeropuertoDALC();
                obj = objAeropuertoDALC.ObtenerAeropuertoBE(codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public AeropuertoBE ObtenerAeropuertoNombre(String nombre)
        {
            AeropuertoBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AeropuertoDALC objAeropuertoDALC = FabricaDALC.getAeropuertoDALC();
                obj = objAeropuertoDALC.ObtenerAeropuertoBENombre(nombre);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = obj.CodAeropuerto;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se trajo un dato con una busqueda por nombre";
                    objLogBE.Tabla = "Aeropuerto";
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

        public void ActualizarAeropuerto(AeropuertoBE objAeropuertoBE)
        {
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AeropuertoDALC objAeropuertoDALC = FabricaDALC.getAeropuertoDALC();
                objAeropuertoDALC.ActualizarAeropuertoBE(objAeropuertoBE);

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objAeropuertoBE.CodAeropuerto;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Se actualizó un registro en el sistema";
                objLogBE.Tabla = "Aeropuerto";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AeropuertoBE> ListarAeropuertos()
        {
            List<AeropuertoBE> lsAeropuertos = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AeropuertoDALC objAeropuertoDALC = FabricaDALC.getAeropuertoDALC();
                lsAeropuertos = objAeropuertoDALC.ListarAeropuertoBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsAeropuertos;
        }
    }
}