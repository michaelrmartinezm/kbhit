using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class SalidaBE
    {
        private int codSalida;
        private int codPlanVuelo;
        private int numero;
        private String placa;
        private String reglaVuelo;
        private String tipoVuelo;
        private int codAvion;
        private DateTime hora;
        private int codAeropuerto;
        private String turbulencia;
        private String equipo;
        private float velocidad;
        private float nivel;
        private String ruta;

        public int CodSalida
        {
            get { return codSalida; }
            set { codSalida = value; }
        }
        
        public int CodPlanVuelo
        {
            get { return codPlanVuelo; }
            set { codPlanVuelo = value; }
        }
        
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        
        public String ReglaVuelo
        {
            get { return reglaVuelo; }
            set { reglaVuelo = value; }
        }
        
        public String TipoVuelo
        {
            get { return tipoVuelo; }
            set { tipoVuelo = value; }
        }
        
        public int CodAvion
        {
            get { return codAvion; }
            set { codAvion = value; }
        }
        
        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        
        public int CodAeropuerto
        {
            get { return codAeropuerto; }
            set { codAeropuerto = value; }
        }
        
        public String Turbulencia
        {
            get { return turbulencia; }
            set { turbulencia = value; }
        }
        
        public String Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }
        
        public float Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }
        
        public float Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        
        public String Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }
    }
}
