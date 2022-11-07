namespace Cochera.Windows
{
    partial class frmCuentasCorrientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.pnlDivisor = new System.Windows.Forms.Panel();
            this.datosCtasCtes = new System.Windows.Forms.DataGridView();
            this.colCtaCtes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarcaTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.botonesMenu = new System.Windows.Forms.ToolStrip();
            this.btnEditarCta = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarCta = new System.Windows.Forms.ToolStripButton();
            this.imgBuscarCliente = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosCtasCtes)).BeginInit();
            this.pnlBuscar.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.botonesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlBotones);
            this.pnlMenu.Controls.Add(this.pnlBuscar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 65);
            this.pnlMenu.TabIndex = 0;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(6, 33);
            this.txtBuscarCliente.MaxLength = 8;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(237, 26);
            this.txtBuscarCliente.TabIndex = 3;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.Location = new System.Drawing.Point(3, 9);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(105, 18);
            this.lblBuscarCliente.TabIndex = 1;
            this.lblBuscarCliente.Text = "Buscar Cliente";
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
            // datosCtasCtes
            // 
            this.datosCtasCtes.AllowUserToAddRows = false;
            this.datosCtasCtes.AllowUserToDeleteRows = false;
            this.datosCtasCtes.AllowUserToResizeColumns = false;
            this.datosCtasCtes.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.datosCtasCtes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.datosCtasCtes.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosCtasCtes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.datosCtasCtes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosCtasCtes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCtaCtes,
            this.colCliente,
            this.colDescripcion,
            this.colNumeroTarjeta,
            this.colMarcaTarjeta,
            this.colTipoTarjeta});
            this.datosCtasCtes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosCtasCtes.Location = new System.Drawing.Point(0, 69);
            this.datosCtasCtes.MultiSelect = false;
            this.datosCtasCtes.Name = "datosCtasCtes";
            this.datosCtasCtes.ReadOnly = true;
            this.datosCtasCtes.RowHeadersVisible = false;
            this.datosCtasCtes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosCtasCtes.Size = new System.Drawing.Size(800, 381);
            this.datosCtasCtes.TabIndex = 2;
            // 
            // colCtaCtes
            // 
            this.colCtaCtes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCtaCtes.DefaultCellStyle = dataGridViewCellStyle27;
            this.colCtaCtes.HeaderText = "Nro. Cuenta Cte.";
            this.colCtaCtes.Name = "colCtaCtes";
            this.colCtaCtes.ReadOnly = true;
            this.colCtaCtes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCtaCtes.Width = 96;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.colCliente.DefaultCellStyle = dataGridViewCellStyle28;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescripcion.DefaultCellStyle = dataGridViewCellStyle29;
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDescripcion.Width = 81;
            // 
            // colNumeroTarjeta
            // 
            this.colNumeroTarjeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNumeroTarjeta.DefaultCellStyle = dataGridViewCellStyle30;
            this.colNumeroTarjeta.HeaderText = "Num. Tarjeta";
            this.colNumeroTarjeta.Name = "colNumeroTarjeta";
            this.colNumeroTarjeta.ReadOnly = true;
            this.colNumeroTarjeta.Width = 96;
            // 
            // colMarcaTarjeta
            // 
            this.colMarcaTarjeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMarcaTarjeta.DefaultCellStyle = dataGridViewCellStyle31;
            this.colMarcaTarjeta.HeaderText = "Marca";
            this.colMarcaTarjeta.Name = "colMarcaTarjeta";
            this.colMarcaTarjeta.ReadOnly = true;
            this.colMarcaTarjeta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMarcaTarjeta.Width = 49;
            // 
            // colTipoTarjeta
            // 
            this.colTipoTarjeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoTarjeta.DefaultCellStyle = dataGridViewCellStyle32;
            this.colTipoTarjeta.HeaderText = "Medio de pago";
            this.colTipoTarjeta.Name = "colTipoTarjeta";
            this.colTipoTarjeta.ReadOnly = true;
            this.colTipoTarjeta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTipoTarjeta.Width = 60;
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.Controls.Add(this.txtBuscarCliente);
            this.pnlBuscar.Controls.Add(this.imgBuscarCliente);
            this.pnlBuscar.Controls.Add(this.lblBuscarCliente);
            this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(287, 65);
            this.pnlBuscar.TabIndex = 5;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.botonesMenu);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(287, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(460, 65);
            this.pnlBotones.TabIndex = 6;
            // 
            // botonesMenu
            // 
            this.botonesMenu.BackColor = System.Drawing.Color.Transparent;
            this.botonesMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonesMenu.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.botonesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditarCta,
            this.btnEliminarCta});
            this.botonesMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.botonesMenu.Location = new System.Drawing.Point(0, 0);
            this.botonesMenu.Name = "botonesMenu";
            this.botonesMenu.Size = new System.Drawing.Size(240, 65);
            this.botonesMenu.TabIndex = 0;
            this.botonesMenu.Text = "toolStrip1";
            // 
            // btnEditarCta
            // 
            this.btnEditarCta.Image = global::Cochera.Windows.Properties.Resources.pago;
            this.btnEditarCta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarCta.Name = "btnEditarCta";
            this.btnEditarCta.Size = new System.Drawing.Size(107, 62);
            this.btnEditarCta.Text = "EDITAR CUENTA";
            this.btnEditarCta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarCta.Click += new System.EventHandler(this.btnEditarCta_Click);
            // 
            // btnEliminarCta
            // 
            this.btnEliminarCta.Image = global::Cochera.Windows.Properties.Resources.cancelar;
            this.btnEliminarCta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarCta.Name = "btnEliminarCta";
            this.btnEliminarCta.Size = new System.Drawing.Size(121, 62);
            this.btnEliminarCta.Text = "ELIMINAR CUENTA";
            this.btnEliminarCta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText; 
            // 
            // imgBuscarCliente
            // 
            this.imgBuscarCliente.Image = global::Cochera.Windows.Properties.Resources.lupa;
            this.imgBuscarCliente.Location = new System.Drawing.Point(249, 33);
            this.imgBuscarCliente.Name = "imgBuscarCliente";
            this.imgBuscarCliente.Size = new System.Drawing.Size(27, 26);
            this.imgBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBuscarCliente.TabIndex = 4;
            this.imgBuscarCliente.TabStop = false;
            // 
            // frmCuentasCorrientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datosCtasCtes);
            this.Controls.Add(this.pnlDivisor);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCuentasCorrientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIngresos";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datosCtasCtes)).EndInit();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.botonesMenu.ResumeLayout(false);
            this.botonesMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBuscarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.DataGridView datosCtasCtes;
        private System.Windows.Forms.PictureBox imgBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCtaCtes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarcaTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoTarjeta;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.ToolStrip botonesMenu;
        private System.Windows.Forms.ToolStripButton btnEditarCta;
        private System.Windows.Forms.ToolStripButton btnEliminarCta;
        private System.Windows.Forms.Panel pnlBuscar;
    }
}