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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
            objAviones = null;
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
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.dgvAviones = new System.Windows.Forms.DataGridView();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Caption = "Aviones";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(579, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "frm_Aviones";
            this.radTitleBar1.ThemeName = "Breeze";
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Enabled = false;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
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
            this.radToolStrip1.Size = new System.Drawing.Size(579, 26);
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
            this.radButtonElement2,
            this.radButtonElement3});
            this.radToolStripItem1.Key = "0";
            this.radToolStripItem1.Name = "radToolStripItem1";
            this.radToolStripItem1.Text = "radToolStripItem1";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "Buscar";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "Visualizar";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.ShowBorder = false;
            this.radButtonElement3.Text = "Editar";
            // 
            // dgvAviones
            // 
            this.dgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAviones.Location = new System.Drawing.Point(26, 105);
            this.dgvAviones.Name = "dgvAviones";
            this.dgvAviones.Size = new System.Drawing.Size(525, 263);
            this.dgvAviones.TabIndex = 5;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(91, 70);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(133, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(23, 77);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 3;
            this.lbModelo.Text = "Modelo";
            // 
            // frmAviones
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 394);
            this.Controls.Add(this.dgvAviones);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.radToolStrip1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "frmAviones";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Aviones";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAviones)).EndInit();
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
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private System.Windows.Forms.DataGridView dgvAviones;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbModelo;
    }
}