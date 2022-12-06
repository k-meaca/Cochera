namespace Cochera.Windows
{
    partial class frmIngresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.imgBuscarPatente = new System.Windows.Forms.PictureBox();
            this.txtBuscarPatente = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.lblBuscarPatente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.datosIngresos = new System.Windows.Forms.DataGridView();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.imgBuscarPatente);
            this.pnlMenu.Controls.Add(this.txtBuscarPatente);
            this.pnlMenu.Controls.Add(this.btnFiltrarPorFecha);
            this.pnlMenu.Controls.Add(this.lblBuscarPatente);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblFechaInicio);
            this.pnlMenu.Controls.Add(this.fechaFinal);
            this.pnlMenu.Controls.Add(this.fechaInicio);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 65);
            this.pnlMenu.TabIndex = 0;
            // 
            // imgBuscarPatente
            // 
            this.imgBuscarPatente.Image = global::Cochera.Windows.Properties.Resources.lupa;
            this.imgBuscarPatente.Location = new System.Drawing.Point(500, 29);
            this.imgBuscarPatente.Name = "imgBuscarPatente";
            this.imgBuscarPatente.Size = new System.Drawing.Size(27, 26);
            this.imgBuscarPatente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBuscarPatente.TabIndex = 4;
            this.imgBuscarPatente.TabStop = false;
            // 
            // txtBuscarPatente
            // 
            this.txtBuscarPatente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPatente.Location = new System.Drawing.Point(332, 29);
            this.txtBuscarPatente.MaxLength = 8;
            this.txtBuscarPatente.Name = "txtBuscarPatente";
            this.txtBuscarPatente.Size = new System.Drawing.Size(162, 26);
            this.txtBuscarPatente.TabIndex = 3;
            this.txtBuscarPatente.TextChanged += new System.EventHandler(this.txtBuscarPatente_TextChanged);
            this.txtBuscarPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPatente_KeyPress);
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnFiltrarPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorFecha.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(200, 7);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(112, 48);
            this.btnFiltrarPorFecha.TabIndex = 2;
            this.btnFiltrarPorFecha.Text = "FILTRAR POR FECHA";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarPorFecha.Click += new System.EventHandler(this.btnFiltrarPorFecha_Click);
            // 
            // lblBuscarPatente
            // 
            this.lblBuscarPatente.AutoSize = true;
            this.lblBuscarPatente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPatente.Location = new System.Drawing.Point(329, 7);
            this.lblBuscarPatente.Name = "lblBuscarPatente";
            this.lblBuscarPatente.Size = new System.Drawing.Size(110, 18);
            this.lblBuscarPatente.TabIndex = 1;
            this.lblBuscarPatente.Text = "Buscar Patente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 9);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 18);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // fechaFinal
            // 
            this.fechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinal.Location = new System.Drawing.Point(104, 35);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(80, 20);
            this.fechaFinal.TabIndex = 0;
            this.fechaFinal.ValueChanged += new System.EventHandler(this.fechaFinal_ValueChanged);
            // 
            // fechaInicio
            // 
            this.fechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(104, 9);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(80, 20);
            this.fechaInicio.TabIndex = 0;
            this.fechaInicio.ValueChanged += new System.EventHandler(this.fechaInicio_ValueChanged);
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.Black;
            this.pnlDivisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivisor.Location = new System.Drawing.Point(0, 65);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(800, 4);
            this.pnlDivisor.TabIndex = 1;
            // 
            // datosIngresos
            // 
            this.datosIngresos.AllowUserToAddRows = false;
            this.datosIngresos.AllowUserToDeleteRows = false;
            this.datosIngresos.AllowUserToResizeColumns = false;
            this.datosIngresos.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.datosIngresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.datosIngresos.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.datosIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatente,
            this.colVehiculo,
            this.colIngreso,
            this.colHoraIngreso,
            this.colEstacionamiento,
            this.colSector});
            this.datosIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosIngresos.Location = new System.Drawing.Point(0, 69);
            this.datosIngresos.MultiSelect = false;
            this.datosIngresos.Name = "datosIngresos";
            this.datosIngresos.ReadOnly = true;
            this.datosIngresos.RowHeadersVisible = false;
            this.datosIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosIngresos.Size = new System.Drawing.Size(800, 381);
            this.datosIngresos.TabIndex = 2;
            // 
            // colPatente
            // 
            this.colPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colPatente.DefaultCellStyle = dataGridViewCellStyle11;
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            this.colPatente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colVehiculo
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colVehiculo.DefaultCellStyle = dataGridViewCellStyle12;
            this.colVehiculo.HeaderText = "Vehiculo";
            this.colVehiculo.Name = "colVehiculo";
            this.colVehiculo.ReadOnly = true;
            this.colVehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVehiculo.Width = 150;
            // 
            // colIngreso
            // 
            this.colIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colIngreso.DefaultCellStyle = dataGridViewCellStyle13;
            this.colIngreso.HeaderText = "Fecha ingreso";
            this.colIngreso.Name = "colIngreso";
            this.colIngreso.ReadOnly = true;
            this.colIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIngreso.Width = 94;
            // 
            // colHoraIngreso
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colHoraIngreso.DefaultCellStyle = dataGridViewCellStyle14;
            this.colHoraIngreso.HeaderText = "Hora ingreso";
            this.colHoraIngreso.Name = "colHoraIngreso";
            this.colHoraIngreso.ReadOnly = true;
            this.colHoraIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHoraIngreso.Width = 120;
            // 
            // colEstacionamiento
            // 
            this.colEstacionamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colEstacionamiento.DefaultCellStyle = dataGridViewCellStyle15;
            this.colEstacionamiento.HeaderText = "Estacionamiento";
            this.colEstacionamiento.Name = "colEstacionamiento";
            this.colEstacionamiento.ReadOnly = true;
            this.colEstacionamiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEstacionamiento.Width = 108;
            // 
            // colSector
            // 
            this.colSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colSector.DefaultCellStyle = dataGridViewCellStyle16;
            this.colSector.HeaderText = "Sector";
            this.colSector.Name = "colSector";
            this.colSector.ReadOnly = true;
            this.colSector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSector.Width = 51;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datosIngresos);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresos";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosIngresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.DataGridView datosIngresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.PictureBox imgBuscarPatente;
        private System.Windows.Forms.TextBox txtBuscarPatente;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
        private System.Windows.Forms.Label lblBuscarPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.DateTimePicker fechaInicio;
    }
}