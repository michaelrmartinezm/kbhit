namespace UPC.Trabajo.KBHit
{
    partial class frmFacturacionTUUA
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
            objFacturacionTUUA = null;
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.cbFecha = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dgvTUUA = new Telerik.WinControls.UI.RadGridView();
            this.tsbGuardar = new Telerik.WinControls.UI.RadButton();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.tsbVerInfo = new Telerik.WinControls.UI.RadButton();
            this.cbAerolinea = new Telerik.WinControls.UI.RadComboBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTUUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbVerInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAerolinea)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Caption = "Facturación TUUA";
            this.radTitleBar1.Location = new System.Drawing.Point(1, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.Size = new System.Drawing.Size(427, 30);
            this.radTitleBar1.TabIndex = 1;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.ThemeName = "Breeze";
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadImageButtonElement)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Enabled = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Enabled = false;
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(25, 70);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 16);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Aerolinea";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(25, 98);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(85, 16);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Fecha de Vuelo";
            // 
            // cbFecha
            // 
            this.cbFecha.AutoSize = true;
            this.cbFecha.Culture = new System.Globalization.CultureInfo("es-MX");
            this.cbFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbFecha.Location = new System.Drawing.Point(120, 92);
            this.cbFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cbFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.cbFecha.Size = new System.Drawing.Size(102, 22);
            this.cbFecha.TabIndex = 6;
            this.cbFecha.TabStop = false;
            this.cbFecha.Text = "radDateTimePicker1";
            this.cbFecha.Value = new System.DateTime(2010, 10, 29, 16, 4, 10, 967);
            // 
            // dgvTUUA
            // 
            this.dgvTUUA.Location = new System.Drawing.Point(27, 149);
            // 
            // 
            // 
            this.dgvTUUA.MasterGridViewTemplate.AllowAddNewRow = false;
            this.dgvTUUA.Name = "dgvTUUA";
            this.dgvTUUA.ReadOnly = true;
            this.dgvTUUA.Size = new System.Drawing.Size(372, 256);
            this.dgvTUUA.TabIndex = 7;
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Location = new System.Drawing.Point(252, 411);
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(147, 32);
            this.tsbGuardar.TabIndex = 8;
            this.tsbGuardar.Text = "Generar Reporte";
            this.tsbGuardar.ThemeName = "Aqua";
            // 
            // tsbVerInfo
            // 
            this.tsbVerInfo.Location = new System.Drawing.Point(25, 120);
            this.tsbVerInfo.Name = "tsbVerInfo";
            this.tsbVerInfo.Size = new System.Drawing.Size(71, 23);
            this.tsbVerInfo.TabIndex = 9;
            this.tsbVerInfo.Text = "Ver Info";
            this.tsbVerInfo.ThemeName = "Aqua";
            this.tsbVerInfo.Click += new System.EventHandler(this.tsbVerInformacion);
            // 
            // cbAerolinea
            // 
            this.cbAerolinea.Location = new System.Drawing.Point(120, 66);
            this.cbAerolinea.Name = "cbAerolinea";
            // 
            // 
            // 
            this.cbAerolinea.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cbAerolinea.Size = new System.Drawing.Size(220, 20);
            this.cbAerolinea.TabIndex = 11;
            this.cbAerolinea.TabStop = false;
            // 
            // frmFacturacionTUUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 468);
            this.Controls.Add(this.cbAerolinea);
            this.Controls.Add(this.tsbVerInfo);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.dgvTUUA);
            this.Controls.Add(this.cbFecha);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "frmFacturacionTUUA";
            this.Shape = this.roundRectShape1;
            this.Text = "Facturación TUUA";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTUUA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbVerInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAerolinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker cbFecha;
        private Telerik.WinControls.UI.RadGridView dgvTUUA;
        private Telerik.WinControls.UI.RadButton tsbGuardar;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadButton tsbVerInfo;
        private Telerik.WinControls.UI.RadComboBox cbAerolinea;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
    }
}