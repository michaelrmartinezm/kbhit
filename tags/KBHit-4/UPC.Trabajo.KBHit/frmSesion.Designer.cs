namespace UPC.Trabajo.KBHit
{
    partial class frmSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barra = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.panel = new Telerik.WinControls.UI.RadPanel();
            this.lblMensaje = new Telerik.WinControls.UI.RadLabel();
            this.txtContrasena = new Telerik.WinControls.UI.RadTextBox();
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.lblContrasena = new Telerik.WinControls.UI.RadLabel();
            this.lblUsuario = new Telerik.WinControls.UI.RadLabel();
            this.btnSalir = new Telerik.WinControls.UI.RadButton();
            this.btnIngresar = new Telerik.WinControls.UI.RadButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            ((System.ComponentModel.ISupportInitialize)(this.barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.barra.Caption = "Login";
            this.barra.Font = new System.Drawing.Font("Snowdrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barra.Location = new System.Drawing.Point(1, 1);
            this.barra.Name = "barra";
            // 
            // 
            // 
            this.barra.RootElement.ApplyShapeToControl = true;
            this.barra.RootElement.Shape = this.roundRectShapeTitle;
            this.barra.Size = new System.Drawing.Size(408, 63);
            this.barra.TabIndex = 0;
            this.barra.TabStop = false;
            this.barra.Text = "Login";
            this.barra.ThemeName = "Office2007Black";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblMensaje);
            this.panel.Controls.Add(this.txtContrasena);
            this.panel.Controls.Add(this.txtUsuario);
            this.panel.Controls.Add(this.lblContrasena);
            this.panel.Controls.Add(this.lblUsuario);
            this.panel.Location = new System.Drawing.Point(12, 70);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(386, 139);
            this.panel.TabIndex = 1;
            this.panel.ThemeName = "Office2007Black";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(250, 88);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.lblMensaje.RootElement.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Size = new System.Drawing.Size(48, 16);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Usuario";
            this.lblMensaje.Visible = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(170, 62);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.NullText = "Ingrese su password";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(128, 20);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.TabStop = false;
            this.txtContrasena.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.InText);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(170, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NullText = "Ingrese su usuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextChanging += new Telerik.WinControls.TextChangingEventHandler(this.InText);
            // 
            // lblContrasena
            // 
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContrasena.Location = new System.Drawing.Point(76, 66);
            this.lblContrasena.Name = "lblContrasena";
            // 
            // 
            // 
            this.lblContrasena.RootElement.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContrasena.Size = new System.Drawing.Size(79, 18);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Location = new System.Drawing.Point(76, 40);
            this.lblUsuario.Name = "lblUsuario";
            // 
            // 
            // 
            this.lblUsuario.RootElement.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Size = new System.Drawing.Size(55, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(316, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.ThemeName = "Aqua";
            this.btnSalir.Click += new System.EventHandler(this.InCerrar);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(226, 215);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(84, 37);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.ThemeName = "Aqua";
            this.btnIngresar.Click += new System.EventHandler(this.IniciarSesion);
            // 
            // frmSesion
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(410, 264);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.barra);
            this.MaximizeBox = false;
            this.Name = "frmSesion";
            this.Shape = this.roundRectShapeForm;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar barra;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private Telerik.WinControls.UI.RadPanel panel;
        private Telerik.WinControls.UI.RadButton btnSalir;
        private Telerik.WinControls.UI.RadButton btnIngresar;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadTextBox txtContrasena;
        private Telerik.WinControls.UI.RadTextBox txtUsuario;
        private Telerik.WinControls.UI.RadLabel lblContrasena;
        private Telerik.WinControls.UI.RadLabel lblUsuario;
        private Telerik.WinControls.UI.RadLabel lblMensaje;
    }
}