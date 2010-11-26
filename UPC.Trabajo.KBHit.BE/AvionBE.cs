using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class AvionBE
    {
        private int codAvion;
        private String nombre;
        private String fabricante;
        private String serie;
        private int cabinaTripulacion;
        private int pasajeros;
        private float longitud;
        private float envergadura;
        private float altura;
        private float pesoVacio;
        private float pesoMaxDespegue;
        private float velocidadCrucero;
        private float velocidadMax;
        private float carreraPesoMax;
        private float autonomiaPesoMaxDesp;
        private float maxFuel;
        private String motor;
        private String empuje;

        public int CodAvion
        {
            get { return codAvion; }
            set { codAvion = value; }
        }
        
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public String Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        
        public String Serie
        {
            get { return serie; }
            set { serie = value; }
        }
        
        public int CabinaTripulacion
        {
            get { return cabinaTripulacion; }
            set { cabinaTripulacion = value; }
        }
        
        public int Pasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }
        
        public float Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        
        public float Envergadura
        {
            get { return envergadura; }
            set { envergadura = value; }
        }
        
        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        
        public float PesoVacio
        {
            get { return pesoVacio; }
            set { pesoVacio = value; }
        }
        
        public float PesoMaxDespegue
        {
            get { return pesoMaxDespegue; }
            set { pesoMaxDespegue = value; }
        }
        
        public float VelocidadCrucero
        {
            get { return velocidadCrucero; }
            set { velocidadCrucero = value; }
        }
        
        public float VelocidadMax
        {
            get { return velocidadMax; }
            set { velocidadMax = value; }
        }
        
        public float CarreraPesoMax
        {
            get { return carreraPesoMax; }
            set { carreraPesoMax = value; }
        }
        
        public float AutonomiaPesoMaxDesp
        {
            get { return autonomiaPesoMaxDesp; }
            set { autonomiaPesoMaxDesp = value; }
        }
        
        public float MaxFuel
        {
            get { return maxFuel; }
            set { maxFuel = value; }
        }
        
        public String Motor
        {
            get { return motor; }
            set { motor = value; }
        }
        
        public String Empuje
        {
            get { return empuje; }
            set { empuje = value; }
        }
    }
}
