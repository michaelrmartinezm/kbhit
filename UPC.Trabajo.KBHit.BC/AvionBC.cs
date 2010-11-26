using System;
using System.Collections.Generic;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class AvionBC
    {
   
        public int RegistrarAvion(AvionBE objAvionBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();
                result = objAvionDALC.InsertarAvionBE(objAvionBE);

                if (result != 0)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = result;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                    objLogBE.Tabla = "Avion";
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

        public AvionBE ObtenerAvion(int codigo)
        {
            AvionBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();
                obj = objAvionDALC.ObtenerAvionBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un registro del sistema";
                    objLogBE.Tabla = "Avion";
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

        public void ActualizarAvion(AvionBE objAvionBE)
        {
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();
                objAvionDALC.ActualizarAvionBE(objAvionBE);

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objAvionBE.CodAvion;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Se actualizó un registro del sistema";
                objLogBE.Tabla = "Avion";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AvionBE> ListarAviones()
        {
            List<AvionBE> lsAviones = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();
                lsAviones = objAvionDALC.ListarAvionBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsAviones;
        }
    }
}