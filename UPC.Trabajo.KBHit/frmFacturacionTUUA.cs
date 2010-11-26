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
    public partial class frmFacturacionTUUA : Telerik.WinControls.UI.ShapedForm
    {
        private static frmFacturacionTUUA objFacturacionTUUA = null;
        public static frmFacturacionTUUA Instance()
        {
            if (objFacturacionTUUA == null)
            {
                objFacturacionTUUA = new frmFacturacionTUUA();
            }
            return objFacturacionTUUA;
        }

        public frmFacturacionTUUA()
        {
            InitializeComponent();
            In_CargarDatos();
        }

        private void tsbVerInformacion(object sender, EventArgs e)
        {
            try 
            {
                if (cbAerolinea.SelectedIndex != -1)
                {
                    dgvTUUA.DataSource = null;

                    TUUABC objTUUABC = new TUUABC();
                    TUUABE objTUUABE = new TUUABE();
                    objTUUABE.ObjAerolineaBE = new AerolineaBE();

                    String aerolinea = cbAerolinea.Items[cbAerolinea.SelectedIndex].Text;
                    objTUUABE.ObjAerolineaBE.Nombre = aerolinea;
                    objTUUABE.Fecha = cbFecha.Value;

                    AerolineaBC objAerolineaBC = new AerolineaBC();
                    List<AerolineaBE> lstAerolineaBE = new List<AerolineaBE>();
                    lstAerolineaBE = objAerolineaBC.ListarAerolineas();

                    foreach (AerolineaBE cDto in lstAerolineaBE)
                    {
                        if (cDto.Nombre == objTUUABE.ObjAerolineaBE.Nombre)
                        {
                            objTUUABE.ObjAerolineaBE.CodAerolinea = cDto.CodAerolinea;
                            break;
                        }
                    }

                    if (objTUUABE.ObjAerolineaBE.CodAerolinea != 0)
                    {
                        List<TUUABE> lst = new List<TUUABE>();
                        lst = objTUUABC.ListarTUUAs();

                        List<TUUABE> lista = new List<TUUABE>();

                        foreach (TUUABE cDto in lst)
                        {
                            if (cDto.ObjAerolineaBE.CodAerolinea == objTUUABE.ObjAerolineaBE.CodAerolinea  && cDto.Fecha.Date == objTUUABE.Fecha.Date)
                            {
                                lista.Add(cDto);
                            }
                        }

                        if (lista != null)
                        {
                            dgvTUUA.DataSource = lista;

                            dgvTUUA.AllowDrop = false;

                            // Opcion a seleccionar varios registros
                            dgvTUUA.MultiSelect = false;

                            // Para evitar poder modificar los datos de la grilla
                            dgvTUUA.ReadOnly = true;

                            // Para poder hacer clic en cualquier parte de la fila y que toda la fila aparezca selecionada
                            dgvTUUA.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.FullRowSelect;

                            this.dgvTUUA.Columns["Fecha"].IsVisible = false;
                            this.dgvTUUA.Columns["CodVuelo"].HeaderText = "Tipo Vuelo";
                            this.dgvTUUA.Columns["ObjAerolineaBE"].IsVisible = false;
                            this.dgvTUUA.Columns["ObjTipoVueloBE"].IsVisible = false;
                            this.dgvTUUA.Columns["Impuesto"].HeaderText = "Impuesto";
                            this.dgvTUUA.Columns["CodBoleto"].HeaderText = "Boleto";
                            this.dgvTUUA.Columns["CodTUUA"].IsVisible = false;
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void In_CargarDatos()
        {
            try
            {
                LimpiarCombo();
                AerolineaBC objAerolineaBC = new AerolineaBC();
                List<AerolineaBE> lstAerolinea = objAerolineaBC.ListarAerolineas();

                if (lstAerolinea != null)
                {
                    foreach (AerolineaBE cDto in lstAerolinea)
                    {
                        Telerik.WinControls.UI.RadComboBoxItem item = new Telerik.WinControls.UI.RadComboBoxItem();
                        item.Text = cDto.Nombre;
                        cbAerolinea.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void LimpiarCombo()
        {
            cbAerolinea.Items.Clear();
        }

        private void In_GuardarFactura(object sender, EventArgs e)
        {
            try
            {
                if (cbAerolinea.SelectedIndex != -1)
                {
                    if (dgvTUUA.DataSource != null)
                    {
                        List<TUUABE> lstTUUA = new List<TUUABE>();
                        FacturaBC objFacturaBC = new FacturaBC();
                        FacturaBE objFacturaBE = new FacturaBE();
                        objFacturaBE.ObjAerolinea = new AerolineaBE();

                        objFacturaBE.Descripcion = "Por concepto de tarifa única por uso del aeropuerto ( TUUA ).";
                        objFacturaBE.ObjAerolinea.Nombre = cbAerolinea.Items[cbAerolinea.SelectedIndex].Text;
                        objFacturaBE.Fecha = cbFecha.Value;

                        lstTUUA = (List<TUUABE>)dgvTUUA.DataSource;
                        float monto = 0;
                        foreach (TUUABE cDto in lstTUUA)
                        {
                            monto += cDto.Impuesto;
                        }

                        objFacturaBE.Monto = monto;

                        int iCod = objFacturaBC.RegistrarFactura(objFacturaBE);
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