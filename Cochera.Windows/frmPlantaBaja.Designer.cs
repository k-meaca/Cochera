namespace Cochera.Windows
{
    partial class frmPlantaBaja
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
            this.Contenedor = new System.Windows.Forms.SplitContainer();
            this.contenedorMotos = new System.Windows.Forms.FlowLayoutPanel();
            this.contenedorAutos = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).BeginInit();
            this.Contenedor.Panel1.SuspendLayout();
            this.Contenedor.Panel2.SuspendLayout();
            this.Contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Black;
            this.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Contenedor.Panel1
            // 
            this.Contenedor.Panel1.BackColor = System.Drawing.Color.White;
            this.Contenedor.Panel1.Controls.Add(this.contenedorMotos);
            // 
            // Contenedor.Panel2
            // 
            this.Contenedor.Panel2.BackColor = System.Drawing.Color.White;
            this.Contenedor.Panel2.Controls.Add(this.contenedorAutos);
            this.Contenedor.Size = new System.Drawing.Size(800, 450);
            this.Contenedor.SplitterDistance = 171;
            this.Contenedor.TabIndex = 0;
            // 
            // contenedorMotos
            // 
            this.contenedorMotos.AutoScroll = true;
            this.contenedorMotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorMotos.Location = new System.Drawing.Point(0, 0);
            this.contenedorMotos.Name = "contenedorMotos";
            this.contenedorMotos.Size = new System.Drawing.Size(798, 169);
            this.contenedorMotos.TabIndex = 0;
            // 
            // contenedorAutos
            // 
            this.contenedorAutos.AutoScroll = true;
            this.contenedorAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorAutos.Location = new System.Drawing.Point(0, 0);
            this.contenedorAutos.Name = "contenedorAutos";
            this.contenedorAutos.Size = new System.Drawing.Size(798, 273);
            this.contenedorAutos.TabIndex = 0;
            // 
            // frmPlantaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlantaBaja";
            this.Text = "frmPlantaBaja";
            this.Contenedor.Panel1.ResumeLayout(false);
            this.Contenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).EndInit();
            this.Contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Contenedor;
        private System.Windows.Forms.FlowLayoutPanel contenedorMotos;
        private System.Windows.Forms.FlowLayoutPanel contenedorAutos;
    }
}