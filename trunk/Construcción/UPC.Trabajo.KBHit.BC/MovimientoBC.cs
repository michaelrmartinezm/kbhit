using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;

namespace UPC.Trabajo.KBHit.BC
{
    public class MovimientoBC
    {

        public int RegistrarMovimiento(MovimientoBE objMovimientoBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                MovimientoDALC objMovimientoDALC = FabricaDALC.getMovimientoDALC();
                AerolineaDALC objAerolineaDALC = FabricaDALC.getAerolineaDALC();
                AeropuertoDALC objAeropuertoDALC = FabricaDALC.getAeropuertoDALC();
                TipoMovimientoDALC objTipoMovimientoDALC = FabricaDALC.getTipoMovimientoDALC();
                AvionDALC objAvionDALC = FabricaDALC.getAvionDALC();

                List<AerolineaBE> lstAerolinea = new List<AerolineaBE>();  
                lstAerolinea = objAerolineaDALC.ListarAerolineaBE();

                if (lstAerolinea != null)
                {
                    Boolean state = false;
                    foreach (AerolineaBE cDto in lstAerolinea)
                    {
                        if (cDto.Nombre == objMovimientoBE.Aerolinea)
                        {
                            objMovimientoBE.CodAerolinea = cDto.CodAerolinea;
                            state = true;
                            break;
                        }                                              
                    }

                    if (state == true)
                    {
                        AeropuertoBE objAeropuertoBE = objAeropuertoDALC.ObtenerAeropuertoBENombre(objMovimientoBE.AeropuertoOrigen);
                        if (objAeropuertoBE != null)
                        {
                            objMovimientoBE.CodAeropuertoOrigen = objAeropuertoBE.CodAeropuerto;
                            objAeropuertoBE = objAeropuertoDALC.ObtenerAeropuertoBENombre(objMovimientoBE.AeropuertoDestino);
                            if (objAeropuertoBE != null)
                            {
                                objMovimientoBE.CodAeropuertoDestino = objAeropuertoBE.CodAeropuerto;
                                List<TipoMovimientoBE> lstTipoMovimiento = objTipoMovimientoDALC.ListarTipoMovimientoBE();
                                if (lstTipoMovimiento != null)
                                {
                                    Boolean _state = false;
                                    foreach (TipoMovimientoBE _cDto in lstTipoMovimiento)
                                    {
                                        if (_cDto.Descripcion == objMovimientoBE.Movimiento)
                                        {
                                            objMovimientoBE.CodTipoMovimiento = _cDto.CodTipoMovimiento;
                                            _state = true;
                                            break;
                                        }
                                    }

                                    if (_state == true)
                                    {
                                        List<AvionBE> lstAvion = objAvionDALC.ListarAvionBE();
                                        if (lstAvion != null)
                                        {
                                            Boolean state_ = false;
                                            foreach (AvionBE cDto_ in lstAvion)
                                            {
                                                if (cDto_.Nombre == objMovimientoBE.Avion)
                                                {
                                                    objMovimientoBE.CodAvion = cDto_.CodAvion;
                                                    state_ = true;
                                                    break;
                                                }
                                            }

                                            if(state_==true)
                                            {
                                                result = objMovimientoDALC.InsertarMovimientoBE(objMovimientoBE);

                                                if (result != 0)
                                                {
                                                    //Guardar el registro;
                                                    LogBC objLogBC = new LogBC();
                                                    LogBE objLogBE = new LogBE();
                                                    objLogBE.CodOperacion = result;
                                                    objLogBE.Fecha = DateTime.Now;
                                                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                                                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                                                    objLogBE.Tabla = "Movimiento";
                                                    objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                                                    int r = (objLogBC.RegistrarLog(objLogBE));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public MovimientoBE ObtenerMovimiento(int codigo)
        {
            MovimientoBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                MovimientoDALC objMovimientoDALC = FabricaDALC.getMovimientoDALC();
                obj = objMovimientoDALC.ObtenerMovimientoBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un registro del sistema";
                    objLogBE.Tabla = "Movimiento";
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

        public void ActualizarMovimiento(MovimientoBE objMovimientoBE)
        {
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                MovimientoDALC objMovimientoDALC = FabricaDALC.getMovimientoDALC();
                objMovimientoDALC.ActualizarMovimientoBE(objMovimientoBE);

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objMovimientoBE.CodMovimiento;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Se actualizó un registro del sistema";
                objLogBE.Tabla = "Movimiento";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MovimientoBE> ListarMovimientos()
        {
            List<MovimientoBE> lsMovimientos = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                MovimientoDALC objMovimientoDALC = FabricaDALC.getMovimientoDALC();
                lsMovimientos = objMovimientoDALC.ListarMovimientoBE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsMovimientos;
        }
    }
}