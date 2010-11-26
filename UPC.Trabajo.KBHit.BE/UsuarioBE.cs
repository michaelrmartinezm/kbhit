using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.External;

namespace UPC.Trabajo.KBHit.BE
{
    public class UsuarioBE
    {
        private UsuarioBE()
        { }

        private static UsuarioBE instancia = null;
        public static UsuarioBE getInstancia()
        {
            if (instancia == null)
            {
                instancia = new UsuarioBE();
            }
            return instancia;
        }

        private String _NombreUsuario;
        private String _ApellidoPaterno;
        private String _ApellidoMaterno;
        private List<String> _lsRoles;

        public String ApellidoMaterno
        {
            get
            {
                return _ApellidoMaterno;
            }
            set
            {
                _ApellidoMaterno = value;
            }
        }
        public String ApellidoPaterno
        {
            get
            {
                return _ApellidoPaterno;
            }
            set
            {
                _ApellidoPaterno = value;
            }
        }
        public List<String> LsRoles
        {
            get
            {
                return _lsRoles;
            }
            set
            {
                _lsRoles = value;
            }
        }
        public String NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }
            set
            {
                _NombreUsuario = value;
            }
        }

        public void Actualizar(PistaBE objPistaBE)
        {
            Notificacion.Imagen tipoImagen = 0;
            String msg = "Se ha actualizado la pista del Aeropuerto " + objPistaBE.CodAeropuerto + " con código " + objPistaBE.CodPista;
            Notificacion.mostrarVentana("Alerta", msg, tipoImagen, 10);
        }
    }
}
