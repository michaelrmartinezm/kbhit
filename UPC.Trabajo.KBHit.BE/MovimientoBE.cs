using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class MovimientoBE
    {
        private int codMovimiento;
        private int codTipoMovimiento;
        private int codAerolinea;
        private int codAvion;
        private String detalle;
        private int codAeropuertoOrigen;
        private int codAeropuertoDestino;

        public int CodAeropuertoOrigen
        {
            get { return codAeropuertoOrigen; }
            set { codAeropuertoOrigen = value; }
        }
        
        public int CodAeropuertoDestino
        {
            get { return codAeropuertoDestino; }
            set { codAeropuertoDestino = value; }
        }

        public int CodMovimiento
        {
            get { return codMovimiento; }
            set { codMovimiento = value; }
        }
        
        public int CodTipoMovimiento
        {
            get { return codTipoMovimiento; }
            set { codTipoMovimiento = value; }
        }
        
        public int CodAerolinea
        {
            get { return codAerolinea; }
            set { codAerolinea = value; }
        }
        
        public int CodAvion
        {
            get { return codAvion; }
            set { codAvion = value; }
        }
        
        public String Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }




        //Variables para manejo del BC respectivo
        public String Movimiento { get; set; }
        public String Aerolinea { get; set; }
        public String Avion { get; set; }
        public String AeropuertoOrigen { get; set; }
        public String AeropuertoDestino { get; set; }

    }
}
