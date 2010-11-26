using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class PlataformaBE
    {
        private int codPlataforma;
        private int codAeropuerto;
        private int naves;
        private String pavimento;
        private String pcn;
        private String dimensiones;
        private String naveMaxPermisible;

        public int CodPlataforma
        {
            get { return codPlataforma; }
            set { codPlataforma = value; }
        }
        
        public int CodAeropuerto
        {
            get { return codAeropuerto; }
            set { codAeropuerto = value; }
        }
        
        public int Naves
        {
            get { return naves; }
            set { naves = value; }
        }
        
        public String Pavimento
        {
            get { return pavimento; }
            set { pavimento = value; }
        }
        
        public String Pcn
        {
            get { return pcn; }
            set { pcn = value; }
        }
        
        public String Dimensiones
        {
            get { return dimensiones; }
            set { dimensiones = value; }
        }
        
        public String NaveMaxPermisible
        {
            get { return naveMaxPermisible; }
            set { naveMaxPermisible = value; }
        }
    }
}
