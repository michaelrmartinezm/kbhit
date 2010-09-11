using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Seguridad.BL.BE
{
    public class FuncionalidadBE
    {
        private int _IdFuncionalidad;
        private String _NombreFuncionalidad;
        private String _Referencia;
        private AplicacionBE _ObjAplicacionBE;

        public AplicacionBE ObjAplicacionBE
        {
            get { return _ObjAplicacionBE; }
            set { _ObjAplicacionBE = value; }
        }

        public String Referencia
        {
            get { return _Referencia; }
            set { _Referencia = value; }
        }

        public String NombreFuncionalidad
        {
            get { return _NombreFuncionalidad; }
            set { _NombreFuncionalidad = value; }
        }

        public int IdFuncionalidad
        {
            get { return _IdFuncionalidad; }
            set { _IdFuncionalidad = value; }
        }
    }
}
