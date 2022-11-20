﻿namespace Cochera.Windows
{
    partial class frmSalidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.imgBuscarPatente = new System.Windows.Forms.PictureBox();
            this.txtBuscarPatente = new System.Windows.Forms.TextBox();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.lblBuscarPatente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.pnlInfoSalidas = new System.Windows.Forms.Panel();
            this.pnlDivisorBottom = new System.Windows.Forms.Panel();
            this.datosSalidas = new System.Windows.Forms.DataGridView();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecaudado = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarPatente)).BeginInit();
            this.pnlInfoSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosSalidas)).BeginInit();
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
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.Black;
            this.pnlDivisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivisor.Location = new System.Drawing.Point(0, 65);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(800, 4);
            this.pnlDivisor.TabIndex = 1;
            // 
            // imgBuscarPatente
            // 
            this.imgBuscarPatente.Image = global::Cochera.Windows.Properties.Resources.lupa;
            this.imgBuscarPatente.Location = new System.Drawing.Point(745, 30);
            this.imgBuscarPatente.Name = "imgBuscarPatente";
            this.imgBuscarPatente.Size = new System.Drawing.Size(27, 26);
            this.imgBuscarPatente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBuscarPatente.TabIndex = 12;
            this.imgBuscarPatente.TabStop = false;
            // 
            // txtBuscarPatente
            // 
            this.txtBuscarPatente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPatente.Location = new System.Drawing.Point(331, 30);
            this.txtBuscarPatente.Name = "txtBuscarPatente";
            this.txtBuscarPatente.Size = new System.Drawing.Size(408, 26);
            this.txtBuscarPatente.TabIndex = 11;
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnFiltrarPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorFecha.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(199, 8);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(112, 48);
            this.btnFiltrarPorFecha.TabIndex = 10;
            this.btnFiltrarPorFecha.Text = "FILTRAR POR FECHA";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarPorFecha.Click += new System.EventHandler(this.btnFiltrarPorFecha_Click);
            // 
            // lblBuscarPatente
            // 
            this.lblBuscarPatente.AutoSize = true;
            this.lblBuscarPatente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPatente.Location = new System.Drawing.Point(328, 8);
            this.lblBuscarPatente.Name = "lblBuscarPatente";
            this.lblBuscarPatente.Size = new System.Drawing.Size(110, 18);
            this.lblBuscarPatente.TabIndex = 7;
            this.lblBuscarPatente.Text = "Buscar Patente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(11, 10);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 18);
            this.lblFechaInicio.TabIndex = 9;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // fechaFinal
            // 
            this.fechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinal.Location = new System.Drawing.Point(103, 36);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(80, 20);
            this.fechaFinal.TabIndex = 5;
            // 
            // fechaInicio
            // 
            this.fechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(103, 10);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(80, 20);
            this.fechaInicio.TabIndex = 6;
            // 
            // pnlInfoSalidas
            // 
            this.pnlInfoSalidas.Controls.Add(this.lblMontoTotal);
            this.pnlInfoSalidas.Controls.Add(this.lblRecaudado);
            this.pnlInfoSalidas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfoSalidas.Location = new System.Drawing.Point(0, 423);
            this.pnlInfoSalidas.Name = "pnlInfoSalidas";
            this.pnlInfoSalidas.Size = new System.Drawing.Size(800, 27);
            this.pnlInfoSalidas.TabIndex = 2;
            // 
            // pnlDivisorBottom
            // 
            this.pnlDivisorBottom.BackColor = System.Drawing.Color.Black;
            this.pnlDivisorBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDivisorBottom.Location = new System.Drawing.Point(0, 420);
            this.pnlDivisorBottom.Name = "pnlDivisorBottom";
            this.pnlDivisorBottom.Size = new System.Drawing.Size(800, 3);
            this.pnlDivisorBottom.TabIndex = 3;
            // 
            // datosSalidas
            // 
            this.datosSalidas.AllowUserToAddRows = false;
            this.datosSalidas.AllowUserToDeleteRows = false;
            this.datosSalidas.AllowUserToResizeColumns = false;
            this.datosSalidas.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.datosSalidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.datosSalidas.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.datosSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatente,
            this.colVehiculo,
            this.colFechaIngreso,
            this.colHoraIngreso,
            this.colFechaSalida,
            this.colHoraSalida,
            this.colEstacionamiento,
            this.colSector,
            this.colMontoTotal});
            this.datosSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosSalidas.Location = new System.Drawing.Point(0, 69);
            this.datosSalidas.MultiSelect = false;
            this.datosSalidas.Name = "datosSalidas";
            this.datosSalidas.ReadOnly = true;
            this.datosSalidas.RowHeadersVisible = false;
            this.datosSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosSalidas.Size = new System.Drawing.Size(800, 351);
            this.datosSalidas.TabIndex = 4;
            // 
            // colPatente
            // 
            this.colPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colPatente.DefaultCellStyle = dataGridViewCellStyle14;
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            this.colPatente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colVehiculo
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colVehiculo.DefaultCellStyle = dataGridViewCellStyle15;
            this.colVehiculo.HeaderText = "Vehiculo";
            this.colVehiculo.Name = "colVehiculo";
            this.colVehiculo.ReadOnly = true;
            this.colVehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVehiculo.Width = 150;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colFechaIngreso.DefaultCellStyle = dataGridViewCellStyle16;
            this.colFechaIngreso.HeaderText = "Fecha ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.ReadOnly = true;
            this.colFechaIngreso.Width = 113;
            // 
            // colHoraIngreso
            // 
            this.colHoraIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colHoraIngreso.DefaultCellStyle = dataGridViewCellStyle17;
            this.colHoraIngreso.HeaderText = "Hora ingreso";
            this.colHoraIngreso.Name = "colHoraIngreso";
            this.colHoraIngreso.ReadOnly = true;
            this.colHoraIngreso.Width = 108;
            // 
            // colFechaSalida
            // 
            this.colFechaSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colFechaSalida.DefaultCellStyle = dataGridViewCellStyle18;
            this.colFechaSalida.HeaderText = "Fecha salida";
            this.colFechaSalida.Name = "colFechaSalida";
            this.colFechaSalida.ReadOnly = true;
            this.colFechaSalida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFechaSalida.Width = 85;
            // 
            // colHoraSalida
            // 
            this.colHoraSalida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colHoraSalida.DefaultCellStyle = dataGridViewCellStyle19;
            this.colHoraSalida.HeaderText = "Hora salida";
            this.colHoraSalida.Name = "colHoraSalida";
            this.colHoraSalida.ReadOnly = true;
            this.colHoraSalida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHoraSalida.Width = 80;
            // 
            // colEstacionamiento
            // 
            this.colEstacionamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colEstacionamiento.DefaultCellStyle = dataGridViewCellStyle20;
            this.colEstacionamiento.HeaderText = "Estacionamiento";
            this.colEstacionamiento.Name = "colEstacionamiento";
            this.colEstacionamiento.ReadOnly = true;
            this.colEstacionamiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEstacionamiento.Width = 108;
            // 
            // colSector
            // 
            this.colSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colSector.DefaultCellStyle = dataGridViewCellStyle21;
            this.colSector.HeaderText = "Sector";
            this.colSector.Name = "colSector";
            this.colSector.ReadOnly = true;
            this.colSector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSector.Width = 51;
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colMontoTotal.DefaultCellStyle = dataGridViewCellStyle22;
            this.colMontoTotal.HeaderText = "Monto total";
            this.colMontoTotal.Name = "colMontoTotal";
            this.colMontoTotal.ReadOnly = true;
            this.colMontoTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMontoTotal.Width = 77;
            // 
            // lblRecaudado
            // 
            this.lblRecaudado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecaudado.AutoSize = true;
            this.lblRecaudado.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudado.Location = new System.Drawing.Point(600, 4);
            this.lblRecaudado.Name = "lblRecaudado";
            this.lblRecaudado.Size = new System.Drawing.Size(88, 18);
            this.lblRecaudado.TabIndex = 0;
            this.lblRecaudado.Text = "Recaudado :";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(694, 4);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(26, 18);
            this.lblMontoTotal.TabIndex = 0;
            this.lblMontoTotal.Text = "$$";
            // 
            // frmSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datosSalidas);
            this.Controls.Add(this.pnlDivisorBottom);
            this.Controls.Add(this.pnlInfoSalidas);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresos";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarPatente)).EndInit();
            this.pnlInfoSalidas.ResumeLayout(false);
            this.pnlInfoSalidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosSalidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.PictureBox imgBuscarPatente;
        private System.Windows.Forms.TextBox txtBuscarPatente;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
        private System.Windows.Forms.Label lblBuscarPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Panel pnlInfoSalidas;
        private System.Windows.Forms.Panel pnlDivisorBottom;
        private System.Windows.Forms.DataGridView datosSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoTotal;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblRecaudado;
    }
}