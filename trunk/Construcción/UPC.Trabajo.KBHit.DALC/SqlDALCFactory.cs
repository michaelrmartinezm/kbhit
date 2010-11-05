using System;

namespace UPC.Trabajo.KBHit.DALC
{
    public class SqlDALCFactory:DALCFactory
    {
        private SqlDALCFactory()
        {

        }

        private static SqlDALCFactory instancia = null;

        public static SqlDALCFactory getFabrica()
        {
            if (instancia == null)
                instancia = new SqlDALCFactory();
            return instancia;
        }

        public override AerolineaDALC getAerolineaDALC() 
        { 
            return new SqlAerolineaDALC(); 
        }

        public override AeropuertoDALC getAeropuertoDALC() 
        {
            return new SqlAeropuertoDALC(); 
        }

        public override AvionDALC getAvionDALC() 
        {
            return new SqlAvionDALC(); 
        }

        public override DestinoDALC getDestinoDALC()
        {
            return new SqlDestinoDALC(); 
        }

        public override InformacionVueloDALC getInformacionVueloDALC() 
        { 
            return new SqlInformacionVueloDALC(); 
        }

        public override MovimientoDALC getMovimientoDALC() 
        { 
            return new SqlMovimientoDALC(); 
        }

        public override PistaDALC getPistaDALC() 
        {
            return new SqlPistaDALC(); 
        }

        public override PlanVueloDALC getPlanVueloDALC() 
        {
            return new SqlPlanVueloDALC(); 
        }

        public override PlataformaDALC getPlataformaDALC() 
        {
            return new SqlPlataformaDALC(); 
        }

        public override SalidaDALC getSalidaDALC() 
        {
            return new SqlSalidaDALC(); 
        }

        public override TipoMovimientoDALC getTipoMovimientoDALC() 
        {
            return new SqlTipoMovimientoDALC(); 
        }

        public override LogDALC getLogDALC()
        {
            return new SqlLogDALC();
        }

        public override ExcepcionDALC getExcepcionDALC()
        {
            return new SqlExcepcionDALC();
        }

        public override IPAeropuertoDALC getIPAeropuerto()
        {
            return new SqlIPAeropuertoDALC();
        }

        public override TipoVueloDALC getTipoVuelo()
        {
            return new SqlTipoVueloDALC();
        }

        public override TUUADALC getTUUA()
        {
            return new SqlTUUADALC();
        }
    }
}