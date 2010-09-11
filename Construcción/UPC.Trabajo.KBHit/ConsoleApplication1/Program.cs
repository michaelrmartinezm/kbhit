using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AeropuertoBE Aeropuerto = new AeropuertoBE();
            SqlAeropuertoDALC AeropuertoDALC = new SqlAeropuertoDALC();
            Aeropuerto.Nombre = "Aeropuerto Internacional Capitán FAP Victor Montes Arias";
            Aeropuerto.Estado = "Piura";
            Aeropuerto.Ciudad = "Talara";
            Aeropuerto.Oaci = "SPYL";
            Aeropuerto.Iata = "TYL";
            Aeropuerto.Elevacion = 282;
            Aeropuerto.Sei = 6;
            Aeropuerto.Fuel = 1;
            Aeropuerto.Operacion = "24x7";

            AeropuertoDALC.InsertarAeropuertoBE(Aeropuerto);
        }
    }
}
