using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class CobroEstacionamientoBE
    {
        private int codEstacionamiento;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int duracion;
        private AerolineaBE objAerolinea;                
        private float impuesto;
        private AvionBE objAvion;

        public AvionBE ObjAvion
        {
            get { return objAvion; }
            set { objAvion = value; }
        }

        public AerolineaBE ObjAerolinea
        {
            get { return objAerolinea; }
            set { objAerolinea = value; }
        }

        public float Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public int CodEstacionamiento
        {
            get { return codEstacionamiento; }
            set { codEstacionamiento = value; }
        }
    }
}
