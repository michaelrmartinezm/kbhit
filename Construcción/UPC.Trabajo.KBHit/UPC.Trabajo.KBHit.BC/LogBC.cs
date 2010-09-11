using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class LogBC
    {

        public int RegistrarLog(LogBE objLogBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                LogDALC objLogDALC = FabricaDALC.getLogDALC();
                result = objLogDALC.InsertarLogBE(objLogBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<LogBE> ListarLogs()
        {
            List<LogBE> lsLogs = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                LogDALC objLogDALC = FabricaDALC.getLogDALC();
                lsLogs = objLogDALC.ListarLogBE();
            }
            catch (Exception ex)
            {
            }
            return lsLogs;
        }

        public List<LogBE> ListarLogsTabla(String Tabla)
        {
            List<LogBE> lsLogs = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                LogDALC objLogDALC = FabricaDALC.getLogDALC();
                lsLogs = objLogDALC.ListarLogBETabla(Tabla);
            }
            catch (Exception ex)
            {
            }
            return lsLogs;
        }

        public List<LogBE> ListarLogsUsuario(String Usuario)
        {
            List<LogBE> lsLogs = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                LogDALC objLogDALC = FabricaDALC.getLogDALC();
                lsLogs = objLogDALC.ListarLogBEUsuario(Usuario);
            }
            catch (Exception ex)
            {
            }
            return lsLogs;
        }

        public List<LogBE> ListarLogsIP(String IP)
        {
            List<LogBE> lsLogs = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                LogDALC objLogDALC = FabricaDALC.getLogDALC();
                lsLogs = objLogDALC.ListarLogBEIP(IP);
            }
            catch (Exception ex)
            {
            }
            return lsLogs;
        }

        public List<LogBE> ListarLogsFecha(DateTime Fecha)
        {
            List<LogBE> lsLogs = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                LogDALC objLogDALC = FabricaDALC.getLogDALC();
                lsLogs = objLogDALC.ListarLogBEFecha(Fecha);
            }
            catch (Exception ex)
            {
            }
            return lsLogs;
        }
    }
}