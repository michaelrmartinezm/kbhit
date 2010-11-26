using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UPC.Trabajo.KBHit.BC;
using UPC.Trabajo.KBHit.BE;

namespace UPC.Trabajo.KBHit
{
    public partial class frmDisponibilidad : Telerik.WinControls.UI.ShapedForm
    {
        private static frmDisponibilidad objDisponibilidad = null;
        public static frmDisponibilidad Instance()
        {
            if (objDisponibilidad == null)
            {
                objDisponibilidad = new frmDisponibilidad();
            }
            return objDisponibilidad;
        }

        public frmDisponibilidad()
        {
            InitializeComponent();
            Refresh.Enabled = true;
            CargarDatos();
        }

        private void dgvDisponibilidadConfigurar()
        {
            try
            {
                dgvDisponibilidad.AllowUserToAddRows = false;
                dgvDisponibilidad.AllowUserToDeleteRows = false;
                dgvDisponibilidad.AllowUserToResizeColumns = false;
                dgvDisponibilidad.AllowUserToResizeRows = false;

                dgvDisponibilidad.AllowDrop = false;

                dgvDisponibilidad.MultiSelect = false; //-- Se protege la grilla para evitar seleccionar varios registros

                dgvDisponibilidad.ReadOnly = true; //-- Se protege la grilla para evitar poder modificar los datos de la grilla

                // Lo siguiente es para elegir toda la fila selecionada
                dgvDisponibilidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvDisponibilidad.Columns[2].Visible = false;
                dgvDisponibilidad.Columns[3].Visible = false;
                dgvDisponibilidad.Columns[4].Visible = false;
                dgvDisponibilidad.Columns[5].Visible = false;
                dgvDisponibilidad.Columns[6].Visible = false;
                dgvDisponibilidad.Columns[7].Visible = false;
                dgvDisponibilidad.Columns[8].Visible = false;
                dgvDisponibilidad.Columns[9].Visible = false;
                dgvDisponibilidad.Columns[10].Visible = false;
                dgvDisponibilidad.Columns[11].Visible = false;
                dgvDisponibilidad.Columns[12].Visible = false;
                dgvDisponibilidad.Columns[13].Visible = false;

                DataGridViewCellStyle csFilaPar = new DataGridViewCellStyle();
                DataGridViewCellStyle csFilaImpar = new DataGridViewCellStyle();

                csFilaPar.BackColor = Color.Azure;
                csFilaImpar.BackColor = Color.Peru;

                int elemento;

                for (elemento = 0; elemento < dgvDisponibilidad.Rows.Count; elemento++)
                {
                    if (elemento % 2 == 0)
                    {
                        dgvDisponibilidad.Rows[elemento].DefaultCellStyle = csFilaPar;
                    }
                    else
                    {
                        dgvDisponibilidad.Rows[elemento].DefaultCellStyle = csFilaImpar;
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void CargarDatos()
        {
            try
            {
                PistaBC objPistaBC = new PistaBC();
                List<PistaBE> lstPista = objPistaBC.ListarPistas();
                if (lstPista != null)
                {
                    dgvDisponibilidad.DataSource = lstPista;
                    dgvDisponibilidadConfigurar();
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InRefreshDGV(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InSeleccionPista(object sender, EventArgs e)
        {
            //-- Estas lineas de código no se usan (aún no detecto porqué) pero no traen problemas
            try
            {
                int codigoPista = (int)dgvDisponibilidad.SelectedRows[0].Cells[0].Value;
                PistaBC objPistaBC = new PistaBC();
                PistaBE objPistaBE = objPistaBC.ObtenerPista(codigoPista);
                if (objPistaBE != null)
                {
                    cbEstado.SelectedText = objPistaBE.Estado;
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }

        private void InActualizarPista(object sender, EventArgs e)
        {
            try
            {
                int codigoPista = (int)dgvDisponibilidad.SelectedRows[0].Cells[1].Value;
                PistaBC objPistaBC = new PistaBC();
                PistaBE objPistaBE = objPistaBC.ObtenerPista(codigoPista);
                //En la versión VS2008 no tenia ningún problema usar cbEstado.SelectText
                //En la versión VS2010, aparentemente trae problemas, pero lo he resuelto usando el SelectItem
                String n_estado = cbEstado.SelectedItem.ToString();
                if (n_estado != objPistaBE.Estado)
                {
                    objPistaBE.Estado = cbEstado.SelectedItem.ToString();
                    int result = objPistaBC.ActualizarPista(objPistaBE);
                    if (result != 0)
                    {
                        objPistaBC.Notify(objPistaBE);
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.RegistrarExcepcion(ex);
            }
        }
    }
}