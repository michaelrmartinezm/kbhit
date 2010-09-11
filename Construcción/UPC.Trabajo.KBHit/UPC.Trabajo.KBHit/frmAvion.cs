using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace UPC.Trabajo.KBHit
{
    public partial class frmAvion : Form
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
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Selecccionar la imagen";
            dialogo.Filter = "Todos (*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                int i = 255;
                string sNombre = System.IO.Path.GetFileName(dialogo.FileName);
                if (sNombre.Length > i)
                {
                    sNombre = sNombre.Substring(0, i);
                }
                this.Foto.Image = Image.FromFile(dialogo.FileName);
            }
        }
    }
}
