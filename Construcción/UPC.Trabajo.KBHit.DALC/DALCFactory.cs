using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class DALCFactory
    {
        public const int SQL = 1;

        public abstract AerolineaDALC getAerolineaDALC();
        public abstract AeropuertoDALC getAeropuertoDALC();
        public abstract AvionDALC getAvionDALC();
        public abstract DestinoDALC getDestinoDALC();
        public abstract InformacionVueloDALC getInformacionVueloDALC();
        public abstract MovimientoDALC getMovimientoDALC();
        public abstract PistaDALC getPistaDALC();
        public abstract PlanVueloDALC getPlanVueloDALC();
        public abstract PlataformaDALC getPlataformaDALC();
        public abstract SalidaDALC getSalidaDALC();
        public abstract TipoMovimientoDALC getTipoMovimientoDALC();
        public abstract LogDALC getLogDALC();
        public abstract ExcepcionDALC getExcepcionDALC();
        public abstract IPAeropuertoDALC getIPAeropuerto();
        public abstract TipoVueloDALC getTipoVuelo();
        public abstract TUUADALC getTUUA();
        public abstract FacturaDALC getFacturaDALC();

        public static DALCFactory getFabrica(int iTipoFabrica)
        {
            switch (iTipoFabrica)
            {
                case SQL: return SqlDALCFactory.getFabrica();
                default: return null;
            }
        }
    }
}