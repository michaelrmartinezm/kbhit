using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Seguridad.BL.BE;

namespace UPC.Seguridad.DL.DALC
{
     public abstract class RolDALC
    {
         public abstract RolBE RolObtener(int idRol);
         public abstract List<RolBE> RolListar();
    }
}
