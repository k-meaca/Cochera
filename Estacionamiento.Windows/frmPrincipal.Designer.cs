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
            this.botonesMenu = new System.Windows.Forms.ToolStrip();
            this.btnClientesMenu = new System.Windows.Forms.ToolStripButton();
            this.btnCuentasCtesMenu = new System.Windows.Forms.ToolStripButton();
            this.btnTarifasMenu = new System.Windows.Forms.ToolStripButton();
            this.pnlDivision = new System.Windows.Forms.Panel();
            this.panelInfoSesion = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.pnlDivisorioV = new System.Windows.Forms.Panel();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.imgMinimizar = new System.Windows.Forms.PictureBox();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.botonesMenu.SuspendLayout();
            this.panelInfoSesion.SuspendLayout();
            this.pnlCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.botonesMenu);
            this.panelMenu.Controls.Add(this.pnlDivision);
            this.panelMenu.Controls.Add(this.panelInfoSesion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 552);
            this.panelMenu.TabIndex = 0;
            // 
            // botonesMenu
            // 
            this.botonesMenu.BackColor = System.Drawing.Color.Transparent;
            this.botonesMenu.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.botonesMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.botonesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientesMenu,
            this.btnCuentasCtesMenu,
            this.btnTarifasMenu});
            this.botonesMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.botonesMenu.Location = new System.Drawing.Point(0, 42);
            this.botonesMenu.Name = "botonesMenu";
            this.botonesMenu.Size = new System.Drawing.Size(189, 162);
            this.botonesMenu.TabIndex = 2;
            this.botonesMenu.Text = "toolStrip1";
            // 
            // btnClientesMenu
            // 
            this.btnClientesMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnClientesMenu.Image = global::Estacionamiento.Windows.Properties.Resources.ClientesMenu;
            this.btnClientesMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientesMenu.Name = "btnClientesMenu";
            this.btnClientesMenu.Size = new System.Drawing.Size(187, 44);
            this.btnClientesMenu.Text = "Clientes";
            this.btnClientesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientesMenu.CheckedChanged += new System.EventHandler(this.btnClientesMenu_CheckedChanged);
            this.btnClientesMenu.Click += new System.EventHandler(this.btnClientesMenu_Click);
            this.btnClientesMenu.MouseEnter += new System.EventHandler(this.btnClientesMenu_MouseEnter);
            this.btnClientesMenu.MouseLeave += new System.EventHandler(this.btnClientesMenu_MouseLeave);
            // 
            // btnCuentasCtesMenu
            // 
            this.btnCuentasCtesMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCuentasCtesMenu.Image = global::Estacionamiento.Windows.Properties.Resources.CuentasCorrientesMenu;
            this.btnCuentasCtesMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCuentasCtesMenu.Name = "btnCuentasCtesMenu";
            this.btnCuentasCtesMenu.Size = new System.Drawing.Size(187, 44);
            this.btnCuentasCtesMenu.Text = "Cuentas Ctes.";
            this.btnCuentasCtesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuentasCtesMenu.CheckedChanged += new System.EventHandler(this.btnCuentasCtesMenu_CheckedChanged);
            this.btnCuentasCtesMenu.Click += new System.EventHandler(this.btnCuentasCtesMenu_Click);
            this.btnCuentasCtesMenu.MouseEnter += new System.EventHandler(this.btnCuentasCtesMenu_MouseEnter);
            this.btnCuentasCtesMenu.MouseLeave += new System.EventHandler(this.btnCuentasCtesMenu_MouseLeave);
            // 
            // btnTarifasMenu
            // 
            this.btnTarifasMenu.Image = global::Estacionamiento.Windows.Properties.Resources.TarifasMenu;
            this.btnTarifasMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTarifasMenu.Name = "btnTarifasMenu";
            this.btnTarifasMenu.Size = new System.Drawing.Size(187, 44);
            this.btnTarifasMenu.Text = "Tarifas";
            this.btnTarifasMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarifasMenu.CheckedChanged += new System.EventHandler(this.btnTarifasMenu_CheckedChanged);
            this.btnTarifasMenu.Click += new System.EventHandler(this.btnTarifasMenu_Click);
            this.btnTarifasMenu.MouseEnter += new System.EventHandler(this.btnTarifasMenu_MouseEnter);
            this.btnTarifasMenu.MouseLeave += new System.EventHandler(this.btnTarifasMenu_MouseLeave);
            // 
            // pnlDivision
            // 
            this.pnlDivision.BackColor = System.Drawing.Color.Silver;
            this.pnlDivision.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivision.Location = new System.Drawing.Point(0, 39);
            this.pnlDivision.Name = "pnlDivision";
            this.pnlDivision.Size = new System.Drawing.Size(189, 3);
            this.pnlDivision.TabIndex = 1;
            // 
            // panelInfoSesion
            // 
            this.panelInfoSesion.Controls.Add(this.lblHora);
            this.panelInfoSesion.Controls.Add(this.lblFecha);
            this.panelInfoSesion.Controls.Add(this.lblUsuario);
            this.panelInfoSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoSesion.Location = new System.Drawing.Point(0, 0);
            this.panelInfoSesion.Name = "panelInfoSesion";
            this.panelInfoSesion.Size = new System.Drawing.Size(189, 39);
            this.panelInfoSesion.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(103, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 16);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // reloj
            // 
            this.reloj.Interval = 60000;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // pnlDivisorioV
            // 
            this.pnlDivisorioV.BackColor = System.Drawing.Color.Silver;
            this.pnlDivisorioV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDivisorioV.Location = new System.Drawing.Point(189, 0);
            this.pnlDivisorioV.Name = "pnlDivisorioV";
            this.pnlDivisorioV.Size = new System.Drawing.Size(3, 552);
            this.pnlDivisorioV.TabIndex = 1;
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.Controls.Add(this.imgMinimizar);
            this.pnlCerrar.Controls.Add(this.imgSalir);
            this.pnlCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCerrar.Location = new System.Drawing.Point(192, 0);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(818, 39);
            this.pnlCerrar.TabIndex = 7;
            // 
            // imgMinimizar
            // 
            this.imgMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.imgMinimizar.Image = global::Estacionamiento.Windows.Properties.Resources.minimizar;
            this.imgMinimizar.Location = new System.Drawing.Point(733, 11);
            this.imgMinimizar.Name = "imgMinimizar";
            this.imgMinimizar.Size = new System.Drawing.Size(38, 17);
            this.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMinimizar.TabIndex = 6;
            this.imgMinimizar.TabStop = false;
            this.imgMinimizar.Click += new System.EventHandler(this.imgMinimizar_Click);
            this.imgMinimizar.MouseEnter += new System.EventHandler(this.imgControl_MouseEnter);
            this.imgMinimizar.MouseLeave += new System.EventHandler(this.imgControl_MouseLeave);
            // 
            // imgSalir
            // 
            this.imgSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgSalir.BackColor = System.Drawing.Color.Transparent;
            this.imgSalir.Image = ((System.Drawing.Image)(resources.GetObject("imgSalir.Image")));
            this.imgSalir.Location = new System.Drawing.Point(777, 11);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(38, 17);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSalir.TabIndex = 6;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            this.imgSalir.MouseEnter += new System.EventHandler(this.imgControl_MouseEnter);
            this.imgSalir.MouseLeave += new System.EventHandler(this.imgControl_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(192, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 3);
            this.panel1.TabIndex = 8;
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormularios.Location = new System.Drawing.Point(192, 42);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(818, 510);
            this.pnlFormularios.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 552);
            this.ControlBox = false;
            this.Controls.Add(this.pnlFormularios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCerrar);
            this.Controls.Add(this.pnlDivisorioV);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cochera 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.botonesMenu.ResumeLayout(false);
            this.botonesMenu.PerformLayout();
            this.panelInfoSesion.ResumeLayout(false);
            this.panelInfoSesion.PerformLayout();
            this.pnlCerrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimizar)).EndInit();
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
        private System.Windows.Forms.Panel pnlDivisorioV;
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.Panel pnlDivision;
        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgMinimizar;
        private System.Windows.Forms.ToolStrip botonesMenu;
        private System.Windows.Forms.ToolStripButton btnClientesMenu;
        private System.Windows.Forms.ToolStripButton btnCuentasCtesMenu;
        private System.Windows.Forms.ToolStripButton btnTarifasMenu;
        private System.Windows.Forms.Panel pnlFormularios;
    }
}