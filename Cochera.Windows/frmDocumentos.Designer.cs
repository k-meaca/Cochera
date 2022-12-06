namespace Cochera.Windows
{
    partial class frmDocumentos
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.botonesMenu = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.datosDocumentos = new System.Windows.Forms.DataGridView();
            this.colTipoDeDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.botonesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.botonesMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 43);
            this.pnlMenu.TabIndex = 0;
            // 
            // botonesMenu
            // 
            this.botonesMenu.BackColor = System.Drawing.Color.Transparent;
            this.botonesMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonesMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.botonesMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.botonesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar});
            this.botonesMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.botonesMenu.Location = new System.Drawing.Point(0, 0);
            this.botonesMenu.Name = "botonesMenu";
            this.botonesMenu.Size = new System.Drawing.Size(272, 43);
            this.botonesMenu.TabIndex = 0;
            this.botonesMenu.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Cochera.Windows.Properties.Resources.AgregarDocumentoMenu;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 40);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Cochera.Windows.Properties.Resources.EditarDocumentoMenu;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 40);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Cochera.Windows.Properties.Resources.EliminarDocumentoMenu;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 40);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.Silver;
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 43);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(800, 3);
            this.pnlSeparador.TabIndex = 1;
            // 
            // datosDocumentos
            // 
            this.datosDocumentos.AllowUserToAddRows = false;
            this.datosDocumentos.AllowUserToDeleteRows = false;
            this.datosDocumentos.AllowUserToResizeColumns = false;
            this.datosDocumentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datosDocumentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datosDocumentos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datosDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoDeDoc});
            this.datosDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosDocumentos.Location = new System.Drawing.Point(0, 46);
            this.datosDocumentos.MultiSelect = false;
            this.datosDocumentos.Name = "datosDocumentos";
            this.datosDocumentos.ReadOnly = true;
            this.datosDocumentos.RowHeadersVisible = false;
            this.datosDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datosDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosDocumentos.Size = new System.Drawing.Size(800, 404);
            this.datosDocumentos.TabIndex = 2;
            // 
            // colTipoDeDoc
            // 
            this.colTipoDeDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTipoDeDoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTipoDeDoc.HeaderText = "Tipo de Doc.";
            this.colTipoDeDoc.Name = "colTipoDeDoc";
            this.colTipoDeDoc.ReadOnly = true;
            this.colTipoDeDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datosDocumentos);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocumentos";
            this.Load += new System.EventHandler(this.frmDocumentos_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.botonesMenu.ResumeLayout(false);
            this.botonesMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.DataGridView datosDocumentos;
        private System.Windows.Forms.ToolStrip botonesMenu;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDeDoc;
    }
}