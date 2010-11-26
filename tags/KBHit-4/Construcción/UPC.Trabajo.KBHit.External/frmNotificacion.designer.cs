namespace UPC.Trabajo.KBHit
{
    partial class frmNotificacion
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
            this.timerInicio = new System.Windows.Forms.Timer(this.components);
            this.timerEspera = new System.Windows.Forms.Timer(this.components);
            this.timerCerrar = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlFondo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // timerInicio
            // 
            this.timerInicio.Interval = 7;
            this.timerInicio.Tick += new System.EventHandler(this.timerInicio_Tick);
            // 
            // timerEspera
            // 
            this.timerEspera.Interval = 5000;
            this.timerEspera.Tick += new System.EventHandler(this.timerEspera_Tick);
            // 
            // timerCerrar
            // 
            this.timerCerrar.Interval = 2;
            this.timerCerrar.Tick += new System.EventHandler(this.timerCerrar_Tick);
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.Transparent;
            this.pnlFondo.BackgroundImage = global::UPC.Trabajo.KBHit.External.recursos.usuarios;
            this.pnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlFondo.Controls.Add(this.lblTexto);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 18);
            this.pnlFondo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(209, 126);
            this.pnlFondo.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTexto.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(0, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(209, 126);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.MouseLeave += new System.EventHandler(this.lblTexto_MouseLeave);
            this.lblTexto.MouseHover += new System.EventHandler(this.lblTexto_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UPC.Trabajo.KBHit.External.recursos.barra;
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 18);
            this.panel2.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblTitulo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::UPC.Trabajo.KBHit.External.recursos.close1;
            this.btnCerrar.Location = new System.Drawing.Point(194, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(11, 11);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // frmNotificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 144);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNotificacion";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmNotificacion_Load);
            this.pnlFondo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerInicio;
        public System.Windows.Forms.Timer timerEspera;
        private System.Windows.Forms.Timer timerCerrar;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.Panel pnlFondo;
        public System.Windows.Forms.Label lblTitulo;
    }
}