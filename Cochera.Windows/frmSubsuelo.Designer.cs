namespace Cochera.Windows
{
    partial class frmSubsuelo
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
            this.pnlAutos = new System.Windows.Forms.Panel();
            this.contenedorAutos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInfoAutos = new System.Windows.Forms.Panel();
            this.lblOcupadosSector = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblLibresSector = new System.Windows.Forms.Label();
            this.lblTotalSector = new System.Windows.Forms.Label();
            this.lblCantOcupadosSector = new System.Windows.Forms.Label();
            this.lblCantTotalSector = new System.Windows.Forms.Label();
            this.lblCantLibresSector = new System.Windows.Forms.Label();
            this.pnlAutos.SuspendLayout();
            this.pnlInfoAutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAutos
            // 
            this.pnlAutos.BackColor = System.Drawing.Color.White;
            this.pnlAutos.Controls.Add(this.contenedorAutos);
            this.pnlAutos.Controls.Add(this.pnlInfoAutos);
            this.pnlAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAutos.Location = new System.Drawing.Point(0, 0);
            this.pnlAutos.Name = "pnlAutos";
            this.pnlAutos.Size = new System.Drawing.Size(981, 511);
            this.pnlAutos.TabIndex = 2;
            // 
            // contenedorAutos
            // 
            this.contenedorAutos.AutoScroll = true;
            this.contenedorAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorAutos.Location = new System.Drawing.Point(0, 0);
            this.contenedorAutos.Name = "contenedorAutos";
            this.contenedorAutos.Size = new System.Drawing.Size(867, 511);
            this.contenedorAutos.TabIndex = 1;
            // 
            // pnlInfoAutos
            // 
            this.pnlInfoAutos.Controls.Add(this.lblOcupadosSector);
            this.pnlInfoAutos.Controls.Add(this.lblSector);
            this.pnlInfoAutos.Controls.Add(this.lblLibresSector);
            this.pnlInfoAutos.Controls.Add(this.lblTotalSector);
            this.pnlInfoAutos.Controls.Add(this.lblCantOcupadosSector);
            this.pnlInfoAutos.Controls.Add(this.lblCantTotalSector);
            this.pnlInfoAutos.Controls.Add(this.lblCantLibresSector);
            this.pnlInfoAutos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfoAutos.Location = new System.Drawing.Point(867, 0);
            this.pnlInfoAutos.Name = "pnlInfoAutos";
            this.pnlInfoAutos.Size = new System.Drawing.Size(114, 511);
            this.pnlInfoAutos.TabIndex = 0;
            // 
            // lblOcupadosSector
            // 
            this.lblOcupadosSector.AutoSize = true;
            this.lblOcupadosSector.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupadosSector.Location = new System.Drawing.Point(3, 108);
            this.lblOcupadosSector.Name = "lblOcupadosSector";
            this.lblOcupadosSector.Size = new System.Drawing.Size(76, 18);
            this.lblOcupadosSector.TabIndex = 0;
            this.lblOcupadosSector.Text = "Ocupados:";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSector.Location = new System.Drawing.Point(11, 11);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(93, 18);
            this.lblSector.TabIndex = 0;
            this.lblSector.Text = "Comunes PB";
            // 
            // lblLibresSector
            // 
            this.lblLibresSector.AutoSize = true;
            this.lblLibresSector.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibresSector.Location = new System.Drawing.Point(25, 78);
            this.lblLibresSector.Name = "lblLibresSector";
            this.lblLibresSector.Size = new System.Drawing.Size(54, 18);
            this.lblLibresSector.TabIndex = 0;
            this.lblLibresSector.Text = "Libres:";
            // 
            // lblTotalSector
            // 
            this.lblTotalSector.AutoSize = true;
            this.lblTotalSector.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSector.Location = new System.Drawing.Point(37, 49);
            this.lblTotalSector.Name = "lblTotalSector";
            this.lblTotalSector.Size = new System.Drawing.Size(42, 18);
            this.lblTotalSector.TabIndex = 0;
            this.lblTotalSector.Text = "Total:";
            // 
            // lblCantOcupadosSector
            // 
            this.lblCantOcupadosSector.AutoSize = true;
            this.lblCantOcupadosSector.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantOcupadosSector.Location = new System.Drawing.Point(85, 108);
            this.lblCantOcupadosSector.Name = "lblCantOcupadosSector";
            this.lblCantOcupadosSector.Size = new System.Drawing.Size(26, 18);
            this.lblCantOcupadosSector.TabIndex = 0;
            this.lblCantOcupadosSector.Text = "##";
            // 
            // lblCantTotalSector
            // 
            this.lblCantTotalSector.AutoSize = true;
            this.lblCantTotalSector.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotalSector.Location = new System.Drawing.Point(85, 49);
            this.lblCantTotalSector.Name = "lblCantTotalSector";
            this.lblCantTotalSector.Size = new System.Drawing.Size(26, 18);
            this.lblCantTotalSector.TabIndex = 0;
            this.lblCantTotalSector.Text = "##";
            // 
            // lblCantLibresSector
            // 
            this.lblCantLibresSector.AutoSize = true;
            this.lblCantLibresSector.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLibresSector.Location = new System.Drawing.Point(85, 78);
            this.lblCantLibresSector.Name = "lblCantLibresSector";
            this.lblCantLibresSector.Size = new System.Drawing.Size(26, 18);
            this.lblCantLibresSector.TabIndex = 0;
            this.lblCantLibresSector.Text = "##";
            // 
            // frmSubsuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 511);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubsuelo";
            this.Text = "frmPlantaBaja";
            this.pnlAutos.ResumeLayout(false);
            this.pnlInfoAutos.ResumeLayout(false);
            this.pnlInfoAutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAutos;
        private System.Windows.Forms.FlowLayoutPanel contenedorAutos;
        private System.Windows.Forms.Panel pnlInfoAutos;
        private System.Windows.Forms.Label lblOcupadosSector;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblLibresSector;
        private System.Windows.Forms.Label lblTotalSector;
        private System.Windows.Forms.Label lblCantOcupadosSector;
        private System.Windows.Forms.Label lblCantTotalSector;
        private System.Windows.Forms.Label lblCantLibresSector;
    }
}