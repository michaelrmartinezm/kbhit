using System;
using System.Drawing;
using System.Windows.Forms;

namespace UPC.Trabajo.KBHit
{
    public partial class frmAvion : Telerik.WinControls.UI.ShapedForm
    {
        private static frmAvion objAvion = null;
        public static frmAvion Instance()
        {
            if (objAvion == null)
            {
                objAvion = new frmAvion();
            }
            return objAvion;
        }

        public frmAvion()
        {
            InitializeComponent();
        }

        private void InCargarVistaAvion(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogo = new OpenFileDialog { Title = "Selecccionar la imagen", Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp" })
            {
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    int i = 255;
                    string sNombre = System.IO.Path.GetFileName(dialogo.FileName);
                    if (sNombre.Length > i)
                        sNombre = sNombre.Substring(0, i);
                    Foto.Image = Image.FromFile(dialogo.FileName);
                }
            }
        }
    }
}