using System;
using System.Collections.Generic;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class FacturaBC
    {
        public int RegistrarFactura(FacturaBE objFacturaBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                FacturaDALC objFacturaDALC = FabricaDALC.getFacturaDALC();
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();

                Boolean state = false;

                List<AerolineaBE> lstAerolinea = objAerolineaDALC.ListarAerolineaBE();
                foreach (AerolineaBE cDto in lstAerolinea)
                {
                    if (cDto.Nombre == objFacturaBE.ObjAerolinea.Nombre)
                    {
                        objFacturaBE.ObjAerolinea.CodAerolinea = cDto.CodAerolinea;
                        state = true;
                        break;
                    }
                }

                if (state == true)
                {
                    result = objFacturaDALC.InsertarFactura(objFacturaBE);

                    if (result != 0)
                    {
                        //Guardar el registro;
                        LogBC objLogBC = new LogBC();
                        LogBE objLogBE = new LogBE();
                        objLogBE.CodOperacion = result;
                        objLogBE.Fecha = DateTime.Now;
                        objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                        objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                        objLogBE.Tabla = "Factura";
                        objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                        int r = (objLogBC.RegistrarLog(objLogBE));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public FacturaBE ObtenerFactura(int codigo)
        {
            FacturaBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                FacturaDALC objFacturaDALC = FabricaDALC.getFacturaDALC();
                obj = objFacturaDALC.ObtenerFactura(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un nuevo registro del sistema";
                    objLogBE.Tabla = "Factura";
                    objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                    int r = (objLogBC.RegistrarLog(objLogBE));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }
    }
}
