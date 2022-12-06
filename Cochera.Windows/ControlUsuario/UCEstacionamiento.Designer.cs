namespace Cochera.Windows
{
    partial class UCEstacionamiento
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBoton = new System.Windows.Forms.Panel();
            this.btnDesocupar = new System.Windows.Forms.Button();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.imgVehiculo = new System.Windows.Forms.PictureBox();
            this.pnlPatente = new System.Windows.Forms.Panel();
            this.lblPatente = new System.Windows.Forms.Label();
            this.pnlBoton.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVehiculo)).BeginInit();
            this.pnlPatente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoton
            // 
            this.pnlBoton.Controls.Add(this.btnDesocupar);
            this.pnlBoton.Controls.Add(this.btnEstacionar);
            this.pnlBoton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBoton.Location = new System.Drawing.Point(0, 207);
            this.pnlBoton.Name = "pnlBoton";
            this.pnlBoton.Size = new System.Drawing.Size(168, 37);
            this.pnlBoton.TabIndex = 0;
            // 
            // btnDesocupar
            // 
            this.btnDesocupar.BackColor = System.Drawing.Color.Salmon;
            this.btnDesocupar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesocupar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesocupar.Location = new System.Drawing.Point(33, 3);
            this.btnDesocupar.Name = "btnDesocupar";
            this.btnDesocupar.Size = new System.Drawing.Size(102, 29);
            this.btnDesocupar.TabIndex = 1;
            this.btnDesocupar.Text = "Desocupar";
            this.btnDesocupar.UseVisualStyleBackColor = false;
            this.btnDesocupar.Click += new System.EventHandler(this.btnDesocupar_Click);
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEstacionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstacionar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionar.Location = new System.Drawing.Point(33, 4);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(102, 28);
            this.btnEstacionar.TabIndex = 0;
            this.btnEstacionar.Text = "Estacionar";
            this.btnEstacionar.UseVisualStyleBackColor = false;
            this.btnEstacionar.Click += new System.EventHandler(this.btnEstacionar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 207);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(141, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 207);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.lblUbicacion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(27, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 27);
            this.panel4.TabIndex = 3;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(34, 4);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(46, 19);
            this.lblUbicacion.TabIndex = 0;
            this.lblUbicacion.Text = "PB35";
            // 
            // pnlImagen
            // 
            this.pnlImagen.Controls.Add(this.imgVehiculo);
            this.pnlImagen.Location = new System.Drawing.Point(33, 33);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(102, 139);
            this.pnlImagen.TabIndex = 4;
            // 
            // imgVehiculo
            // 
            this.imgVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgVehiculo.Location = new System.Drawing.Point(0, 0);
            this.imgVehiculo.Name = "imgVehiculo";
            this.imgVehiculo.Size = new System.Drawing.Size(102, 139);
            this.imgVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVehiculo.TabIndex = 0;
            this.imgVehiculo.TabStop = false;
            this.imgVehiculo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imgVehiculo_MouseDoubleClick);
            // 
            // pnlPatente
            // 
            this.pnlPatente.BackColor = System.Drawing.Color.Black;
            this.pnlPatente.Controls.Add(this.lblPatente);
            this.pnlPatente.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPatente.ForeColor = System.Drawing.Color.White;
            this.pnlPatente.Location = new System.Drawing.Point(33, 178);
            this.pnlPatente.Name = "pnlPatente";
            this.pnlPatente.Size = new System.Drawing.Size(102, 24);
            this.pnlPatente.TabIndex = 5;
            this.pnlPatente.Visible = false;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(22, 3);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(58, 18);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "POO001";
            // 
            // UCEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPatente);
            this.Controls.Add(this.pnlImagen);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBoton);
            this.Name = "UCEstacionamiento";
            this.Size = new System.Drawing.Size(168, 244);
            this.pnlBoton.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVehiculo)).EndInit();
            this.pnlPatente.ResumeLayout(false);
            this.pnlPatente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEstacionar;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.PictureBox imgVehiculo;
        private System.Windows.Forms.Button btnDesocupar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Panel pnlPatente;
        private System.Windows.Forms.Label lblPatente;
    }
}
