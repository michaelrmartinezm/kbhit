using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.DALC;
using UPC.Trabajo.KBHit.External;

namespace UPC.Trabajo.KBHit.BC
{
    public class PistaBC
    {

        public int RegistrarPista(PistaBE objPistaBE)
        {
            int result = 0;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PistaDALC objPistaDALC = FabricaDALC.getPistaDALC();
                result = objPistaDALC.InsertarPistaBE(objPistaBE);

                if (result != 0)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = result;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Inserción de un nuevo registro en el sistema";
                    objLogBE.Tabla = "Pista";
                    objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                    int r = (objLogBC.RegistrarLog(objLogBE));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public PistaBE ObtenerPista(int codigo)
        {
            PistaBE obj = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PistaDALC objPistaDALC = FabricaDALC.getPistaDALC();
                obj = objPistaDALC.ObtenerPistaBE(codigo);

                if (obj != null)
                {
                    //Guardar el registro;
                    LogBC objLogBC = new LogBC();
                    LogBE objLogBE = new LogBE();
                    objLogBE.CodOperacion = codigo;
                    objLogBE.Fecha = DateTime.Now;
                    objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                    objLogBE.Razon = "Se obtuvo un registro del sistema";
                    objLogBE.Tabla = "Pista";
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

        public int ActualizarPista(PistaBE objPistaBE)
        {
            int result = 0;

            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PistaDALC objPistaDALC = FabricaDALC.getPistaDALC();
                objPistaDALC.ActualizarPistaBE(objPistaBE);
                result = 1;

                //Guardar el registro;
                LogBC objLogBC = new LogBC();
                LogBE objLogBE = new LogBE();
                objLogBE.CodOperacion = objPistaBE.CodPista;
                objLogBE.Fecha = DateTime.Now;
                objLogBE.IP = UPC.Trabajo.KBHit.BC.Properties.Settings.Default.IP;
                objLogBE.Razon = "Se actuzalizó un registro del sistema";
                objLogBE.Tabla = "Pista";
                objLogBE.Usuario = "UsuarioX"; //Debo obtener el usuario
                int r = (objLogBC.RegistrarLog(objLogBE));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public List<PistaBE> ListarPistas()
        {
            List<PistaBE> lsPistas = null;
            try
            {
                DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
                PistaDALC objPistaDALC = FabricaDALC.getPistaDALC();
                lsPistas = objPistaDALC.ListarPistaBE();

                //EL SIGUIENTE CÓDIGO ES PARA CUANDO SE DETERMINE UN AEROPUERTO ESPECIFICO PARA UNA 'IP'
                //List<PistaBE> lstPista = null;
                //CodigoDefault = UnoEspecifico;
                //
                //if(lstPista!=null)
                //{
                //    foreach (PistaBE cDto in lsPistas)
                //    {
                //        if (cDto.CodAeropuerto == CodigoDefault)
                //        {
                //            if (lstPista == null) lstPista = new List<PistaBE>();
                //            lstPista.Add(cDto);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsPistas;
            //return lstPista
        }

        public void Notify(PistaBE objPistaBE)
        {
            DALCFactory FabricaDALC = DALCFactory.getFabrica(DALCFactory.SQL);
            PistaDALC objPistaDALC = FabricaDALC.getPistaDALC();

            foreach (UsuarioBE _observador in objPistaDALC.LstUsuario)
            {
                _observador.Actualizar(objPistaBE);
            }            
        }

        public void SerObservador(UsuarioBE objUsuarioBE)
        {
            String IP = Properties.Settings.Default.IP;
            DALCFactory fabrica = DALCFactory.getFabrica(DALCFactory.SQL);
            IPAeropuertoDALC obj = fabrica.getIPAeropuerto();
            IPAeropuertoBE aeropuerto = obj.ObtenerIPAeropuerto(IP);
            int codigoAero = aeropuerto.CodAeropuerto;

            PistaDALC pista = fabrica.getPistaDALC();
            List<PistaBE> lst = new List<PistaBE>();
            lst = pista.ListarPistaBE();
            List<PistaBE> myLst = new List<PistaBE>();
            foreach (PistaBE cDto in lst)
            {
                if (cDto.CodAeropuerto == codigoAero)
                {
                    if (myLst == null) { myLst = new List<PistaBE>(); }
                    myLst.Add(cDto);
                }
            }

            PistaDALC ovj = fabrica.getPistaDALC();


            /*foreach (PistaBE _cDto in myLst)
            {*/
                ovj.AgregarObservador(objUsuarioBE);
            /*}*/
        }
    }
}