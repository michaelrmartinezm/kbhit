using System;

namespace UPC.Seguridad.BL.BE
{
    public class UsuarioBE
    {
        private int _IdUsuario;
        private String _Login;
        private String _Contrasenia;
        private String _NombreUsuario;
        private String _ApellidoPaterno;
        private String _ApellidoMaterno;
        private String _DNI;

        public String DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        public String ApellidoMaterno
        {
            get { return _ApellidoMaterno; }
            set { _ApellidoMaterno = value; }
        }

        public String ApellidoPaterno
        {
            get { return _ApellidoPaterno; }
            set { _ApellidoPaterno = value; }
        }

        public String NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        public String Contrasenia
        {
            get { return _Contrasenia; }
            set { _Contrasenia = value; }
        }

        public String Login
        {
            get { return _Login; }
            set { _Login = value; }
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
    }
}
