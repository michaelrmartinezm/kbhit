using System;
using UPC.Trabajo.KBHit.BC;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit
{
    public partial class frmEmbarque : Telerik.WinControls.UI.ShapedForm
    {
        private static frmEmbarque objEmbarque = null;
        public static frmEmbarque Instance()
        {
            if (objEmbarque == null)
            {
                objEmbarque = new frmEmbarque();
            }
            return objEmbarque;
        }

        public frmEmbarque()
        {
            InitializeComponent();
        }

        private void btnPasarBoleto(object sender, EventArgs e)
        {
            /*
             * Aquí debo poner el código necesario para seleccionar al azar la información que vaya a trabajar
             * ( eg. TipoVuelo={1,2} , Aerolinea="xxxxxxxx" )
             */

            try
            {
                TUUABC objTUUABC = null;
                TUUABE objTUUABE = null;

                objTUUABC = new TUUABC();
                objTUUABE = new TUUABE();

                objTUUABE.ObjAerolineaBE.Nombre = "Recibo de Tabla Ficticia";

                Random numC = new Random();
                
                objTUUABE.ObjTipoVueloBE.CodTipoVuelo = numC.Next(1,2);    /* { 1=Nacional, 2=Internacional } */
                objTUUABE.CodBoleto = numC.Next(1, 250);
                
                int codigo = objTUUABC.RegistrarTUUA(objTUUABE);

                if (codigo != 0)
                {
                    String msg = "Datos evaluados correctamente.";
                    tsbGuardar.Text = msg;
                }
                else
                {
                    String msg = "Datos evaluados incorrectamente. Intente de nuevo.";
                    tsbGuardar.Text = msg;
                }
                 
            }
            catch(Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }
    }
}