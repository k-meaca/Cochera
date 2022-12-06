namespace Cochera.Windows
{
    partial class frmTarifas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.botonesMenu = new System.Windows.Forms.ToolStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.datosTarifas = new System.Windows.Forms.DataGridView();
            this.colTipoDeVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.botonesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.botonesMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 50);
            this.pnlMenu.TabIndex = 0;
            // 
            // botonesMenu
            // 
            this.botonesMenu.BackColor = System.Drawing.Color.Transparent;
            this.botonesMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonesMenu.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonesMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.botonesMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.botonesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar});
            this.botonesMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.botonesMenu.Location = new System.Drawing.Point(0, 0);
            this.botonesMenu.Name = "botonesMenu";
            this.botonesMenu.Size = new System.Drawing.Size(58, 50);
            this.botonesMenu.TabIndex = 0;
            this.botonesMenu.Text = "toolStrip1";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Cochera.Windows.Properties.Resources.EditarTarifa;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 47);
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditarMenu_Click);
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.Silver;
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 50);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(800, 3);
            this.pnlSeparador.TabIndex = 1;
            // 
            // datosTarifas
            // 
            this.datosTarifas.AllowUserToAddRows = false;
            this.datosTarifas.AllowUserToDeleteRows = false;
            this.datosTarifas.AllowUserToResizeColumns = false;
            this.datosTarifas.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            this.datosTarifas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datosTarifas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.datosTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoDeVehiculo,
            this.colTiempo,
            this.colTarifa});
            this.datosTarifas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosTarifas.Location = new System.Drawing.Point(0, 53);
            this.datosTarifas.MultiSelect = false;
            this.datosTarifas.Name = "datosTarifas";
            this.datosTarifas.ReadOnly = true;
            this.datosTarifas.RowHeadersVisible = false;
            this.datosTarifas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datosTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosTarifas.Size = new System.Drawing.Size(800, 397);
            this.datosTarifas.TabIndex = 2;
            // 
            // colTipoDeVehiculo
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoDeVehiculo.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTipoDeVehiculo.HeaderText = "Vehiculo";
            this.colTipoDeVehiculo.Name = "colTipoDeVehiculo";
            this.colTipoDeVehiculo.ReadOnly = true;
            this.colTipoDeVehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTipoDeVehiculo.Width = 450;
            // 
            // colTiempo
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTiempo.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTiempo.HeaderText = "Tiempo";
            this.colTiempo.Name = "colTiempo";
            this.colTiempo.ReadOnly = true;
            this.colTiempo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTiempo.Width = 300;
            // 
            // colTarifa
            // 
            this.colTarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTarifa.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTarifa.HeaderText = "Tarifa";
            this.colTarifa.Name = "colTarifa";
            this.colTarifa.ReadOnly = true;
            this.colTarifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datosTarifas);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTarifas";
            this.Text = "frmTarifasEdicion";
            this.Load += new System.EventHandler(this.frmTarifasEdicion_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.botonesMenu.ResumeLayout(false);
            this.botonesMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosTarifas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.DataGridView datosTarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDeVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifa;
        private System.Windows.Forms.ToolStrip botonesMenu;
        private System.Windows.Forms.ToolStripButton btnEditar;
    }
}