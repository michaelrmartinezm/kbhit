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
            this.components = new System.ComponentModel.Container();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.dgvAerolineas = new System.Windows.Forms.DataGridView();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lbRuc = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.radToolStrip1 = new Telerik.WinControls.UI.RadToolStrip();
            this.radToolStripElement1 = new Telerik.WinControls.UI.RadToolStripElement();
            this.radToolStripItem1 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radToolStripItem2 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radToolStripItem3 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.radToolStripItem4 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement4 = new Telerik.WinControls.UI.RadButtonElement();
            this.radToolStripItem5 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement5 = new Telerik.WinControls.UI.RadButtonElement();
            this.office2007BlackTheme1 = new Telerik.WinControls.Themes.Office2007BlackTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Caption = "Aerolineas";
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(632, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.ThemeName = "Breeze";
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // dgvAerolineas
            // 
            this.dgvAerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAerolineas.Location = new System.Drawing.Point(20, 102);
            this.dgvAerolineas.Name = "dgvAerolineas";
            this.dgvAerolineas.Size = new System.Drawing.Size(589, 256);
            this.dgvAerolineas.TabIndex = 9;
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(461, 71);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(149, 20);
            this.txtRuc.TabIndex = 8;
            // 
            // lbRuc
            // 
            this.lbRuc.AutoSize = true;
            this.lbRuc.Location = new System.Drawing.Point(403, 74);
            this.lbRuc.Name = "lbRuc";
            this.lbRuc.Size = new System.Drawing.Size(39, 13);
            this.lbRuc.TabIndex = 7;
            this.lbRuc.Text = "R.U.C.";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(17, 74);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre";
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
            this.radToolStrip1.Size = new System.Drawing.Size(632, 26);
            this.radToolStrip1.TabIndex = 10;
            this.radToolStrip1.Text = "radToolStrip1";
            this.radToolStrip1.ThemeName = "Office2007Black";
            // 
            // radToolStripElement1
            // 
            this.radToolStripElement1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.radToolStripElement1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToolStripItem1,
            this.radToolStripItem2,
            this.radToolStripItem3,
            this.radToolStripItem4,
            this.radToolStripItem5});
            this.radToolStripElement1.Name = "radToolStripElement1";
            // 
            // radToolStripItem1
            // 
            this.radToolStripItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.radToolStripItem1.Key = "0";
            this.radToolStripItem1.Name = "radToolStripItem1";
            this.radToolStripItem1.Text = "Buscar por Nombre";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "Buscar por Nombre";
            // 
            // radToolStripItem2
            // 
            this.radToolStripItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement2});
            this.radToolStripItem2.Key = "1";
            this.radToolStripItem2.Name = "radToolStripItem2";
            this.radToolStripItem2.Text = "Buscar por RUC";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "Buscar por RUC";
            // 
            // radToolStripItem3
            // 
            this.radToolStripItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement3});
            this.radToolStripItem3.Key = "2";
            this.radToolStripItem3.Name = "radToolStripItem3";
            this.radToolStripItem3.Text = "Nuevo";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.ShowBorder = false;
            this.radButtonElement3.Text = "Nuevo";
            // 
            // radToolStripItem4
            // 
            this.radToolStripItem4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement4});
            this.radToolStripItem4.Key = "3";
            this.radToolStripItem4.Name = "radToolStripItem4";
            this.radToolStripItem4.Text = "radToolStripItem4";
            // 
            // radButtonElement4
            // 
            this.radButtonElement4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement4.Name = "radButtonElement4";
            this.radButtonElement4.ShowBorder = false;
            this.radButtonElement4.Text = "Visualizar";
            // 
            // radToolStripItem5
            // 
            this.radToolStripItem5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement5});
            this.radToolStripItem5.Key = "4";
            this.radToolStripItem5.Name = "radToolStripItem5";
            this.radToolStripItem5.Text = "radToolStripItem5";
            // 
            // radButtonElement5
            // 
            this.radButtonElement5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement5.Name = "radButtonElement5";
            this.radButtonElement5.ShowBorder = false;
            this.radButtonElement5.Text = "Editar";
            // 
            // frmAerolineas
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 382);
            this.Controls.Add(this.radToolStrip1);
            this.Controls.Add(this.dgvAerolineas);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.lbRuc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "frmAerolineas";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Aerolineas";
            this.ThemeName = "Breeze";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAerolineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private System.Windows.Forms.DataGridView dgvAerolineas;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lbRuc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.UI.RadToolStrip radToolStrip1;
        private Telerik.WinControls.UI.RadToolStripElement radToolStripElement1;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.Themes.Office2007BlackTheme office2007BlackTheme1;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem4;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement4;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem5;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement5;
    }
}