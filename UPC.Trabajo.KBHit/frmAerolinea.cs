using System;
using System.Drawing;
using System.Windows.Forms;
using UPC.Trabajo.KBHit.BC;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit
{
    public partial class frmAerolinea : Telerik.WinControls.UI.ShapedForm
    {
        private static frmAerolinea objAerolinea = null;
        public static frmAerolinea Instance()
        {
            if (objAerolinea == null)
            {
                objAerolinea = new frmAerolinea();
            }
            return objAerolinea;
        }

        public frmAerolinea()
        {
            InitializeComponent();
        }

        private void bnNuevaAerolinea(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombreAerolinea.Clear();
            txtRuc.Clear();
            cbProcedencia.SelectedItem = -1;
            //image;
        }

        private Boolean CamposLlenos()
        {
            if (txtNombreAerolinea.Text != "")
            {
                if (txtRuc.Text != "")
                {
                    if (cbProcedencia.SelectedItem != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void bnGuardarAerolinea(object sender, EventArgs e)
        {
            try
            {
                if (CamposLlenos())
                {
                    if (FormatoCorrecto())
                    {
                        if (LongitudCorrecto())
                        {
                            AerolineaBC objAerolineaBC = null;
                            AerolineaBE objAerolineaBE = null;

                            objAerolineaBC = new AerolineaBC();
                            objAerolineaBE = new AerolineaBE { Nombre = txtNombreAerolinea.Text, Ruc = txtRuc.Text, Procedencia = cbProcedencia.SelectedText, Logotipo = Funciones.Image2Bytes(Foto.Image) };

                            int codigo = objAerolineaBC.RegistrarAerolinea(objAerolineaBE);

                            if (codigo != 0)
                            {
                                txtCodigo.Text = codigo.ToString();
                                String msg = String.Format("{0} con código {1}", txtNombreAerolinea.Text, txtCodigo.Text);
                                MessageBox.Show(String.Format("La Aerolinea {0} fue registrado satisfactoriamente.", msg), "Sistema de Gestión Aereo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                String msg = String.Format("{0}", txtNombreAerolinea.Text);
                                MessageBox.Show(String.Format("La Aerolinea {0} no ha sido registrada.", msg), "Sistema de Gestión Aereo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private Boolean FormatoCorrecto()
        {
            long value = Convert.ToInt64(txtRuc.Text);
            if ((value >= 10000000000 && value <= 15999999999) || (value >= 20000000000 && value <= 25999999999))
            {
                return true;
            }
            return false;
        }

        private Boolean LongitudCorrecto()
        {
            if (txtNombreAerolinea.Text.Length <= 500)
            {
                if (txtRuc.Text.Length == 11)
                {
                    return true;
                }
            }
            return false;
        }

        private void InCargarLogotipo(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog { Title = "Selecccionar la imagen", Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp" })
            {
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    int i = 255;
                    string sNombre = System.IO.Path.GetFileName(dialogo.FileName);
                    if (sNombre.Length > i)
                        sNombre = sNombre.Substring(0, i);
                    this.Foto.Image = Image.FromFile(dialogo.FileName);
                }
            }
        }

        private void InCerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}