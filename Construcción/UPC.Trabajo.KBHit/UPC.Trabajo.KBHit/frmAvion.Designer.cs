namespace UPC.Trabajo.KBHit
{
    partial class frmAvion
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
            objAvion = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvion));
            this.tsMenuAvion = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFabricante = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Foto = new DevExpress.XtraEditors.PictureEdit();
            this.nudEmpuje = new System.Windows.Forms.NumericUpDown();
            this.nudAutonimiaPeso = new System.Windows.Forms.NumericUpDown();
            this.nudMaxFuel = new System.Windows.Forms.NumericUpDown();
            this.nudCarreraDespegue = new System.Windows.Forms.NumericUpDown();
            this.nudVelocMax = new System.Windows.Forms.NumericUpDown();
            this.nudCrucero = new System.Windows.Forms.NumericUpDown();
            this.nudPesoMaxDespegue = new System.Windows.Forms.NumericUpDown();
            this.nudPesoVacio = new System.Windows.Forms.NumericUpDown();
            this.nudEnvergadura = new System.Windows.Forms.NumericUpDown();
            this.nudLongitud = new System.Windows.Forms.NumericUpDown();
            this.nudPasajeros = new System.Windows.Forms.NumericUpDown();
            this.nudTripulacion = new System.Windows.Forms.NumericUpDown();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbEmpuje = new System.Windows.Forms.Label();
            this.lbMotor = new System.Windows.Forms.Label();
            this.lbMaxFuel = new System.Windows.Forms.Label();
            this.lbAutonomia = new System.Windows.Forms.Label();
            this.lbCarreraDespegue = new System.Windows.Forms.Label();
            this.lbPesoMaxDespegue = new System.Windows.Forms.Label();
            this.lbEnvergadura = new System.Windows.Forms.Label();
            this.lbVelocidadMaxima = new System.Windows.Forms.Label();
            this.lbVelocidadCrucero = new System.Windows.Forms.Label();
            this.lbPesoVacio = new System.Windows.Forms.Label();
            this.lbLongitud = new System.Windows.Forms.Label();
            this.lbPasajeros = new System.Windows.Forms.Label();
            this.lbTripulacion = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.tsMenuAvion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpuje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutonimiaPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarreraDespegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrucero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoMaxDespegue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoVacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnvergadura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuAvion
            // 
            this.tsMenuAvion.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuAvion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbNuevo});
            this.tsMenuAvion.Location = new System.Drawing.Point(0, 0);
            this.tsMenuAvion.Name = "tsMenuAvion";
            this.tsMenuAvion.Size = new System.Drawing.Size(975, 25);
            this.tsMenuAvion.TabIndex = 0;
            this.tsMenuAvion.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(23, 30);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(52, 15);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbFabricante
            // 
            this.lbFabricante.AutoSize = true;
            this.lbFabricante.Location = new System.Drawing.Point(451, 30);
            this.lbFabricante.Name = "lbFabricante";
            this.lbFabricante.Size = new System.Drawing.Size(65, 15);
            this.lbFabricante.TabIndex = 2;
            this.lbFabricante.Text = "Fabricante";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bnCargar);
            this.groupBox1.Controls.Add(this.panelControl1);
            this.groupBox1.Controls.Add(this.nudEmpuje);
            this.groupBox1.Controls.Add(this.nudAutonimiaPeso);
            this.groupBox1.Controls.Add(this.nudMaxFuel);
            this.groupBox1.Controls.Add(this.nudCarreraDespegue);
            this.groupBox1.Controls.Add(this.nudVelocMax);
            this.groupBox1.Controls.Add(this.nudCrucero);
            this.groupBox1.Controls.Add(this.nudPesoMaxDespegue);
            this.groupBox1.Controls.Add(this.nudPesoVacio);
            this.groupBox1.Controls.Add(this.nudEnvergadura);
            this.groupBox1.Controls.Add(this.nudLongitud);
            this.groupBox1.Controls.Add(this.nudPasajeros);
            this.groupBox1.Controls.Add(this.nudTripulacion);
            this.groupBox1.Controls.Add(this.txtMotor);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtFabricante);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lbImagen);
            this.groupBox1.Controls.Add(this.lbEmpuje);
            this.groupBox1.Controls.Add(this.lbMotor);
            this.groupBox1.Controls.Add(this.lbMaxFuel);
            this.groupBox1.Controls.Add(this.lbAutonomia);
            this.groupBox1.Controls.Add(this.lbCarreraDespegue);
            this.groupBox1.Controls.Add(this.lbPesoMaxDespegue);
            this.groupBox1.Controls.Add(this.lbEnvergadura);
            this.groupBox1.Controls.Add(this.lbVelocidadMaxima);
            this.groupBox1.Controls.Add(this.lbVelocidadCrucero);
            this.groupBox1.Controls.Add(this.lbPesoVacio);
            this.groupBox1.Controls.Add(this.lbLongitud);
            this.groupBox1.Controls.Add(this.lbPasajeros);
            this.groupBox1.Controls.Add(this.lbTripulacion);
            this.groupBox1.Controls.Add(this.lbModelo);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.lbFabricante);
            this.groupBox1.Location = new System.Drawing.Point(14, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 412);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Avión";
            // 
            // bnCargar
            // 
            this.bnCargar.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.bnCargar.Appearance.ForeColor = System.Drawing.Color.Chocolate;
            this.bnCargar.Appearance.Options.UseFont = true;
            this.bnCargar.Appearance.Options.UseForeColor = true;
            this.bnCargar.Location = new System.Drawing.Point(225, 384);
            this.bnCargar.Name = "bnCargar";
            this.bnCargar.Size = new System.Drawing.Size(176, 20);
            this.bnCargar.TabIndex = 47;
            this.bnCargar.Text = "Cargar Vista del Avión";
            this.bnCargar.Click += new System.EventHandler(this.InCargarVistaAvion);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Foto);
            this.panelControl1.Location = new System.Drawing.Point(200, 255);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(225, 123);
            this.panelControl1.TabIndex = 46;
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(5, 5);
            this.Foto.Name = "Foto";
            this.Foto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Foto.Size = new System.Drawing.Size(215, 111);
            this.Foto.TabIndex = 0;
            // 
            // nudEmpuje
            // 
            this.nudEmpuje.Location = new System.Drawing.Point(685, 220);
            this.nudEmpuje.Name = "nudEmpuje";
            this.nudEmpuje.Size = new System.Drawing.Size(227, 21);
            this.nudEmpuje.TabIndex = 45;
            // 
            // nudAutonimiaPeso
            // 
            this.nudAutonimiaPeso.Location = new System.Drawing.Point(199, 188);
            this.nudAutonimiaPeso.Name = "nudAutonimiaPeso";
            this.nudAutonimiaPeso.Size = new System.Drawing.Size(227, 21);
            this.nudAutonimiaPeso.TabIndex = 44;
            // 
            // nudMaxFuel
            // 
            this.nudMaxFuel.Location = new System.Drawing.Point(685, 193);
            this.nudMaxFuel.Name = "nudMaxFuel";
            this.nudMaxFuel.Size = new System.Drawing.Size(227, 21);
            this.nudMaxFuel.TabIndex = 43;
            // 
            // nudCarreraDespegue
            // 
            this.nudCarreraDespegue.Location = new System.Drawing.Point(686, 162);
            this.nudCarreraDespegue.Name = "nudCarreraDespegue";
            this.nudCarreraDespegue.Size = new System.Drawing.Size(227, 21);
            this.nudCarreraDespegue.TabIndex = 42;
            // 
            // nudVelocMax
            // 
            this.nudVelocMax.Location = new System.Drawing.Point(200, 161);
            this.nudVelocMax.Name = "nudVelocMax";
            this.nudVelocMax.Size = new System.Drawing.Size(227, 21);
            this.nudVelocMax.TabIndex = 41;
            // 
            // nudCrucero
            // 
            this.nudCrucero.Location = new System.Drawing.Point(686, 135);
            this.nudCrucero.Name = "nudCrucero";
            this.nudCrucero.Size = new System.Drawing.Size(227, 21);
            this.nudCrucero.TabIndex = 40;
            // 
            // nudPesoMaxDespegue
            // 
            this.nudPesoMaxDespegue.Location = new System.Drawing.Point(200, 132);
            this.nudPesoMaxDespegue.Name = "nudPesoMaxDespegue";
            this.nudPesoMaxDespegue.Size = new System.Drawing.Size(227, 21);
            this.nudPesoMaxDespegue.TabIndex = 39;
            // 
            // nudPesoVacio
            // 
            this.nudPesoVacio.Location = new System.Drawing.Point(685, 108);
            this.nudPesoVacio.Name = "nudPesoVacio";
            this.nudPesoVacio.Size = new System.Drawing.Size(227, 21);
            this.nudPesoVacio.TabIndex = 38;
            // 
            // nudEnvergadura
            // 
            this.nudEnvergadura.Location = new System.Drawing.Point(200, 105);
            this.nudEnvergadura.Name = "nudEnvergadura";
            this.nudEnvergadura.Size = new System.Drawing.Size(227, 21);
            this.nudEnvergadura.TabIndex = 37;
            // 
            // nudLongitud
            // 
            this.nudLongitud.Location = new System.Drawing.Point(686, 81);
            this.nudLongitud.Name = "nudLongitud";
            this.nudLongitud.Size = new System.Drawing.Size(227, 21);
            this.nudLongitud.TabIndex = 36;
            // 
            // nudPasajeros
            // 
            this.nudPasajeros.Location = new System.Drawing.Point(200, 78);
            this.nudPasajeros.Name = "nudPasajeros";
            this.nudPasajeros.Size = new System.Drawing.Size(227, 21);
            this.nudPasajeros.TabIndex = 35;
            // 
            // nudTripulacion
            // 
            this.nudTripulacion.Location = new System.Drawing.Point(686, 54);
            this.nudTripulacion.Name = "nudTripulacion";
            this.nudTripulacion.Size = new System.Drawing.Size(227, 21);
            this.nudTripulacion.TabIndex = 34;
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(199, 217);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(226, 21);
            this.txtMotor.TabIndex = 32;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(200, 51);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(226, 21);
            this.txtModelo.TabIndex = 19;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(687, 27);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(226, 21);
            this.txtFabricante.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 21);
            this.txtNombre.TabIndex = 17;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(23, 255);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(49, 15);
            this.lbImagen.TabIndex = 4;
            this.lbImagen.Text = "Imágen";
            // 
            // lbEmpuje
            // 
            this.lbEmpuje.AutoSize = true;
            this.lbEmpuje.Location = new System.Drawing.Point(450, 222);
            this.lbEmpuje.Name = "lbEmpuje";
            this.lbEmpuje.Size = new System.Drawing.Size(98, 15);
            this.lbEmpuje.TabIndex = 16;
            this.lbEmpuje.Text = "Empuje Máximo";
            // 
            // lbMotor
            // 
            this.lbMotor.AutoSize = true;
            this.lbMotor.Location = new System.Drawing.Point(22, 222);
            this.lbMotor.Name = "lbMotor";
            this.lbMotor.Size = new System.Drawing.Size(39, 15);
            this.lbMotor.TabIndex = 15;
            this.lbMotor.Text = "Motor";
            // 
            // lbMaxFuel
            // 
            this.lbMaxFuel.AutoSize = true;
            this.lbMaxFuel.Location = new System.Drawing.Point(451, 193);
            this.lbMaxFuel.Name = "lbMaxFuel";
            this.lbMaxFuel.Size = new System.Drawing.Size(203, 15);
            this.lbMaxFuel.TabIndex = 14;
            this.lbMaxFuel.Text = "Máxima Capacidad de Combustible";
            // 
            // lbAutonomia
            // 
            this.lbAutonomia.AutoSize = true;
            this.lbAutonomia.Location = new System.Drawing.Point(22, 192);
            this.lbAutonomia.Name = "lbAutonomia";
            this.lbAutonomia.Size = new System.Drawing.Size(168, 15);
            this.lbAutonomia.TabIndex = 13;
            this.lbAutonomia.Text = "Autonomia con Peso Máximo";
            // 
            // lbCarreraDespegue
            // 
            this.lbCarreraDespegue.AutoSize = true;
            this.lbCarreraDespegue.Location = new System.Drawing.Point(450, 165);
            this.lbCarreraDespegue.Name = "lbCarreraDespegue";
            this.lbCarreraDespegue.Size = new System.Drawing.Size(227, 15);
            this.lbCarreraDespegue.TabIndex = 12;
            this.lbCarreraDespegue.Text = "Carrera de Despegue con Peso Máximo";
            // 
            // lbPesoMaxDespegue
            // 
            this.lbPesoMaxDespegue.AutoSize = true;
            this.lbPesoMaxDespegue.Location = new System.Drawing.Point(23, 136);
            this.lbPesoMaxDespegue.Name = "lbPesoMaxDespegue";
            this.lbPesoMaxDespegue.Size = new System.Drawing.Size(160, 15);
            this.lbPesoMaxDespegue.TabIndex = 11;
            this.lbPesoMaxDespegue.Text = "Peso Máximo de Despegue";
            // 
            // lbEnvergadura
            // 
            this.lbEnvergadura.AutoSize = true;
            this.lbEnvergadura.Location = new System.Drawing.Point(23, 109);
            this.lbEnvergadura.Name = "lbEnvergadura";
            this.lbEnvergadura.Size = new System.Drawing.Size(77, 15);
            this.lbEnvergadura.TabIndex = 10;
            this.lbEnvergadura.Text = "Envergadura";
            // 
            // lbVelocidadMaxima
            // 
            this.lbVelocidadMaxima.AutoSize = true;
            this.lbVelocidadMaxima.Location = new System.Drawing.Point(23, 165);
            this.lbVelocidadMaxima.Name = "lbVelocidadMaxima";
            this.lbVelocidadMaxima.Size = new System.Drawing.Size(109, 15);
            this.lbVelocidadMaxima.TabIndex = 9;
            this.lbVelocidadMaxima.Text = "Velocidad Máxima";
            // 
            // lbVelocidadCrucero
            // 
            this.lbVelocidadCrucero.AutoSize = true;
            this.lbVelocidadCrucero.Location = new System.Drawing.Point(450, 136);
            this.lbVelocidadCrucero.Name = "lbVelocidadCrucero";
            this.lbVelocidadCrucero.Size = new System.Drawing.Size(124, 15);
            this.lbVelocidadCrucero.TabIndex = 8;
            this.lbVelocidadCrucero.Text = "Velocidad de Crucero";
            // 
            // lbPesoVacio
            // 
            this.lbPesoVacio.AutoSize = true;
            this.lbPesoVacio.Location = new System.Drawing.Point(450, 108);
            this.lbPesoVacio.Name = "lbPesoVacio";
            this.lbPesoVacio.Size = new System.Drawing.Size(68, 15);
            this.lbPesoVacio.TabIndex = 7;
            this.lbPesoVacio.Text = "Peso Vacio";
            // 
            // lbLongitud
            // 
            this.lbLongitud.AutoSize = true;
            this.lbLongitud.Location = new System.Drawing.Point(450, 82);
            this.lbLongitud.Name = "lbLongitud";
            this.lbLongitud.Size = new System.Drawing.Size(48, 15);
            this.lbLongitud.TabIndex = 6;
            this.lbLongitud.Text = "Logitud";
            // 
            // lbPasajeros
            // 
            this.lbPasajeros.AutoSize = true;
            this.lbPasajeros.Location = new System.Drawing.Point(23, 83);
            this.lbPasajeros.Name = "lbPasajeros";
            this.lbPasajeros.Size = new System.Drawing.Size(127, 15);
            this.lbPasajeros.TabIndex = 5;
            this.lbPasajeros.Text = "Número de Pasajeros";
            // 
            // lbTripulacion
            // 
            this.lbTripulacion.AutoSize = true;
            this.lbTripulacion.Location = new System.Drawing.Point(450, 56);
            this.lbTripulacion.Name = "lbTripulacion";
            this.lbTripulacion.Size = new System.Drawing.Size(127, 15);
            this.lbTripulacion.TabIndex = 4;
            this.lbTripulacion.Text = "Tripulación en Cabina";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(23, 57);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(98, 15);
            this.lbModelo.TabIndex = 3;
            this.lbModelo.Text = "Modelo de Avión";
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UPC.Trabajo.KBHit.Properties.Resources.SSA43923;
            this.ClientSize = new System.Drawing.Size(975, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsMenuAvion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAvion";
            this.Text = "Avión";
            this.tsMenuAvion.ResumeLayout(false);
            this.tsMenuAvion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpuje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutonimiaPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarreraDespegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelocMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrucero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoMaxDespegue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoVacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnvergadura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuAvion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFabricante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPesoMaxDespegue;
        private System.Windows.Forms.Label lbEnvergadura;
        private System.Windows.Forms.Label lbVelocidadMaxima;
        private System.Windows.Forms.Label lbVelocidadCrucero;
        private System.Windows.Forms.Label lbPesoVacio;
        private System.Windows.Forms.Label lbLongitud;
        private System.Windows.Forms.Label lbPasajeros;
        private System.Windows.Forms.Label lbTripulacion;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbMaxFuel;
        private System.Windows.Forms.Label lbAutonomia;
        private System.Windows.Forms.Label lbCarreraDespegue;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbEmpuje;
        private System.Windows.Forms.Label lbMotor;
        private System.Windows.Forms.NumericUpDown nudTripulacion;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.NumericUpDown nudEmpuje;
        private System.Windows.Forms.NumericUpDown nudAutonimiaPeso;
        private System.Windows.Forms.NumericUpDown nudMaxFuel;
        private System.Windows.Forms.NumericUpDown nudCarreraDespegue;
        private System.Windows.Forms.NumericUpDown nudVelocMax;
        private System.Windows.Forms.NumericUpDown nudCrucero;
        private System.Windows.Forms.NumericUpDown nudPesoMaxDespegue;
        private System.Windows.Forms.NumericUpDown nudPesoVacio;
        private System.Windows.Forms.NumericUpDown nudEnvergadura;
        private System.Windows.Forms.NumericUpDown nudLongitud;
        private System.Windows.Forms.NumericUpDown nudPasajeros;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private DevExpress.XtraEditors.SimpleButton bnCargar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit Foto;
    }
}