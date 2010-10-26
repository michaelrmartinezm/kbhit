using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UPC.Trabajo.KBHit.BC;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit
{
    public partial class frmAproximacion : Telerik.WinControls.UI.ShapedForm
    {
        private static frmAproximacion objAproximacion = null;
        public static frmAproximacion Instance()
        {
            if (objAproximacion == null)
            {
                objAproximacion = new frmAproximacion();
            }
            return objAproximacion;
        }

        public frmAproximacion()
        {
            InitializeComponent();
        }

        private void InGuardarAproximacion(object sender, EventArgs e)
        {
            try
            {
                if (CamposLlenos())
                {
                    if (LongitudCorrecto())
                    {
                        MovimientoBC objMovimientoBC = new MovimientoBC();
                        MovimientoBE objMovimientoBE = new MovimientoBE { Movimiento = cbTipoMovimiento.SelectedText, Aerolinea = cbAerolinea.SelectedText, Avion = cbAvion.SelectedText, AeropuertoOrigen = cbOrigen.SelectedText, AeropuertoDestino = cbDestino.SelectedText };

                        int codigo = objMovimientoBC.RegistrarMovimiento(objMovimientoBE);

                        if (codigo != 0)
                        {
                            MessageBox.Show("La Aproximación ha sido registrada satisfactoriamente.", "Sistema de Gestión Aereo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La Aproximación no ha sido registrada.", "Sistema de Gestión Aereo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private Boolean CamposLlenos()
        {
            if (cbTipoMovimiento.SelectedItem != null)
            {
                if (cbAerolinea.SelectedItem != null)
                {
                    if (cbAvion.SelectedItem != null)
                    {
                        if (rtcObservaciones.Text != "")
                        {
                            if (cbOrigen.SelectedItem != null)
                            {
                                if (cbDestino.SelectedItem != null)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private Boolean LongitudCorrecto()
        {
            if (rtcObservaciones.Text.Length < 500)
                return true;
            return false;
        }
    }
}