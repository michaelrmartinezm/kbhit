namespace UPC.Trabajo.KBHit
{
    partial class frmPlataforma
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
            objPlataforma = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlataforma));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbAeropuerto = new System.Windows.Forms.ComboBox();
            this.lbAeroperto = new System.Windows.Forms.Label();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.lbPlataforma = new System.Windows.Forms.Label();
            this.tsMenuPlataforma = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.txtAeronaveMacPermisible = new System.Windows.Forms.TextBox();
            this.txtDimensiones = new System.Windows.Forms.TextBox();
            this.txtPCN = new System.Windows.Forms.TextBox();
            this.cbPavimento = new System.Windows.Forms.ComboBox();
            this.dudPuestos = new System.Windows.Forms.DomainUpDown();
            this.lbAeronaveMaxPermisible = new System.Windows.Forms.Label();
            this.lbDimensiones = new System.Windows.Forms.Label();
            this.lbPCN = new System.Windows.Forms.Label();
            this.lbPavimento = new System.Windows.Forms.Label();
            this.lbPuesto = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.tsMenuPlataforma.SuspendLayout();
            this.gbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.cbAeropuerto);
            this.gbDatos.Controls.Add(this.lbAeroperto);
            this.gbDatos.Controls.Add(this.cbPlataforma);
            this.gbDatos.Controls.Add(this.lbPlataforma);
            this.gbDatos.Location = new System.Drawing.Point(12, 28);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(779, 80);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Principales";
            // 
            // cbAeropuerto
            // 
            this.cbAeropuerto.FormattingEnabled = true;
            this.cbAeropuerto.Location = new System.Drawing.Point(505, 38);
            this.cbAeropuerto.Name = "cbAeropuerto";
            this.cbAeropuerto.Size = new System.Drawing.Size(244, 23);
            this.cbAeropuerto.TabIndex = 3;
            this.cbAeropuerto.SelectedValueChanged += new System.EventHandler(this.InElegirAeropuerto);
            // 
            // lbAeroperto
            // 
            this.lbAeroperto.AutoSize = true;
            this.lbAeroperto.Location = new System.Drawing.Point(432, 41);
            this.lbAeroperto.Name = "lbAeroperto";
            this.lbAeroperto.Size = new System.Drawing.Size(67, 15);
            this.lbAeroperto.TabIndex = 2;
            this.lbAeroperto.Text = "Aeropuerto";
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Location = new System.Drawing.Point(101, 38);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(244, 23);
            this.cbPlataforma.TabIndex = 1;
            this.cbPlataforma.SelectedValueChanged += new System.EventHandler(this.InElegirPlataforma);
            // 
            // lbPlataforma
            // 
            this.lbPlataforma.AutoSize = true;
            this.lbPlataforma.Location = new System.Drawing.Point(28, 41);
            this.lbPlataforma.Name = "lbPlataforma";
            this.lbPlataforma.Size = new System.Drawing.Size(67, 15);
            this.lbPlataforma.TabIndex = 0;
            this.lbPlataforma.Text = "Plataforma";
            // 
            // tsMenuPlataforma
            // 
            this.tsMenuPlataforma.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuPlataforma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbNuevo});
            this.tsMenuPlataforma.Location = new System.Drawing.Point(0, 0);
            this.tsMenuPlataforma.Name = "tsMenuPlataforma";
            this.tsMenuPlataforma.Size = new System.Drawing.Size(803, 25);
            this.tsMenuPlataforma.TabIndex = 1;
            this.tsMenuPlataforma.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(53, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalle.Controls.Add(this.txtAeronaveMacPermisible);
            this.gbDetalle.Controls.Add(this.txtDimensiones);
            this.gbDetalle.Controls.Add(this.txtPCN);
            this.gbDetalle.Controls.Add(this.cbPavimento);
            this.gbDetalle.Controls.Add(this.dudPuestos);
            this.gbDetalle.Controls.Add(this.lbAeronaveMaxPermisible);
            this.gbDetalle.Controls.Add(this.lbDimensiones);
            this.gbDetalle.Controls.Add(this.lbPCN);
            this.gbDetalle.Controls.Add(this.lbPavimento);
            this.gbDetalle.Controls.Add(this.lbPuesto);
            this.gbDetalle.Location = new System.Drawing.Point(12, 114);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(779, 252);
            this.gbDetalle.TabIndex = 2;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle de Plataforma";
            // 
            // txtAeronaveMacPermisible
            // 
            this.txtAeronaveMacPermisible.Location = new System.Drawing.Point(435, 205);
            this.txtAeronaveMacPermisible.Name = "txtAeronaveMacPermisible";
            this.txtAeronaveMacPermisible.Size = new System.Drawing.Size(314, 21);
            this.txtAeronaveMacPermisible.TabIndex = 9;
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Location = new System.Drawing.Point(435, 166);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(314, 21);
            this.txtDimensiones.TabIndex = 8;
            // 
            // txtPCN
            // 
            this.txtPCN.Location = new System.Drawing.Point(435, 127);
            this.txtPCN.Name = "txtPCN";
            this.txtPCN.Size = new System.Drawing.Size(314, 21);
            this.txtPCN.TabIndex = 7;
            // 
            // cbPavimento
            // 
            this.cbPavimento.FormattingEnabled = true;
            this.cbPavimento.Location = new System.Drawing.Point(435, 89);
            this.cbPavimento.Name = "cbPavimento";
            this.cbPavimento.Size = new System.Drawing.Size(314, 23);
            this.cbPavimento.TabIndex = 6;
            // 
            // dudPuestos
            // 
            this.dudPuestos.Location = new System.Drawing.Point(435, 53);
            this.dudPuestos.Name = "dudPuestos";
            this.dudPuestos.Size = new System.Drawing.Size(314, 21);
            this.dudPuestos.TabIndex = 5;
            // 
            // lbAeronaveMaxPermisible
            // 
            this.lbAeronaveMaxPermisible.AutoSize = true;
            this.lbAeronaveMaxPermisible.Location = new System.Drawing.Point(28, 208);
            this.lbAeronaveMaxPermisible.Name = "lbAeronaveMaxPermisible";
            this.lbAeronaveMaxPermisible.Size = new System.Drawing.Size(168, 15);
            this.lbAeronaveMaxPermisible.TabIndex = 4;
            this.lbAeronaveMaxPermisible.Text = "Aeronave Máxima Permisible";
            // 
            // lbDimensiones
            // 
            this.lbDimensiones.AutoSize = true;
            this.lbDimensiones.Location = new System.Drawing.Point(28, 169);
            this.lbDimensiones.Name = "lbDimensiones";
            this.lbDimensiones.Size = new System.Drawing.Size(80, 15);
            this.lbDimensiones.TabIndex = 3;
            this.lbDimensiones.Text = "Dimensiones";
            // 
            // lbPCN
            // 
            this.lbPCN.AutoSize = true;
            this.lbPCN.Location = new System.Drawing.Point(28, 130);
            this.lbPCN.Name = "lbPCN";
            this.lbPCN.Size = new System.Drawing.Size(32, 15);
            this.lbPCN.TabIndex = 2;
            this.lbPCN.Text = "PCN";
            // 
            // lbPavimento
            // 
            this.lbPavimento.AutoSize = true;
            this.lbPavimento.Location = new System.Drawing.Point(28, 92);
            this.lbPavimento.Name = "lbPavimento";
            this.lbPavimento.Size = new System.Drawing.Size(65, 15);
            this.lbPavimento.TabIndex = 1;
            this.lbPavimento.Text = "Pavimento";
            // 
            // lbPuesto
            // 
            this.lbPuesto.AutoSize = true;
            this.lbPuesto.Location = new System.Drawing.Point(28, 55);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(240, 15);
            this.lbPuesto.TabIndex = 0;
            this.lbPuesto.Text = "Puestos de Estacionamiento de Aeronaves";
            // 
            // frmPlataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(803, 391);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.tsMenuPlataforma);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPlataforma";
            this.Text = "frmPlataforma";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.tsMenuPlataforma.ResumeLayout(false);
            this.tsMenuPlataforma.PerformLayout();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ToolStrip tsMenuPlataforma;
        private System.Windows.Forms.ComboBox cbAeropuerto;
        private System.Windows.Forms.Label lbAeroperto;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.Label lbPlataforma;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lbAeronaveMaxPermisible;
        private System.Windows.Forms.Label lbDimensiones;
        private System.Windows.Forms.Label lbPCN;
        private System.Windows.Forms.Label lbPavimento;
        private System.Windows.Forms.Label lbPuesto;
        private System.Windows.Forms.TextBox txtAeronaveMacPermisible;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.TextBox txtPCN;
        private System.Windows.Forms.ComboBox cbPavimento;
        private System.Windows.Forms.DomainUpDown dudPuestos;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
    }
}