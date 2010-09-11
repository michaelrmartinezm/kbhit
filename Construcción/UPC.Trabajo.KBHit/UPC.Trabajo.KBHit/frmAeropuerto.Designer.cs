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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAeropuerto));
            this.gbAeropuerto = new System.Windows.Forms.GroupBox();
            this.cbAeropuerto = new System.Windows.Forms.ComboBox();
            this.lbAeropuerto = new System.Windows.Forms.Label();
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
            this.tsMenuAeropuerto = new System.Windows.Forms.ToolStrip();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbPista = new System.Windows.Forms.ToolStripButton();
            this.tsbPlataforma = new System.Windows.Forms.ToolStripButton();
            this.gbAeropuerto.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.tsMenuAeropuerto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAeropuerto
            // 
            this.gbAeropuerto.BackColor = System.Drawing.Color.Transparent;
            this.gbAeropuerto.Controls.Add(this.cbAeropuerto);
            this.gbAeropuerto.Controls.Add(this.lbAeropuerto);
            this.gbAeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAeropuerto.Location = new System.Drawing.Point(14, 42);
            this.gbAeropuerto.Name = "gbAeropuerto";
            this.gbAeropuerto.Size = new System.Drawing.Size(763, 88);
            this.gbAeropuerto.TabIndex = 0;
            this.gbAeropuerto.TabStop = false;
            this.gbAeropuerto.Text = "Aeropuerto";
            // 
            // cbAeropuerto
            // 
            this.cbAeropuerto.FormattingEnabled = true;
            this.cbAeropuerto.Location = new System.Drawing.Point(114, 38);
            this.cbAeropuerto.Name = "cbAeropuerto";
            this.cbAeropuerto.Size = new System.Drawing.Size(227, 23);
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
            this.gbDetalle.Location = new System.Drawing.Point(14, 147);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(763, 387);
            this.gbDetalle.TabIndex = 1;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // cbFuel
            // 
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(396, 355);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(340, 23);
            this.cbFuel.TabIndex = 20;
            // 
            // lbFUEL
            // 
            this.lbFUEL.AutoSize = true;
            this.lbFUEL.Location = new System.Drawing.Point(29, 355);
            this.lbFUEL.Name = "lbFUEL";
            this.lbFUEL.Size = new System.Drawing.Size(38, 15);
            this.lbFUEL.TabIndex = 19;
            this.lbFUEL.Text = "FUEL";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(396, 63);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(340, 23);
            this.cbDepartamento.TabIndex = 18;
            // 
            // dudServicioEmergencia
            // 
            this.dudServicioEmergencia.Location = new System.Drawing.Point(396, 249);
            this.dudServicioEmergencia.Name = "dudServicioEmergencia";
            this.dudServicioEmergencia.Size = new System.Drawing.Size(340, 21);
            this.dudServicioEmergencia.TabIndex = 17;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(396, 324);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(340, 21);
            this.txtFecha.TabIndex = 16;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(396, 288);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(340, 21);
            this.txtHorario.TabIndex = 15;
            // 
            // txtElevacion
            // 
            this.txtElevacion.Location = new System.Drawing.Point(396, 208);
            this.txtElevacion.Name = "txtElevacion";
            this.txtElevacion.Size = new System.Drawing.Size(340, 21);
            this.txtElevacion.TabIndex = 14;
            // 
            // txtOACI
            // 
            this.txtOACI.Location = new System.Drawing.Point(396, 171);
            this.txtOACI.Name = "txtOACI";
            this.txtOACI.Size = new System.Drawing.Size(340, 21);
            this.txtOACI.TabIndex = 13;
            // 
            // txtIATA
            // 
            this.txtIATA.Location = new System.Drawing.Point(396, 135);
            this.txtIATA.Name = "txtIATA";
            this.txtIATA.Size = new System.Drawing.Size(340, 21);
            this.txtIATA.TabIndex = 12;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(396, 98);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(340, 21);
            this.txtCiudad.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(396, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 21);
            this.txtNombre.TabIndex = 10;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(29, 327);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(172, 15);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Última Fecha de Actualización";
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Location = new System.Drawing.Point(29, 291);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(125, 15);
            this.lbHorario.TabIndex = 8;
            this.lbHorario.Text = "Horario de Operación";
            // 
            // lbServiciosEmergencias
            // 
            this.lbServiciosEmergencias.AutoSize = true;
            this.lbServiciosEmergencias.Location = new System.Drawing.Point(29, 251);
            this.lbServiciosEmergencias.Name = "lbServiciosEmergencias";
            this.lbServiciosEmergencias.Size = new System.Drawing.Size(143, 15);
            this.lbServiciosEmergencias.TabIndex = 7;
            this.lbServiciosEmergencias.Text = "Servicios de Emergencia";
            // 
            // lbElevacion
            // 
            this.lbElevacion.AutoSize = true;
            this.lbElevacion.Location = new System.Drawing.Point(29, 211);
            this.lbElevacion.Name = "lbElevacion";
            this.lbElevacion.Size = new System.Drawing.Size(60, 15);
            this.lbElevacion.TabIndex = 6;
            this.lbElevacion.Text = "Elevación";
            // 
            // lbOACI
            // 
            this.lbOACI.AutoSize = true;
            this.lbOACI.Location = new System.Drawing.Point(32, 174);
            this.lbOACI.Name = "lbOACI";
            this.lbOACI.Size = new System.Drawing.Size(34, 15);
            this.lbOACI.TabIndex = 5;
            this.lbOACI.Text = "OACI";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(29, 101);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(46, 15);
            this.lbCiudad.TabIndex = 4;
            this.lbCiudad.Text = "Ciudad";
            // 
            // lbIATA
            // 
            this.lbIATA.AutoSize = true;
            this.lbIATA.Location = new System.Drawing.Point(32, 138);
            this.lbIATA.Name = "lbIATA";
            this.lbIATA.Size = new System.Drawing.Size(31, 15);
            this.lbIATA.TabIndex = 3;
            this.lbIATA.Text = "IATA";
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.AutoSize = true;
            this.lbDepartamento.Location = new System.Drawing.Point(29, 66);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(86, 15);
            this.lbDepartamento.TabIndex = 2;
            this.lbDepartamento.Text = "Departamento";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 34);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(135, 15);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre del Aeropuerto";
            // 
            // tsMenuAeropuerto
            // 
            this.tsMenuAeropuerto.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuAeropuerto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbActualizar,
            this.tsbPista,
            this.tsbPlataforma});
            this.tsMenuAeropuerto.Location = new System.Drawing.Point(0, 0);
            this.tsMenuAeropuerto.Name = "tsMenuAeropuerto";
            this.tsMenuAeropuerto.Size = new System.Drawing.Size(789, 25);
            this.tsMenuAeropuerto.TabIndex = 2;
            this.tsMenuAeropuerto.Text = "toolStrip1";
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(63, 22);
            this.tsbActualizar.Text = "Actualizar";
            // 
            // tsbPista
            // 
            this.tsbPista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPista.Name = "tsbPista";
            this.tsbPista.Size = new System.Drawing.Size(36, 22);
            this.tsbPista.Text = "Pista";
            this.tsbPista.Click += new System.EventHandler(this.InPistaConsultar);
            // 
            // tsbPlataforma
            // 
            this.tsbPlataforma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlataforma.Name = "tsbPlataforma";
            this.tsbPlataforma.Size = new System.Drawing.Size(69, 22);
            this.tsbPlataforma.Text = "Plataforma";
            this.tsbPlataforma.Click += new System.EventHandler(this.InPlataformaConsultar);
            // 
            // frmAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(789, 546);
            this.Controls.Add(this.tsMenuAeropuerto);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbAeropuerto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAeropuerto";
            this.Text = "Aeropuerto";
            this.gbAeropuerto.ResumeLayout(false);
            this.gbAeropuerto.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.tsMenuAeropuerto.ResumeLayout(false);
            this.tsMenuAeropuerto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAeropuerto;
        private System.Windows.Forms.ComboBox cbAeropuerto;
        private System.Windows.Forms.Label lbAeropuerto;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbServiciosEmergencias;
        private System.Windows.Forms.Label lbElevacion;
        private System.Windows.Forms.Label lbOACI;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbIATA;
        private System.Windows.Forms.Label lbDepartamento;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.DomainUpDown dudServicioEmergencia;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtElevacion;
        private System.Windows.Forms.TextBox txtOACI;
        private System.Windows.Forms.TextBox txtIATA;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ToolStrip tsMenuAeropuerto;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbPista;
        private System.Windows.Forms.ToolStripButton tsbPlataforma;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.Label lbFUEL;
    }
}