namespace Cochera.Windows
{
    partial class frmLogin
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblErrorUsuario = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.DimGray;
            this.pnlSeparador.Location = new System.Drawing.Point(243, 12);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(3, 262);
            this.pnlSeparador.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(26, 31);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(202, 225);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(282, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 25);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(282, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(287, 65);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(248, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(287, 155);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(248, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // imgPassword
            // 
            this.imgPassword.Image = ((System.Drawing.Image)(resources.GetObject("imgPassword.Image")));
            this.imgPassword.Location = new System.Drawing.Point(541, 155);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(29, 27);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPassword.TabIndex = 4;
            this.imgPassword.TabStop = false;
            this.imgPassword.Click += new System.EventHandler(this.imgPassword_Click);
            // 
            // imgSalir
            // 
            this.imgSalir.BackColor = System.Drawing.Color.Transparent;
            this.imgSalir.Image = ((System.Drawing.Image)(resources.GetObject("imgSalir.Image")));
            this.imgSalir.Location = new System.Drawing.Point(579, 3);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(17, 16);
            this.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSalir.TabIndex = 5;
            this.imgSalir.TabStop = false;
            this.imgSalir.Click += new System.EventHandler(this.imgSalir_Click);
            this.imgSalir.MouseEnter += new System.EventHandler(this.imgSalir_MouseEnter);
            this.imgSalir.MouseLeave += new System.EventHandler(this.imgSalir_MouseLeave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(287, 221);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(283, 35);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblErrorUsuario
            // 
            this.lblErrorUsuario.AutoSize = true;
            this.lblErrorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsuario.Location = new System.Drawing.Point(284, 95);
            this.lblErrorUsuario.Name = "lblErrorUsuario";
            this.lblErrorUsuario.Size = new System.Drawing.Size(77, 13);
            this.lblErrorUsuario.TabIndex = 6;
            this.lblErrorUsuario.Text = "ErrorUsuario";
            this.lblErrorUsuario.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(284, 185);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(88, 13);
            this.lblErrorPassword.TabIndex = 7;
            this.lblErrorPassword.Text = "ErrorPassword";
            this.lblErrorPassword.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 286);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.pnlSeparador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cocheria 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox imgPassword;
        private System.Windows.Forms.PictureBox imgSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblErrorUsuario;
        private System.Windows.Forms.Label lblErrorPassword;
    }
}

