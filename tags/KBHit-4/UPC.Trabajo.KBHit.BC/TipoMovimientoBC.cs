using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class TipoMovimientoBC
    {

        public int RegistrarTipoMovimiento(TipoMovimientoBE objTipoMovimientoBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TipoMovimientoDALC objTipoMovimientoDALC = FabricaDALC.getTipoMovimientoDALC();
                result = objTipoMovimientoDALC.InsertarTipoMovimientoBE(objTipoMovimientoBE);

                if (result != 0)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = result;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                    objLogBE.Tabla = "TipoMovimiento";
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

        public TipoMovimientoBE ObtenerTipoMovimiento(int codigo)
        {
            TipoMovimientoBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TipoMovimientoDALC objTipoMovimientoDALC = FabricaDALC.getTipoMovimientoDALC();
                obj = objTipoMovimientoDALC.ObtenerTipoMovimientoBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un registro del sistema";
                    objLogBE.Tabla = "TipoMovimiento";
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

        public void ActualizarTipoMovimiento(TipoMovimientoBE objTipoMovimientoBE)
        {
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TipoMovimientoDALC objTipoMovimientoDALC = FabricaDALC.getTipoMovimientoDALC();
                objTipoMovimientoDALC.ActualizarTipoMovimientoBE(objTipoMovimientoBE);

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objTipoMovimientoBE.CodTipoMovimiento;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Se actualizó un registro del sistema";
                objLogBE.Tabla = "TipoMovimiento";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipoMovimientoBE> ListarTipoMovimientos()
        {
            List<TipoMovimientoBE> lsTipoMovimientos = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                TipoMovimientoDALC objTipoMovimientoDALC = FabricaDALC.getTipoMovimientoDALC();
                lsTipoMovimientos = objTipoMovimientoDALC.ListarTipoMovimientoBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsTipoMovimientos;
        }
    }
}