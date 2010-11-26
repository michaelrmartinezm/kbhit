namespace UPC.Trabajo.KBHit
{
    partial class frmAerolinea
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
            objAerolinea = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.gbDatosAerolinea = new System.Windows.Forms.GroupBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Foto = new DevExpress.XtraEditors.PictureEdit();
            this.cbProcedencia = new System.Windows.Forms.ComboBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtNombreAerolinea = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbProcedencia = new System.Windows.Forms.Label();
            this.lbRuc = new System.Windows.Forms.Label();
            this.lbNombreAerolinea = new System.Windows.Forms.Label();
            this.lbCodAerolinea = new System.Windows.Forms.Label();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.grupo1 = new Telerik.WinControls.UI.RadPanel();
            this.tsbCerrar = new Telerik.WinControls.UI.RadButton();
            this.tsbNuevo = new Telerik.WinControls.UI.RadButton();
            this.tsbGuardar = new Telerik.WinControls.UI.RadButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            this.gbDatosAerolinea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo1)).BeginInit();
            this.grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Caption = "Aerolinea";
            this.radTitleBar1.Location = new System.Drawing.Point(1, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(634, 30);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.ThemeName = "Breeze";
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // gbDatosAerolinea
            // 
            this.gbDatosAerolinea.BackColor = System.Drawing.Color.Transparent;
            this.gbDatosAerolinea.Controls.Add(this.panelControl1);
            this.gbDatosAerolinea.Controls.Add(this.cbProcedencia);
            this.gbDatosAerolinea.Controls.Add(this.txtRuc);
            this.gbDatosAerolinea.Controls.Add(this.txtNombreAerolinea);
            this.gbDatosAerolinea.Controls.Add(this.txtCodigo);
            this.gbDatosAerolinea.Controls.Add(this.lbProcedencia);
            this.gbDatosAerolinea.Controls.Add(this.lbRuc);
            this.gbDatosAerolinea.Controls.Add(this.lbNombreAerolinea);
            this.gbDatosAerolinea.Controls.Add(this.lbCodAerolinea);
            this.gbDatosAerolinea.Location = new System.Drawing.Point(12, 37);
            this.gbDatosAerolinea.Name = "gbDatosAerolinea";
            this.gbDatosAerolinea.Size = new System.Drawing.Size(521, 189);
            this.gbDatosAerolinea.TabIndex = 2;
            this.gbDatosAerolinea.TabStop = false;
            this.gbDatosAerolinea.Text = "Datos de la Aerolínea";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Foto);
            this.panelControl1.Location = new System.Drawing.Point(17, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(130, 137);
            this.panelControl1.TabIndex = 8;
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(5, 5);
            this.Foto.Name = "Foto";
            this.Foto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Foto.Size = new System.Drawing.Size(120, 127);
            this.Foto.TabIndex = 0;
            // 
            // cbProcedencia
            // 
            this.cbProcedencia.FormattingEnabled = true;
            this.cbProcedencia.Items.AddRange(new object[] {
            "Lima",
            "Ica"});
            this.cbProcedencia.Location = new System.Drawing.Point(301, 143);
            this.cbProcedencia.Name = "cbProcedencia";
            this.cbProcedencia.Size = new System.Drawing.Size(198, 21);
            this.cbProcedencia.TabIndex = 7;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(301, 117);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(198, 20);
            this.txtRuc.TabIndex = 6;
            // 
            // txtNombreAerolinea
            // 
            this.txtNombreAerolinea.Location = new System.Drawing.Point(301, 91);
            this.txtNombreAerolinea.Name = "txtNombreAerolinea";
            this.txtNombreAerolinea.Size = new System.Drawing.Size(198, 20);
            this.txtNombreAerolinea.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(301, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(198, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lbProcedencia
            // 
            this.lbProcedencia.AutoSize = true;
            this.lbProcedencia.Location = new System.Drawing.Point(172, 151);
            this.lbProcedencia.Name = "lbProcedencia";
            this.lbProcedencia.Size = new System.Drawing.Size(67, 13);
            this.lbProcedencia.TabIndex = 3;
            this.lbProcedencia.Text = "Procedencia";
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.Location = new System.Drawing.Point(172, 124);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(39, 13);
            this.lbRuc.TabIndex = 2;
            this.lbRuc.Text = "R-U.C.";
            // 
            // lbNombreAerolinea
            // 
            this.lbNombreAerolinea.AutoSize = true;
            this.lbNombreAerolinea.Location = new System.Drawing.Point(172, 98);
            this.lbNombreAerolinea.Name = "lbNombreAerolinea";
            this.lbNombreAerolinea.Size = new System.Drawing.Size(119, 13);
            this.lbNombreAerolinea.TabIndex = 1;
            this.lbNombreAerolinea.Text = "Nombre de la Aerolínea";
            // 
            // lbCodAerolinea
            // 
            this.lbCodAerolinea.AutoSize = true;
            this.lbCodAerolinea.Location = new System.Drawing.Point(172, 72);
            this.lbCodAerolinea.Name = "lbCodAerolinea";
            this.lbCodAerolinea.Size = new System.Drawing.Size(40, 13);
            this.lbCodAerolinea.TabIndex = 0;
            this.lbCodAerolinea.Text = "Código";
            // 
            // grupo1
            // 
            this.grupo1.Controls.Add(this.tsbCerrar);
            this.grupo1.Controls.Add(this.tsbNuevo);
            this.grupo1.Controls.Add(this.tsbGuardar);
            this.grupo1.Location = new System.Drawing.Point(540, 82);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(84, 144);
            this.grupo1.TabIndex = 3;
            this.grupo1.ThemeName = "Breeze";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Location = new System.Drawing.Point(3, 99);
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(78, 39);
            this.tsbCerrar.TabIndex = 2;
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.ThemeName = "Aqua";
            this.tsbCerrar.Click += new System.EventHandler(this.InCerrar);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Location = new System.Drawing.Point(3, 54);
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(78, 39);
            this.tsbNuevo.TabIndex = 1;
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.ThemeName = "Aqua";
            this.tsbNuevo.Click += new System.EventHandler(this.bnNuevaAerolinea);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Location = new System.Drawing.Point(3, 9);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(78, 39);
            this.tsbGuardar.TabIndex = 0;
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.ThemeName = "Aqua";
            this.tsbGuardar.Click += new System.EventHandler(this.bnGuardarAerolinea);
            // 
            // frmAerolinea
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(636, 238);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.gbDatosAerolinea);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "frmAerolinea";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Aerolinea";
            this.ThemeName = "Breeze";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            this.gbDatosAerolinea.ResumeLayout(false);
            this.gbDatosAerolinea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo1)).EndInit();
            this.grupo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tsbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private System.Windows.Forms.GroupBox gbDatosAerolinea;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit Foto;
        private System.Windows.Forms.ComboBox cbProcedencia;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtNombreAerolinea;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbProcedencia;
        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.Label lbNombreAerolinea;
        private System.Windows.Forms.Label lbCodAerolinea;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.UI.RadPanel grupo1;
        private Telerik.WinControls.UI.RadButton tsbNuevo;
        private Telerik.WinControls.UI.RadButton tsbGuardar;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadButton tsbCerrar;
    }
}