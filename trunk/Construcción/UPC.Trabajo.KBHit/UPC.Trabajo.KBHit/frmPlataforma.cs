using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UPC.Trabajo.KBHit.BC;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit
{
    public partial class frmPlataforma : Form
    {
        private String AeropuertoElegido;

        public String aeropuertoElegido
        {
            get { return AeropuertoElegido; }
            set { AeropuertoElegido = value; }
        }
        
        private static frmPlataforma objPlataforma = null;
        public static frmPlataforma Instance()
        {
            if (objPlataforma == null)
            {
                objPlataforma = new frmPlataforma();
            }
            return objPlataforma;
        }

        public frmPlataforma()
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
            cbPlataforma.Items.Clear();
            cbPlataforma.SelectedItem = -1;
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

                    cbPlataforma.Items.Clear();

                    PlataformaBC objPlataformaBC = null;
                    objPlataformaBC = new PlataformaBC();

                    List<PlataformaBE> lstPlataformaBE = null;
                    lstPlataformaBE = new List<PlataformaBE>();

                    lstPlataformaBE = objPlataformaBC.ListarPlataformas();

                    foreach (PlataformaBE cDto in lstPlataformaBE)
                    {
                        if (cDto.CodAeropuerto == codAeropuerto)
                        {
                            cbPlataforma.Items.Add(cDto.CodPlataforma);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InElegirPlataforma(object sender, EventArgs e)
        {
            try
            {
                int value;
                if (cbPlataforma.SelectedItem != null)
                    value = Convert.ToInt32(cbPlataforma.SelectedItem);
                else
                    value = -1;

                if (value != -1)
                {
                    int plataforma = value;
                    PlataformaBC objPlataformaBC = null;
                    objPlataformaBC = new PlataformaBC();
                    PlataformaBE objPlataformaBE = null;
                    objPlataformaBE = objPlataformaBC.ObtenerPlataforma(plataforma);

                    if (objPlataformaBE != null)
                    {
                        dudPuestos.Text = objPlataformaBE.Naves.ToString();
                        cbPavimento.Text = objPlataformaBE.Pavimento;
                        txtPCN.Text = objPlataformaBE.Pcn;
                        txtDimensiones.Text = objPlataformaBE.Dimensiones;
                        txtAeronaveMacPermisible.Text = objPlataformaBE.NaveMaxPermisible;
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