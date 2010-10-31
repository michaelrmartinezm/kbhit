namespace UPC.Trabajo.KBHit
{
    partial class frmFacturacionTUA
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
            this.components = new System.ComponentModel.Container();
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.radComboBox1 = new Telerik.WinControls.UI.RadComboBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.tsbGuardar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Caption = "Facturación TUA";
            this.radTitleBar1.Location = new System.Drawing.Point(1, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.Size = new System.Drawing.Size(429, 30);
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
            // radComboBox1
            // 
            this.radComboBox1.Location = new System.Drawing.Point(120, 66);
            this.radComboBox1.Name = "radComboBox1";
            // 
            // 
            // 
            this.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radComboBox1.Size = new System.Drawing.Size(279, 20);
            this.radComboBox1.TabIndex = 2;
            this.radComboBox1.TabStop = false;
            this.radComboBox1.Text = "radComboBox1";
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
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.AutoSize = true;
            this.radDateTimePicker1.Culture = new System.Globalization.CultureInfo("es-MX");
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePicker1.Location = new System.Drawing.Point(120, 92);
            this.radDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.NullDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.radDateTimePicker1.Size = new System.Drawing.Size(150, 22);
            this.radDateTimePicker1.TabIndex = 6;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "radDateTimePicker1";
            this.radDateTimePicker1.Value = new System.DateTime(2010, 10, 29, 16, 4, 10, 967);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(27, 145);
            // 
            // 
            // 
            this.radGridView1.MasterGridViewTemplate.AllowAddNewRow = false;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(372, 260);
            this.radGridView1.TabIndex = 7;
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
            // ShapedForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 468);
            this.Controls.Add(this.tsbGuardar);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radComboBox1);
            this.Controls.Add(this.radTitleBar1);
            this.Name = "ShapedForm1";
            this.Shape = this.roundRectShapeForm;
            this.Text = "Facturación TUA";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.UI.RadComboBox radComboBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton tsbGuardar;
    }
}