namespace Cochera.Windows
{
    partial class frmIngresosEdicion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.Vehiculo = new System.Windows.Forms.Label();
            this.cmboxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.datosClientes = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotonCliente = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlIzq = new System.Windows.Forms.Panel();
            this.lblEstacionamiento = new System.Windows.Forms.Label();
            this.txtEstacionamiento = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.cmboxTarifa = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmboxModelo = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.lblExpiracion = new System.Windows.Forms.Label();
            this.txtExpiracion = new System.Windows.Forms.TextBox();
            this.pnlDer = new System.Windows.Forms.Panel();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlDivisorTop = new System.Windows.Forms.Panel();
            this.pnlBotonEstacionar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.checkAbonar = new System.Windows.Forms.CheckBox();
            this.mostradorErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosClientes)).BeginInit();
            this.pnlBotonCliente.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlBotonEstacionar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostradorErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(731, 6);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(14, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingresar Vehiculo";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 458);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(731, 6);
            this.pnlBottom.TabIndex = 1;
            // 
            // Vehiculo
            // 
            this.Vehiculo.AutoSize = true;
            this.Vehiculo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehiculo.Location = new System.Drawing.Point(21, 63);
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.Size = new System.Drawing.Size(63, 18);
            this.Vehiculo.TabIndex = 2;
            this.Vehiculo.Text = "Vehiculo";
            // 
            // cmboxTipoVehiculo
            // 
            this.cmboxTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTipoVehiculo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxTipoVehiculo.FormattingEnabled = true;
            this.cmboxTipoVehiculo.Location = new System.Drawing.Point(24, 87);
            this.cmboxTipoVehiculo.Name = "cmboxTipoVehiculo";
            this.cmboxTipoVehiculo.Size = new System.Drawing.Size(162, 26);
            this.cmboxTipoVehiculo.TabIndex = 0;
            this.cmboxTipoVehiculo.SelectedValueChanged += new System.EventHandler(this.cmboxTipoVehiculo_SelectedValueChanged);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(20, 121);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(59, 18);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(24, 145);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(162, 26);
            this.txtPatente.TabIndex = 1;
            this.txtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatente_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(395, 66);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 18);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.datosClientes);
            this.pnlClientes.Controls.Add(this.pnlBotonCliente);
            this.pnlClientes.Location = new System.Drawing.Point(398, 87);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(293, 318);
            this.pnlClientes.TabIndex = 6;
            // 
            // datosClientes
            // 
            this.datosClientes.AllowUserToAddRows = false;
            this.datosClientes.AllowUserToDeleteRows = false;
            this.datosClientes.AllowUserToResizeColumns = false;
            this.datosClientes.AllowUserToResizeRows = false;
            this.datosClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCliente,
            this.colNumDoc});
            this.datosClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosClientes.Location = new System.Drawing.Point(0, 0);
            this.datosClientes.MultiSelect = false;
            this.datosClientes.Name = "datosClientes";
            this.datosClientes.ReadOnly = true;
            this.datosClientes.RowHeadersVisible = false;
            this.datosClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosClientes.Size = new System.Drawing.Size(293, 282);
            this.datosClientes.TabIndex = 3;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colNumDoc
            // 
            this.colNumDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNumDoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNumDoc.HeaderText = "Nro de Doc.";
            this.colNumDoc.Name = "colNumDoc";
            this.colNumDoc.ReadOnly = true;
            this.colNumDoc.Width = 99;
            // 
            // pnlBotonCliente
            // 
            this.pnlBotonCliente.Controls.Add(this.btnAgregar);
            this.pnlBotonCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonCliente.Location = new System.Drawing.Point(0, 282);
            this.pnlBotonCliente.Name = "pnlBotonCliente";
            this.pnlBotonCliente.Size = new System.Drawing.Size(293, 36);
            this.pnlBotonCliente.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(293, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar cliente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlIzq
            // 
            this.pnlIzq.BackColor = System.Drawing.Color.Black;
            this.pnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzq.Location = new System.Drawing.Point(0, 6);
            this.pnlIzq.Name = "pnlIzq";
            this.pnlIzq.Size = new System.Drawing.Size(6, 452);
            this.pnlIzq.TabIndex = 0;
            // 
            // lblEstacionamiento
            // 
            this.lblEstacionamiento.AutoSize = true;
            this.lblEstacionamiento.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacionamiento.Location = new System.Drawing.Point(21, 184);
            this.lblEstacionamiento.Name = "lblEstacionamiento";
            this.lblEstacionamiento.Size = new System.Drawing.Size(119, 18);
            this.lblEstacionamiento.TabIndex = 2;
            this.lblEstacionamiento.Text = "Estacionamiento";
            // 
            // txtEstacionamiento
            // 
            this.txtEstacionamiento.Enabled = false;
            this.txtEstacionamiento.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstacionamiento.Location = new System.Drawing.Point(24, 208);
            this.txtEstacionamiento.Name = "txtEstacionamiento";
            this.txtEstacionamiento.Size = new System.Drawing.Size(162, 26);
            this.txtEstacionamiento.TabIndex = 4;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifa.Location = new System.Drawing.Point(224, 184);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(45, 18);
            this.lblTarifa.TabIndex = 2;
            this.lblTarifa.Text = "Tarifa";
            // 
            // cmboxTarifa
            // 
            this.cmboxTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxTarifa.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxTarifa.FormattingEnabled = true;
            this.cmboxTarifa.Location = new System.Drawing.Point(227, 208);
            this.cmboxTarifa.Name = "cmboxTarifa";
            this.cmboxTarifa.Size = new System.Drawing.Size(162, 26);
            this.cmboxTarifa.TabIndex = 3;
            this.cmboxTarifa.SelectedValueChanged += new System.EventHandler(this.cmboxTarifa_SelectedValueChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(224, 63);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 18);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // cmboxModelo
            // 
            this.cmboxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxModelo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxModelo.FormattingEnabled = true;
            this.cmboxModelo.Location = new System.Drawing.Point(227, 87);
            this.cmboxModelo.Name = "cmboxModelo";
            this.cmboxModelo.Size = new System.Drawing.Size(162, 26);
            this.cmboxModelo.TabIndex = 3;
            this.cmboxModelo.SelectedValueChanged += new System.EventHandler(this.cmboxModelo_SelectedValueChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(224, 121);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 18);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(224, 306);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 18);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(227, 330);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(162, 26);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(21, 241);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(58, 18);
            this.lblIngreso.TabIndex = 2;
            this.lblIngreso.Text = "Ingreso";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Enabled = false;
            this.txtIngreso.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.Location = new System.Drawing.Point(24, 265);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(162, 26);
            this.txtIngreso.TabIndex = 4;
            // 
            // lblExpiracion
            // 
            this.lblExpiracion.AutoSize = true;
            this.lblExpiracion.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiracion.Location = new System.Drawing.Point(224, 241);
            this.lblExpiracion.Name = "lblExpiracion";
            this.lblExpiracion.Size = new System.Drawing.Size(78, 18);
            this.lblExpiracion.TabIndex = 2;
            this.lblExpiracion.Text = "Expiracion";
            // 
            // txtExpiracion
            // 
            this.txtExpiracion.Enabled = false;
            this.txtExpiracion.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiracion.Location = new System.Drawing.Point(227, 265);
            this.txtExpiracion.Name = "txtExpiracion";
            this.txtExpiracion.Size = new System.Drawing.Size(162, 26);
            this.txtExpiracion.TabIndex = 4;
            // 
            // pnlDer
            // 
            this.pnlDer.BackColor = System.Drawing.Color.Black;
            this.pnlDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDer.Location = new System.Drawing.Point(725, 6);
            this.pnlDer.Name = "pnlDer";
            this.pnlDer.Size = new System.Drawing.Size(6, 452);
            this.pnlDer.TabIndex = 7;
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstacionar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEstacionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstacionar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacionar.Location = new System.Drawing.Point(524, 3);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(97, 34);
            this.btnEstacionar.TabIndex = 2;
            this.btnEstacionar.Text = "Estacionar";
            this.btnEstacionar.UseVisualStyleBackColor = false;
            this.btnEstacionar.Click += new System.EventHandler(this.btnEstacionar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(6, 6);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(719, 36);
            this.pnlTitulo.TabIndex = 8;
            // 
            // pnlDivisorTop
            // 
            this.pnlDivisorTop.BackColor = System.Drawing.Color.Silver;
            this.pnlDivisorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivisorTop.Location = new System.Drawing.Point(6, 42);
            this.pnlDivisorTop.Name = "pnlDivisorTop";
            this.pnlDivisorTop.Size = new System.Drawing.Size(719, 4);
            this.pnlDivisorTop.TabIndex = 9;
            // 
            // pnlBotonEstacionar
            // 
            this.pnlBotonEstacionar.Controls.Add(this.btnCancelar);
            this.pnlBotonEstacionar.Controls.Add(this.btnEditar);
            this.pnlBotonEstacionar.Controls.Add(this.btnEstacionar);
            this.pnlBotonEstacionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonEstacionar.Location = new System.Drawing.Point(6, 418);
            this.pnlBotonEstacionar.Name = "pnlBotonEstacionar";
            this.pnlBotonEstacionar.Size = new System.Drawing.Size(719, 40);
            this.pnlBotonEstacionar.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(627, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 34);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(524, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(227, 145);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(162, 26);
            this.txtMarca.TabIndex = 4;
            // 
            // checkAbonar
            // 
            this.checkAbonar.AutoSize = true;
            this.checkAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAbonar.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAbonar.Location = new System.Drawing.Point(45, 322);
            this.checkAbonar.Name = "checkAbonar";
            this.checkAbonar.Size = new System.Drawing.Size(107, 33);
            this.checkAbonar.TabIndex = 2;
            this.checkAbonar.Text = "Abonar";
            this.checkAbonar.UseVisualStyleBackColor = true;
            this.checkAbonar.CheckedChanged += new System.EventHandler(this.checkAbonar_CheckedChanged);
            // 
            // mostradorErrores
            // 
            this.mostradorErrores.ContainerControl = this;
            // 
            // frmIngresosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 464);
            this.ControlBox = false;
            this.Controls.Add(this.checkAbonar);
            this.Controls.Add(this.pnlBotonEstacionar);
            this.Controls.Add(this.pnlDivisorTop);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlIzq);
            this.Controls.Add(this.pnlDer);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.txtExpiracion);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblExpiracion);
            this.Controls.Add(this.txtEstacionamiento);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblEstacionamiento);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.cmboxModelo);
            this.Controls.Add(this.cmboxTarifa);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.cmboxTipoVehiculo);
            this.Controls.Add(this.Vehiculo);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresosEdicion";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIngresosEdicion_FormClosing);
            this.pnlClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datosClientes)).EndInit();
            this.pnlBotonCliente.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlBotonEstacionar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mostradorErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label Vehiculo;
        private System.Windows.Forms.ComboBox cmboxTipoVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Panel pnlIzq;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEstacionamiento;
        private System.Windows.Forms.TextBox txtEstacionamiento;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.ComboBox cmboxTarifa;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmboxModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label lblExpiracion;
        private System.Windows.Forms.TextBox txtExpiracion;
        private System.Windows.Forms.Panel pnlDer;
        private System.Windows.Forms.Button btnEstacionar;
        private System.Windows.Forms.Panel pnlBotonCliente;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlDivisorTop;
        private System.Windows.Forms.Panel pnlBotonEstacionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.DataGridView datosClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDoc;
        private System.Windows.Forms.CheckBox checkAbonar;
        private System.Windows.Forms.ErrorProvider mostradorErrores;
        private System.Windows.Forms.Button btnEditar;
    }
}