namespace Cochera.Windows
{
    partial class frmEstacionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstacionamiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInfoEstacionamiento = new System.Windows.Forms.Panel();
            this.pnlDivisorBottom = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.botonesMenu = new System.Windows.Forms.ToolStrip();
            this.btnPlantaBaja = new System.Windows.Forms.ToolStripButton();
            this.btnSubsueloA = new System.Windows.Forms.ToolStripButton();
            this.btnSubsueloB = new System.Windows.Forms.ToolStripButton();
            this.btnSubsueloC = new System.Windows.Forms.ToolStripButton();
            this.btnMostrarTodos = new System.Windows.Forms.ToolStripButton();
            this.pnlDivisorTop = new System.Windows.Forms.Panel();
            this.pnlEstacionamientos = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.datosEstacionamientos = new System.Windows.Forms.DataGridView();
            this.colSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOcupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenu.SuspendLayout();
            this.botonesMenu.SuspendLayout();
            this.pnlEstacionamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosEstacionamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfoEstacionamiento
            // 
            this.pnlInfoEstacionamiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfoEstacionamiento.Location = new System.Drawing.Point(0, 480);
            this.pnlInfoEstacionamiento.Name = "pnlInfoEstacionamiento";
            this.pnlInfoEstacionamiento.Size = new System.Drawing.Size(829, 25);
            this.pnlInfoEstacionamiento.TabIndex = 0;
            // 
            // pnlDivisorBottom
            // 
            this.pnlDivisorBottom.BackColor = System.Drawing.Color.Silver;
            this.pnlDivisorBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDivisorBottom.Location = new System.Drawing.Point(0, 476);
            this.pnlDivisorBottom.Name = "pnlDivisorBottom";
            this.pnlDivisorBottom.Size = new System.Drawing.Size(829, 4);
            this.pnlDivisorBottom.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.botonesMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(829, 43);
            this.pnlMenu.TabIndex = 2;
            // 
            // botonesMenu
            // 
            this.botonesMenu.BackColor = System.Drawing.Color.Transparent;
            this.botonesMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonesMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.botonesMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.botonesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlantaBaja,
            this.btnSubsueloA,
            this.btnSubsueloB,
            this.btnSubsueloC,
            this.btnMostrarTodos});
            this.botonesMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.botonesMenu.Location = new System.Drawing.Point(0, 0);
            this.botonesMenu.Margin = new System.Windows.Forms.Padding(3);
            this.botonesMenu.Name = "botonesMenu";
            this.botonesMenu.Size = new System.Drawing.Size(553, 43);
            this.botonesMenu.TabIndex = 0;
            this.botonesMenu.Text = "toolStrip1";
            // 
            // btnPlantaBaja
            // 
            this.btnPlantaBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPlantaBaja.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantaBaja.Image = global::Cochera.Windows.Properties.Resources.AgregarAbonado;
            this.btnPlantaBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlantaBaja.Margin = new System.Windows.Forms.Padding(3);
            this.btnPlantaBaja.Name = "btnPlantaBaja";
            this.btnPlantaBaja.Size = new System.Drawing.Size(96, 37);
            this.btnPlantaBaja.Text = "Planta Baja";
            this.btnPlantaBaja.Click += new System.EventHandler(this.btnPlantaBaja_Click);
            // 
            // btnSubsueloA
            // 
            this.btnSubsueloA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSubsueloA.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubsueloA.Image = global::Cochera.Windows.Properties.Resources.EditarAbonado;
            this.btnSubsueloA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSubsueloA.Margin = new System.Windows.Forms.Padding(3);
            this.btnSubsueloA.Name = "btnSubsueloA";
            this.btnSubsueloA.Size = new System.Drawing.Size(95, 37);
            this.btnSubsueloA.Text = "Subsuelo A";
            // 
            // btnSubsueloB
            // 
            this.btnSubsueloB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSubsueloB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubsueloB.Image = global::Cochera.Windows.Properties.Resources.EliminarAbonado;
            this.btnSubsueloB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSubsueloB.Margin = new System.Windows.Forms.Padding(3);
            this.btnSubsueloB.Name = "btnSubsueloB";
            this.btnSubsueloB.Size = new System.Drawing.Size(87, 37);
            this.btnSubsueloB.Text = "Subuelo B";
            // 
            // btnSubsueloC
            // 
            this.btnSubsueloC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSubsueloC.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubsueloC.Image = ((System.Drawing.Image)(resources.GetObject("btnSubsueloC.Image")));
            this.btnSubsueloC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSubsueloC.Margin = new System.Windows.Forms.Padding(3);
            this.btnSubsueloC.Name = "btnSubsueloC";
            this.btnSubsueloC.Size = new System.Drawing.Size(95, 37);
            this.btnSubsueloC.Text = "Subsuelo C";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodos.Image")));
            this.btnMostrarTodos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(3);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(116, 37);
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // pnlDivisorTop
            // 
            this.pnlDivisorTop.BackColor = System.Drawing.Color.Silver;
            this.pnlDivisorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivisorTop.Location = new System.Drawing.Point(0, 43);
            this.pnlDivisorTop.Name = "pnlDivisorTop";
            this.pnlDivisorTop.Size = new System.Drawing.Size(829, 4);
            this.pnlDivisorTop.TabIndex = 3;
            // 
            // pnlEstacionamientos
            // 
            this.pnlEstacionamientos.Controls.Add(this.datosEstacionamientos);
            this.pnlEstacionamientos.Controls.Add(this.panelBotones);
            this.pnlEstacionamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEstacionamientos.Location = new System.Drawing.Point(0, 47);
            this.pnlEstacionamientos.Name = "pnlEstacionamientos";
            this.pnlEstacionamientos.Size = new System.Drawing.Size(829, 429);
            this.pnlEstacionamientos.TabIndex = 4;
            // 
            // panelBotones
            // 
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBotones.Location = new System.Drawing.Point(710, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(119, 429);
            this.panelBotones.TabIndex = 0;
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
            this.datosEstacionamientos.Size = new System.Drawing.Size(710, 429);
            this.datosEstacionamientos.TabIndex = 1;
            // 
            // colSector
            // 
            this.colSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSector.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSector.HeaderText = "Sector";
            this.colSector.Name = "colSector";
            this.colSector.ReadOnly = true;
            // 
            // colUbicacion
            // 
            this.colUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUbicacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUbicacion.HeaderText = "Ubicacion";
            this.colUbicacion.Name = "colUbicacion";
            this.colUbicacion.ReadOnly = true;
            this.colUbicacion.Width = 80;
            // 
            // colOcupado
            // 
            this.colOcupado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOcupado.DefaultCellStyle = dataGridViewCellStyle6;
            this.colOcupado.HeaderText = "Ocupado";
            this.colOcupado.Name = "colOcupado";
            this.colOcupado.ReadOnly = true;
            this.colOcupado.Width = 76;
            // 
            // frmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 505);
            this.ControlBox = false;
            this.Controls.Add(this.pnlEstacionamientos);
            this.Controls.Add(this.pnlDivisorTop);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDivisorBottom);
            this.Controls.Add(this.pnlInfoEstacionamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstacionamiento";
            this.Text = "frmEstacionamiento";
            this.Load += new System.EventHandler(this.frmEstacionamiento_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.botonesMenu.ResumeLayout(false);
            this.botonesMenu.PerformLayout();
            this.pnlEstacionamientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datosEstacionamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfoEstacionamiento;
        private System.Windows.Forms.Panel pnlDivisorBottom;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ToolStrip botonesMenu;
        private System.Windows.Forms.ToolStripButton btnPlantaBaja;
        private System.Windows.Forms.ToolStripButton btnSubsueloA;
        private System.Windows.Forms.ToolStripButton btnSubsueloB;
        private System.Windows.Forms.ToolStripButton btnSubsueloC;
        private System.Windows.Forms.ToolStripButton btnMostrarTodos;
        private System.Windows.Forms.Panel pnlDivisorTop;
        private System.Windows.Forms.Panel pnlEstacionamientos;
        private System.Windows.Forms.DataGridView datosEstacionamientos;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOcupado;
    }
}