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
                if (cbAerolineaB.SelectedIndex != -1)
                {

                    TUUABC objTUUABC = new TUUABC();
                    TUUABE objTUUABE = new TUUABE();

                    objTUUABE.ObjAerolineaBE.Nombre = cbAerolineaB.Items[cbAerolineaB.SelectedIndex].Text;
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

                    List<TUUABE> lst = new List<TUUABE>();
                    lst = objTUUABC.ListarTUUAs();

                    List<TUUABE> lista = new List<TUUABE>();

                    foreach (TUUABE cDto in lst)
                    {
                        if (cDto.ObjAerolineaBE.CodAerolinea == objTUUABE.ObjAerolineaBE.CodAerolinea)
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

                        this.dgvTUUA.Columns["CodTUUA"].HeaderText = "Código";
                        this.dgvTUUA.Columns["CodVuelo"].HeaderText = "Vuelo";
                        this.dgvTUUA.Columns["CodBoleto"].HeaderText = "Boleto";
                        this.dgvTUUA.Columns["Impuesto"].HeaderText = "Impuesto";
                        this.dgvTUUA.Columns["CodTipoVuelo"].IsVisible = false;
                        this.dgvTUUA.Columns["Fecha"].IsVisible = false;
                        this.dgvTUUA.Columns["Aerolinea"].IsVisible = false;
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
                    //Telerik.WinControls.RadItem item = new Telerik.WinControls.RadItem();

                    foreach (AerolineaBE cDto in lstAerolinea)
                    {                        
                        //item.Text = cDto.Nombre;
                        //item.Name = "Element" + cbAerolineaB.Items.Count.ToString();
                        cbAerolinea.Items.Add(cDto.Nombre);
                        //cbAerolinea.Items.AddRange(new Telerik.WinControls.RadItem[] {item});
                        //cbAerolinea.Items.Insert(cbAerolinea.Items.Count, item);
                        //cbAerolinea.Items.Add(cDto.Nombre).ToString();
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
            cbAerolineaB.Items.Clear();
        }
    }
}