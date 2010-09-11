using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Permissions;
using System.Media;

namespace UPC.Trabajo.KBHit
{
    internal partial class frmNotificacion : Form
    {
        //Representa la posicion vertical del aviso
        int posicion = 0;
        int posVertical = 0;

        #region - Constructor -
        public frmNotificacion(int posicionVertical)
        {
            InitializeComponent();
            posVertical = posicionVertical;
        }
        #endregion

        #region - Agrega el efecto DropShadow al formulario -
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            [SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
            get
            {
                CreateParams parameters = base.CreateParams;

                if (DropShadowSupported)
                {
                    parameters.ClassStyle = (parameters.ClassStyle | CS_DROPSHADOW);
                }

                return parameters;
            }
        }

        public static bool DropShadowSupported
        {
            get { return IsWindowsXPOrAbove; }
        }

        public static bool IsWindowsXPOrAbove
        {
            get
            {
                OperatingSystem system = Environment.OSVersion;
                bool runningNT = system.Platform == PlatformID.Win32NT;

                return runningNT && system.Version.CompareTo(new Version(5, 1, 0, 0)) >= 0;
            }
        }
        #endregion

        #region - Evento Load -
        private void frmNotificacion_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Size.Width - 10, Screen.PrimaryScreen.Bounds.Bottom);
            timerInicio.Enabled = true;
        }
        #endregion

        #region - Evento Tick del timer Inicio -
        private void timerInicio_Tick(object sender, EventArgs e)
        {
            posicion += 5;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - posicion - 37, posVertical);


            if (posicion >= 190)
            {
                timerInicio.Enabled = false;
                timerEspera.Enabled = true;

                SoundPlayer myPlayer = new SoundPlayer(UPC.Trabajo.KBHit.External.recursos.Popup);
                myPlayer.Play();
            }
        }
        #endregion

        #region - Evento click del icono para cerrar el aviso -
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            timerInicio.Enabled = false;
            timerEspera.Enabled = false;
            timerCerrar.Enabled = true;
        }
        #endregion

        #region - Evento tick del timer que cierra el aviso -
        private void timerCerrar_Tick(object sender, EventArgs e)
        {
            posicion -= 5;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - posicion, posVertical);

            if (posicion <= 0)
            {
                this.Opacity = 0.3;
                UPC.Trabajo.KBHit.External.Notificacion.listaSlots.Remove(posVertical);
                this.Close();
            }
        }
        #endregion

        #region - Evento tick del timer que espera -
        private void timerEspera_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            timerEspera.Enabled = false;
            timerCerrar.Enabled = true;
        }
        #endregion

        #region - Evento Mouse Over que evita que se oculte el aviso si el usuario tiene el mouse sobre el -
        private void lblTexto_MouseHover(object sender, EventArgs e)
        {
            timerEspera.Enabled = false;
        }
        #endregion

        #region - Evento Mouse leave que oculta el aviso si el usuario quita el mouse -
        private void lblTexto_MouseLeave(object sender, EventArgs e)
        {
            timerEspera.Enabled = true;
        }
        #endregion

    }
}
