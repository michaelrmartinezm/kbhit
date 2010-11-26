using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class AeropuertoBE
    {
        private int codAeropuerto;

        public int CodAeropuerto
        {
            get { return codAeropuerto; }
            set { codAeropuerto = value; }
        }
        private String estado;

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private String ciudad;

        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        private String iata;

        public String Iata
        {
            get { return iata; }
            set { iata = value; }
        }
        private String oaci;

        public String Oaci
        {
            get { return oaci; }
            set { oaci = value; }
        }
        private int elevacion;

        public int Elevacion
        {
            get { return elevacion; }
            set { elevacion = value; }
        }
        private int sei;

        public int Sei
        {
            get { return sei; }
            set { sei = value; }
        }
        private int fuel;

        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        private String operacion;

        public String Operacion
        {
            get { return operacion; }
            set { operacion = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}
