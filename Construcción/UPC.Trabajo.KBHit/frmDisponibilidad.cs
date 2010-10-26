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

                // Opcion a seleccionar varios registros
                dgvDisponibilidad.MultiSelect = false;

                // Para evitar poder modificar los datos de la grilla
                dgvDisponibilidad.ReadOnly = true;

                // Para poder hacer clic en cualquier parte de la fila y que toda la fila aparezca selecionada
                dgvDisponibilidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Customizar las columnas de la grilla
                /*dgvDisponibilidad.Columns[0].HeaderText = "Código";
                dgvDisponibilidad.Columns[0].DataPropertyName = "CodPista";
                dgvDisponibilidad.Columns[0].Width = 80;

                dgvDisponibilidad.Columns[1].HeaderText = "Estado";
                dgvDisponibilidad.Columns[1].DataPropertyName = "Estado";
                dgvDisponibilidad.Columns[1].Width = 120;
                */
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

                csFilaPar.BackColor = Color.Silver;
                csFilaImpar.BackColor = Color.White;

                int i;

                for (i = 0; i < dgvDisponibilidad.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dgvDisponibilidad.Rows[i].DefaultCellStyle = csFilaPar;
                    }
                    else
                    {
                        dgvDisponibilidad.Rows[i].DefaultCellStyle = csFilaImpar;
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
                String n_estado = cbEstado.SelectedText;
                if (n_estado != objPistaBE.Estado)
                {
                    objPistaBE.Estado = cbEstado.SelectedText;
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