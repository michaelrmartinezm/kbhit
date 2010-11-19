using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class PistaBE
    {
        private int codPista;
        private int codAeropuerto;        
        private int ancho;
        private int tora;
        private int toda;
        private int asda;
        private int lda;
        private String pavimento;
        private String designado;
        private String pcn;
        private String franja;
        private String rodaje;
        private int largo;
        private String estado; //-- estado es la disponibilidad actual de la pista        

        public String Estado
        {
            get { return estado; }
            set { estado = value;}
        }

        public int CodPista
        {
            get { return codPista; }
            set { codPista = value; }
        }
        
        public int CodAeropuerto
        {
            get { return codAeropuerto; }
            set { codAeropuerto = value; }
        }
        
        public int Largo
        {
            get { return largo; }
            set { largo = value; }
        }
        
        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        
        public int Tora
        {
            get { return tora; }
            set { tora = value; }
        }
        
        public int Toda
        {
            get { return toda; }
            set { toda = value; }
        }
        
        public int Asda
        {
            get { return asda; }
            set { asda = value; }
        }
        
        public int Lda
        {
            get { return lda; }
            set { lda = value; }
        }
        
        public String Pavimento
        {
            get { return pavimento; }
            set { pavimento = value; }
        }
        
        public String Designado
        {
            get { return designado; }
            set { designado = value; }
        }
        
        public String Pcn
        {
            get { return pcn; }
            set { pcn = value; }
        }
        
        public String Franja
        {
            get { return franja; }
            set { franja = value; }
        }
        
        public String Rodaje
        {
            get { return rodaje; }
            set { rodaje = value; }
        }
    }
}