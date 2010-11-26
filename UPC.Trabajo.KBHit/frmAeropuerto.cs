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
    public partial class frmAeropuerto : Telerik.WinControls.UI.ShapedForm
    {
        public static String AeropuertoElegido = String.Empty;

        private static frmAeropuerto objAeropuerto = null;
        public static frmAeropuerto Instance()
        {
            if (objAeropuerto == null)
            {
                objAeropuerto = new frmAeropuerto();
            }
            return objAeropuerto;
        }

        public frmAeropuerto()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                LimpiarCombos();
                AeropuertoBC objAeropuertoBC = new AeropuertoBC();
                List<AeropuertoBE> lstAeropuerto = new List<AeropuertoBE>();

                lstAeropuerto = objAeropuertoBC.ListarAeropuertos();

                if (lstAeropuerto != null)
                {
                    foreach (AeropuertoBE cDto in lstAeropuerto)
                    {
                        cbAeropuerto.Items.Add(cDto.Nombre);
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void LimpiarCombos()
        {
            cbAeropuerto.Items.Clear();
        }

        private void InElegirAeropuerto(object sender, EventArgs e)
        {
            try
            {
                String value;
                if (cbAeropuerto.SelectedItem != null)
                {
                    value = cbAeropuerto.SelectedItem.ToString();
                    AeropuertoElegido = value;
                    frmPlataforma frm = null;
                    frm = new frmPlataforma();
                    AeropuertoElegido = cbAeropuerto.SelectedItem.ToString();

                    //Mostrar los datos del Aeropuerto seleccionado
                    AeropuertoBC objAeropuertoBC = null;
                    objAeropuertoBC = new AeropuertoBC();
                    AeropuertoBE objAeropuertoBE = objAeropuertoBC.ObtenerAeropuertoNombre(AeropuertoElegido);

                    txtNombre.Text = objAeropuertoBE.Nombre;
                    cbDepartamento.SelectedText = objAeropuertoBE.Estado;
                    txtCiudad.Text = objAeropuertoBE.Ciudad;
                    txtIATA.Text = objAeropuertoBE.Iata;
                    txtOACI.Text = objAeropuertoBE.Oaci;
                    txtElevacion.Text = objAeropuertoBE.Elevacion.ToString();
                    dudServicioEmergencia.Text = objAeropuertoBE.Sei.ToString();
                    txtHorario.Text = objAeropuertoBE.Operacion;
                    txtFecha.Text = objAeropuertoBE.Fecha.ToString();
                    if (objAeropuertoBE.Fuel == 1)
                        cbFuel.SelectedText = "Si";
                    else
                        cbFuel.SelectedText = "No";
                }
                else
                    value = "";
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InPlataformaConsultar(object sender, EventArgs e)
        {
            try
            {
                frmPlataforma frm = frmPlataforma.Instance();
                frm.MdiParent = this.ParentForm;
                frm.Show();
                frm.BringToFront();

            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InPistaConsultar(object sender, EventArgs e)
        {
            try
            {
                frmPista frm = frmPista.Instance();
                frm.MdiParent = this.ParentForm;
                frm.Show();
                frm.BringToFront();

            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }
    }
}