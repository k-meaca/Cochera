namespace Estacionamiento.Windows
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInfoSesion = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.panelCerrar = new System.Windows.Forms.Panel();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelInfoSesion.SuspendLayout();
            this.panelCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelInfoSesion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 552);
            this.panelMenu.TabIndex = 0;
            // 
            // panelInfoSesion
            // 
            this.panelInfoSesion.Controls.Add(this.lblHora);
            this.panelInfoSesion.Controls.Add(this.lblFecha);
            this.panelInfoSesion.Controls.Add(this.lblUsuario);
            this.panelInfoSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoSesion.Location = new System.Drawing.Point(0, 0);
            this.panelInfoSesion.Name = "panelInfoSesion";
            this.panelInfoSesion.Size = new System.Drawing.Size(236, 95);
            this.panelInfoSesion.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 57);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora";
            // 
            // reloj
            // 
            this.reloj.Interval = 60000;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // panelCerrar
            // 
            this.panelCerrar.Controls.Add(this.imgSalir);
            this.panelCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCerrar.Location = new System.Drawing.Point(236, 0);
            this.panelCerrar.Name = "panelCerrar";
            this.panelCerrar.Size = new System.Drawing.Size(774, 22);
            this.panelCerrar.TabIndex = 1;
            // 
            // imgSalir
            // 
            this.imgSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgSalir.BackColor = System.Drawing.Color.Transparent;
            this.imgSalir.Image = ((System.Drawing.Image)(resources.GetObject("imgSalir.Image")));
            this.imgSalir.Location = new System.Drawing.Point(754, 3);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(17, 16);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSalir.TabIndex = 6;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            this.imgSalir.MouseEnter += new System.EventHandler(this.imgSalir_MouseEnter);
            this.imgSalir.MouseLeave += new System.EventHandler(this.imgSalir_MouseLeave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 552);
            this.ControlBox = false;
            this.Controls.Add(this.panelCerrar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cochera 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelInfoSesion.ResumeLayout(false);
            this.panelInfoSesion.PerformLayout();
            this.panelCerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelInfoSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.Panel panelCerrar;
        private System.Windows.Forms.PictureBox imgSalir;
    }
}