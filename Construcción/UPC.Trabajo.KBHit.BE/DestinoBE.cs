using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class DestinoBE
    {
        private int codDestino;
        private int codPlanVuelo;
        private String tiempoHr;
        private String tiempoMin;
        private int codAerodromo;
        private int codAerodromoAlter;
        private int codAerodromo2Alter;

        public int CodDestino
        {
            get { return codDestino; }
            set { codDestino = value; }
        }
        
        public int CodPlanVuelo
        {
            get { return codPlanVuelo; }
            set { codPlanVuelo = value; }
        }
        
        public String TiempoHr
        {
            get { return tiempoHr; }
            set { tiempoHr = value; }
        }
        
        public String TiempoMin
        {
            get { return tiempoMin; }
            set { tiempoMin = value; }
        }
        
        public int CodAerodromo
        {
            get { return codAerodromo; }
            set { codAerodromo = value; }
        }
        
        public int CodAerodromoAlter
        {
            get { return codAerodromoAlter; }
            set { codAerodromoAlter = value; }
        }
        
        public int CodAerodromo2Alter
        {
            get { return codAerodromo2Alter; }
            set { codAerodromo2Alter = value; }
        }
    }
}
