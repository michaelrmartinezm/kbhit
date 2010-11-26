using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit.DALC
{
    public abstract class IPAeropuertoDALC
    {
        public abstract IPAeropuertoBE ObtenerIPAeropuerto(String IP);
    }
}
