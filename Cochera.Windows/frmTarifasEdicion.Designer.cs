namespace Cochera.Windows
{
    partial class frmTarifasEdicion
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
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mostradorDeErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostradorDeErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(43, 96);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(62, 19);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(35, 50);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(70, 19);
            this.lblTipoVehiculo.TabIndex = 1;
            this.lblTipoVehiculo.Text = "Vehiculo";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(43, 143);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(53, 19);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(144, 140);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(99, 27);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.Location = new System.Drawing.Point(118, 143);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(18, 19);
            this.lblPesos.TabIndex = 3;
            this.lblPesos.Text = "$";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(39, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 28);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(147, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(122, 93);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(121, 27);
            this.txtTiempo.TabIndex = 2;
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVehiculo.Location = new System.Drawing.Point(122, 47);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.Size = new System.Drawing.Size(124, 27);
            this.txtTipoVehiculo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 235);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(275, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 235);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 5);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 5);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTitulo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 31);
            this.panel5.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(77, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "EDITAR TARIFA";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 5);
            this.panel6.TabIndex = 11;
            // 
            // mostradorDeErrores
            // 
            this.mostradorDeErrores.ContainerControl = this;
            // 
            // frmTarifasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 235);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.txtTipoVehiculo);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTarifasEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostradorDeErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ErrorProvider mostradorDeErrores;
    }
}