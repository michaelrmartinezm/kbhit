namespace UPC.Trabajo.KBHit
{
    partial class frmPista
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
            objPista = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPista));
            this.tsMenuPista = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbAeropuerto = new System.Windows.Forms.ComboBox();
            this.cbPista = new System.Windows.Forms.ComboBox();
            this.lbAeropuerto = new System.Windows.Forms.Label();
            this.lbPista = new System.Windows.Forms.Label();
            this.dbDetallePista = new System.Windows.Forms.GroupBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtFranja = new System.Windows.Forms.TextBox();
            this.txtPCN = new System.Windows.Forms.TextBox();
            this.txtDesignador = new System.Windows.Forms.TextBox();
            this.txtPavimento = new System.Windows.Forms.TextBox();
            this.txtLDA = new System.Windows.Forms.TextBox();
            this.dudASDA = new System.Windows.Forms.DomainUpDown();
            this.dudTODA = new System.Windows.Forms.DomainUpDown();
            this.dudTORA = new System.Windows.Forms.DomainUpDown();
            this.dudAncho = new System.Windows.Forms.DomainUpDown();
            this.dudLargo = new System.Windows.Forms.DomainUpDown();
            this.lbCalle = new System.Windows.Forms.Label();
            this.lbFranja = new System.Windows.Forms.Label();
            this.lbPCN = new System.Windows.Forms.Label();
            this.lbDesignador = new System.Windows.Forms.Label();
            this.lbPavimento = new System.Windows.Forms.Label();
            this.lbLDA = new System.Windows.Forms.Label();
            this.lbToda = new System.Windows.Forms.Label();
            this.lbAsda = new System.Windows.Forms.Label();
            this.lbTora = new System.Windows.Forms.Label();
            this.lbAncho = new System.Windows.Forms.Label();
            this.lbLargo = new System.Windows.Forms.Label();
            this.tsMenuPista.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.dbDetallePista.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenuPista
            // 
            this.tsMenuPista.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuPista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbNuevo});
            this.tsMenuPista.Location = new System.Drawing.Point(0, 0);
            this.tsMenuPista.Name = "tsMenuPista";
            this.tsMenuPista.Size = new System.Drawing.Size(799, 25);
            this.tsMenuPista.TabIndex = 0;
            this.tsMenuPista.Text = "toolStrip1";
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
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.cbAeropuerto);
            this.gbDatos.Controls.Add(this.cbPista);
            this.gbDatos.Controls.Add(this.lbAeropuerto);
            this.gbDatos.Controls.Add(this.lbPista);
            this.gbDatos.Location = new System.Drawing.Point(14, 32);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(773, 84);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Principales";
            // 
            // cbAeropuerto
            // 
            this.cbAeropuerto.FormattingEnabled = true;
            this.cbAeropuerto.Location = new System.Drawing.Point(516, 35);
            this.cbAeropuerto.Name = "cbAeropuerto";
            this.cbAeropuerto.Size = new System.Drawing.Size(224, 23);
            this.cbAeropuerto.TabIndex = 3;
            // 
            // cbPista
            // 
            this.cbPista.FormattingEnabled = true;
            this.cbPista.Location = new System.Drawing.Point(130, 35);
            this.cbPista.Name = "cbPista";
            this.cbPista.Size = new System.Drawing.Size(217, 23);
            this.cbPista.TabIndex = 2;
            // 
            // lbAeropuerto
            // 
            this.lbAeropuerto.AutoSize = true;
            this.lbAeropuerto.Location = new System.Drawing.Point(443, 38);
            this.lbAeropuerto.Name = "lbAeropuerto";
            this.lbAeropuerto.Size = new System.Drawing.Size(67, 15);
            this.lbAeropuerto.TabIndex = 1;
            this.lbAeropuerto.Text = "Aeropuerto";
            // 
            // lbPista
            // 
            this.lbPista.AutoSize = true;
            this.lbPista.Location = new System.Drawing.Point(19, 38);
            this.lbPista.Name = "lbPista";
            this.lbPista.Size = new System.Drawing.Size(105, 15);
            this.lbPista.TabIndex = 0;
            this.lbPista.Text = "Pista de Aterrizaje";
            // 
            // dbDetallePista
            // 
            this.dbDetallePista.BackColor = System.Drawing.Color.Transparent;
            this.dbDetallePista.Controls.Add(this.txtCalle);
            this.dbDetallePista.Controls.Add(this.txtFranja);
            this.dbDetallePista.Controls.Add(this.txtPCN);
            this.dbDetallePista.Controls.Add(this.txtDesignador);
            this.dbDetallePista.Controls.Add(this.txtPavimento);
            this.dbDetallePista.Controls.Add(this.txtLDA);
            this.dbDetallePista.Controls.Add(this.dudASDA);
            this.dbDetallePista.Controls.Add(this.dudTODA);
            this.dbDetallePista.Controls.Add(this.dudTORA);
            this.dbDetallePista.Controls.Add(this.dudAncho);
            this.dbDetallePista.Controls.Add(this.dudLargo);
            this.dbDetallePista.Controls.Add(this.lbCalle);
            this.dbDetallePista.Controls.Add(this.lbFranja);
            this.dbDetallePista.Controls.Add(this.lbPCN);
            this.dbDetallePista.Controls.Add(this.lbDesignador);
            this.dbDetallePista.Controls.Add(this.lbPavimento);
            this.dbDetallePista.Controls.Add(this.lbLDA);
            this.dbDetallePista.Controls.Add(this.lbToda);
            this.dbDetallePista.Controls.Add(this.lbAsda);
            this.dbDetallePista.Controls.Add(this.lbTora);
            this.dbDetallePista.Controls.Add(this.lbAncho);
            this.dbDetallePista.Controls.Add(this.lbLargo);
            this.dbDetallePista.Location = new System.Drawing.Point(14, 122);
            this.dbDetallePista.Name = "dbDetallePista";
            this.dbDetallePista.Size = new System.Drawing.Size(773, 484);
            this.dbDetallePista.TabIndex = 2;
            this.dbDetallePista.TabStop = false;
            this.dbDetallePista.Text = "Detalle de Pista";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(398, 444);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(342, 21);
            this.txtCalle.TabIndex = 23;
            // 
            // txtFranja
            // 
            this.txtFranja.Location = new System.Drawing.Point(398, 399);
            this.txtFranja.Name = "txtFranja";
            this.txtFranja.Size = new System.Drawing.Size(342, 21);
            this.txtFranja.TabIndex = 22;
            // 
            // txtPCN
            // 
            this.txtPCN.Location = new System.Drawing.Point(398, 358);
            this.txtPCN.Name = "txtPCN";
            this.txtPCN.Size = new System.Drawing.Size(342, 21);
            this.txtPCN.TabIndex = 20;
            // 
            // txtDesignador
            // 
            this.txtDesignador.Location = new System.Drawing.Point(398, 316);
            this.txtDesignador.Name = "txtDesignador";
            this.txtDesignador.Size = new System.Drawing.Size(342, 21);
            this.txtDesignador.TabIndex = 19;
            // 
            // txtPavimento
            // 
            this.txtPavimento.Location = new System.Drawing.Point(398, 280);
            this.txtPavimento.Name = "txtPavimento";
            this.txtPavimento.Size = new System.Drawing.Size(342, 21);
            this.txtPavimento.TabIndex = 18;
            // 
            // txtLDA
            // 
            this.txtLDA.Location = new System.Drawing.Point(398, 241);
            this.txtLDA.Name = "txtLDA";
            this.txtLDA.Size = new System.Drawing.Size(342, 21);
            this.txtLDA.TabIndex = 17;
            // 
            // dudASDA
            // 
            this.dudASDA.Location = new System.Drawing.Point(398, 197);
            this.dudASDA.Name = "dudASDA";
            this.dudASDA.Size = new System.Drawing.Size(342, 21);
            this.dudASDA.TabIndex = 16;
            // 
            // dudTODA
            // 
            this.dudTODA.Location = new System.Drawing.Point(398, 156);
            this.dudTODA.Name = "dudTODA";
            this.dudTODA.Size = new System.Drawing.Size(342, 21);
            this.dudTODA.TabIndex = 15;
            // 
            // dudTORA
            // 
            this.dudTORA.Location = new System.Drawing.Point(398, 116);
            this.dudTORA.Name = "dudTORA";
            this.dudTORA.Size = new System.Drawing.Size(342, 21);
            this.dudTORA.TabIndex = 14;
            // 
            // dudAncho
            // 
            this.dudAncho.Location = new System.Drawing.Point(398, 80);
            this.dudAncho.Name = "dudAncho";
            this.dudAncho.Size = new System.Drawing.Size(342, 21);
            this.dudAncho.TabIndex = 13;
            // 
            // dudLargo
            // 
            this.dudLargo.Location = new System.Drawing.Point(398, 42);
            this.dudLargo.Name = "dudLargo";
            this.dudLargo.Size = new System.Drawing.Size(342, 21);
            this.dudLargo.TabIndex = 12;
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(19, 447);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(95, 15);
            this.lbCalle.TabIndex = 11;
            this.lbCalle.Text = "Calle de Rodaje";
            // 
            // lbFranja
            // 
            this.lbFranja.AutoSize = true;
            this.lbFranja.Location = new System.Drawing.Point(19, 402);
            this.lbFranja.Name = "lbFranja";
            this.lbFranja.Size = new System.Drawing.Size(89, 15);
            this.lbFranja.TabIndex = 10;
            this.lbFranja.Text = "Franja de Pista";
            // 
            // lbPCN
            // 
            this.lbPCN.AutoSize = true;
            this.lbPCN.Location = new System.Drawing.Point(19, 361);
            this.lbPCN.Name = "lbPCN";
            this.lbPCN.Size = new System.Drawing.Size(32, 15);
            this.lbPCN.TabIndex = 8;
            this.lbPCN.Text = "PCN";
            // 
            // lbDesignador
            // 
            this.lbDesignador.AutoSize = true;
            this.lbDesignador.Location = new System.Drawing.Point(19, 319);
            this.lbDesignador.Name = "lbDesignador";
            this.lbDesignador.Size = new System.Drawing.Size(118, 15);
            this.lbDesignador.TabIndex = 7;
            this.lbDesignador.Text = "Designador de Pista";
            // 
            // lbPavimento
            // 
            this.lbPavimento.AutoSize = true;
            this.lbPavimento.Location = new System.Drawing.Point(19, 283);
            this.lbPavimento.Name = "lbPavimento";
            this.lbPavimento.Size = new System.Drawing.Size(65, 15);
            this.lbPavimento.TabIndex = 6;
            this.lbPavimento.Text = "Pavimento";
            // 
            // lbLDA
            // 
            this.lbLDA.AutoSize = true;
            this.lbLDA.Location = new System.Drawing.Point(19, 244);
            this.lbLDA.Name = "lbLDA";
            this.lbLDA.Size = new System.Drawing.Size(30, 15);
            this.lbLDA.TabIndex = 5;
            this.lbLDA.Text = "LDA";
            // 
            // lbToda
            // 
            this.lbToda.AutoSize = true;
            this.lbToda.Location = new System.Drawing.Point(19, 158);
            this.lbToda.Name = "lbToda";
            this.lbToda.Size = new System.Drawing.Size(39, 15);
            this.lbToda.TabIndex = 4;
            this.lbToda.Text = "TODA";
            // 
            // lbAsda
            // 
            this.lbAsda.AutoSize = true;
            this.lbAsda.Location = new System.Drawing.Point(19, 199);
            this.lbAsda.Name = "lbAsda";
            this.lbAsda.Size = new System.Drawing.Size(38, 15);
            this.lbAsda.TabIndex = 3;
            this.lbAsda.Text = "ASDA";
            // 
            // lbTora
            // 
            this.lbTora.AutoSize = true;
            this.lbTora.Location = new System.Drawing.Point(19, 118);
            this.lbTora.Name = "lbTora";
            this.lbTora.Size = new System.Drawing.Size(39, 15);
            this.lbTora.TabIndex = 2;
            this.lbTora.Text = "TORA";
            // 
            // lbAncho
            // 
            this.lbAncho.AutoSize = true;
            this.lbAncho.Location = new System.Drawing.Point(19, 82);
            this.lbAncho.Name = "lbAncho";
            this.lbAncho.Size = new System.Drawing.Size(41, 15);
            this.lbAncho.TabIndex = 1;
            this.lbAncho.Text = "Ancho";
            // 
            // lbLargo
            // 
            this.lbLargo.AutoSize = true;
            this.lbLargo.Location = new System.Drawing.Point(19, 44);
            this.lbLargo.Name = "lbLargo";
            this.lbLargo.Size = new System.Drawing.Size(39, 15);
            this.lbLargo.TabIndex = 0;
            this.lbLargo.Text = "Largo";
            // 
            // frmPista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 617);
            this.Controls.Add(this.dbDetallePista);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.tsMenuPista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPista";
            this.Text = "Pista";
            this.tsMenuPista.ResumeLayout(false);
            this.tsMenuPista.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.dbDetallePista.ResumeLayout(false);
            this.dbDetallePista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuPista;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbAeropuerto;
        private System.Windows.Forms.Label lbPista;
        private System.Windows.Forms.ComboBox cbPista;
        private System.Windows.Forms.ComboBox cbAeropuerto;
        private System.Windows.Forms.GroupBox dbDetallePista;
        private System.Windows.Forms.Label lbDesignador;
        private System.Windows.Forms.Label lbPavimento;
        private System.Windows.Forms.Label lbLDA;
        private System.Windows.Forms.Label lbToda;
        private System.Windows.Forms.Label lbAsda;
        private System.Windows.Forms.Label lbTora;
        private System.Windows.Forms.Label lbAncho;
        private System.Windows.Forms.Label lbLargo;
        private System.Windows.Forms.DomainUpDown dudAncho;
        private System.Windows.Forms.DomainUpDown dudLargo;
        private System.Windows.Forms.Label lbCalle;
        private System.Windows.Forms.Label lbFranja;
        private System.Windows.Forms.Label lbPCN;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtFranja;
        private System.Windows.Forms.TextBox txtPCN;
        private System.Windows.Forms.TextBox txtDesignador;
        private System.Windows.Forms.TextBox txtPavimento;
        private System.Windows.Forms.TextBox txtLDA;
        private System.Windows.Forms.DomainUpDown dudASDA;
        private System.Windows.Forms.DomainUpDown dudTODA;
        private System.Windows.Forms.DomainUpDown dudTORA;

    }
}