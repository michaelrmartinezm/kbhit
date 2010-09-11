namespace UPC.Trabajo.KBHit
{
    partial class frmAproximacion
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
            objAproximacion = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbAproximacion = new System.Windows.Forms.GroupBox();
            this.gbReferencia = new System.Windows.Forms.GroupBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbOrigen = new System.Windows.Forms.Label();
            this.gbDetalleVuelo = new System.Windows.Forms.GroupBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pbAvion = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pbAerolinea = new DevExpress.XtraEditors.PictureEdit();
            this.gbObservaciones = new System.Windows.Forms.GroupBox();
            this.rtcObservaciones = new System.Windows.Forms.RichTextBox();
            this.cbAvion = new System.Windows.Forms.ComboBox();
            this.cbAerolinea = new System.Windows.Forms.ComboBox();
            this.lbAvion = new System.Windows.Forms.Label();
            this.lbAerolinea = new System.Windows.Forms.Label();
            this.cbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lbTipoMovimiento = new System.Windows.Forms.Label();
            this.tsMenuAproximacion = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.gbAproximacion.SuspendLayout();
            this.gbReferencia.SuspendLayout();
            this.gbDetalleVuelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAerolinea.Properties)).BeginInit();
            this.gbObservaciones.SuspendLayout();
            this.tsMenuAproximacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAproximacion
            // 
            this.gbAproximacion.BackColor = System.Drawing.Color.Transparent;
            this.gbAproximacion.Controls.Add(this.gbReferencia);
            this.gbAproximacion.Controls.Add(this.gbDetalleVuelo);
            this.gbAproximacion.Controls.Add(this.cbTipoMovimiento);
            this.gbAproximacion.Controls.Add(this.lbTipoMovimiento);
            this.gbAproximacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAproximacion.Location = new System.Drawing.Point(12, 28);
            this.gbAproximacion.Name = "gbAproximacion";
            this.gbAproximacion.Size = new System.Drawing.Size(711, 512);
            this.gbAproximacion.TabIndex = 0;
            this.gbAproximacion.TabStop = false;
            this.gbAproximacion.Text = "Aproximación con Radio Ayuda VOR - DME";
            // 
            // gbReferencia
            // 
            this.gbReferencia.Controls.Add(this.cbDestino);
            this.gbReferencia.Controls.Add(this.cbOrigen);
            this.gbReferencia.Controls.Add(this.lbDestino);
            this.gbReferencia.Controls.Add(this.lbOrigen);
            this.gbReferencia.Location = new System.Drawing.Point(15, 424);
            this.gbReferencia.Name = "gbReferencia";
            this.gbReferencia.Size = new System.Drawing.Size(680, 70);
            this.gbReferencia.TabIndex = 3;
            this.gbReferencia.TabStop = false;
            this.gbReferencia.Text = "Referencia";
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(441, 30);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(221, 23);
            this.cbDestino.TabIndex = 7;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(118, 30);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(221, 23);
            this.cbOrigen.TabIndex = 6;
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(375, 33);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(49, 15);
            this.lbDestino.TabIndex = 5;
            this.lbDestino.Text = "Destino";
            // 
            // lbOrigen
            // 
            this.lbOrigen.AutoSize = true;
            this.lbOrigen.Location = new System.Drawing.Point(26, 33);
            this.lbOrigen.Name = "lbOrigen";
            this.lbOrigen.Size = new System.Drawing.Size(44, 15);
            this.lbOrigen.TabIndex = 4;
            this.lbOrigen.Text = "Origen";
            // 
            // gbDetalleVuelo
            // 
            this.gbDetalleVuelo.Controls.Add(this.panelControl2);
            this.gbDetalleVuelo.Controls.Add(this.panelControl1);
            this.gbDetalleVuelo.Controls.Add(this.gbObservaciones);
            this.gbDetalleVuelo.Controls.Add(this.cbAvion);
            this.gbDetalleVuelo.Controls.Add(this.cbAerolinea);
            this.gbDetalleVuelo.Controls.Add(this.lbAvion);
            this.gbDetalleVuelo.Controls.Add(this.lbAerolinea);
            this.gbDetalleVuelo.Location = new System.Drawing.Point(15, 58);
            this.gbDetalleVuelo.Name = "gbDetalleVuelo";
            this.gbDetalleVuelo.Size = new System.Drawing.Size(680, 360);
            this.gbDetalleVuelo.TabIndex = 2;
            this.gbDetalleVuelo.TabStop = false;
            this.gbDetalleVuelo.Text = "Detalle de Vuelo";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pbAvion);
            this.panelControl2.Location = new System.Drawing.Point(441, 58);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(221, 123);
            this.panelControl2.TabIndex = 48;
            // 
            // pbAvion
            // 
            this.pbAvion.Location = new System.Drawing.Point(5, 5);
            this.pbAvion.Name = "pbAvion";
            this.pbAvion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pbAvion.Size = new System.Drawing.Size(211, 113);
            this.pbAvion.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pbAerolinea);
            this.panelControl1.Location = new System.Drawing.Point(118, 58);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(221, 123);
            this.panelControl1.TabIndex = 47;
            // 
            // pbAerolinea
            // 
            this.pbAerolinea.Location = new System.Drawing.Point(5, 5);
            this.pbAerolinea.Name = "pbAerolinea";
            this.pbAerolinea.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pbAerolinea.Size = new System.Drawing.Size(211, 113);
            this.pbAerolinea.TabIndex = 0;
            // 
            // gbObservaciones
            // 
            this.gbObservaciones.Controls.Add(this.rtcObservaciones);
            this.gbObservaciones.Location = new System.Drawing.Point(29, 186);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Size = new System.Drawing.Size(633, 156);
            this.gbObservaciones.TabIndex = 4;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Text = "Observaciones";
            // 
            // rtcObservaciones
            // 
            this.rtcObservaciones.Location = new System.Drawing.Point(17, 31);
            this.rtcObservaciones.Name = "rtcObservaciones";
            this.rtcObservaciones.Size = new System.Drawing.Size(601, 111);
            this.rtcObservaciones.TabIndex = 0;
            this.rtcObservaciones.Text = "";
            // 
            // cbAvion
            // 
            this.cbAvion.FormattingEnabled = true;
            this.cbAvion.Location = new System.Drawing.Point(441, 29);
            this.cbAvion.Name = "cbAvion";
            this.cbAvion.Size = new System.Drawing.Size(221, 23);
            this.cbAvion.TabIndex = 3;
            // 
            // cbAerolinea
            // 
            this.cbAerolinea.FormattingEnabled = true;
            this.cbAerolinea.Location = new System.Drawing.Point(118, 29);
            this.cbAerolinea.Name = "cbAerolinea";
            this.cbAerolinea.Size = new System.Drawing.Size(221, 23);
            this.cbAerolinea.TabIndex = 2;
            // 
            // lbAvion
            // 
            this.lbAvion.AutoSize = true;
            this.lbAvion.Location = new System.Drawing.Point(375, 37);
            this.lbAvion.Name = "lbAvion";
            this.lbAvion.Size = new System.Drawing.Size(36, 15);
            this.lbAvion.TabIndex = 1;
            this.lbAvion.Text = "Avión";
            // 
            // lbAerolinea
            // 
            this.lbAerolinea.AutoSize = true;
            this.lbAerolinea.Location = new System.Drawing.Point(26, 37);
            this.lbAerolinea.Name = "lbAerolinea";
            this.lbAerolinea.Size = new System.Drawing.Size(59, 15);
            this.lbAerolinea.TabIndex = 0;
            this.lbAerolinea.Text = "Aerolínea";
            // 
            // cbTipoMovimiento
            // 
            this.cbTipoMovimiento.FormattingEnabled = true;
            this.cbTipoMovimiento.Location = new System.Drawing.Point(133, 26);
            this.cbTipoMovimiento.Name = "cbTipoMovimiento";
            this.cbTipoMovimiento.Size = new System.Drawing.Size(221, 23);
            this.cbTipoMovimiento.TabIndex = 1;
            // 
            // lbTipoMovimiento
            // 
            this.lbTipoMovimiento.AutoSize = true;
            this.lbTipoMovimiento.Location = new System.Drawing.Point(12, 29);
            this.lbTipoMovimiento.Name = "lbTipoMovimiento";
            this.lbTipoMovimiento.Size = new System.Drawing.Size(115, 15);
            this.lbTipoMovimiento.TabIndex = 0;
            this.lbTipoMovimiento.Text = "Tipo de Movimiento";
            // 
            // tsMenuAproximacion
            // 
            this.tsMenuAproximacion.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuAproximacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbNuevo});
            this.tsMenuAproximacion.Location = new System.Drawing.Point(0, 0);
            this.tsMenuAproximacion.Name = "tsMenuAproximacion";
            this.tsMenuAproximacion.Size = new System.Drawing.Size(736, 25);
            this.tsMenuAproximacion.TabIndex = 1;
            this.tsMenuAproximacion.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(53, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.InGuardarAproximacion);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // frmAproximacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UPC.Trabajo.KBHit.Properties.Resources.SSA43870;
            this.ClientSize = new System.Drawing.Size(736, 548);
            this.Controls.Add(this.tsMenuAproximacion);
            this.Controls.Add(this.gbAproximacion);
            this.Name = "frmAproximacion";
            this.Text = "VOR - DME";
            this.gbAproximacion.ResumeLayout(false);
            this.gbAproximacion.PerformLayout();
            this.gbReferencia.ResumeLayout(false);
            this.gbReferencia.PerformLayout();
            this.gbDetalleVuelo.ResumeLayout(false);
            this.gbDetalleVuelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAerolinea.Properties)).EndInit();
            this.gbObservaciones.ResumeLayout(false);
            this.tsMenuAproximacion.ResumeLayout(false);
            this.tsMenuAproximacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAproximacion;
        private System.Windows.Forms.ComboBox cbTipoMovimiento;
        private System.Windows.Forms.Label lbTipoMovimiento;
        private System.Windows.Forms.GroupBox gbDetalleVuelo;
        private System.Windows.Forms.ComboBox cbAvion;
        private System.Windows.Forms.ComboBox cbAerolinea;
        private System.Windows.Forms.Label lbAvion;
        private System.Windows.Forms.Label lbAerolinea;
        private System.Windows.Forms.GroupBox gbObservaciones;
        private System.Windows.Forms.RichTextBox rtcObservaciones;
        private System.Windows.Forms.GroupBox gbReferencia;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label lbOrigen;
        private System.Windows.Forms.ToolStrip tsMenuAproximacion;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pbAvion;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pbAerolinea;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.Label lbDestino;
    }
}