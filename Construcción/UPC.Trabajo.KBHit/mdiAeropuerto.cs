using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit
{
    public partial class mdiAeropuerto : Telerik.WinControls.UI.RadRibbonForm
    {
        private static mdiAeropuerto myMDI = null;
        public static mdiAeropuerto Instance()
        {
            if (myMDI == null)
            {
                myMDI = new mdiAeropuerto();
            }
            return myMDI;
        }

        public mdiAeropuerto()
        {
            InitializeComponent();
        }

        private void InAeropuertoConsultar(object sender, EventArgs e)
        {
            try
            {
                frmAeropuerto frm = frmAeropuerto.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
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
                frm.MdiParent = this;
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
                frmDisponibilidad frm = frmDisponibilidad.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InAvionConsultar(object sender, EventArgs e)
        {
            try
            {
                frmAvion frm = frmAvion.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InAerolineaConsultar(object sender, EventArgs e)
        {
            try
            {
                frmAerolineas frm = frmAerolineas.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InAerolineaRegistrar(object sender, EventArgs e)
        {
            try
            {
                frmAerolinea frm = frmAerolinea.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InPlanDeVueloRegistrar(object sender, EventArgs e)
        {
            try
            {
                frmPlandeVuelo frm = frmPlandeVuelo.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InAerolineaBuscar(object sender, EventArgs e)
        {
            try
            {
                frmPlandeVuelos frm = frmPlandeVuelos.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InAproximacionRegistrar(object sender, EventArgs e)
        {
            try
            {
                frmAproximacion frm = frmAproximacion.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InPlanVuelosBuscar(object sender, EventArgs e)
        {
            try
            {
                frmPlandeVuelos frm = frmPlandeVuelos.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InLoad(object sender, EventArgs e)
        {
            UsuarioBE objUsuarioBE = UsuarioBE.getInstancia();
            foreach (String sRol in objUsuarioBE.LsRoles)
            {
                if (sRol == "Controlador de Torre de Control")
                {
                    //Sólo muestra VOR-DME y Pista
                    radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    radRibbonBarGroup6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    radRibbonBarGroup4.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    radRibbonBarGroup5.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    radRibbonBarGroup7.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                }
                else if (sRol == "Despachador de Vuelo")
                {
                    //Muestra todo menos VOR-DME y Pista
                    radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    radRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    radRibbonBarGroup3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    radRibbonBarGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    radRibbonBarGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    radRibbonBarGroup6.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    radRibbonBarGroup7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                }

            }
        }        
    }
}