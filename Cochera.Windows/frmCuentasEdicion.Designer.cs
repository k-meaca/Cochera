namespace Cochera.Windows
{
    partial class frmCuentasEdicion
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNumCuenta = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.mostradorDeErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMarcaTarjeta = new System.Windows.Forms.Label();
            this.cmboxMarcas = new System.Windows.Forms.ComboBox();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.cmboxTiposTarjetas = new System.Windows.Forms.ComboBox();
            this.lblNumTarjeta = new System.Windows.Forms.Label();
            this.txtNumTarjeta = new System.Windows.Forms.TextBox();
            this.lblCodSeguridad = new System.Windows.Forms.Label();
            this.txtCodSeguridad = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostradorDeErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(14, 111);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 393);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(489, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 393);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 5);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 5);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTitulo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(484, 34);
            this.panel5.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(170, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AGREGAR CLIENTE";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(484, 5);
            this.panel6.TabIndex = 6;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(18, 133);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(440, 27);
            this.txtCliente.TabIndex = 0;
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCuenta.Location = new System.Drawing.Point(14, 59);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(122, 19);
            this.lblNumCuenta.TabIndex = 0;
            this.lblNumCuenta.Text = "Num. de cuenta";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Enabled = false;
            this.txtNumCuenta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCuenta.Location = new System.Drawing.Point(18, 81);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(195, 27);
            this.txtNumCuenta.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(14, 163);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(95, 19);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(18, 185);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(440, 27);
            this.txtDescripcion.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(263, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(116, 353);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 28);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // mostradorDeErrores
            // 
            this.mostradorDeErrores.ContainerControl = this;
            // 
            // lblMarcaTarjeta
            // 
            this.lblMarcaTarjeta.AutoSize = true;
            this.lblMarcaTarjeta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaTarjeta.Location = new System.Drawing.Point(14, 221);
            this.lblMarcaTarjeta.Name = "lblMarcaTarjeta";
            this.lblMarcaTarjeta.Size = new System.Drawing.Size(128, 19);
            this.lblMarcaTarjeta.TabIndex = 0;
            this.lblMarcaTarjeta.Text = "Marca de tarjeta";
            // 
            // cmboxMarcas
            // 
            this.cmboxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxMarcas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxMarcas.FormattingEnabled = true;
            this.cmboxMarcas.Location = new System.Drawing.Point(18, 243);
            this.cmboxMarcas.Name = "cmboxMarcas";
            this.cmboxMarcas.Size = new System.Drawing.Size(194, 27);
            this.cmboxMarcas.TabIndex = 5;
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.AutoSize = true;
            this.lblMedioDePago.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedioDePago.Location = new System.Drawing.Point(260, 221);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(114, 19);
            this.lblMedioDePago.TabIndex = 0;
            this.lblMedioDePago.Text = "Medio de pago";
            // 
            // cmboxTiposTarjetas
            // 
            this.cmboxTiposTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTiposTarjetas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxTiposTarjetas.FormattingEnabled = true;
            this.cmboxTiposTarjetas.Location = new System.Drawing.Point(264, 243);
            this.cmboxTiposTarjetas.Name = "cmboxTiposTarjetas";
            this.cmboxTiposTarjetas.Size = new System.Drawing.Size(194, 27);
            this.cmboxTiposTarjetas.TabIndex = 6;
            // 
            // lblNumTarjeta
            // 
            this.lblNumTarjeta.AutoSize = true;
            this.lblNumTarjeta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTarjeta.Location = new System.Drawing.Point(15, 284);
            this.lblNumTarjeta.Name = "lblNumTarjeta";
            this.lblNumTarjeta.Size = new System.Drawing.Size(122, 19);
            this.lblNumTarjeta.TabIndex = 0;
            this.lblNumTarjeta.Text = "Numero Tarjeta";
            // 
            // txtNumTarjeta
            // 
            this.txtNumTarjeta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTarjeta.Location = new System.Drawing.Point(18, 306);
            this.txtNumTarjeta.MaxLength = 16;
            this.txtNumTarjeta.Name = "txtNumTarjeta";
            this.txtNumTarjeta.Size = new System.Drawing.Size(195, 27);
            this.txtNumTarjeta.TabIndex = 7;
            // 
            // lblCodSeguridad
            // 
            this.lblCodSeguridad.AutoSize = true;
            this.lblCodSeguridad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodSeguridad.Location = new System.Drawing.Point(260, 284);
            this.lblCodSeguridad.Name = "lblCodSeguridad";
            this.lblCodSeguridad.Size = new System.Drawing.Size(158, 19);
            this.lblCodSeguridad.TabIndex = 0;
            this.lblCodSeguridad.Text = "Codigo de seguridad";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSeguridad.Location = new System.Drawing.Point(264, 306);
            this.txtCodSeguridad.MaxLength = 3;
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(72, 27);
            this.txtCodSeguridad.TabIndex = 8;
            // 
            // frmCuentasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 393);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmboxTiposTarjetas);
            this.Controls.Add(this.cmboxMarcas);
            this.Controls.Add(this.txtCodSeguridad);
            this.Controls.Add(this.txtNumTarjeta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblMedioDePago);
            this.Controls.Add(this.lblMarcaTarjeta);
            this.Controls.Add(this.lblCodSeguridad);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.lblNumTarjeta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNumCuenta);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCuentasEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientesEdicion";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCuentasEdicion_FormClosing);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostradorDeErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNumCuenta;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ErrorProvider mostradorDeErrores;
        private System.Windows.Forms.ComboBox cmboxMarcas;
        private System.Windows.Forms.Label lblMarcaTarjeta;
        private System.Windows.Forms.ComboBox cmboxTiposTarjetas;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.TextBox txtNumTarjeta;
        private System.Windows.Forms.Label lblNumTarjeta;
        private System.Windows.Forms.TextBox txtCodSeguridad;
        private System.Windows.Forms.Label lblCodSeguridad;
    }
}