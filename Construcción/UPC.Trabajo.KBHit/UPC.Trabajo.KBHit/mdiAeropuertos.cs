using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit
{
    public partial class mdiAeropuertos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static mdiAeropuertos myMDI = null;
        public static mdiAeropuertos Instance()
        {
            if (myMDI == null)
            {
                myMDI = new mdiAeropuertos();
            }
            return myMDI;
        }

        public mdiAeropuertos()
        {
            InitializeComponent();
        }

        private void InAeropuertoConsultar(object sender, ItemClickEventArgs e)
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

        private void InPlataformaConsultar(object sender, ItemClickEventArgs e)
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

        private void InPistaConsultar(object sender, ItemClickEventArgs e)
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

        private void InAvionConsultar(object sender, ItemClickEventArgs e)
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

        private void InAerolineaConsultar(object sender, ItemClickEventArgs e)
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

        private void InAerolineaRegistrar(object sender, ItemClickEventArgs e)
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

        private void InPlanDeVueloRegistrar(object sender, ItemClickEventArgs e)
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

        private void InAerolineaBuscar(object sender, ItemClickEventArgs e)
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

        private void InAproximacionRegistrar(object sender, ItemClickEventArgs e)
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

        private void InPlanVuelosBuscar(object sender, ItemClickEventArgs e)
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
                    ribbonPageGroup1.Visible = true;
                    ribbonPageGroup6.Visible = true;
                    ribbonPageGroup2.Visible = false;
                    ribbonPageGroup3.Visible = false;
                    ribbonPageGroup4.Visible = false;
                    ribbonPageGroup5.Visible = false;
                    ribbonPageGroup7.Visible = false;
                }
                else if (sRol == "Despachador de Vuelo")
                {
                    //Muestra todo menos VOR-DME y Pista
                    ribbonPageGroup1.Visible = false;
                    ribbonPageGroup2.Visible = true;
                    ribbonPageGroup3.Visible = true;
                    ribbonPageGroup4.Visible = true;
                    ribbonPageGroup5.Visible = true;
                    ribbonPageGroup6.Visible = false;
                    ribbonPageGroup7.Visible = true;
                }

            }
        }
    }
}