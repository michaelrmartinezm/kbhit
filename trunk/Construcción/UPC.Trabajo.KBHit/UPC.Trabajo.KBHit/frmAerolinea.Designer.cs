namespace UPC.Trabajo.KBHit
{
    partial class frmAerolinea
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
            objAerolinea = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsMenuAerolinea = new System.Windows.Forms.ToolStrip();
            this.tsbGrabar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.gbDatosAerolinea = new System.Windows.Forms.GroupBox();
            this.bnCargar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Foto = new DevExpress.XtraEditors.PictureEdit();
            this.cbProcedencia = new System.Windows.Forms.ComboBox();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtNombreAerolinea = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbProcedencia = new System.Windows.Forms.Label();
            this.lbRuc = new System.Windows.Forms.Label();
            this.lbNombreAerolinea = new System.Windows.Forms.Label();
            this.lbCodAerolinea = new System.Windows.Forms.Label();
            this.tsMenuAerolinea.SuspendLayout();
            this.gbDatosAerolinea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenuAerolinea
            // 
            this.tsMenuAerolinea.BackColor = System.Drawing.Color.Transparent;
            this.tsMenuAerolinea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGrabar,
            this.tsbNuevo});
            this.tsMenuAerolinea.Location = new System.Drawing.Point(0, 0);
            this.tsMenuAerolinea.Name = "tsMenuAerolinea";
            this.tsMenuAerolinea.Size = new System.Drawing.Size(821, 25);
            this.tsMenuAerolinea.TabIndex = 0;
            this.tsMenuAerolinea.Text = "toolStrip1";
            // 
            // tsbGrabar
            // 
            this.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrabar.Name = "tsbGrabar";
            this.tsbGrabar.Size = new System.Drawing.Size(53, 22);
            this.tsbGrabar.Text = "Guardar";
            this.tsbGrabar.Click += new System.EventHandler(this.bnGuardarAerolinea);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.bnNuevaAerolinea);
            // 
            // gbDatosAerolinea
            // 
            this.gbDatosAerolinea.BackColor = System.Drawing.Color.Transparent;
            this.gbDatosAerolinea.Controls.Add(this.bnCargar);
            this.gbDatosAerolinea.Controls.Add(this.panelControl1);
            this.gbDatosAerolinea.Controls.Add(this.cbProcedencia);
            this.gbDatosAerolinea.Controls.Add(this.txtRuc);
            this.gbDatosAerolinea.Controls.Add(this.txtNombreAerolinea);
            this.gbDatosAerolinea.Controls.Add(this.txtCodigo);
            this.gbDatosAerolinea.Controls.Add(this.lbProcedencia);
            this.gbDatosAerolinea.Controls.Add(this.lbRuc);
            this.gbDatosAerolinea.Controls.Add(this.lbNombreAerolinea);
            this.gbDatosAerolinea.Controls.Add(this.lbCodAerolinea);
            this.gbDatosAerolinea.Location = new System.Drawing.Point(12, 28);
            this.gbDatosAerolinea.Name = "gbDatosAerolinea";
            this.gbDatosAerolinea.Size = new System.Drawing.Size(797, 222);
            this.gbDatosAerolinea.TabIndex = 1;
            this.gbDatosAerolinea.TabStop = false;
            this.gbDatosAerolinea.Text = "Datos de la Aerolínea";
            // 
            // bnCargar
            // 
            this.bnCargar.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold);
            this.bnCargar.Appearance.ForeColor = System.Drawing.Color.Chocolate;
            this.bnCargar.Appearance.Options.UseFont = true;
            this.bnCargar.Appearance.Options.UseForeColor = true;
            this.bnCargar.Location = new System.Drawing.Point(38, 182);
            this.bnCargar.Name = "bnCargar";
            this.bnCargar.Size = new System.Drawing.Size(109, 20);
            this.bnCargar.TabIndex = 12;
            this.bnCargar.Text = "Cargar Logotipo";
            this.bnCargar.Click += new System.EventHandler(this.InCargarLogotipo);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Foto);
            this.panelControl1.Location = new System.Drawing.Point(29, 44);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(130, 137);
            this.panelControl1.TabIndex = 8;
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(5, 5);
            this.Foto.Name = "Foto";
            this.Foto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Foto.Size = new System.Drawing.Size(120, 127);
            this.Foto.TabIndex = 0;
            // 
            // cbProcedencia
            // 
            this.cbProcedencia.FormattingEnabled = true;
            this.cbProcedencia.Items.AddRange(new object[] {
            "Lima",
            "Ica"});
            this.cbProcedencia.Location = new System.Drawing.Point(429, 181);
            this.cbProcedencia.Name = "cbProcedencia";
            this.cbProcedencia.Size = new System.Drawing.Size(332, 21);
            this.cbProcedencia.TabIndex = 7;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(429, 132);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(332, 20);
            this.txtRuc.TabIndex = 6;
            // 
            // txtNombreAerolinea
            // 
            this.txtNombreAerolinea.Location = new System.Drawing.Point(429, 86);
            this.txtNombreAerolinea.Name = "txtNombreAerolinea";
            this.txtNombreAerolinea.Size = new System.Drawing.Size(332, 20);
            this.txtNombreAerolinea.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(429, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(332, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lbProcedencia
            // 
            this.lbProcedencia.AutoSize = true;
            this.lbProcedencia.Location = new System.Drawing.Point(232, 188);
            this.lbProcedencia.Name = "lbProcedencia";
            this.lbProcedencia.Size = new System.Drawing.Size(67, 13);
            this.lbProcedencia.TabIndex = 3;
            this.lbProcedencia.Text = "Procedencia";
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.Location = new System.Drawing.Point(232, 139);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(39, 13);
            this.lbRuc.TabIndex = 2;
            this.lbRuc.Text = "R-U.C.";
            // 
            // lbNombreAerolinea
            // 
            this.lbNombreAerolinea.AutoSize = true;
            this.lbNombreAerolinea.Location = new System.Drawing.Point(232, 93);
            this.lbNombreAerolinea.Name = "lbNombreAerolinea";
            this.lbNombreAerolinea.Size = new System.Drawing.Size(119, 13);
            this.lbNombreAerolinea.TabIndex = 1;
            this.lbNombreAerolinea.Text = "Nombre de la Aerolínea";
            // 
            // lbCodAerolinea
            // 
            this.lbCodAerolinea.AutoSize = true;
            this.lbCodAerolinea.Location = new System.Drawing.Point(232, 51);
            this.lbCodAerolinea.Name = "lbCodAerolinea";
            this.lbCodAerolinea.Size = new System.Drawing.Size(40, 13);
            this.lbCodAerolinea.TabIndex = 0;
            this.lbCodAerolinea.Text = "Código";
            // 
            // frmAerolinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UPC.Trabajo.KBHit.Properties.Resources.SSA43891;
            this.ClientSize = new System.Drawing.Size(821, 272);
            this.Controls.Add(this.gbDatosAerolinea);
            this.Controls.Add(this.tsMenuAerolinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAerolinea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aerolínea";
            this.tsMenuAerolinea.ResumeLayout(false);
            this.tsMenuAerolinea.PerformLayout();
            this.gbDatosAerolinea.ResumeLayout(false);
            this.gbDatosAerolinea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenuAerolinea;
        private System.Windows.Forms.ToolStripButton tsbGrabar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.GroupBox gbDatosAerolinea;
        private System.Windows.Forms.Label lbProcedencia;
        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.Label lbNombreAerolinea;
        private System.Windows.Forms.Label lbCodAerolinea;
        private System.Windows.Forms.ComboBox cbProcedencia;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtNombreAerolinea;
        private System.Windows.Forms.TextBox txtCodigo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit Foto;
        private DevExpress.XtraEditors.SimpleButton bnCargar;
    }
}