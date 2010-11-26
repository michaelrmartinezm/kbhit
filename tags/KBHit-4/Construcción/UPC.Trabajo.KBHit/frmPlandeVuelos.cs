using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UPC.Trabajo.KBHit
{
    public partial class frmPlandeVuelos : Telerik.WinControls.UI.ShapedForm
    {
        private static frmPlandeVuelos objPlandeVuelos = null;
        public static frmPlandeVuelos Instance()
        {
            if (objPlandeVuelos == null)
            {
                objPlandeVuelos = new frmPlandeVuelos();
            }
            return objPlandeVuelos;
        }

        public frmPlandeVuelos()
        {
            InitializeComponent();
        }
    }
}