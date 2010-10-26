using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UPC.Trabajo.KBHit
{
    public partial class frmAviones : Telerik.WinControls.UI.ShapedForm
    {
        private static frmAviones objAviones = null;
        public static frmAviones Instance()
        {
            if (objAviones == null)
            {
                objAviones = new frmAviones();
            }
            return objAviones;
        }

        public frmAviones()
        {
            InitializeComponent();
        }
    }
}