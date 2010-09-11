namespace UPC.Trabajo.KBHit
{
    partial class frmPlandeVuelos
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
            objPlandeVuelos = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlandeVuelos));
            this.tsMenuPanVuelo = new System.Windows.Forms.ToolStrip();
            this.tsbVisualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.dgvPlanVuelo = new System.Windows.Forms.DataGridView();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.tsMenuPanVuelo.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuPanVuelo
            // 
            this.tsMenuPanVuelo.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuPanVuelo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbVisualizar,
            this.tsbNuevo});
            this.tsMenuPanVuelo.Location = new System.Drawing.Point(0, 0);
            this.tsMenuPanVuelo.Name = "tsMenuPanVuelo";
            this.tsMenuPanVuelo.Size = new System.Drawing.Size(805, 25);
            this.tsMenuPanVuelo.TabIndex = 0;
            this.tsMenuPanVuelo.Text = "toolStrip1";
            // 
            // tsbVisualizar
            // 
            this.tsbVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVisualizar.Name = "tsbVisualizar";
            this.tsbVisualizar.Size = new System.Drawing.Size(60, 22);
            this.tsbVisualizar.Text = "Visualizar";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gbBusqueda.Controls.Add(this.lbFechaFin);
            this.gbBusqueda.Controls.Add(this.lbFechaInicio);
            this.gbBusqueda.Controls.Add(this.dgvPlanVuelo);
            this.gbBusqueda.Controls.Add(this.dtpFechaFin);
            this.gbBusqueda.Controls.Add(this.dtpFechaInicio);
            this.gbBusqueda.Location = new System.Drawing.Point(12, 28);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(781, 482);
            this.gbBusqueda.TabIndex = 1;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(549, 24);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(62, 13);
            this.lbFechaFin.TabIndex = 4;
            this.lbFechaFin.Text = "Fecha Final";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(25, 24);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.lbFechaInicio.TabIndex = 3;
            this.lbFechaInicio.Text = "Fecha de Inicio";
            // 
            // dgvPlanVuelo
            // 
            this.dgvPlanVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanVuelo.Location = new System.Drawing.Point(28, 91);
            this.dgvPlanVuelo.Name = "dgvPlanVuelo";
            this.dgvPlanVuelo.Size = new System.Drawing.Size(718, 371);
            this.dgvPlanVuelo.TabIndex = 2;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(546, 40);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(28, 40);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // frmPlandeVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 522);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.tsMenuPanVuelo);
            this.Name = "frmPlandeVuelos";
            this.Text = "Consulta de Plan de Vuelo";
            this.tsMenuPanVuelo.ResumeLayout(false);
            this.tsMenuPanVuelo.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuPanVuelo;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ToolStripButton tsbVisualizar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.DataGridView dgvPlanVuelo;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label lbFechaFin;
    }
}