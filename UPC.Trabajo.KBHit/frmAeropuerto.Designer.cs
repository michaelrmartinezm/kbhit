namespace UPC.Trabajo.KBHit
{
    partial class frmAeropuerto
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
            objAeropuerto = null;
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
            this.radToolStrip1 = new Telerik.WinControls.UI.RadToolStrip();
            this.radToolStripElement1 = new Telerik.WinControls.UI.RadToolStripElement();
            this.radToolStripItem1 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.lbFUEL = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.dudServicioEmergencia = new System.Windows.Forms.DomainUpDown();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtElevacion = new System.Windows.Forms.TextBox();
            this.txtOACI = new System.Windows.Forms.TextBox();
            this.txtIATA = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbServiciosEmergencias = new System.Windows.Forms.Label();
            this.lbElevacion = new System.Windows.Forms.Label();
            this.lbOACI = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.lbIATA = new System.Windows.Forms.Label();
            this.lbDepartamento = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.gbAeropuerto = new System.Windows.Forms.GroupBox();
            this.cbAeropuerto = new System.Windows.Forms.ComboBox();
            this.lbAeropuerto = new System.Windows.Forms.Label();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.gbAeropuerto.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Caption = "Aeropuerto";
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            // 
            // 
            // 
            this.barra.RootElement.ApplyShapeToControl = true;
            this.barra.RootElement.Shape = this.roundRectShapeTitle;
            this.barra.Size = new System.Drawing.Size(435, 23);
            this.barra.TabIndex = 0;
            this.barra.TabStop = false;
            this.barra.Text = "frm_Aeropuerto";
            this.barra.ThemeName = "Breeze";
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Enabled = false;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.barra.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // radToolStrip1
            // 
            this.radToolStrip1.AllowDragging = false;
            this.radToolStrip1.AllowFloating = false;
            this.radToolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radToolStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToolStripElement1});
            this.radToolStrip1.Location = new System.Drawing.Point(0, 23);
            this.radToolStrip1.MinimumSize = new System.Drawing.Size(5, 5);
            this.radToolStrip1.Name = "radToolStrip1";
            this.radToolStrip1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radToolStrip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radToolStrip1.RootElement.MinSize = new System.Drawing.Size(5, 5);
            this.radToolStrip1.ShowOverFlowButton = true;
            this.radToolStrip1.Size = new System.Drawing.Size(435, 26);
            this.radToolStrip1.TabIndex = 1;
            this.radToolStrip1.Text = "radToolStrip1";
            this.radToolStrip1.ThemeName = "Office2007Black";
            // 
            // radToolStripElement1
            // 
            this.radToolStripElement1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToolStripItem1});
            this.radToolStripElement1.Name = "radToolStripElement1";
            // 
            // radToolStripItem1
            // 
            this.radToolStripItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement3,
            this.radButtonElement2});
            this.radToolStripItem1.Key = "0";
            this.radToolStripItem1.Name = "radToolStripItem1";
            this.radToolStripItem1.Text = "radToolStripItem1";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "Actualizar";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.ShowBorder = false;
            this.radButtonElement3.Text = "Pista";
            this.radButtonElement3.Click += new System.EventHandler(this.InPistaConsultar);
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "Plataforma";
            this.radButtonElement2.Click += new System.EventHandler(this.InPlataformaConsultar);
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalle.Controls.Add(this.cbFuel);
            this.gbDetalle.Controls.Add(this.lbFUEL);
            this.gbDetalle.Controls.Add(this.cbDepartamento);
            this.gbDetalle.Controls.Add(this.dudServicioEmergencia);
            this.gbDetalle.Controls.Add(this.txtFecha);
            this.gbDetalle.Controls.Add(this.txtHorario);
            this.gbDetalle.Controls.Add(this.txtElevacion);
            this.gbDetalle.Controls.Add(this.txtOACI);
            this.gbDetalle.Controls.Add(this.txtIATA);
            this.gbDetalle.Controls.Add(this.txtCiudad);
            this.gbDetalle.Controls.Add(this.txtNombre);
            this.gbDetalle.Controls.Add(this.lbFecha);
            this.gbDetalle.Controls.Add(this.lbHorario);
            this.gbDetalle.Controls.Add(this.lbServiciosEmergencias);
            this.gbDetalle.Controls.Add(this.lbElevacion);
            this.gbDetalle.Controls.Add(this.lbOACI);
            this.gbDetalle.Controls.Add(this.lbCiudad);
            this.gbDetalle.Controls.Add(this.lbIATA);
            this.gbDetalle.Controls.Add(this.lbDepartamento);
            this.gbDetalle.Controls.Add(this.lbNombre);
            this.gbDetalle.Location = new System.Drawing.Point(12, 161);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(410, 387);
            this.gbDetalle.TabIndex = 3;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // cbFuel
            // 
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(185, 351);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(174, 21);
            this.cbFuel.TabIndex = 20;
            // 
            // lbFUEL
            // 
            this.lbFUEL.AutoSize = true;
            this.lbFUEL.Location = new System.Drawing.Point(29, 355);
            this.lbFUEL.Name = "lbFUEL";
            this.lbFUEL.Size = new System.Drawing.Size(34, 13);
            this.lbFUEL.TabIndex = 19;
            this.lbFUEL.Text = "FUEL";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(185, 59);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(174, 21);
            this.cbDepartamento.TabIndex = 18;
            // 
            // dudServicioEmergencia
            // 
            this.dudServicioEmergencia.Location = new System.Drawing.Point(185, 245);
            this.dudServicioEmergencia.Name = "dudServicioEmergencia";
            this.dudServicioEmergencia.Size = new System.Drawing.Size(174, 20);
            this.dudServicioEmergencia.TabIndex = 17;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(185, 320);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(174, 20);
            this.txtFecha.TabIndex = 16;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(185, 284);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(174, 20);
            this.txtHorario.TabIndex = 15;
            // 
            // txtElevacion
            // 
            this.txtElevacion.Location = new System.Drawing.Point(185, 204);
            this.txtElevacion.Name = "txtElevacion";
            this.txtElevacion.Size = new System.Drawing.Size(174, 20);
            this.txtElevacion.TabIndex = 14;
            // 
            // txtOACI
            // 
            this.txtOACI.Location = new System.Drawing.Point(185, 167);
            this.txtOACI.Name = "txtOACI";
            this.txtOACI.Size = new System.Drawing.Size(174, 20);
            this.txtOACI.TabIndex = 13;
            // 
            // txtIATA
            // 
            this.txtIATA.Location = new System.Drawing.Point(185, 131);
            this.txtIATA.Name = "txtIATA";
            this.txtIATA.Size = new System.Drawing.Size(174, 20);
            this.txtIATA.TabIndex = 12;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(185, 94);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(174, 20);
            this.txtCiudad.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(185, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(29, 327);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(150, 13);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Última Fecha de Actualización";
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(29, 291);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(108, 13);
            this.lbHorario.TabIndex = 8;
            this.lbHorario.Text = "Horario de Operación";
            // 
            // lbServiciosEmergencias
            // 
            this.lbServiciosEmergencias.AutoSize = true;
            this.lbServiciosEmergencias.Location = new System.Drawing.Point(29, 251);
            this.lbServiciosEmergencias.Name = "lbServiciosEmergencias";
            this.lbServiciosEmergencias.Size = new System.Drawing.Size(124, 13);
            this.lbServiciosEmergencias.TabIndex = 7;
            this.lbServiciosEmergencias.Text = "Servicios de Emergencia";
            // 
            // lbElevacion
            // 
            this.lbElevacion.AutoSize = true;
            this.lbElevacion.Location = new System.Drawing.Point(29, 211);
            this.lbElevacion.Name = "lbElevacion";
            this.lbElevacion.Size = new System.Drawing.Size(54, 13);
            this.lbElevacion.TabIndex = 6;
            this.lbElevacion.Text = "Elevación";
            // 
            // lbOACI
            // 
            this.lbOACI.AutoSize = true;
            this.lbOACI.Location = new System.Drawing.Point(32, 174);
            this.lbOACI.Name = "lbOACI";
            this.lbOACI.Size = new System.Drawing.Size(32, 13);
            this.lbOACI.TabIndex = 5;
            this.lbOACI.Text = "OACI";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(29, 101);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(40, 13);
            this.lbCiudad.TabIndex = 4;
            this.lbCiudad.Text = "Ciudad";
            // 
            // lbIATA
            // 
            this.lbIATA.AutoSize = true;
            this.lbIATA.Location = new System.Drawing.Point(32, 138);
            this.lbIATA.Name = "lbIATA";
            this.lbIATA.Size = new System.Drawing.Size(31, 13);
            this.lbIATA.TabIndex = 3;
            this.lbIATA.Text = "IATA";
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.AutoSize = true;
            this.lbDepartamento.Location = new System.Drawing.Point(29, 66);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lbDepartamento.TabIndex = 2;
            this.lbDepartamento.Text = "Departamento";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 34);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(116, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre del Aeropuerto";
            // 
            // gbAeropuerto
            // 
            this.gbAeropuerto.BackColor = System.Drawing.Color.Transparent;
            this.gbAeropuerto.Controls.Add(this.cbAeropuerto);
            this.gbAeropuerto.Controls.Add(this.lbAeropuerto);
            this.gbAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAeropuerto.Location = new System.Drawing.Point(12, 56);
            this.gbAeropuerto.Name = "gbAeropuerto";
            this.gbAeropuerto.Size = new System.Drawing.Size(410, 88);
            this.gbAeropuerto.TabIndex = 2;
            this.gbAeropuerto.TabStop = false;
            this.gbAeropuerto.Text = "Aeropuerto";
            // 
            // cbAeropuerto
            // 
            this.cbAeropuerto.FormattingEnabled = true;
            this.cbAeropuerto.Location = new System.Drawing.Point(185, 39);
            this.cbAeropuerto.Name = "cbAeropuerto";
            this.cbAeropuerto.Size = new System.Drawing.Size(174, 23);
            this.cbAeropuerto.TabIndex = 1;
            this.cbAeropuerto.SelectedValueChanged += new System.EventHandler(this.InElegirAeropuerto);
            // 
            // lbAeropuerto
            // 
            this.lbAeropuerto.AutoSize = true;
            this.lbAeropuerto.Location = new System.Drawing.Point(29, 42);
            this.lbAeropuerto.Name = "lbAeropuerto";
            this.lbAeropuerto.Size = new System.Drawing.Size(67, 15);
            this.lbAeropuerto.TabIndex = 0;
            this.lbAeropuerto.Text = "Aeropuerto";
            // 
            // frmAeropuerto
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(435, 561);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbAeropuerto);
            this.Controls.Add(this.radToolStrip1);
            this.Controls.Add(this.barra);
            this.Name = "frmAeropuerto";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Aeropuerto";
            ((System.ComponentModel.ISupportInitialize)(this.barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.gbAeropuerto.ResumeLayout(false);
            this.gbAeropuerto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar barra;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private Telerik.WinControls.UI.RadToolStrip radToolStrip1;
        private Telerik.WinControls.UI.RadToolStripElement radToolStripElement1;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.Label lbFUEL;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.DomainUpDown dudServicioEmergencia;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtElevacion;
        private System.Windows.Forms.TextBox txtOACI;
        private System.Windows.Forms.TextBox txtIATA;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbServiciosEmergencias;
        private System.Windows.Forms.Label lbElevacion;
        private System.Windows.Forms.Label lbOACI;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbIATA;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.GroupBox gbAeropuerto;
        private System.Windows.Forms.ComboBox cbAeropuerto;
        private System.Windows.Forms.Label lbAeropuerto;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
    }
}