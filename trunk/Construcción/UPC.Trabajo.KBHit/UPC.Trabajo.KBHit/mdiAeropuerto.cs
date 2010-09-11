using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace UPC.Trabajo.KBHit
{
    public partial class mdiAeropuerto : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static mdiAeropuerto MDI = null;
        public static mdiAeropuerto Instance()
        {
            if (MDI == null)
            {
                MDI = new mdiAeropuerto();
            }
            return MDI;
        }

        public mdiAeropuerto()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
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
                //OtrasFunciones.InsertarExcepcion(ex);
            }
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
                //OtrasFunciones.InsertarExcepcion(ex);
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
                //OtrasFunciones.InsertarExcepcion(ex);
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
                //OtrasFunciones.InsertarExcepcion(ex);
            }
        }

        private void InAvionConsultar(object sender, ItemClickEventArgs e)
        {
            try
            {
                /*frmAvion frm = frmAvion.Instance();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();*/
            }
            catch (Exception ex)
            {
                //OtrasFunciones.InsertarExcepcion(ex);
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
                //OtrasFunciones.InsertarExcepcion(ex);
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
                //OtrasFunciones.InsertarExcepcion(ex);
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
                //OtrasFunciones.InsertarExcepcion(ex);
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
                //OtrasFunciones.InsertarExcepcion(ex);
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
                //OtrasFunciones.InsertarExcepcion(ex);
            }
        }
    }
}