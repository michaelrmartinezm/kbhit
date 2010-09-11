using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UPC.Trabajo.KBHit.BC;
using UPC.Trabajo.KBHit.BE;
using UPC.Trabajo.KBHit.External;

namespace UPC.Trabajo.KBHit
{
    public partial class frmPlandeVuelo : Form
    {
        private static frmPlandeVuelo objPlandeVuelo = null;
        public static frmPlandeVuelo Instance()
        {
            if (objPlandeVuelo == null)
            {
                objPlandeVuelo = new frmPlandeVuelo();
            }
            return objPlandeVuelo;
        }

        public frmPlandeVuelo()
        {
            InitializeComponent();
        }

        private void InGuardarPlanDeVuelo(object sender, EventArgs e)
        {
            try
            {
                Notificacion.Imagen tipoImagen = 0;
                String msg = "He seleccionado la aerolinea: " + cbAerolinea.SelectedText + "cuyo código es: " + cbAerolinea.SelectedValue;
                Notificacion.mostrarVentana("Alerta", msg, tipoImagen, 10);

                if (CamposLlenos())
                {
                    if (FormatoCorrecto())
                    {
                        if (LongitudCorrecto())
                        {
                            PlanVueloBC objPlanVueloBC = new PlanVueloBC();
                            PlanDeVueloBE objPlanVueloBE = new PlanDeVueloBE();
                            DestinoBE objDestinoBE = new DestinoBE();
                            SalidaBE objSalidaBE = new SalidaBE();
                            InformacionVueloBE objInformacionVueloBE = new InformacionVueloBE();

                            DateTime fecha = new DateTime(); fecha = DateTime.ParseExact((txtHora.Text), "dd/mm/yyyy", null);

                            objPlanVueloBE.Aerolinea = cbAerolinea.SelectedText;
                            objPlanVueloBE.Destinatario = rtbDestinatarios.Text;
                            objPlanVueloBE.Presentador = rtbPresentador.Text;
                            objPlanVueloBE.Prioridad = cbPrioridad.SelectedText;
                            objPlanVueloBE.Remitente = txtRemitente.Text;
                            objPlanVueloBE.Requisitos = rtbRequisitos.Text;

                            objPlanVueloBE.AerodromoSalida = cbAerodromoSalida.SelectedText;
                            objSalidaBE.CodAvion = Convert.ToInt32(cbNave.SelectedText);
                            objSalidaBE.Equipo = txtEquipo.Text;
                            objSalidaBE.Hora = fecha;
                            objSalidaBE.Nivel = (float)Convert.ToDouble(txtNivel.Text);
                            objSalidaBE.Numero = Convert.ToInt32(txtNumero.Text);
                            objSalidaBE.Placa = txtPlaca.Text;
                            objSalidaBE.ReglaVuelo = cbReglasVuelo.SelectedText;

                            objPlanVueloBE.AerodromoDestino = cbAerodromoDestno.SelectedText;
                            objPlanVueloBE.AerodromoAlterno_ = cbAerodromoAlterno.SelectedText;
                            objPlanVueloBE.AerodromoAlterno__ = cbAerodromoAlterno2.SelectedText;
                            objDestinoBE.TiempoHr = dudHoras.Text;
                            objDestinoBE.TiempoMin = dudMinutos.Text;

                            objInformacionVueloBE.Capacidad = Convert.ToInt32(dudCapacidad.Text);
                            objInformacionVueloBE.Color = txtColor.Text;
                            objInformacionVueloBE.Cubierta = StateChecked(chbCubierta);
                            objInformacionVueloBE.Desierto = StateChecked(chbDesertico);
                            objInformacionVueloBE.Elt = StateChecked(CHBelt);
                            objInformacionVueloBE.Fluor = StateChecked(chbFluor);
                            objInformacionVueloBE.Luz = StateChecked(chbLuz);
                            objInformacionVueloBE.Polar = StateChecked(chbPolar);
                            objInformacionVueloBE.Maritimo = StateChecked(chbMaritimo);
                            objInformacionVueloBE.Selva = StateChecked(chbSelva);
                            objInformacionVueloBE.Uhf = StateChecked(chbUHF);
                            objInformacionVueloBE.Vhf = StateChecked(chbVHF);
                            objInformacionVueloBE.MarcasNave = txtColorMarca.Text;
                            objInformacionVueloBE.Observaciones = txtObservaciones.Text;
                            objInformacionVueloBE.Piloto = txtPilotoMancod.Text;

                            int codigo = objPlanVueloBC.RegistrarPlanVuelo(objPlanVueloBE, objSalidaBE, objDestinoBE, objInformacionVueloBE);

                            if (codigo != 0)
                            {
                                MessageBox.Show(String.Format("El Plan de Vuelo con código {0} fue registrado satisfactoriamente.", codigo), "Sistema de Gestión Aereo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido registrar el Plan de Vuelo.", "Sistema de Gestión Aereo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private Boolean CamposLlenos()
        {
            if (cbAerolinea.SelectedItem != null)
            {
                if (cbPrioridad.SelectedItem != null)
                {
                    if (rtbDestinatarios.Text != "")
                    {
                        if (rtbPresentador.Text != "")
                        {
                            if (txtRemitente.Text != "")
                            {
                                if (rtbRequisitos.Text != "")
                                {
                                    if (txtNumero.Text != "")
                                    {
                                        if (txtPlaca.Text != "")
                                        {
                                            if (cbReglasVuelo.SelectedItem != null)
                                            {
                                                if (cbTipoVuelo.SelectedItem != null)
                                                {
                                                    if (cbNave.SelectedItem != null)
                                                    {
                                                        if (txtTurbulencia.Text != "")
                                                        {
                                                            if (txtEquipo.Text != "")
                                                            {
                                                                if (txtNivel.Text != "")
                                                                {
                                                                    if (cbAerodromoSalida.SelectedItem != null)
                                                                    {
                                                                        if (txtHora.Text != "")
                                                                        {
                                                                            if (txtCrucero.Text != "")
                                                                            {
                                                                                if (rtbRuta.Text != "")
                                                                                {
                                                                                    if (cbAerodromoDestno.SelectedItem != null)
                                                                                    {
                                                                                        if (dudHoras.Text != "")
                                                                                        {
                                                                                            if (dudMinutos.Text != "")
                                                                                            {
                                                                                                if (cbAerodromoAlterno.SelectedItem != null)
                                                                                                {
                                                                                                    if (cbAerodromoAlterno2.SelectedItem != null)
                                                                                                    {
                                                                                                        if (dudHorasInfo.Text != "")
                                                                                                        {
                                                                                                            if (dudMinutosInfo.Text != "")
                                                                                                            {
                                                                                                                if (dudPersonasAbordo.Text != "")
                                                                                                                {
                                                                                                                    if (txtNumeroInfo.Text != "")
                                                                                                                    {
                                                                                                                        if (dudCapacidad.Text != "")
                                                                                                                        {
                                                                                                                            if (txtColor.Text != "")
                                                                                                                            {
                                                                                                                                if (txtColorMarca.Text != "")
                                                                                                                                {
                                                                                                                                    if(txtObservaciones.Text != "")
                                                                                                                                    {
                                                                                                                                        if (txtPilotoMancod.Text != "")
                                                                                                                                        {
                                                                                                                                           return true;
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
                }
            }
            return false;
        }

        private Boolean FormatoCorrecto()
        {
            int valueI;
            long valueL;
            float valueF;
            valueL = Convert.ToInt64(txtNumero.Text);
            if (valueL > 0)
            {
                valueF = (float)Convert.ToDouble(txtNivel.Text);
                if(valueF > 0.0)
                {
                    valueF = (float)Convert.ToDouble(txtCrucero.Text);
                    if (valueF > 0.0)
                    {
                        valueI = Convert.ToInt32(dudHoras.Text);
                        if (valueI > 0)
                        {
                            valueI = Convert.ToInt32(dudMinutos.Text);
                            if (valueI > 0)
                            {
                                valueI = Convert.ToInt32(dudHorasInfo.Text);
                                if (valueI > 0)
                                {
                                    valueI = Convert.ToInt32(dudMinutosInfo.Text);
                                    if (valueI > 0)
                                    {
                                        valueI = Convert.ToInt32(dudPersonasAbordo.Text);
                                        if (valueI > 0)
                                        {
                                            valueI = Convert.ToInt32(txtNumeroInfo.Text);
                                            if (valueI > 0)
                                            {
                                                valueI = Convert.ToInt32(dudCapacidad.Text);
                                                if (valueI > 0)
                                                {
                                                    return true;
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
            return false;
        }

        private Boolean LongitudCorrecto()
        {
            if (rtbDestinatarios.Text.Length < 1000)
            {
                if (txtRemitente.Text.Length < 500)
                {
                    if (rtbPresentador.Text.Length < 500)
                    {
                        if (rtbRequisitos.Text.Length < 1000)
                        {
                            if (txtPlaca.Text.Length < 50)
                            {
                                if (txtEquipo.Text.Length < 50)
                                {
                                    if (rtbRuta.Text.Length < 8000)
                                    {
                                        if (txtColor.Text.Length < 500)
                                        {
                                            if (txtColorMarca.Text.Length < 500)
                                            {
                                                if (txtObservaciones.Text.Length < 1000)
                                                {
                                                    if (txtPilotoMancod.Text.Length < 500)
                                                    {
                                                        return true;
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
            }
            return false;
        }

        private int StateChecked(CheckBox obj)
        {
            if (obj.Checked) return 1;
            else
                return 0;
        }
    }
}