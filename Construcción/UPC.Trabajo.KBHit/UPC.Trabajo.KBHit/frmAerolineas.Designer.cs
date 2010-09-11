namespace UPC.Trabajo.KBHit
{
    partial class frmAerolineas
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
            objAerolineas = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAerolineas));
            this.tsMenuAerolineas = new System.Windows.Forms.ToolStrip();
            this.tsbBuscarNombre = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarRuc = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbVisualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.gbAerolineas = new System.Windows.Forms.GroupBox();
            this.dgvAerolineas = new System.Windows.Forms.DataGridView();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lbRuc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tsMenuAerolineas.SuspendLayout();
            this.gbAerolineas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolineas)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuAerolineas
            // 
            this.tsMenuAerolineas.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuAerolineas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscarNombre,
            this.tsbBuscarRuc,
            this.tsbNuevo,
            this.tsbVisualizar,
            this.tsbEditar});
            this.tsMenuAerolineas.Location = new System.Drawing.Point(0, 0);
            this.tsMenuAerolineas.Name = "tsMenuAerolineas";
            this.tsMenuAerolineas.Size = new System.Drawing.Size(824, 25);
            this.tsMenuAerolineas.TabIndex = 0;
            this.tsMenuAerolineas.Text = "toolStrip1";
            // 
            // tsbBuscarNombre
            // 
            this.tsbBuscarNombre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarNombre.Name = "tsbBuscarNombre";
            this.tsbBuscarNombre.Size = new System.Drawing.Size(109, 22);
            this.tsbBuscarNombre.Text = "Bucar por Nombre";
            // 
            // tsbBuscarRuc
            // 
            this.tsbBuscarRuc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarRuc.Name = "tsbBuscarRuc";
            this.tsbBuscarRuc.Size = new System.Drawing.Size(102, 22);
            this.tsbBuscarRuc.Text = "Buscar por R.U.C.";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbVisualizar
            // 
            this.tsbVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVisualizar.Name = "tsbVisualizar";
            this.tsbVisualizar.Size = new System.Drawing.Size(60, 22);
            this.tsbVisualizar.Text = "Visualizar";
            // 
            // tsbEditar
            // 
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(41, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // gbAerolineas
            // 
            this.gbAerolineas.BackColor = System.Drawing.Color.Transparent;
            this.gbAerolineas.Controls.Add(this.dgvAerolineas);
            this.gbAerolineas.Controls.Add(this.txtRuc);
            this.gbAerolineas.Controls.Add(this.lbRuc);
            this.gbAerolineas.Controls.Add(this.txtNombre);
            this.gbAerolineas.Controls.Add(this.lbNombre);
            this.gbAerolineas.Location = new System.Drawing.Point(14, 32);
            this.gbAerolineas.Name = "gbAerolineas";
            this.gbAerolineas.Size = new System.Drawing.Size(798, 389);
            this.gbAerolineas.TabIndex = 1;
            this.gbAerolineas.TabStop = false;
            this.gbAerolineas.Text = "Aerolíneas";
            // 
            // dgvAerolineas
            // 
            this.dgvAerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAerolineas.Location = new System.Drawing.Point(48, 90);
            this.dgvAerolineas.Name = "dgvAerolineas";
            this.dgvAerolineas.Size = new System.Drawing.Size(698, 285);
            this.dgvAerolineas.TabIndex = 4;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(533, 45);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(213, 21);
            this.txtRuc.TabIndex = 3;
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.Location = new System.Drawing.Point(475, 48);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(42, 15);
            this.lbRuc.TabIndex = 2;
            this.lbRuc.Text = "R.U.C.";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(45, 48);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(52, 15);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // frmAerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 433);
            this.Controls.Add(this.gbAerolineas);
            this.Controls.Add(this.tsMenuAerolineas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAerolineas";
            this.Text = "Aerolíneas";
            this.tsMenuAerolineas.ResumeLayout(false);
            this.tsMenuAerolineas.PerformLayout();
            this.gbAerolineas.ResumeLayout(false);
            this.gbAerolineas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuAerolineas;
        private System.Windows.Forms.GroupBox gbAerolineas;
        private System.Windows.Forms.ToolStripButton tsbBuscarNombre;
        private System.Windows.Forms.ToolStripButton tsbBuscarRuc;
        private System.Windows.Forms.ToolStripButton tsbVisualizar;
        private System.Windows.Forms.DataGridView dgvAerolineas;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
    }
}