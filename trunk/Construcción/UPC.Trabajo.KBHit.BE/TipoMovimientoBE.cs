using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.BE
{
    public class TipoMovimientoBE
    {
        private int codTipoMovimiento;
        private String descripcion;

        public int CodTipoMovimiento
        {
            get { return codTipoMovimiento; }
            set { codTipoMovimiento = value; }
        }
        
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
