namespace Cochera.Windows
{
    partial class frmEstacionamientoTodos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnDesocupar = new System.Windows.Forms.Button();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.lblCantLibresD = new System.Windows.Forms.Label();
            this.lblCantLibresC = new System.Windows.Forms.Label();
            this.lblTotalLugares = new System.Windows.Forms.Label();
            this.lblEstacionamientosLibres = new System.Windows.Forms.Label();
            this.lblLibresD = new System.Windows.Forms.Label();
            this.lblLibresC = new System.Windows.Forms.Label();
            this.lblCantTotal = new System.Windows.Forms.Label();
            this.lblCantLibresB = new System.Windows.Forms.Label();
            this.lblCantLibresTotales = new System.Windows.Forms.Label();
            this.lblCantLibresA = new System.Windows.Forms.Label();
            this.lblLibresB = new System.Windows.Forms.Label();
            this.lblLibresPB = new System.Windows.Forms.Label();
            this.lblCantLibresPB = new System.Windows.Forms.Label();
            this.lblLibresA = new System.Windows.Forms.Label();
            this.datosEstacionamientos = new System.Windows.Forms.DataGridView();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOcupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLibresEn = new System.Windows.Forms.Label();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosEstacionamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnDesocupar);
            this.panelBotones.Controls.Add(this.btnEstacionar);
            this.panelBotones.Controls.Add(this.lblCantLibresD);
            this.panelBotones.Controls.Add(this.lblCantLibresC);
            this.panelBotones.Controls.Add(this.lblTotalLugares);
            this.panelBotones.Controls.Add(this.lblEstacionamientosLibres);
            this.panelBotones.Controls.Add(this.lblLibresD);
            this.panelBotones.Controls.Add(this.lblLibresC);
            this.panelBotones.Controls.Add(this.lblCantTotal);
            this.panelBotones.Controls.Add(this.lblCantLibresB);
            this.panelBotones.Controls.Add(this.lblCantLibresTotales);
            this.panelBotones.Controls.Add(this.lblCantLibresA);
            this.panelBotones.Controls.Add(this.lblLibresB);
            this.panelBotones.Controls.Add(this.lblLibresEn);
            this.panelBotones.Controls.Add(this.lblLibresPB);
            this.panelBotones.Controls.Add(this.lblCantLibresPB);
            this.panelBotones.Controls.Add(this.lblLibresA);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(631, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(169, 450);
            this.panelBotones.TabIndex = 1;
            // 
            // btnDesocupar
            // 
            this.btnDesocupar.BackColor = System.Drawing.Color.Salmon;
            this.btnDesocupar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesocupar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesocupar.Location = new System.Drawing.Point(11, 57);
            this.btnDesocupar.Name = "btnDesocupar";
            this.btnDesocupar.Size = new System.Drawing.Size(150, 46);
            this.btnDesocupar.TabIndex = 3;
            this.btnDesocupar.Text = "Desocupar";
            this.btnDesocupar.UseVisualStyleBackColor = false;
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEstacionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstacionar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionar.Location = new System.Drawing.Point(11, 6);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(150, 45);
            this.btnEstacionar.TabIndex = 2;
            this.btnEstacionar.Text = "Estacionar";
            this.btnEstacionar.UseVisualStyleBackColor = false;
            // 
            // lblCantLibresD
            // 
            this.lblCantLibresD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantLibresD.AutoSize = true;
            this.lblCantLibresD.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLibresD.Location = new System.Drawing.Point(121, 428);
            this.lblCantLibresD.Name = "lblCantLibresD";
            this.lblCantLibresD.Size = new System.Drawing.Size(29, 19);
            this.lblCantLibresD.TabIndex = 0;
            this.lblCantLibresD.Text = "##";
            // 
            // lblCantLibresC
            // 
            this.lblCantLibresC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantLibresC.AutoSize = true;
            this.lblCantLibresC.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLibresC.Location = new System.Drawing.Point(121, 393);
            this.lblCantLibresC.Name = "lblCantLibresC";
            this.lblCantLibresC.Size = new System.Drawing.Size(29, 19);
            this.lblCantLibresC.TabIndex = 0;
            this.lblCantLibresC.Text = "##";
            // 
            // lblTotalLugares
            // 
            this.lblTotalLugares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalLugares.AutoSize = true;
            this.lblTotalLugares.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLugares.Location = new System.Drawing.Point(16, 201);
            this.lblTotalLugares.Name = "lblTotalLugares";
            this.lblTotalLugares.Size = new System.Drawing.Size(114, 19);
            this.lblTotalLugares.TabIndex = 0;
            this.lblTotalLugares.Text = "Lugares total: ";
            // 
            // lblEstacionamientosLibres
            // 
            this.lblEstacionamientosLibres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstacionamientosLibres.AutoSize = true;
            this.lblEstacionamientosLibres.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacionamientosLibres.Location = new System.Drawing.Point(7, 234);
            this.lblEstacionamientosLibres.Name = "lblEstacionamientosLibres";
            this.lblEstacionamientosLibres.Size = new System.Drawing.Size(123, 19);
            this.lblEstacionamientosLibres.TabIndex = 0;
            this.lblEstacionamientosLibres.Text = "Lugares libres: ";
            // 
            // lblLibresD
            // 
            this.lblLibresD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibresD.AutoSize = true;
            this.lblLibresD.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresD.Location = new System.Drawing.Point(24, 428);
            this.lblLibresD.Name = "lblLibresD";
            this.lblLibresD.Size = new System.Drawing.Size(96, 19);
            this.lblLibresD.TabIndex = 0;
            this.lblLibresD.Text = "Subsuelo D:";
            // 
            // lblLibresC
            // 
            this.lblLibresC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibresC.AutoSize = true;
            this.lblLibresC.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresC.Location = new System.Drawing.Point(24, 393);
            this.lblLibresC.Name = "lblLibresC";
            this.lblLibresC.Size = new System.Drawing.Size(95, 19);
            this.lblLibresC.TabIndex = 0;
            this.lblLibresC.Text = "Subsuelo C:";
            // 
            // lblCantTotal
            // 
            this.lblCantTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantTotal.AutoSize = true;
            this.lblCantTotal.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotal.Location = new System.Drawing.Point(132, 201);
            this.lblCantTotal.Name = "lblCantTotal";
            this.lblCantTotal.Size = new System.Drawing.Size(29, 19);
            this.lblCantTotal.TabIndex = 0;
            this.lblCantTotal.Text = "##";
            // 
            // lblCantLibresB
            // 
            this.lblCantLibresB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantLibresB.AutoSize = true;
            this.lblCantLibresB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLibresB.Location = new System.Drawing.Point(121, 358);
            this.lblCantLibresB.Name = "lblCantLibresB";
            this.lblCantLibresB.Size = new System.Drawing.Size(29, 19);
            this.lblCantLibresB.TabIndex = 0;
            this.lblCantLibresB.Text = "##";
            // 
            // lblCantLibresTotales
            // 
            this.lblCantLibresTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantLibresTotales.AutoSize = true;
            this.lblCantLibresTotales.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLibresTotales.Location = new System.Drawing.Point(132, 234);
            this.lblCantLibresTotales.Name = "lblCantLibresTotales";
            this.lblCantLibresTotales.Size = new System.Drawing.Size(29, 19);
            this.lblCantLibresTotales.TabIndex = 0;
            this.lblCantLibresTotales.Text = "##";
            // 
            // lblCantLibresA
            // 
            this.lblCantLibresA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantLibresA.AutoSize = true;
            this.lblCantLibresA.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLibresA.Location = new System.Drawing.Point(121, 324);
            this.lblCantLibresA.Name = "lblCantLibresA";
            this.lblCantLibresA.Size = new System.Drawing.Size(29, 19);
            this.lblCantLibresA.TabIndex = 0;
            this.lblCantLibresA.Text = "##";
            // 
            // lblLibresB
            // 
            this.lblLibresB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibresB.AutoSize = true;
            this.lblLibresB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresB.Location = new System.Drawing.Point(20, 358);
            this.lblLibresB.Name = "lblLibresB";
            this.lblLibresB.Size = new System.Drawing.Size(95, 19);
            this.lblLibresB.TabIndex = 0;
            this.lblLibresB.Text = "Subsuelo B:";
            // 
            // lblLibresPB
            // 
            this.lblLibresPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibresPB.AutoSize = true;
            this.lblLibresPB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresPB.Location = new System.Drawing.Point(19, 292);
            this.lblLibresPB.Name = "lblLibresPB";
            this.lblLibresPB.Size = new System.Drawing.Size(96, 19);
            this.lblLibresPB.TabIndex = 0;
            this.lblLibresPB.Text = "Planta Baja:";
            // 
            // lblCantLibresPB
            // 
            this.lblCantLibresPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantLibresPB.AutoSize = true;
            this.lblCantLibresPB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLibresPB.Location = new System.Drawing.Point(121, 292);
            this.lblCantLibresPB.Name = "lblCantLibresPB";
            this.lblCantLibresPB.Size = new System.Drawing.Size(29, 19);
            this.lblCantLibresPB.TabIndex = 0;
            this.lblCantLibresPB.Text = "##";
            // 
            // lblLibresA
            // 
            this.lblLibresA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibresA.AutoSize = true;
            this.lblLibresA.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresA.Location = new System.Drawing.Point(20, 324);
            this.lblLibresA.Name = "lblLibresA";
            this.lblLibresA.Size = new System.Drawing.Size(99, 19);
            this.lblLibresA.TabIndex = 0;
            this.lblLibresA.Text = "Subsuelo A: ";
            // 
            // datosEstacionamientos
            // 
            this.datosEstacionamientos.AllowUserToAddRows = false;
            this.datosEstacionamientos.AllowUserToDeleteRows = false;
            this.datosEstacionamientos.AllowUserToResizeColumns = false;
            this.datosEstacionamientos.AllowUserToResizeRows = false;
            this.datosEstacionamientos.BackgroundColor = System.Drawing.Color.White;
            this.datosEstacionamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosEstacionamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSector,
            this.colUbicacion,
            this.colOcupado});
            this.datosEstacionamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosEstacionamientos.GridColor = System.Drawing.Color.Silver;
            this.datosEstacionamientos.Location = new System.Drawing.Point(0, 0);
            this.datosEstacionamientos.Name = "datosEstacionamientos";
            this.datosEstacionamientos.ReadOnly = true;
            this.datosEstacionamientos.RowHeadersVisible = false;
            this.datosEstacionamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosEstacionamientos.Size = new System.Drawing.Size(631, 450);
            this.datosEstacionamientos.TabIndex = 2;
            // 
            // colSector
            // 
            this.colSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSector.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSector.HeaderText = "Sector";
            this.colSector.Name = "colSector";
            this.colSector.ReadOnly = true;
            // 
            // colUbicacion
            // 
            this.colUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUbicacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUbicacion.HeaderText = "Ubicacion";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;
            this.colUbicacion.Width = 80;
            // 
            // colOcupado
            // 
            this.colOcupado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOcupado.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOcupado.HeaderText = "Ocupado";
            this.colOcupado.Name = "colOcupado";
            this.colOcupado.ReadOnly = true;
            this.colOcupado.Width = 76;
            // 
            // lblLibresEn
            // 
            this.lblLibresEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibresEn.AutoSize = true;
            this.lblLibresEn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresEn.Location = new System.Drawing.Point(41, 262);
            this.lblLibresEn.Name = "lblLibresEn";
            this.lblLibresEn.Size = new System.Drawing.Size(87, 19);
            this.lblLibresEn.TabIndex = 0;
            this.lblLibresEn.Text = "LIBRES EN";
            // 
            // frmEstacionamientoTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datosEstacionamientos);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstacionamientoTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstacionamientoTodos";
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosEstacionamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnDesocupar;
        private System.Windows.Forms.Button btnEstacionar;
        private System.Windows.Forms.Label lblCantLibresD;
        private System.Windows.Forms.Label lblCantLibresC;
        private System.Windows.Forms.Label lblTotalLugares;
        private System.Windows.Forms.Label lblEstacionamientosLibres;
        private System.Windows.Forms.Label lblLibresD;
        private System.Windows.Forms.Label lblLibresC;
        private System.Windows.Forms.Label lblCantTotal;
        private System.Windows.Forms.Label lblCantLibresB;
        private System.Windows.Forms.Label lblCantLibresTotales;
        private System.Windows.Forms.Label lblCantLibresA;
        private System.Windows.Forms.Label lblLibresB;
        private System.Windows.Forms.Label lblLibresPB;
        private System.Windows.Forms.Label lblCantLibresPB;
        private System.Windows.Forms.Label lblLibresA;
        private System.Windows.Forms.DataGridView datosEstacionamientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOcupado;
        private System.Windows.Forms.Label lblLibresEn;
    }
}