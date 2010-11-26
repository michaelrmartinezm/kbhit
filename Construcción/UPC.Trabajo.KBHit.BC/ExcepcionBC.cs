using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class ExcepcionBC
    {

        public int RegistrarExcepcion(ExcepcionBE objExcepcionBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                ExcepcionDALC objExcepcionDALC = FabricaDALC.getExcepcionDALC();
                result = objExcepcionDALC.ExcepcionInsertar(objExcepcionBE);
            }
            catch (Exception ex)
            {
            }
            return result;
        }
    }
}