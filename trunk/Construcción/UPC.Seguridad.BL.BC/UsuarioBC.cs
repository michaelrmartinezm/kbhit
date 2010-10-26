using System;
using System.Collections.Generic;
using UPC.Seguridad.BL.BE;
using UPC.Seguridad.DL.DALC;

namespace UPC.Seguridad.BL.BC
{
    public class UsuarioBC
    {
        public List<FuncionalidadBE> UsuarioListarFuncionalidadesXAplicacion(String sLogin, String sContrasenia, String sAplicacion)
        {
            List<FuncionalidadBE> lsFuncionalidades = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                UsuarioDALC objUsuarioDALC = FabricaDALC.getUsuarioDALC();
                int idUsuario = objUsuarioDALC.UsuarioExiste(sLogin);
                if (idUsuario == 0)
                    return lsFuncionalidades;
                else
                {
                    UsuarioBE objUsuarioBE = objUsuarioDALC.UsuarioValidar(idUsuario, sContrasenia);
                    if (objUsuarioBE == null)
                        return lsFuncionalidades;
                    else
                    {
                        AplicacionDALC objAplicacionDALC = FabricaDALC.getAplicacionDALC();
                        AplicacionBE objAplicacionBE = objAplicacionDALC.AplicacionObtenerXNombre(sAplicacion);
                        if (objAplicacionBE == null)
                            return lsFuncionalidades;
                        else
                        {
                            lsFuncionalidades = new List<FuncionalidadBE>();
                            Rol_UsuarioDALC objRolUsuarioDALC = FabricaDALC.getRolUsuarioDALC();
                            List<Rol_UsuarioBE> lsRolUsuarioBE = null;
                            lsRolUsuarioBE = objRolUsuarioDALC.RolUsuarioListarxUsuario(objUsuarioBE);
                            if (lsRolUsuarioBE == null)
                                return lsFuncionalidades;
                            else
                            {
                                Rol_FuncionalidadDALC objRolFuncionalidadDALC = FabricaDALC.getRolFuncionalidadDALC();
                                List<Rol_FuncionalidadBE> lsRolFuncionalidad = new List<Rol_FuncionalidadBE>();
                                for (int i = 0; i < lsRolUsuarioBE.Count; i++)
                                {
                                    lsRolFuncionalidad.AddRange(objRolFuncionalidadDALC.RolFuncionalidadListarXRol(lsRolUsuarioBE[i].ObjRolBE, objAplicacionBE));
                                }
                                for (int i = 0; i < lsRolFuncionalidad.Count; i++)
                                {
                                    lsFuncionalidades.Add(lsRolFuncionalidad[i].ObjFuncionalidadBE);
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
            return lsFuncionalidades;
        }

        public UsuarioBE UsuarioLoguear(String sUsuario, String sContrasenia)
        {
            UsuarioBE objUsuarioBE = null;

            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                UsuarioDALC objUsuarioDALC = FabricaDALC.getUsuarioDALC();
                int idUsuario = objUsuarioDALC.UsuarioExiste(sUsuario);
                if (idUsuario == 0)
                    return objUsuarioBE;
                else 
                {
                    objUsuarioBE = objUsuarioDALC.UsuarioValidar(idUsuario, sContrasenia);
                    if (objUsuarioBE == null)
                        return objUsuarioBE;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objUsuarioBE;
        }

        public List<Rol_UsuarioBE> ListarRoles(String sUsuario, String sContrasenia)
        {
            List<Rol_UsuarioBE> lsRoles = null;

            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);

                UsuarioDALC objUsuarioDALC = FabricaDALC.getUsuarioDALC();
                int idUsuario = objUsuarioDALC.UsuarioExiste(sUsuario);
                if (idUsuario == 0)
                    return lsRoles;
                else
                {
                    UsuarioBE objUsuarioBE = objUsuarioDALC.UsuarioValidar(idUsuario, sContrasenia);
                    if (objUsuarioBE == null)
                    {
                        return lsRoles;
                    }
                    else
                    {
                        Rol_UsuarioDALC objRolUsuarioDALC = FabricaDALC.getRolUsuarioDALC();
                        lsRoles = objRolUsuarioDALC.RolUsuarioListarxUsuario(objUsuarioBE);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsRoles;
        }
    }
}