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
            this.gbDisponiblidad = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.dgvDisponibilidad = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).BeginInit();
            this.gbDisponiblidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Caption = "Disponibilidad";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(524, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "frm_Disponibilidad";
            this.radTitleBar1.ThemeName = "Breeze";
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Enabled = false;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
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
            this.radToolStrip1.Size = new System.Drawing.Size(524, 48);
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
            this.radButtonElement1.Text = "Actualizar";
            this.radButtonElement1.Click += new System.EventHandler(this.InActualizarPista);
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "Refrescar";
            this.radButtonElement2.Click += new System.EventHandler(this.InRefreshDGV);
            // 
            // gbDisponiblidad
            // 
            this.gbDisponiblidad.BackColor = System.Drawing.Color.Transparent;
            this.gbDisponiblidad.Controls.Add(this.cbEstado);
            this.gbDisponiblidad.Controls.Add(this.lbEstado);
            this.gbDisponiblidad.Controls.Add(this.dgvDisponibilidad);
            this.gbDisponiblidad.Location = new System.Drawing.Point(12, 65);
            this.gbDisponiblidad.Name = "gbDisponiblidad";
            this.gbDisponiblidad.Size = new System.Drawing.Size(498, 346);
            this.gbDisponiblidad.TabIndex = 2;
            this.gbDisponiblidad.TabStop = false;
            this.gbDisponiblidad.Text = "Disponibilidad de Pista de Aterrizaje";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cbEstado.Location = new System.Drawing.Point(337, 311);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(155, 21);
            this.cbEstado.TabIndex = 2;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(189, 319);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(142, 13);
            this.lbEstado.TabIndex = 1;
            this.lbEstado.Text = "Estado de Pista de Aterrizaje";
            // 
            // dgvDisponibilidad
            // 
            this.dgvDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibilidad.Location = new System.Drawing.Point(6, 20);
            this.dgvDisponibilidad.Name = "dgvDisponibilidad";
            this.dgvDisponibilidad.Size = new System.Drawing.Size(486, 285);
            this.dgvDisponibilidad.TabIndex = 0;
            // 
            // Refresh
            // 
            this.Refresh.Interval = 15000;
            this.Refresh.Tick += new System.EventHandler(this.InRefreshDGV);
            // 
            // frmDisponibilidad
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 432);
            this.Controls.Add(this.gbDisponiblidad);
            this.Controls.Add(this.radToolStrip1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "frmDisponibilidad";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Disponibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).EndInit();
            this.gbDisponiblidad.ResumeLayout(false);
            this.gbDisponiblidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidad)).EndInit();
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
        private System.Windows.Forms.GroupBox gbDisponiblidad;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.DataGridView dgvDisponibilidad;
        private System.Windows.Forms.Timer Refresh;
    }
}