﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UPC.Trabajo.KBHit
{
    public partial class frmAerolineas : Telerik.WinControls.UI.ShapedForm
    {
        private static frmAerolineas objAerolineas = null;
        public static frmAerolineas Instance()
        {
            if (objAerolineas == null)
            {
                objAerolineas = new frmAerolineas();
            }
            return objAerolineas;
        }

        public frmAerolineas()
        {
            InitializeComponent();
        }
    }
}