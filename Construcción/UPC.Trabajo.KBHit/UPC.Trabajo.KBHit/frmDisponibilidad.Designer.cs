namespace UPC.Trabajo.KBHit
{
    partial class frmDisponibilidad
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
            objDisponibilidad = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tsMenuDisponibilidad = new System.Windows.Forms.ToolStrip();
            this.tsbActualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbRefrezcar = new System.Windows.Forms.ToolStripButton();
            this.gbDisponiblidad = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.dgvDisponibilidad = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Timer(this.components);
            this.tsMenuDisponibilidad.SuspendLayout();
            this.gbDisponiblidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuDisponibilidad
            // 
            this.tsMenuDisponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuDisponibilidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbActualizar,
            this.tsbRefrezcar});
            this.tsMenuDisponibilidad.Location = new System.Drawing.Point(0, 0);
            this.tsMenuDisponibilidad.Name = "tsMenuDisponibilidad";
            this.tsMenuDisponibilidad.Size = new System.Drawing.Size(523, 25);
            this.tsMenuDisponibilidad.TabIndex = 0;
            this.tsMenuDisponibilidad.Text = "toolStrip1";
            // 
            // tsbActualizar
            // 
            this.tsbActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActualizar.Name = "tsbActualizar";
            this.tsbActualizar.Size = new System.Drawing.Size(63, 22);
            this.tsbActualizar.Text = "Actualizar";
            this.tsbActualizar.Click += new System.EventHandler(this.InActualizarPista);
            // 
            // tsbRefrezcar
            // 
            this.tsbRefrezcar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrezcar.Name = "tsbRefrezcar";
            this.tsbRefrezcar.Size = new System.Drawing.Size(59, 22);
            this.tsbRefrezcar.Text = "Refrezcar";
            this.tsbRefrezcar.Click += new System.EventHandler(this.InRefreshDGV);
            // 
            // gbDisponiblidad
            // 
            this.gbDisponiblidad.BackColor = System.Drawing.Color.Transparent;
            this.gbDisponiblidad.Controls.Add(this.cbEstado);
            this.gbDisponiblidad.Controls.Add(this.lbEstado);
            this.gbDisponiblidad.Controls.Add(this.dgvDisponibilidad);
            this.gbDisponiblidad.Location = new System.Drawing.Point(12, 28);
            this.gbDisponiblidad.Name = "gbDisponiblidad";
            this.gbDisponiblidad.Size = new System.Drawing.Size(498, 361);
            this.gbDisponiblidad.TabIndex = 1;
            this.gbDisponiblidad.TabStop = false;
            this.gbDisponiblidad.Text = "Disponibilidad de Pista de Aterrizaje";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cbEstado.Location = new System.Drawing.Point(273, 320);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(217, 23);
            this.cbEstado.TabIndex = 2;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(104, 328);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(163, 15);
            this.lbEstado.TabIndex = 1;
            this.lbEstado.Text = "Estado de Pista de Aterrizaje";
            // 
            // dgvDisponibilidad
            // 
            this.dgvDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibilidad.Location = new System.Drawing.Point(6, 20);
            this.dgvDisponibilidad.Name = "dgvDisponibilidad";
            this.dgvDisponibilidad.Size = new System.Drawing.Size(484, 285);
            this.dgvDisponibilidad.TabIndex = 0;
            // 
            // Refresh
            // 
            this.Refresh.Interval = 15000;
            this.Refresh.Tick += new System.EventHandler(this.InRefreshDGV);
            // 
            // frmDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UPC.Trabajo.KBHit.Properties.Resources.SSA43911;
            this.ClientSize = new System.Drawing.Size(523, 401);
            this.Controls.Add(this.gbDisponiblidad);
            this.Controls.Add(this.tsMenuDisponibilidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDisponibilidad";
            this.Text = "Disponibilidad";
            this.tsMenuDisponibilidad.ResumeLayout(false);
            this.tsMenuDisponibilidad.PerformLayout();
            this.gbDisponiblidad.ResumeLayout(false);
            this.gbDisponiblidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuDisponibilidad;
        private System.Windows.Forms.GroupBox gbDisponiblidad;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.DataGridView dgvDisponibilidad;
        private System.Windows.Forms.ToolStripButton tsbActualizar;
        private System.Windows.Forms.ToolStripButton tsbRefrezcar;
        private System.Windows.Forms.Timer Refresh;
    }
}