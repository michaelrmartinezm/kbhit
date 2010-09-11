using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UPC.Trabajo.KBHit.External;
using UPC.Seguridad.BL.BC;
using UPC.Seguridad.BL.BE;
using UPC.Trabajo.KBHit.BC;

namespace UPC.Trabajo.KBHit
{
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }

        private void InIniciarSesion(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sContrasenia = Cryptography.GetMD5Hash(txtContrasena.Text);
            String sAplicacion = this.Name;

            UsuarioBC objUsuarioBC = new UsuarioBC();

            UPC.Seguridad.BL.BE.UsuarioBE objUsuarioSeguridadBE = objUsuarioBC.UsuarioLoguear(sUsuario, sContrasenia);
            if (objUsuarioSeguridadBE == null)
            {
                lblMensaje.Text = "Usuario y/o contraseña incorrectos!!";
            }
            else
            {
                Funciones.UsuarioLogueado = objUsuarioSeguridadBE.IdUsuario;
                PistaBC objPistaBC = new PistaBC();
                

                UPC.Trabajo.KBHit.BE.UsuarioBE objUsuarioBE = UPC.Trabajo.KBHit.BE.UsuarioBE.getInstancia();
                objUsuarioBE.NombreUsuario = objUsuarioSeguridadBE.NombreUsuario;
                objUsuarioBE.ApellidoPaterno = objUsuarioSeguridadBE.ApellidoPaterno;
                objUsuarioBE.ApellidoMaterno = objUsuarioSeguridadBE.ApellidoMaterno;

                List<Rol_UsuarioBE> lsRolXUsuario = objUsuarioBC.ListarRoles(sUsuario, sContrasenia);

                if (lsRolXUsuario != null)
                {
                    objUsuarioBE.LsRoles = new List<String>();

                    for (int i = 0; i < lsRolXUsuario.Count; i++)
                    {
                        objUsuarioBE.LsRoles.Add(lsRolXUsuario[i].ObjRolBE.DescripcionRol);
                    }

                    objPistaBC.SerObservador(objUsuarioBE);
                    //llenar la lista de suscriptores en las pistas del aeropuerto

                    mdiAeropuertos md = new mdiAeropuertos();
                    md.Show();
                }
                else
                    lblMensaje.Text = "Usted no tiene ningun rol asignado";
            }
        }

        private void InCerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = Cryptography.GetMD5Hash("u610039");
        }
    }
}
