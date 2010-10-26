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
    public partial class frmPista : Telerik.WinControls.UI.ShapedForm
    {
        private String AeropuertoElegido;

        public String aeropuertoElegido
        {
            get { return AeropuertoElegido; }
            set { AeropuertoElegido = value; }
        }

        private static frmPista objPista = null;
        public static frmPista Instance()
        {
            if (objPista == null)
            {
                objPista = new frmPista();
            }
            return objPista;
        }

        public frmPista()
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

                if (frmAeropuerto.AeropuertoElegido != null)
                {
                    String value = frmAeropuerto.AeropuertoElegido;
                    cbAeropuerto.SelectedItem = value;
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
            cbPista.Items.Clear();
            cbPista.SelectedItem = -1;
        }

        private void InElegirAeropuerto(object sender, EventArgs e)
        {
            try
            {
                String value;
                if (cbAeropuerto.SelectedItem != null)
                    value = cbAeropuerto.SelectedItem.ToString();
                else
                    value = "";

                if (value != "")
                {
                    String aeropuerto = value;
                    AeropuertoBC objAeropuertoBC = null;
                    objAeropuertoBC = new AeropuertoBC();
                    AeropuertoBE objAeropuertoBE = null;
                    objAeropuertoBE = objAeropuertoBC.ObtenerAeropuertoNombre(aeropuerto);
                    int codAeropuerto = objAeropuertoBE.CodAeropuerto;

                    cbPista.Items.Clear();

                    PistaBC objPistaBC = null;
                    objPistaBC = new PistaBC();

                    List<PistaBE> lstPistaBE = null;
                    lstPistaBE = new List<PistaBE>();

                    lstPistaBE = objPistaBC.ListarPistas();

                    foreach (PistaBE cDto in lstPistaBE)
                    {
                        if (cDto.CodAeropuerto == codAeropuerto)
                        {
                            cbPista.Items.Add(cDto.CodPista);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InElegirPista(object sender, EventArgs e)
        {
            try
            {
                int value;
                if (cbPista.SelectedItem != null)
                    value = Convert.ToInt32(cbPista.SelectedItem);
                else
                    value = -1;

                if (value != -1)
                {
                    int Pista = value;
                    PistaBC objPistaBC = null;
                    objPistaBC = new PistaBC();
                    PistaBE objPistaBE = null;
                    objPistaBE = objPistaBC.ObtenerPista(Pista);

                    if (objPistaBE != null)
                    {
                        dudLargo.Text = objPistaBE.Largo.ToString();
                        dudAncho.Text = objPistaBE.Ancho.ToString();
                        dudTORA.Text = objPistaBE.Tora.ToString();
                        dudTODA.Text = objPistaBE.Toda.ToString();
                        dudASDA.Text = objPistaBE.Asda.ToString();
                        txtLDA.Text = objPistaBE.Lda.ToString();
                        txtPavimento.Text = objPistaBE.Pavimento;
                        txtDesignador.Text = objPistaBE.Designado;
                        txtPCN.Text = objPistaBE.Pcn;
                        txtFranja.Text = objPistaBE.Franja;
                        txtCalle.Text = objPistaBE.Rodaje;
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }
    }
}