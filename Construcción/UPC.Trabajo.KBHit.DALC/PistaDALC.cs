using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class PistaDALC
    {
        public abstract int InsertarPistaBE(PistaBE obj);
        public abstract PistaBE ObtenerPistaBE(int iCod);
        //-- La función eliminar es por demás, pero forma parte del código de implementación hecha mucho antes.
        public abstract void EliminarPistaBE(int iCod);
        public abstract List<PistaBE> ListarPistaBE();
        public abstract void ActualizarPistaBE(PistaBE obj);
        private List<UsuarioBE> lstUsuario = new List<UsuarioBE>();

        //-- A continuación se muestra el código que forma parte de la implementación del patrón observador
        public List<UsuarioBE> LstUsuario
        {
            get { return lstUsuario; }
            set { lstUsuario = value; }
        }

        public abstract void AgregarObservador(UsuarioBE _observador);
        public abstract void QuitarObservador(UsuarioBE _observador);
    }
}
