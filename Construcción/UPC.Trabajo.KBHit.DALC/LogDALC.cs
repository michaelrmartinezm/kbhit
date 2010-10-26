using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class LogDALC
    {
        public abstract int InsertarLogBE(LogBE obj);
        public abstract List<LogBE> ListarLogBE();
        public abstract List<LogBE> ListarLogBETabla(String Tabla);
        public abstract List<LogBE> ListarLogBEUsuario(String Usuario);
        public abstract List<LogBE> ListarLogBEFecha(DateTime Fecha);
        public abstract List<LogBE> ListarLogBEIP(String IP);
    }
}
