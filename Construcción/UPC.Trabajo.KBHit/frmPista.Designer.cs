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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cbAeropuerto = new System.Windows.Forms.ComboBox();
            this.cbPista = new System.Windows.Forms.ComboBox();
            this.lbAeropuerto = new System.Windows.Forms.Label();
            this.lbPista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).BeginInit();
            this.dbDetallePista.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Caption = "Pista";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(548, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "frm_Pista";
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
            this.radToolStrip1.Size = new System.Drawing.Size(548, 26);
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
            this.dbDetallePista.Location = new System.Drawing.Point(12, 166);
            this.dbDetallePista.Name = "dbDetallePista";
            this.dbDetallePista.Size = new System.Drawing.Size(522, 284);
            this.dbDetallePista.TabIndex = 4;
            this.dbDetallePista.TabStop = false;
            this.dbDetallePista.Text = "Detalle de Pista";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(129, 162);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(160, 20);
            this.txtCalle.TabIndex = 23;
            // 
            // txtFranja
            // 
            this.txtFranja.Location = new System.Drawing.Point(129, 136);
            this.txtFranja.Name = "txtFranja";
            this.txtFranja.Size = new System.Drawing.Size(160, 20);
            this.txtFranja.TabIndex = 22;
            // 
            // txtPCN
            // 
            this.txtPCN.Location = new System.Drawing.Point(129, 110);
            this.txtPCN.Name = "txtPCN";
            this.txtPCN.Size = new System.Drawing.Size(160, 20);
            this.txtPCN.TabIndex = 20;
            // 
            // txtDesignador
            // 
            this.txtDesignador.Location = new System.Drawing.Point(129, 84);
            this.txtDesignador.Name = "txtDesignador";
            this.txtDesignador.Size = new System.Drawing.Size(160, 20);
            this.txtDesignador.TabIndex = 19;
            // 
            // txtPavimento
            // 
            this.txtPavimento.Location = new System.Drawing.Point(129, 58);
            this.txtPavimento.Name = "txtPavimento";
            this.txtPavimento.Size = new System.Drawing.Size(160, 20);
            this.txtPavimento.TabIndex = 18;
            // 
            // txtLDA
            // 
            this.txtLDA.Location = new System.Drawing.Point(129, 32);
            this.txtLDA.Name = "txtLDA";
            this.txtLDA.Size = new System.Drawing.Size(160, 20);
            this.txtLDA.TabIndex = 17;
            // 
            // dudASDA
            // 
            this.dudASDA.Location = new System.Drawing.Point(129, 240);
            this.dudASDA.Name = "dudASDA";
            this.dudASDA.Size = new System.Drawing.Size(93, 20);
            this.dudASDA.TabIndex = 16;
            // 
            // dudTODA
            // 
            this.dudTODA.Location = new System.Drawing.Point(129, 214);
            this.dudTODA.Name = "dudTODA";
            this.dudTODA.Size = new System.Drawing.Size(93, 20);
            this.dudTODA.TabIndex = 15;
            // 
            // dudTORA
            // 
            this.dudTORA.Location = new System.Drawing.Point(129, 188);
            this.dudTORA.Name = "dudTORA";
            this.dudTORA.Size = new System.Drawing.Size(93, 20);
            this.dudTORA.TabIndex = 14;
            // 
            // dudAncho
            // 
            this.dudAncho.Location = new System.Drawing.Point(409, 214);
            this.dudAncho.Name = "dudAncho";
            this.dudAncho.Size = new System.Drawing.Size(93, 20);
            this.dudAncho.TabIndex = 13;
            // 
            // dudLargo
            // 
            this.dudLargo.Location = new System.Drawing.Point(409, 188);
            this.dudLargo.Name = "dudLargo";
            this.dudLargo.Size = new System.Drawing.Size(93, 20);
            this.dudLargo.TabIndex = 12;
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(19, 169);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(82, 13);
            this.lbCalle.TabIndex = 11;
            this.lbCalle.Text = "Calle de Rodaje";
            // 
            // lbFranja
            // 
            this.lbFranja.AutoSize = true;
            this.lbFranja.Location = new System.Drawing.Point(19, 143);
            this.lbFranja.Name = "lbFranja";
            this.lbFranja.Size = new System.Drawing.Size(77, 13);
            this.lbFranja.TabIndex = 10;
            this.lbFranja.Text = "Franja de Pista";
            // 
            // lbPCN
            // 
            this.lbPCN.AutoSize = true;
            this.lbPCN.Location = new System.Drawing.Point(19, 117);
            this.lbPCN.Name = "lbPCN";
            this.lbPCN.Size = new System.Drawing.Size(29, 13);
            this.lbPCN.TabIndex = 8;
            this.lbPCN.Text = "PCN";
            // 
            // lbDesignador
            // 
            this.lbDesignador.AutoSize = true;
            this.lbDesignador.Location = new System.Drawing.Point(19, 91);
            this.lbDesignador.Name = "lbDesignador";
            this.lbDesignador.Size = new System.Drawing.Size(102, 13);
            this.lbDesignador.TabIndex = 7;
            this.lbDesignador.Text = "Designador de Pista";
            // 
            // lbPavimento
            // 
            this.lbPavimento.AutoSize = true;
            this.lbPavimento.Location = new System.Drawing.Point(19, 65);
            this.lbPavimento.Name = "lbPavimento";
            this.lbPavimento.Size = new System.Drawing.Size(57, 13);
            this.lbPavimento.TabIndex = 6;
            this.lbPavimento.Text = "Pavimento";
            // 
            // lbLDA
            // 
            this.lbLDA.AutoSize = true;
            this.lbLDA.Location = new System.Drawing.Point(19, 39);
            this.lbLDA.Name = "lbLDA";
            this.lbLDA.Size = new System.Drawing.Size(28, 13);
            this.lbLDA.TabIndex = 5;
            this.lbLDA.Text = "LDA";
            // 
            // lbToda
            // 
            this.lbToda.AutoSize = true;
            this.lbToda.Location = new System.Drawing.Point(19, 221);
            this.lbToda.Name = "lbToda";
            this.lbToda.Size = new System.Drawing.Size(37, 13);
            this.lbToda.TabIndex = 4;
            this.lbToda.Text = "TODA";
            // 
            // lbAsda
            // 
            this.lbAsda.AutoSize = true;
            this.lbAsda.Location = new System.Drawing.Point(19, 247);
            this.lbAsda.Name = "lbAsda";
            this.lbAsda.Size = new System.Drawing.Size(36, 13);
            this.lbAsda.TabIndex = 3;
            this.lbAsda.Text = "ASDA";
            // 
            // lbTora
            // 
            this.lbTora.AutoSize = true;
            this.lbTora.Location = new System.Drawing.Point(19, 195);
            this.lbTora.Name = "lbTora";
            this.lbTora.Size = new System.Drawing.Size(37, 13);
            this.lbTora.TabIndex = 2;
            this.lbTora.Text = "TORA";
            // 
            // lbAncho
            // 
            this.lbAncho.AutoSize = true;
            this.lbAncho.Location = new System.Drawing.Point(299, 221);
            this.lbAncho.Name = "lbAncho";
            this.lbAncho.Size = new System.Drawing.Size(38, 13);
            this.lbAncho.TabIndex = 1;
            this.lbAncho.Text = "Ancho";
            // 
            // lbLargo
            // 
            this.lbLargo.AutoSize = true;
            this.lbLargo.Location = new System.Drawing.Point(299, 195);
            this.lbLargo.Name = "lbLargo";
            this.lbLargo.Size = new System.Drawing.Size(34, 13);
            this.lbLargo.TabIndex = 0;
            this.lbLargo.Text = "Largo";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.cbAeropuerto);
            this.gbDatos.Controls.Add(this.cbPista);
            this.gbDatos.Controls.Add(this.lbAeropuerto);
            this.gbDatos.Controls.Add(this.lbPista);
            this.gbDatos.Location = new System.Drawing.Point(12, 55);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(522, 105);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Principales";
            // 
            // cbAeropuerto
            // 
            this.cbAeropuerto.FormattingEnabled = true;
            this.cbAeropuerto.Location = new System.Drawing.Point(129, 40);
            this.cbAeropuerto.Name = "cbAeropuerto";
            this.cbAeropuerto.Size = new System.Drawing.Size(208, 21);
            this.cbAeropuerto.TabIndex = 3;
            this.cbAeropuerto.SelectedValueChanged += new System.EventHandler(this.InElegirAeropuerto);
            // 
            // cbPista
            // 
            this.cbPista.FormattingEnabled = true;
            this.cbPista.Location = new System.Drawing.Point(129, 67);
            this.cbPista.Name = "cbPista";
            this.cbPista.Size = new System.Drawing.Size(93, 21);
            this.cbPista.TabIndex = 2;
            this.cbPista.SelectedValueChanged += new System.EventHandler(this.InElegirPista);
            // 
            // lbAeropuerto
            // 
            this.lbAeropuerto.AutoSize = true;
            this.lbAeropuerto.Location = new System.Drawing.Point(19, 40);
            this.lbAeropuerto.Name = "lbAeropuerto";
            this.lbAeropuerto.Size = new System.Drawing.Size(59, 13);
            this.lbAeropuerto.TabIndex = 1;
            this.lbAeropuerto.Text = "Aeropuerto";
            // 
            // lbPista
            // 
            this.lbPista.AutoSize = true;
            this.lbPista.Location = new System.Drawing.Point(19, 72);
            this.lbPista.Name = "lbPista";
            this.lbPista.Size = new System.Drawing.Size(91, 13);
            this.lbPista.TabIndex = 0;
            this.lbPista.Text = "Pista de Aterrizaje";
            // 
            // frmPista
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 467);
            this.Controls.Add(this.dbDetallePista);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.radToolStrip1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "frmPista";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Pista";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).EndInit();
            this.dbDetallePista.ResumeLayout(false);
            this.dbDetallePista.PerformLayout();
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
        private System.Windows.Forms.GroupBox dbDetallePista;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtFranja;
        private System.Windows.Forms.TextBox txtPCN;
        private System.Windows.Forms.TextBox txtDesignador;
        private System.Windows.Forms.TextBox txtPavimento;
        private System.Windows.Forms.TextBox txtLDA;
        private System.Windows.Forms.DomainUpDown dudASDA;
        private System.Windows.Forms.DomainUpDown dudTODA;
        private System.Windows.Forms.DomainUpDown dudTORA;
        private System.Windows.Forms.DomainUpDown dudAncho;
        private System.Windows.Forms.DomainUpDown dudLargo;
        private System.Windows.Forms.Label lbCalle;
        private System.Windows.Forms.Label lbFranja;
        private System.Windows.Forms.Label lbPCN;
        private System.Windows.Forms.Label lbDesignador;
        private System.Windows.Forms.Label lbPavimento;
        private System.Windows.Forms.Label lbLDA;
        private System.Windows.Forms.Label lbToda;
        private System.Windows.Forms.Label lbAsda;
        private System.Windows.Forms.Label lbTora;
        private System.Windows.Forms.Label lbAncho;
        private System.Windows.Forms.Label lbLargo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ComboBox cbAeropuerto;
        private System.Windows.Forms.ComboBox cbPista;
        private System.Windows.Forms.Label lbAeropuerto;
        private System.Windows.Forms.Label lbPista;
    }
}