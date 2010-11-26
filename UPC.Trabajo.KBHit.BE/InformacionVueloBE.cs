using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class InformacionVueloBE
    {
        private int codInfoVuelo;
        private int codPlanVuelo;
        private int horas;
        private int min;
        private int personas;
        private int uhf;
        private int vhf;

        public int Vhf
        {
            get { return vhf; }
            set { vhf = value; }
        }
        private int elt;
        private int polar;
        private int desierto;
        private int maritimo;
        private int selva;
        private int fluor;
        private int luz;
        private int numero;
        private int capacidad;
        private int cubierta;
        private String color;
        private String marcasNave;
        private String observaciones;
        private String piloto;

        public int CodInfoVuelo
        {
            get { return codInfoVuelo; }
            set { codInfoVuelo = value; }
        }
        
        public int CodPlanVuelo
        {
            get { return codPlanVuelo; }
            set { codPlanVuelo = value; }
        }
        
        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }
        
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        
        public int Personas
        {
            get { return personas; }
            set { personas = value; }
        }
        
        public int Uhf
        {
            get { return uhf; }
            set { uhf = value; }
        }
        
        public int Elt
        {
            get { return elt; }
            set { elt = value; }
        }
        
        public int Polar
        {
            get { return polar; }
            set { polar = value; }
        }
        
        public int Desierto
        {
            get { return desierto; }
            set { desierto = value; }
        }
        
        public int Maritimo
        {
            get { return maritimo; }
            set { maritimo = value; }
        }
        
        public int Selva
        {
            get { return selva; }
            set { selva = value; }
        }
        
        public int Fluor
        {
            get { return fluor; }
            set { fluor = value; }
        }
        
        public int Luz
        {
            get { return luz; }
            set { luz = value; }
        }
        
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        
        public int Cubierta
        {
            get { return cubierta; }
            set { cubierta = value; }
        }
        
        public String Color
        {
            get { return color; }
            set { color = value; }
        }
        
        public String MarcasNave
        {
            get { return marcasNave; }
            set { marcasNave = value; }
        }
        
        public String Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        
        public String Piloto
        {
            get { return piloto; }
            set { piloto = value; }
        }
    }
}
