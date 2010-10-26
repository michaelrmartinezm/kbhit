using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class PlanDeVueloBE
    {
        private int codPlanVuelo;
        private int codAerolinea;
        private String destinatario;
        private String remitente;
        private String presentador;
        private String requisitos;
        private String prioridad;
        private DateTime hora;

        public int CodPlanVuelo
        {
            get { return codPlanVuelo; }
            set { codPlanVuelo = value; }
        }
        
        public int CodAerolinea
        {
            get { return codAerolinea; }
            set { codAerolinea = value; }
        }
        
        public String Destinatario
        {
            get { return destinatario; }
            set { destinatario = value; }
        }
        
        public String Remitente
        {
            get { return remitente; }
            set { remitente = value; }
        }
        
        public String Presentador
        {
            get { return presentador; }
            set { presentador = value; }
        }
        
        public String Requisitos
        {
            get { return requisitos; }
            set { requisitos = value; }
        }
        
        public String Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        
        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }



        //Variables que necesitaré {uso correcto}

        public String Aerolinea { get; set; }
        public String AerodromoSalida { get; set; }
        public String AerodromoDestino { get; set; }
        public String AerodromoAlterno_ { get; set; }
        public String AerodromoAlterno__ { get; set; }

    }
}
