namespace Cochera.Windows
{
    partial class frmContabilidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlFiltrarBotones = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFiltrarDescripcion = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnFiltrarSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarAbonado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarVehiculo = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnFiltrarAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarCamioneta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarCombi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarMoto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarMotoSidecar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarPago = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnFiltrarEfectivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFiltrarDebito = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.pnlFiltrarFecha = new System.Windows.Forms.Panel();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarPorFecha = new System.Windows.Forms.Button();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.datosContables = new System.Windows.Forms.DataGridView();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.pnlFiltrarBotones.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlFiltrarFecha.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosContables)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlFiltrarBotones);
            this.pnlMenu.Controls.Add(this.pnlFiltrarFecha);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1015, 65);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlFiltrarBotones
            // 
            this.pnlFiltrarBotones.Controls.Add(this.toolStrip1);
            this.pnlFiltrarBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltrarBotones.Location = new System.Drawing.Point(312, 0);
            this.pnlFiltrarBotones.Name = "pnlFiltrarBotones";
            this.pnlFiltrarBotones.Size = new System.Drawing.Size(703, 65);
            this.pnlFiltrarBotones.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFiltrarDescripcion,
            this.btnFiltrarVehiculo,
            this.btnFiltrarPago,
            this.btnActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 65);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFiltrarDescripcion
            // 
            this.btnFiltrarDescripcion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFiltrarSalida,
            this.btnFiltrarAbonado});
            this.btnFiltrarDescripcion.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarDescripcion.Image = global::Cochera.Windows.Properties.Resources.descripcion;
            this.btnFiltrarDescripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrarDescripcion.Name = "btnFiltrarDescripcion";
            this.btnFiltrarDescripcion.Size = new System.Drawing.Size(153, 62);
            this.btnFiltrarDescripcion.Text = "FILTRAR DESCRIPCION";
            this.btnFiltrarDescripcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnFiltrarSalida
            // 
            this.btnFiltrarSalida.Name = "btnFiltrarSalida";
            this.btnFiltrarSalida.Size = new System.Drawing.Size(132, 22);
            this.btnFiltrarSalida.Text = "SALIDA";
            this.btnFiltrarSalida.Click += new System.EventHandler(this.btnFiltrarPorSalida_Click);
            // 
            // btnFiltrarAbonado
            // 
            this.btnFiltrarAbonado.Name = "btnFiltrarAbonado";
            this.btnFiltrarAbonado.Size = new System.Drawing.Size(132, 22);
            this.btnFiltrarAbonado.Text = "ABONADO";
            this.btnFiltrarAbonado.Click += new System.EventHandler(this.btnFiltrarPorAbonado_Click);
            // 
            // btnFiltrarVehiculo
            // 
            this.btnFiltrarVehiculo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFiltrarAuto,
            this.btnFiltrarCamioneta,
            this.btnFiltrarCombi,
            this.btnFiltrarMoto,
            this.btnFiltrarMotoSidecar});
            this.btnFiltrarVehiculo.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarVehiculo.Image = global::Cochera.Windows.Properties.Resources.buscarVehiculo;
            this.btnFiltrarVehiculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrarVehiculo.Name = "btnFiltrarVehiculo";
            this.btnFiltrarVehiculo.Size = new System.Drawing.Size(132, 62);
            this.btnFiltrarVehiculo.Text = "FILTRAR VEHICULO";
            this.btnFiltrarVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnFiltrarAuto
            // 
            this.btnFiltrarAuto.Name = "btnFiltrarAuto";
            this.btnFiltrarAuto.Size = new System.Drawing.Size(178, 22);
            this.btnFiltrarAuto.Text = "AUTO";
            this.btnFiltrarAuto.Click += new System.EventHandler(this.btnFiltrarAuto_Click);
            // 
            // btnFiltrarCamioneta
            // 
            this.btnFiltrarCamioneta.Name = "btnFiltrarCamioneta";
            this.btnFiltrarCamioneta.Size = new System.Drawing.Size(178, 22);
            this.btnFiltrarCamioneta.Text = "CAMIONETA";
            this.btnFiltrarCamioneta.Click += new System.EventHandler(this.btnFiltrarCamioneta_Click);
            // 
            // btnFiltrarCombi
            // 
            this.btnFiltrarCombi.Name = "btnFiltrarCombi";
            this.btnFiltrarCombi.Size = new System.Drawing.Size(178, 22);
            this.btnFiltrarCombi.Text = "COMBI";
            this.btnFiltrarCombi.Click += new System.EventHandler(this.btnFiltrarCombi_Click);
            // 
            // btnFiltrarMoto
            // 
            this.btnFiltrarMoto.Name = "btnFiltrarMoto";
            this.btnFiltrarMoto.Size = new System.Drawing.Size(178, 22);
            this.btnFiltrarMoto.Text = "MOTO";
            this.btnFiltrarMoto.Click += new System.EventHandler(this.btnFiltrarMoto_Click);
            // 
            // btnFiltrarMotoSidecar
            // 
            this.btnFiltrarMotoSidecar.Name = "btnFiltrarMotoSidecar";
            this.btnFiltrarMotoSidecar.Size = new System.Drawing.Size(178, 22);
            this.btnFiltrarMotoSidecar.Text = "MOTO C/ SIDECAR";
            this.btnFiltrarMotoSidecar.Click += new System.EventHandler(this.btnFiltrarMotoSidecar_Click);
            // 
            // btnFiltrarPago
            // 
            this.btnFiltrarPago.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFiltrarEfectivo,
            this.btnFiltrarDebito});
            this.btnFiltrarPago.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPago.Image = global::Cochera.Windows.Properties.Resources.metodoPago;
            this.btnFiltrarPago.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrarPago.Name = "btnFiltrarPago";
            this.btnFiltrarPago.Size = new System.Drawing.Size(128, 62);
            this.btnFiltrarPago.Text = "FILTRAR POR PAGO";
            this.btnFiltrarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnFiltrarEfectivo
            // 
            this.btnFiltrarEfectivo.Name = "btnFiltrarEfectivo";
            this.btnFiltrarEfectivo.Size = new System.Drawing.Size(195, 22);
            this.btnFiltrarEfectivo.Text = "EFECTIVO";
            this.btnFiltrarEfectivo.Click += new System.EventHandler(this.btnFiltrarEfectivo_Click);
            // 
            // btnFiltrarDebito
            // 
            this.btnFiltrarDebito.Name = "btnFiltrarDebito";
            this.btnFiltrarDebito.Size = new System.Drawing.Size(195, 22);
            this.btnFiltrarDebito.Text = "DEBITO AUTOMATICO";
            this.btnFiltrarDebito.Click += new System.EventHandler(this.btnFiltrarDebito_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::Cochera.Windows.Properties.Resources.actualizar;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 62);
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlFiltrarFecha
            // 
            this.pnlFiltrarFecha.Controls.Add(this.fechaFinal);
            this.pnlFiltrarFecha.Controls.Add(this.btnFiltrarPorFecha);
            this.pnlFiltrarFecha.Controls.Add(this.fechaInicio);
            this.pnlFiltrarFecha.Controls.Add(this.lblFechaFinal);
            this.pnlFiltrarFecha.Controls.Add(this.lblFechaInicio);
            this.pnlFiltrarFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltrarFecha.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltrarFecha.Name = "pnlFiltrarFecha";
            this.pnlFiltrarFecha.Size = new System.Drawing.Size(312, 65);
            this.pnlFiltrarFecha.TabIndex = 3;
            // 
            // fechaFinal
            // 
            this.fechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinal.Location = new System.Drawing.Point(95, 36);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(80, 20);
            this.fechaFinal.TabIndex = 0;
            this.fechaFinal.ValueChanged += new System.EventHandler(this.fechaFinal_ValueChanged);
            // 
            // btnFiltrarPorFecha
            // 
            this.btnFiltrarPorFecha.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnFiltrarPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarPorFecha.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPorFecha.Location = new System.Drawing.Point(191, 8);
            this.btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            this.btnFiltrarPorFecha.Size = new System.Drawing.Size(112, 48);
            this.btnFiltrarPorFecha.TabIndex = 2;
            this.btnFiltrarPorFecha.Text = "FILTRAR POR FECHA";
            this.btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarPorFecha.Click += new System.EventHandler(this.btnFiltrarPorFecha_Click);
            // 
            // fechaInicio
            // 
            this.fechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(95, 10);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(80, 20);
            this.fechaInicio.TabIndex = 0;
            this.fechaInicio.ValueChanged += new System.EventHandler(this.fechaInicio_ValueChanged);
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(3, 36);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(83, 18);
            this.lblFechaFinal.TabIndex = 1;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(3, 10);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 18);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // pnlDivisor
            // 
            this.pnlDivisor.BackColor = System.Drawing.Color.Black;
            this.pnlDivisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivisor.Location = new System.Drawing.Point(0, 65);
            this.pnlDivisor.Name = "pnlDivisor";
            this.pnlDivisor.Size = new System.Drawing.Size(1015, 4);
            this.pnlDivisor.TabIndex = 1;
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.Controls.Add(this.lblImporteTotal);
            this.pnlInformacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInformacion.Location = new System.Drawing.Point(0, 422);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(1015, 28);
            this.pnlInformacion.TabIndex = 2;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(801, 3);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(183, 18);
            this.lblImporteTotal.TabIndex = 0;
            this.lblImporteTotal.Text = "Importe Total: $$$$$$$$$";
            this.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datosContables
            // 
            this.datosContables.AllowUserToAddRows = false;
            this.datosContables.AllowUserToDeleteRows = false;
            this.datosContables.AllowUserToResizeColumns = false;
            this.datosContables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.datosContables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datosContables.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosContables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datosContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosContables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescripcion,
            this.colVehiculo,
            this.colPatente,
            this.colFechaMovimiento,
            this.colHoraMov,
            this.colTipoPago,
            this.colImporte});
            this.datosContables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosContables.Location = new System.Drawing.Point(0, 69);
            this.datosContables.MultiSelect = false;
            this.datosContables.Name = "datosContables";
            this.datosContables.ReadOnly = true;
            this.datosContables.RowHeadersVisible = false;
            this.datosContables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosContables.Size = new System.Drawing.Size(1015, 353);
            this.datosContables.TabIndex = 3;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colVehiculo
            // 
            this.colVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colVehiculo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colVehiculo.HeaderText = "Vehiculo";
            this.colVehiculo.Name = "colVehiculo";
            this.colVehiculo.ReadOnly = true;
            this.colVehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colVehiculo.Width = 61;
            // 
            // colPatente
            // 
            this.colPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colPatente.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            this.colPatente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPatente.Width = 57;
            // 
            // colFechaMovimiento
            // 
            this.colFechaMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colFechaMovimiento.DefaultCellStyle = dataGridViewCellStyle6;
            this.colFechaMovimiento.HeaderText = "Fecha Mov.";
            this.colFechaMovimiento.Name = "colFechaMovimiento";
            this.colFechaMovimiento.ReadOnly = true;
            this.colFechaMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFechaMovimiento.Width = 76;
            // 
            // colHoraMov
            // 
            this.colHoraMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHoraMov.DefaultCellStyle = dataGridViewCellStyle7;
            this.colHoraMov.HeaderText = "Hora Mov.";
            this.colHoraMov.Name = "colHoraMov";
            this.colHoraMov.ReadOnly = true;
            this.colHoraMov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHoraMov.Width = 71;
            // 
            // colTipoPago
            // 
            this.colTipoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoPago.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTipoPago.HeaderText = "Modo de pago";
            this.colTipoPago.Name = "colTipoPago";
            this.colTipoPago.ReadOnly = true;
            this.colTipoPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTipoPago.Width = 92;
            // 
            // colImporte
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle9;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            this.colImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datosContables);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "|";
            this.pnlMenu.ResumeLayout(false);
            this.pnlFiltrarBotones.ResumeLayout(false);
            this.pnlFiltrarBotones.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlFiltrarFecha.ResumeLayout(false);
            this.pnlFiltrarFecha.PerformLayout();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosContables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.DataGridView datosContables;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Panel pnlFiltrarFecha;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Button btnFiltrarPorFecha;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Panel pnlFiltrarBotones;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripDropDownButton btnFiltrarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarAuto;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarCamioneta;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarCombi;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarMoto;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarMotoSidecar;
        private System.Windows.Forms.ToolStripDropDownButton btnFiltrarPago;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarEfectivo;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarDebito;
        private System.Windows.Forms.ToolStripDropDownButton btnFiltrarDescripcion;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarSalida;
        private System.Windows.Forms.ToolStripMenuItem btnFiltrarAbonado;
    }
}