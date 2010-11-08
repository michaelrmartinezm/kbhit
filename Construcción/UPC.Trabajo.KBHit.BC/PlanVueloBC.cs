using System;
using System.Collections.Generic;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class PlanVueloBC
    {

        public int RegistrarPlanVuelo(PlanDeVueloBE objPlanVueloBE, SalidaBE objSalidaBE, DestinoBE objDestinoBE, InformacionVueloBE objInformacionVueloBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PlanVueloDALC objPlanVueloDALC = FabricaDALC.getPlanVueloDALC();
                SalidaDALC objSalidaDALC = FabricaDALC.getSalidaDALC();
                DestinoDALC objDestinoDALC = FabricaDALC.getDestinoDALC();
                InformacionVueloDALC objInformacionVueloDALC = FabricaDALC.getInformacionVueloDALC();
                AeropuertoDALC objAeropueroDALC = FabricaDALC.getAeropuertoDALC();

                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                List<AerolineaBE> lstAerolinea = objAerolineaDALC.ListarAerolineaBE();
                Boolean state = false;
                foreach(AerolineaBE cDto in lstAerolinea)
                {
                    if (cDto.Nombre == objPlanVueloBE.Aerolinea)
                    {
                        objPlanVueloBE.CodAerolinea = cDto.CodAerolinea;
                        state = true;
                        break;
                    }
                }

                if (state == true)
                {
                    result = objPlanVueloDALC.InsertarPlanVueloBE(objPlanVueloBE);
                    if (result != 0)
                    {
                        objSalidaBE.CodPlanVuelo = result;
                        objDestinoBE.CodPlanVuelo = result;
                        objInformacionVueloBE.CodPlanVuelo = result;

                        AeropuertoBE objAeropuertoBE = objAeropueroDALC.ObtenerAeropuertoBENombre(objPlanVueloBE.AerodromoSalida);
                        if(objAeropuertoBE!=null)
                        {
                            objSalidaBE.CodAeropuerto = objAeropuertoBE.CodAeropuerto;
                            int r_salida = 0;
                            r_salida = objSalidaDALC.InsertarSalidaBE(objSalidaBE);
                            if (r_salida != 0)
                            {
                                objAeropuertoBE = objAeropueroDALC.ObtenerAeropuertoBENombre(objPlanVueloBE.AerodromoDestino);
                                if (objAeropuertoBE != null)
                                {
                                    objDestinoBE.CodAerodromo = objAeropuertoBE.CodAeropuerto;
                                    objAeropuertoBE = objAeropueroDALC.ObtenerAeropuertoBENombre(objPlanVueloBE.AerodromoAlterno_);
                                    if (objAeropuertoBE != null)
                                    {
                                        objDestinoBE.CodAerodromoAlter = objAeropuertoBE.CodAeropuerto;
                                        objAeropuertoBE = objAeropueroDALC.ObtenerAeropuertoBENombre(objPlanVueloBE.AerodromoAlterno__);
                                        if (objAeropuertoBE != null)
                                        {
                                            objDestinoBE.CodAerodromo2Alter = objAeropuertoBE.CodAeropuerto;
                                            int r_destino = 0;
                                            r_destino = objDestinoDALC.InsertarDestinoBE(objDestinoBE);
                                            if (r_destino != 0)
                                            {
                                                int r_infoVuelo = 0;
                                                r_infoVuelo = objInformacionVueloDALC.InsertarInformacionVueloBE(objInformacionVueloBE);

                                                if (r_infoVuelo == 0)
                                                    result = 0;
                                            }
                                            else
                                                result = 0;
                                        }
                                    }
                                }
                            }
                            else
                                result = 0;

                        }
                        
                    }

                    if (result != 0)
                    {
                        //Guardar el registro;
                        LogBC objLogBC = new LogBC();
                        LogBE objLogBE = new LogBE();
                        objLogBE.CodOperacion = result;
                        objLogBE.Fecha = DateTime.Now;
                        objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                        objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                        objLogBE.Tabla = "PlanVuelo";
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

        public PlanDeVueloBE ObtenerPlanVuelo(int codigo)
        {
            PlanDeVueloBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PlanVueloDALC objPlanVueloDALC = FabricaDALC.getPlanVueloDALC();
                obj = objPlanVueloDALC.ObtenerPlanVueloBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un nuevo registro del sistema";
                    objLogBE.Tabla = "PlanVuelo";
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

        public void ActualizarPlanVuelo(PlanDeVueloBE objPlanVueloBE)
        {
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PlanVueloDALC objPlanVueloDALC = FabricaDALC.getPlanVueloDALC();
                objPlanVueloDALC.ActualizarPlanVueloBE(objPlanVueloBE);

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objPlanVueloBE.CodPlanVuelo;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Se actualizó un registro del sistema";
                objLogBE.Tabla = "PlanVuelo";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PlanDeVueloBE> ListarPlanVuelos()
        {
            List<PlanDeVueloBE> lsPlanVuelos = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PlanVueloDALC objPlanVueloDALC = FabricaDALC.getPlanVueloDALC();
                lsPlanVuelos = objPlanVueloDALC.ListarPlanVueloBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsPlanVuelos;
        }
    }
}