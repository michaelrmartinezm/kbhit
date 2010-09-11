namespace UPC.Trabajo.KBHit
{
    partial class frmAviones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviones));
            this.tsMenuAviones = new System.Windows.Forms.ToolStrip();
            this.gbAviones = new System.Windows.Forms.GroupBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dgvAviones = new System.Windows.Forms.DataGridView();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbVisualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsMenuAviones.SuspendLayout();
            this.gbAviones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuAviones
            // 
            this.tsMenuAviones.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuAviones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscar,
            this.tsbVisualizar,
            this.tsbEditar});
            this.tsMenuAviones.Location = new System.Drawing.Point(0, 0);
            this.tsMenuAviones.Name = "tsMenuAviones";
            this.tsMenuAviones.Size = new System.Drawing.Size(807, 25);
            this.tsMenuAviones.TabIndex = 0;
            this.tsMenuAviones.Text = "toolStrip1";
            // 
            // gbAviones
            // 
            this.gbAviones.BackColor = System.Drawing.Color.Transparent;
            this.gbAviones.Controls.Add(this.dgvAviones);
            this.gbAviones.Controls.Add(this.txtModelo);
            this.gbAviones.Controls.Add(this.lbModelo);
            this.gbAviones.Location = new System.Drawing.Point(14, 32);
            this.gbAviones.Name = "gbAviones";
            this.gbAviones.Size = new System.Drawing.Size(781, 407);
            this.gbAviones.TabIndex = 1;
            this.gbAviones.TabStop = false;
            this.gbAviones.Text = "Búsqueda de Aviones";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(28, 46);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(49, 15);
            this.lbModelo.TabIndex = 0;
            this.lbModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(422, 43);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(322, 21);
            this.txtModelo.TabIndex = 1;
            // 
            // dgvAviones
            // 
            this.dgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAviones.Location = new System.Drawing.Point(31, 85);
            this.dgvAviones.Name = "dgvAviones";
            this.dgvAviones.Size = new System.Drawing.Size(713, 303);
            this.dgvAviones.TabIndex = 2;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(62, 22);
            this.tsbBuscar.Text = "Buscar";
            // 
            // tsbVisualizar
            // 
            this.tsbVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbVisualizar.Image")));
            this.tsbVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVisualizar.Name = "tsbVisualizar";
            this.tsbVisualizar.Size = new System.Drawing.Size(76, 22);
            this.tsbVisualizar.Text = "Visualizar";
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(57, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // frmAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(807, 451);
            this.Controls.Add(this.gbAviones);
            this.Controls.Add(this.tsMenuAviones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAviones";
            this.Text = "Aviones";
            this.tsMenuAviones.ResumeLayout(false);
            this.tsMenuAviones.PerformLayout();
            this.gbAviones.ResumeLayout(false);
            this.gbAviones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuAviones;
        private System.Windows.Forms.GroupBox gbAviones;
        private System.Windows.Forms.DataGridView dgvAviones;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbVisualizar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
    }
}