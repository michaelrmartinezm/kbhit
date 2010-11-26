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
            this.components = new System.ComponentModel.Container();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            this.radToolStrip1 = new Telerik.WinControls.UI.RadToolStrip();
            this.radToolStripElement1 = new Telerik.WinControls.UI.RadToolStripElement();
            this.radToolStripItem1 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbAeropuerto = new System.Windows.Forms.ComboBox();
            this.lbAeroperto = new System.Windows.Forms.Label();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.lbPlataforma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).BeginInit();
            this.gbDetalle.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Caption = "Plataforma";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(441, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "frm_Plataforma";
            this.radTitleBar1.ThemeName = "Breeze";
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // radToolStrip1
            // 
            this.radToolStrip1.AllowDragging = false;
            this.radToolStrip1.AllowFloating = false;
            this.radToolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radToolStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToolStripElement1});
            this.radToolStrip1.Location = new System.Drawing.Point(0, 23);
            this.radToolStrip1.MinimumSize = new System.Drawing.Size(5, 5);
            this.radToolStrip1.Name = "radToolStrip1";
            this.radToolStrip1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radToolStrip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radToolStrip1.RootElement.MinSize = new System.Drawing.Size(5, 5);
            this.radToolStrip1.ShowOverFlowButton = true;
            this.radToolStrip1.Size = new System.Drawing.Size(441, 26);
            this.radToolStrip1.TabIndex = 1;
            this.radToolStrip1.Text = "radToolStrip1";
            this.radToolStrip1.ThemeName = "Office2007Black";
            // 
            // radToolStripElement1
            // 
            this.radToolStripElement1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToolStripItem1});
            this.radToolStripElement1.Name = "radToolStripElement1";
            // 
            // radToolStripItem1
            // 
            this.radToolStripItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radButtonElement2});
            this.radToolStripItem1.Key = "0";
            this.radToolStripItem1.Name = "radToolStripItem1";
            this.radToolStripItem1.Text = "radToolStripItem1";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "Guardar";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "Nuevo";
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
            this.gbDetalle.Location = new System.Drawing.Point(12, 166);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(416, 205);
            this.gbDetalle.TabIndex = 4;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle de Plataforma";
            // 
            // txtAeronaveMacPermisible
            // 
            this.txtAeronaveMacPermisible.Location = new System.Drawing.Point(244, 153);
            this.txtAeronaveMacPermisible.Name = "txtAeronaveMacPermisible";
            this.txtAeronaveMacPermisible.Size = new System.Drawing.Size(141, 20);
            this.txtAeronaveMacPermisible.TabIndex = 9;
            // 
            // txtDimensiones
            // 
            this.txtDimensiones.Location = new System.Drawing.Point(244, 127);
            this.txtDimensiones.Name = "txtDimensiones";
            this.txtDimensiones.Size = new System.Drawing.Size(141, 20);
            this.txtDimensiones.TabIndex = 8;
            // 
            // txtPCN
            // 
            this.txtPCN.Location = new System.Drawing.Point(244, 101);
            this.txtPCN.Name = "txtPCN";
            this.txtPCN.Size = new System.Drawing.Size(141, 20);
            this.txtPCN.TabIndex = 7;
            // 
            // cbPavimento
            // 
            this.cbPavimento.FormattingEnabled = true;
            this.cbPavimento.Location = new System.Drawing.Point(244, 74);
            this.cbPavimento.Name = "cbPavimento";
            this.cbPavimento.Size = new System.Drawing.Size(141, 21);
            this.cbPavimento.TabIndex = 6;
            // 
            // dudPuestos
            // 
            this.dudPuestos.Location = new System.Drawing.Point(244, 48);
            this.dudPuestos.Name = "dudPuestos";
            this.dudPuestos.Size = new System.Drawing.Size(141, 20);
            this.dudPuestos.TabIndex = 5;
            // 
            // lbAeronaveMaxPermisible
            // 
            this.lbAeronaveMaxPermisible.AutoSize = true;
            this.lbAeronaveMaxPermisible.Location = new System.Drawing.Point(28, 156);
            this.lbAeronaveMaxPermisible.Name = "lbAeronaveMaxPermisible";
            this.lbAeronaveMaxPermisible.Size = new System.Drawing.Size(142, 13);
            this.lbAeronaveMaxPermisible.TabIndex = 4;
            this.lbAeronaveMaxPermisible.Text = "Aeronave Máxima Permisible";
            // 
            // lbDimensiones
            // 
            this.lbDimensiones.AutoSize = true;
            this.lbDimensiones.Location = new System.Drawing.Point(28, 134);
            this.lbDimensiones.Name = "lbDimensiones";
            this.lbDimensiones.Size = new System.Drawing.Size(67, 13);
            this.lbDimensiones.TabIndex = 3;
            this.lbDimensiones.Text = "Dimensiones";
            // 
            // lbPCN
            // 
            this.lbPCN.AutoSize = true;
            this.lbPCN.Location = new System.Drawing.Point(28, 108);
            this.lbPCN.Name = "lbPCN";
            this.lbPCN.Size = new System.Drawing.Size(29, 13);
            this.lbPCN.TabIndex = 2;
            this.lbPCN.Text = "PCN";
            // 
            // lbPavimento
            // 
            this.lbPavimento.AutoSize = true;
            this.lbPavimento.Location = new System.Drawing.Point(28, 84);
            this.lbPavimento.Name = "lbPavimento";
            this.lbPavimento.Size = new System.Drawing.Size(57, 13);
            this.lbPavimento.TabIndex = 1;
            this.lbPavimento.Text = "Pavimento";
            // 
            // lbPuesto
            // 
            this.lbPuesto.AutoSize = true;
            this.lbPuesto.Location = new System.Drawing.Point(28, 55);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(210, 13);
            this.lbPuesto.TabIndex = 0;
            this.lbPuesto.Text = "Puestos de Estacionamiento de Aeronaves";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.cbAeropuerto);
            this.gbDatos.Controls.Add(this.lbAeroperto);
            this.gbDatos.Controls.Add(this.cbPlataforma);
            this.gbDatos.Controls.Add(this.lbPlataforma);
            this.gbDatos.Location = new System.Drawing.Point(12, 55);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(416, 105);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Principales";
            // 
            // cbAeropuerto
            // 
            this.cbAeropuerto.FormattingEnabled = true;
            this.cbAeropuerto.Location = new System.Drawing.Point(101, 33);
            this.cbAeropuerto.Name = "cbAeropuerto";
            this.cbAeropuerto.Size = new System.Drawing.Size(162, 21);
            this.cbAeropuerto.TabIndex = 3;
            this.cbAeropuerto.SelectedValueChanged += new System.EventHandler(this.InElegirAeropuerto);
            // 
            // lbAeroperto
            // 
            this.lbAeroperto.AutoSize = true;
            this.lbAeroperto.Location = new System.Drawing.Point(28, 36);
            this.lbAeroperto.Name = "lbAeroperto";
            this.lbAeroperto.Size = new System.Drawing.Size(59, 13);
            this.lbAeroperto.TabIndex = 2;
            this.lbAeroperto.Text = "Aeropuerto";
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Location = new System.Drawing.Point(101, 60);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(137, 21);
            this.cbPlataforma.TabIndex = 1;
            this.cbPlataforma.SelectedValueChanged += new System.EventHandler(this.InElegirPlataforma);
            // 
            // lbPlataforma
            // 
            this.lbPlataforma.AutoSize = true;
            this.lbPlataforma.Location = new System.Drawing.Point(28, 63);
            this.lbPlataforma.Name = "lbPlataforma";
            this.lbPlataforma.Size = new System.Drawing.Size(57, 13);
            this.lbPlataforma.TabIndex = 0;
            this.lbPlataforma.Text = "Plataforma";
            // 
            // frmPlataforma
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 388);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.radToolStrip1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "frmPlataforma";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Plataforma";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private Telerik.WinControls.UI.RadToolStrip radToolStrip1;
        private Telerik.WinControls.UI.RadToolStripElement radToolStripElement1;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.TextBox txtAeronaveMacPermisible;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.TextBox txtPCN;
        private System.Windows.Forms.ComboBox cbPavimento;
        private System.Windows.Forms.DomainUpDown dudPuestos;
        private System.Windows.Forms.Label lbAeronaveMaxPermisible;
        private System.Windows.Forms.Label lbDimensiones;
        private System.Windows.Forms.Label lbPCN;
        private System.Windows.Forms.Label lbPavimento;
        private System.Windows.Forms.Label lbPuesto;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ComboBox cbAeropuerto;
        private System.Windows.Forms.Label lbAeroperto;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.Label lbPlataforma;
    }
}