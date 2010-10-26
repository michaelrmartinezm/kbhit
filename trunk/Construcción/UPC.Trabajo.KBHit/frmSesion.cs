using System;
using System.Collections.Generic;
using UPC.Trabajo.KBHit.External;
using UPC.Seguridad.BL.BC;
using UPC.Seguridad.BL.BE;
using UPC.Trabajo.KBHit.BC;

namespace UPC.Trabajo.KBHit
{
    public partial class frmSesion : Telerik.WinControls.UI.ShapedForm
    {
        public frmSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContrasena.Text != "")
            {
                String sUsuario = txtUsuario.Text;
                String sContrasenia = Cryptography.GetMD5Hash(txtContrasena.Text);
                String sAplicacion = this.Name;

                UsuarioBC objUsuarioBC = new UsuarioBC();

                UPC.Seguridad.BL.BE.UsuarioBE objUsuarioSeguridadBE = null;
                objUsuarioSeguridadBE = objUsuarioBC.UsuarioLoguear(sUsuario, sContrasenia);
                if (objUsuarioSeguridadBE.IdUsuario == 0)
                {
                    lblMensaje.Text = "Usuario y/o contraseña incorrectos!!";
                    lblMensaje.Visible = true;
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

                        mdiAeropuerto md = new mdiAeropuerto();
                        md.Show();
                    }
                    else
                        lblMensaje.Text = "Usted no tiene ningun rol asignado";
                }
            }
            else
            {
                lblMensaje.Text = "Ingrese todos los campos";
                lblMensaje.Visible = true;
            }
        }

        private void InCerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InText(object sender, Telerik.WinControls.TextChangingEventArgs e)
        {
            lblMensaje.Visible = false;
        }
    }
}